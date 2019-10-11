using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace GameUpdater
{
    public partial class Form_gamesupdater : Form

    {
        FileSystemWatcher watcher;
        string line;
        Boolean checkingForUpdates = false;

        public Form_gamesupdater()
        {

            InitializeComponent();
            StreamWriter sw = File.AppendText(Application.StartupPath + "//GameUpdater.txt");
            sw.Close();
            dataGridView_links.ReadOnly = false;
            dataGridView_links.Columns[1].ReadOnly = true;

            System.IO.TextReader tr = new StreamReader(Application.StartupPath + "//GameUpdater.txt");
            string line;
            while ((line = tr.ReadLine()) != null)
            {
                string[] items = line.Trim().Split(',');
                this.dataGridView_links.Rows.Add(items);
                this.dataGridView_links.Sort(this.dataGridView_links.Columns["Column1"], ListSortDirection.Ascending);
            }
            foreach (DataGridViewRow row in dataGridView_links.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(row.Cells[2].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            tr.Close();

            watcher = new FileSystemWatcher()
            {
                Path = Application.StartupPath,
                Filter = "GameUpdater.txt",
                NotifyFilter = NotifyFilters.LastWrite
            };
            watcher.Changed += OnChanged;

            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            try
            {
                watcher.EnableRaisingEvents = false;
                WriteDataToFile();
            }
            finally
            {
                watcher.EnableRaisingEvents = true;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            checkingForUpdates = true;
            progressBar_checking.Value = 0;

            System.IO.TextReader tr_count = new StreamReader(Application.StartupPath + "//GameUpdater.txt");

            var file_counter = tr_count.ReadToEnd();

            var lines = file_counter.Split(new char[] { '\n' });
            var count = lines.Count();

            tr_count.Close();

            this.dataGridView_links.Rows.Clear();

            DataTable dt = new DataTable();
            using (System.IO.TextReader tr = new StreamReader(Application.StartupPath +"//GameUpdater.txt"))
            {
                string line;

                progressBar_checking.Maximum = (progressBar_checking.Step * count);

                while ((line = tr.ReadLine()) != null)
                {
                    if (line == "") { progressBar_checking.PerformStep(); continue; }

                    progressBar_checking.PerformStep();

                    string[] items = line.Trim().Split(',');
                    StreamReader sr = null;

                    try
                    {
                        string regex_str = "<b>Version(:)?( )?</b>(:)?";
                        string tofind = "<b>Version";

                        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(items[3]);
                        myRequest.Method = "GET";
                        WebResponse myResponse = myRequest.GetResponse();
                        sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                        string web_result = sr.ReadToEnd();
                        sr.Close(); myResponse.Close();

                        if (System.Text.RegularExpressions.Regex.IsMatch(web_result, regex_str, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            int start = web_result.IndexOf(tofind) + tofind.Length+6;
                            int end = web_result.IndexOf("<br />", start);
                            string current_version = web_result.Substring(start, end - start);

                            items[1] = current_version;

                        }
                        else
                            items[1] = " ";
                    }

                    catch
                    {
                        items[1] = " ";
                    }


                    progressBar_checking.Maximum--;

                    this.dataGridView_links.Rows.Add(items);
                    this.dataGridView_links.Sort(this.dataGridView_links.Columns["Column1"], ListSortDirection.Ascending);
                    
                }
                tr.Close();

                if (count == 1 && line == null) MessageBox.Show("You have no Entrys in the Data File!", "Alert");


                progressBar_checking.Maximum = 60;
                for (int i = progressBar_checking.Value; i <= progressBar_checking.Maximum;i++) { progressBar_checking.PerformStep(); }
                progressBar_checking.Maximum--;

            }

            watcher.EnableRaisingEvents = true;
            checkingForUpdates = false;
            WriteDataToFile();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            form_add form2 = new form_add();
            form2.ShowDialog();
        }

        private void button_openrepo_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }


        public void RefreshList()
        {
            watcher.EnableRaisingEvents = false;
            try
            {
                this.dataGridView_links.BeginInvoke(new Action(() => dataGridView_links.Rows.Clear()));

                System.IO.TextReader tr = new StreamReader(Application.StartupPath + "//GameUpdater.txt");

                while ((line = tr.ReadLine()) != null)
                {
                    string[] items = line.Trim().Split(',');
                    this.dataGridView_links.Invoke(new Action(() => dataGridView_links.Rows.Add(items)));
                    this.dataGridView_links.Invoke(new Action(() => dataGridView_links.Sort(this.dataGridView_links.Columns["Column1"], ListSortDirection.Ascending)));
                }
                foreach (DataGridViewRow row in dataGridView_links.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(row.Cells[2].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }
                tr.Close();

            }
            catch
            {

            }
            watcher.EnableRaisingEvents = true;
        }

        public void WriteDataToFile()
        {
            if (checkingForUpdates == false)
            {
                watcher.EnableRaisingEvents = false;

                StreamWriter tw = new StreamWriter(@Application.StartupPath + "//GameUpdater.txt");

                foreach (DataGridViewRow row in dataGridView_links.Rows)
                {

                    if (row.Cells[0].Value == null)
                    {
                        row.Cells[0].Value = " ";
                    }
                    if (row.Cells[1].Value == null)
                    {
                        row.Cells[1].Value = " ";
                    }
                    if (row.Cells[2].Value == null)
                    {
                        row.Cells[2].Value = " ";
                    }
                    if (row.Cells[3].Value == null)
                    {
                        row.Cells[3].Value = " ";
                    }

                    line = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," + row.Cells[3].Value.ToString();
                    tw.WriteLine(line);

                }
                tw.Close();

                foreach (DataGridViewRow row in dataGridView_links.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(row.Cells[2].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }
            }
            watcher.EnableRaisingEvents = true;

        }

        private void dataGridView_links_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            WriteDataToFile();
        }

        private void dataGridView_links_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            WriteDataToFile();
        }
    }
}
