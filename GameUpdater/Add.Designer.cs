namespace GameUpdater
{
    partial class form_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_version = new System.Windows.Forms.TextBox();
            this.textBox_link = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_link = new System.Windows.Forms.Label();
            this.button_add_item = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(121, 9);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(282, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_version
            // 
            this.textBox_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_version.Location = new System.Drawing.Point(121, 48);
            this.textBox_version.Name = "textBox_version";
            this.textBox_version.Size = new System.Drawing.Size(282, 20);
            this.textBox_version.TabIndex = 1;
            // 
            // textBox_link
            // 
            this.textBox_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_link.Location = new System.Drawing.Point(121, 87);
            this.textBox_link.Name = "textBox_link";
            this.textBox_link.Size = new System.Drawing.Size(282, 20);
            this.textBox_link.TabIndex = 2;
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(34, 13);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(81, 13);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Name of Game:";
            // 
            // label_version
            // 
            this.label_version.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(41, 52);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(74, 13);
            this.label_version.TabIndex = 4;
            this.label_version.Text = "Local Version:";
            // 
            // label_link
            // 
            this.label_link.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_link.AutoSize = true;
            this.label_link.Location = new System.Drawing.Point(85, 91);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(30, 13);
            this.label_link.TabIndex = 5;
            this.label_link.Text = "Link:";
            // 
            // button_add_item
            // 
            this.button_add_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add_item.Location = new System.Drawing.Point(3, 120);
            this.button_add_item.Name = "button_add_item";
            this.button_add_item.Size = new System.Drawing.Size(111, 33);
            this.button_add_item.TabIndex = 6;
            this.button_add_item.Text = "Add";
            this.button_add_item.UseVisualStyleBackColor = true;
            this.button_add_item.Click += new System.EventHandler(this.button_add_item_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(292, 120);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(111, 33);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.31034F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.68965F));
            this.tableLayoutPanel1.Controls.Add(this.label_version, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_add_item, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_cancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_link, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_link, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_version, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_name, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 156);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 176);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "form_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entry";
            this.Load += new System.EventHandler(this.Add_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_version;
        private System.Windows.Forms.TextBox textBox_link;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_link;
        private System.Windows.Forms.Button button_add_item;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}