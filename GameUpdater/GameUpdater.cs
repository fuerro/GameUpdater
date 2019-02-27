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

namespace GameUpdater
{
    public partial class form_gamesupdater : Form

    {
        public form_gamesupdater()
        {
            InitializeComponent();
            StreamWriter sw = File.AppendText(Application.StartupPath + "//GameUpdater.txt");
            sw.Close();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.dataGridView_links.Rows.Clear();
            DataTable dt = new DataTable();
            using (System.IO.TextReader tr = new StreamReader(Application.StartupPath +"//GameUpdater.txt"))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    if (line == "") continue;

                    string[] items = line.Trim().Split(',');

                    bool result = items[1].Equals(items[2]);

                    if (result == true)
                    {
                        Array.Resize(ref items, items.Length + 1);
                        items[items.Length - 1] = "No";
                    }
                    else
                    {
                        Array.Resize(ref items, items.Length + 1);
                        items[items.Length - 1] = "Yes";
                    }
                    this.dataGridView_links.Rows.Add(items);
                }

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //this.Hide();
            form_add form2 = new form_add();
            form2.ShowDialog();
        }
    }
}
