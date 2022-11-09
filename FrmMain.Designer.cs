namespace WFA221109
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiTenyeszto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParkereso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBejelentes = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.Thistle;
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTenyeszto,
            this.tsmiParkereso,
            this.tsmiBejelentes});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(908, 78);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiTenyeszto
            // 
            this.tsmiTenyeszto.Image = global::WFA221109.Properties.Resources.wizard;
            this.tsmiTenyeszto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTenyeszto.Name = "tsmiTenyeszto";
            this.tsmiTenyeszto.Size = new System.Drawing.Size(95, 74);
            this.tsmiTenyeszto.Text = "Tenyésztők";
            this.tsmiTenyeszto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiParkereso
            // 
            this.tsmiParkereso.Image = global::WFA221109.Properties.Resources.love;
            this.tsmiParkereso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiParkereso.Name = "tsmiParkereso";
            this.tsmiParkereso.Size = new System.Drawing.Size(86, 74);
            this.tsmiParkereso.Text = "Párkereső";
            this.tsmiParkereso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiBejelentes
            // 
            this.tsmiBejelentes.Image = global::WFA221109.Properties.Resources.unicorn;
            this.tsmiBejelentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiBejelentes.Name = "tsmiBejelentes";
            this.tsmiBejelentes.Size = new System.Drawing.Size(91, 74);
            this.tsmiBejelentes.Text = "Bejelentés";
            this.tsmiBejelentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiBejelentes.Click += new System.EventHandler(this.TsmiBejelentes_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvMain.Location = new System.Drawing.Point(29, 106);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 29;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(851, 441);
            this.dgvMain.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 5F;
            this.Column2.HeaderText = "fajta";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 5F;
            this.Column3.HeaderText = "tulajdonos";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 5F;
            this.Column4.HeaderText = "város";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 5F;
            this.Column5.HeaderText = "súly";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 5F;
            this.Column6.HeaderText = "nem";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(908, 575);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmMain";
            this.Text = "Unikornis Ménes Manager 2022";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem tsmiTenyeszto;
        private ToolStripMenuItem tsmiParkereso;
        private ToolStripMenuItem tsmiBejelentes;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}