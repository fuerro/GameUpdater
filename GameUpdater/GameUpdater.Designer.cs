namespace GameUpdater
{
    partial class Form_gamesupdater
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView_links = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add = new System.Windows.Forms.Button();
            this.progressBar_checking = new System.Windows.Forms.ProgressBar();
            this.button_openrepo = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_links)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(636, 496);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(132, 22);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Location = new System.Drawing.Point(497, 466);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(132, 24);
            this.button_refresh.TabIndex = 1;
            this.button_refresh.Text = "Check for Updates";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // dataGridView_links
            // 
            this.dataGridView_links.AllowUserToAddRows = false;
            this.dataGridView_links.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_links.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_links.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_links.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_links.Location = new System.Drawing.Point(13, 13);
            this.dataGridView_links.Name = "dataGridView_links";
            this.dataGridView_links.Size = new System.Drawing.Size(755, 447);
            this.dataGridView_links.TabIndex = 2;
            this.dataGridView_links.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_links_CellEndEdit);
            this.dataGridView_links.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_links_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Online Version";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Local Version";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Link";
            this.Column4.Name = "Column4";
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add.Location = new System.Drawing.Point(13, 466);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(135, 52);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // progressBar_checking
            // 
            this.progressBar_checking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_checking.Location = new System.Drawing.Point(154, 466);
            this.progressBar_checking.Maximum = 0;
            this.progressBar_checking.Name = "progressBar_checking";
            this.progressBar_checking.Size = new System.Drawing.Size(337, 52);
            this.progressBar_checking.TabIndex = 4;
            // 
            // button_openrepo
            // 
            this.button_openrepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openrepo.Location = new System.Drawing.Point(497, 496);
            this.button_openrepo.Name = "button_openrepo";
            this.button_openrepo.Size = new System.Drawing.Size(132, 22);
            this.button_openrepo.TabIndex = 5;
            this.button_openrepo.Text = "Open Data-File";
            this.button_openrepo.UseVisualStyleBackColor = true;
            this.button_openrepo.Click += new System.EventHandler(this.button_openrepo_Click);
            // 
            // button_reload
            // 
            this.button_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reload.Location = new System.Drawing.Point(636, 466);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(132, 24);
            this.button_reload.TabIndex = 6;
            this.button_reload.Text = "Refresh";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // Form_gamesupdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 522);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.button_openrepo);
            this.Controls.Add(this.progressBar_checking);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_links);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_exit);
            this.Name = "Form_gamesupdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameUpdater";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_links)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView_links;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ProgressBar progressBar_checking;
        private System.Windows.Forms.Button button_openrepo;
        private System.Windows.Forms.Button button_reload;
    }
}

