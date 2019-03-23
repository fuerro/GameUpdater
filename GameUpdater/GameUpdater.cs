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
    public partial class form_gamesupdater : Form

    {
        public form_gamesupdater()
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
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            progressBar_checking.Value = 0;

            System.IO.TextReader tr_count = new StreamReader(Application.StartupPath + "//GameUpdater.txt"); // big string

            var file_counter = tr_count.ReadToEnd();

            var lines = file_counter.Split(new char[] { '\n' });           // big array
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
                    try
                    {
                        string regex_str = "<b>Version(:)?( )?</b>(:)?";
                        string tofind = "<b>Version";

                        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(items[3]);
                        myRequest.Method = "GET";
                        WebResponse myResponse = myRequest.GetResponse();
                        StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
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

                StreamWriter tw = new StreamWriter(@Application.StartupPath + "//GameUpdater.txt");

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

                    line = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," + row.Cells[3].Value.ToString();
                    tw.WriteLine(line);

                }
                tw.Close();
            }
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            form_add form2 = new form_add();
            form2.ShowDialog();
        }

        private void button_openrepo_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "//GameUpdater.txt");
        }
    }
}
