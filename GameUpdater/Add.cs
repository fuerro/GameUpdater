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
    public partial class form_add : Form
    {

        public form_add()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_item_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrWhiteSpace(textBox_name.Text) && !string.IsNullOrWhiteSpace(textBox_version.Text) && !string.IsNullOrWhiteSpace(textBox_link.Text)) {

                File.AppendAllText(Application.StartupPath + "//GameUpdater.txt", textBox_name.Text + ", ," + textBox_version.Text + "," + textBox_link.Text + Environment.NewLine);

                textBox_name.Clear();
                textBox_version.Clear();
                textBox_link.Clear();

            }
            else
            {
                MessageBox.Show("Please fill in all Textboxes!", "Alert");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
