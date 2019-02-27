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
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(100, 9);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(228, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_version
            // 
            this.textBox_version.Location = new System.Drawing.Point(100, 35);
            this.textBox_version.Name = "textBox_version";
            this.textBox_version.Size = new System.Drawing.Size(228, 20);
            this.textBox_version.TabIndex = 1;
            // 
            // textBox_link
            // 
            this.textBox_link.Location = new System.Drawing.Point(100, 61);
            this.textBox_link.Name = "textBox_link";
            this.textBox_link.Size = new System.Drawing.Size(228, 20);
            this.textBox_link.TabIndex = 2;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(13, 12);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(81, 13);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Name of Game:";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(13, 38);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(74, 13);
            this.label_version.TabIndex = 4;
            this.label_version.Text = "Local Version:";
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Location = new System.Drawing.Point(13, 64);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(30, 13);
            this.label_link.TabIndex = 5;
            this.label_link.Text = "Link:";
            // 
            // button_add_item
            // 
            this.button_add_item.Location = new System.Drawing.Point(100, 88);
            this.button_add_item.Name = "button_add_item";
            this.button_add_item.Size = new System.Drawing.Size(111, 37);
            this.button_add_item.TabIndex = 6;
            this.button_add_item.Text = "Add";
            this.button_add_item.UseVisualStyleBackColor = true;
            this.button_add_item.Click += new System.EventHandler(this.button_add_item_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(217, 88);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(111, 37);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 131);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add_item);
            this.Controls.Add(this.label_link);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_link);
            this.Controls.Add(this.textBox_version);
            this.Controls.Add(this.textBox_name);
            this.Name = "form_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entry";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}