namespace CELnovi
{
    partial class FrmOprema
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
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.btnUnesi2 = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOprema
            // 
            this.dgvOprema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOprema.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvOprema.Location = new System.Drawing.Point(62, 77);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOprema.Size = new System.Drawing.Size(1043, 289);
            this.dgvOprema.TabIndex = 0;
            // 
            // btnUnesi2
            // 
            this.btnUnesi2.BackColor = System.Drawing.Color.Lime;
            this.btnUnesi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesi2.ForeColor = System.Drawing.Color.Black;
            this.btnUnesi2.Location = new System.Drawing.Point(878, 385);
            this.btnUnesi2.Name = "btnUnesi2";
            this.btnUnesi2.Size = new System.Drawing.Size(227, 43);
            this.btnUnesi2.TabIndex = 1;
            this.btnUnesi2.Text = "UNESI OPREMU";
            this.btnUnesi2.UseVisualStyleBackColor = false;
            this.btnUnesi2.Click += new System.EventHandler(this.btnUnesi2Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.Lime;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.Color.Black;
            this.btnUredi.Location = new System.Drawing.Point(699, 385);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(162, 43);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "UPDATE";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.bntUrediClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(456, 24);
            this.txtSearch.MaximumSize = new System.Drawing.Size(400, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 35);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(862, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "PRETRAZI";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(999, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1173, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnesi2);
            this.Controls.Add(this.dgvOprema);
            this.Name = "FrmOprema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOprema";
            this.Load += new System.EventHandler(this.FrmOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnUnesi2;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}