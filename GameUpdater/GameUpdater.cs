using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace GameUpdater
{
    public partial class Form_gamesupdater : Form

    {

        public static Form_gamesupdater Instance { get; private set;}
        public static FileSystemWatcher watcher;
        string line;
        public static Boolean checkingForUpdates = false;

        public Form_gamesupdater()
        {
            Instance = this;
            InitializeComponent();
            StreamWriter sw = File.AppendText(Application.StartupPath + "//GameUpdater.txt");
            sw.Close();
            //dataGridView_links.ReadOnly = false;
            //dataGridView_links.Columns[1].ReadOnly = true;

            System.IO.TextReader tr = new StreamReader(Application.StartupPath + "//GameUpdater.txt");
            string line;
            while ((line = tr.ReadLine()) != null)
            {
                int commaCount = Regex.Matches(line, ",").Count;
                if (commaCount == 3)
                {
                    line = line.Replace(",http", ", ,http");
                    line = "," + line + ",";
                }
                if (commaCount == 4)
                {
                    line += ",";
                    line = line.Replace(",http", ",,http");
                }
                if (commaCount == 5)
                {
                    line += ",";
                }
                string[] items = line.Trim().Split(',');
                this.dataGridView_links.Rows.Add(items);
                this.dataGridView_links.Sort(this.dataGridView_links.Columns["Column1"], ListSortDirection.Ascending);
            }
            foreach (DataGridViewRow row in dataGridView_links.Rows)
            {
                if (row.Cells[2].Value.ToString().Equals(row.Cells[3].Value.ToString()))
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

            WriteDataToFile();
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

                        string regex_date = "<b>Release Date(:)?( )?</b>(:)?";
                        string tofind_date = "<b>Release Date";

                        var regex_tags = new System.Text.RegularExpressions.Regex("<title>\\[.*?\\]\\s?[A-z]{1}");
                        string tofind_tags = items[1].ToString();

                        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(items[5]);
                        myRequest.Method = "GET";
                        WebResponse myResponse = myRequest.GetResponse();
                        sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                        string web_result = sr.ReadToEnd();
                        sr.Close(); myResponse.Close();

                        if (System.Text.RegularExpressions.Regex.IsMatch(web_result, regex_str, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            int start = web_result.IndexOf(tofind) + tofind.Length + 6;
                            int end = web_result.IndexOf("<br />", start);
                            string current_version = web_result.Substring(start, end - start);

                            items[2] = current_version;

                        }
                        else
                        {
                            items[2] = " ";
                        }

                        if (System.Text.RegularExpressions.Regex.IsMatch(web_result, regex_date, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            int start = web_result.IndexOf(tofind_date) + tofind_date.Length + 6;
                            int end = web_result.IndexOf("<br />", start);
                            string lastest_release = web_result.Substring(start, end - start);

                            items[4] = lastest_release;

                        }
                        else
                        {
                            items[4] = " ";
                        }

                        MatchCollection tags_matches = regex_tags.Matches(web_result);
                        string tags = (tags_matches[0].Value).ToString();
                        int length = tags.Length;

                        if (tags != null)
                        {
                            tags = tags.Remove(tags.Length -1, 1);
                            tags = tags.Remove(0,7);
                            tags = WebUtility.HtmlDecode(tags);
                            tags = tags.Replace(" ", "");
                            tags = tags.Replace("-", "");
                            items[0] = tags;
                        }
                        else
                        {
                            items[0] = " ";
                        }
                    }

                    catch
                    {
                        items[0] = " ";
                        items[2] = " ";
                        items[4] = " ";
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
                    if (row.Cells[2].Value.ToString().Equals(row.Cells[3].Value.ToString()))
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
                    if (row.Cells[4].Value == null)
                    {
                        row.Cells[4].Value = " ";
                    }
                    if (row.Cells[5].Value == null)
                    {
                        row.Cells[5].Value = " ";
                    }
                    if (row.Cells[6].Value == null)
                    {
                        row.Cells[6].Value = "";
                    }

                    line = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," + row.Cells[3].Value.ToString() + "," + row.Cells[4].Value.ToString() + "," + row.Cells[5].Value.ToString() + "," + row.Cells[6].Value.ToString();
                    tw.WriteLine(line);

                }
                tw.Close();

                foreach (DataGridViewRow row in dataGridView_links.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(row.Cells[3].Value.ToString()))
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
