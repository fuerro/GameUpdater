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

namespace WindowsFormsApp1
{
    public partial class form_gamesupdater : Form
    {
        public form_gamesupdater()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (System.IO.TextReader tr = new StreamReader("C:\\tmp\\Links_text.txt"))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {

                    string[] items = line.Trim().Split(',');
                    if (dt.Columns.Count == 0)
                    {
                        // Create the data columns for the data table based on the number of items
                        // on the first line of the file
                        for (int i = 0; i < items.Length; i++)
                            dt.Columns.Add(new DataColumn("Column" + i, typeof(string)));
                    }
                    dt.Rows.Add(items);

                }
                //show it in gridview
                this.dataGridView_links.DataSource = dt;

                //if ((dataGridView_links.Columns[1].ToString()).Equals(dataGridView_links.Columns[2].ToString()))
                //    dataGridView_links.Columns[4]. = "Yes";
            }
        }
    }
}
