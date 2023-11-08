namespace KuisPertemuan13
{
    partial class Form1
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbKristen = new System.Windows.Forms.RadioButton();
            this.rbIslam = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDel1 = new System.Windows.Forms.TextBox();
            this.txtDel5 = new System.Windows.Forms.TextBox();
            this.txtDel4 = new System.Windows.Forms.TextBox();
            this.txtDel3 = new System.Windows.Forms.TextBox();
            this.txtDel2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJudul.Location = new System.Drawing.Point(269, 28);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(272, 32);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Kuis Pertemuan 13";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(38, 74);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 25);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(168, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(584, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(42, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(710, 213);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblId.Location = new System.Drawing.Point(48, 349);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 25);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(102, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            // 
            // rbAll
            // 
            this.rbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.SystemColors.Control;
            this.rbAll.Location = new System.Drawing.Point(57, 398);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(62, 29);
            this.rbAll.TabIndex = 6;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbKristen
            // 
            this.rbKristen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbKristen.AutoSize = true;
            this.rbKristen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKristen.ForeColor = System.Drawing.SystemColors.Control;
            this.rbKristen.Location = new System.Drawing.Point(299, 398);
            this.rbKristen.Name = "rbKristen";
            this.rbKristen.Size = new System.Drawing.Size(105, 29);
            this.rbKristen.TabIndex = 7;
            this.rbKristen.TabStop = true;
            this.rbKristen.Text = "Kristen";
            this.rbKristen.UseVisualStyleBackColor = true;
            this.rbKristen.CheckedChanged += new System.EventHandler(this.rbKristen_CheckedChanged);
            // 
            // rbIslam
            // 
            this.rbIslam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbIslam.AutoSize = true;
            this.rbIslam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIslam.ForeColor = System.Drawing.SystemColors.Control;
            this.rbIslam.Location = new System.Drawing.Point(164, 398);
            this.rbIslam.Name = "rbIslam";
            this.rbIslam.Size = new System.Drawing.Size(88, 29);
            this.rbIslam.TabIndex = 8;
            this.rbIslam.TabStop = true;
            this.rbIslam.Text = "Islam";
            this.rbIslam.UseVisualStyleBackColor = true;
            this.rbIslam.CheckedChanged += new System.EventHandler(this.rbIslam_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(431, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(546, 442);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(677, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDel1
            // 
            this.txtDel1.BackColor = System.Drawing.Color.Turquoise;
            this.txtDel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDel1.ForeColor = System.Drawing.Color.Transparent;
            this.txtDel1.Location = new System.Drawing.Point(576, 41);
            this.txtDel1.Name = "txtDel1";
            this.txtDel1.Size = new System.Drawing.Size(100, 19);
            this.txtDel1.TabIndex = 12;
            // 
            // txtDel5
            // 
            this.txtDel5.BackColor = System.Drawing.Color.Turquoise;
            this.txtDel5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDel5.ForeColor = System.Drawing.Color.Transparent;
            this.txtDel5.Location = new System.Drawing.Point(102, 28);
            this.txtDel5.Name = "txtDel5";
            this.txtDel5.Size = new System.Drawing.Size(100, 19);
            this.txtDel5.TabIndex = 13;
            // 
            // txtDel4
            // 
            this.txtDel4.BackColor = System.Drawing.Color.Turquoise;
            this.txtDel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDel4.ForeColor = System.Drawing.Color.Transparent;
            this.txtDel4.Location = new System.Drawing.Point(535, 12);
            this.txtDel4.Name = "txtDel4";
            this.txtDel4.Size = new System.Drawing.Size(100, 19);
            this.txtDel4.TabIndex = 14;
            // 
            // txtDel3
            // 
            this.txtDel3.BackColor = System.Drawing.Color.Turquoise;
            this.txtDel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDel3.ForeColor = System.Drawing.Color.Transparent;
            this.txtDel3.Location = new System.Drawing.Point(626, 41);
            this.txtDel3.Name = "txtDel3";
            this.txtDel3.Size = new System.Drawing.Size(100, 19);
            this.txtDel3.TabIndex = 15;
            // 
            // txtDel2
            // 
            this.txtDel2.BackColor = System.Drawing.Color.Turquoise;
            this.txtDel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDel2.ForeColor = System.Drawing.Color.Transparent;
            this.txtDel2.Location = new System.Drawing.Point(576, 12);
            this.txtDel2.Name = "txtDel2";
            this.txtDel2.Size = new System.Drawing.Size(100, 19);
            this.txtDel2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.txtDel2);
            this.Controls.Add(this.txtDel3);
            this.Controls.Add(this.txtDel4);
            this.Controls.Add(this.txtDel5);
            this.Controls.Add(this.txtDel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rbIslam);
            this.Controls.Add(this.rbKristen);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblJudul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbKristen;
        private System.Windows.Forms.RadioButton rbIslam;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDel1;
        private System.Windows.Forms.TextBox txtDel5;
        private System.Windows.Forms.TextBox txtDel4;
        private System.Windows.Forms.TextBox txtDel3;
        private System.Windows.Forms.TextBox txtDel2;
    }
}

