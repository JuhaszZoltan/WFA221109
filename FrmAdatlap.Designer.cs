namespace WFA221109
{
    partial class FrmAdatlap
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
            this.txtFajta = new System.Windows.Forms.Label();
            this.cbFajtak = new System.Windows.Forms.ComboBox();
            this.nudSuly = new System.Windows.Forms.NumericUpDown();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.btnUj = new System.Windows.Forms.Button();
            this.txtTulaj = new System.Windows.Forms.Label();
            this.txtSuly = new System.Windows.Forms.Label();
            this.txtNem = new System.Windows.Forms.Label();
            this.cbTulajdonosok = new System.Windows.Forms.ComboBox();
            this.rbKanca = new System.Windows.Forms.RadioButton();
            this.rbCsodor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFajta
            // 
            this.txtFajta.AutoSize = true;
            this.txtFajta.BackColor = System.Drawing.Color.Plum;
            this.txtFajta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFajta.Location = new System.Drawing.Point(75, 55);
            this.txtFajta.Name = "txtFajta";
            this.txtFajta.Size = new System.Drawing.Size(49, 23);
            this.txtFajta.TabIndex = 0;
            this.txtFajta.Text = "Fajta:";
            // 
            // cbFajtak
            // 
            this.cbFajtak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFajtak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFajtak.FormattingEnabled = true;
            this.cbFajtak.Location = new System.Drawing.Point(149, 52);
            this.cbFajtak.Name = "cbFajtak";
            this.cbFajtak.Size = new System.Drawing.Size(164, 31);
            this.cbFajtak.TabIndex = 1;
            this.cbFajtak.SelectedIndexChanged += new System.EventHandler(this.CbFajtak_SelectedIndexChanged);
            // 
            // nudSuly
            // 
            this.nudSuly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudSuly.Location = new System.Drawing.Point(174, 169);
            this.nudSuly.Name = "nudSuly";
            this.nudSuly.Size = new System.Drawing.Size(97, 30);
            this.nudSuly.TabIndex = 2;
            // 
            // pbKep
            // 
            this.pbKep.BackColor = System.Drawing.Color.White;
            this.pbKep.Location = new System.Drawing.Point(349, 31);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(200, 250);
            this.pbKep.TabIndex = 3;
            this.pbKep.TabStop = false;
            // 
            // btnUj
            // 
            this.btnUj.BackColor = System.Drawing.Color.Plum;
            this.btnUj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUj.Location = new System.Drawing.Point(27, 309);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(522, 71);
            this.btnUj.TabIndex = 4;
            this.btnUj.Text = "Új egyed rögzítése az adatbázisba!";
            this.btnUj.UseVisualStyleBackColor = false;
            // 
            // txtTulaj
            // 
            this.txtTulaj.AutoSize = true;
            this.txtTulaj.BackColor = System.Drawing.Color.Plum;
            this.txtTulaj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTulaj.Location = new System.Drawing.Point(27, 113);
            this.txtTulaj.Name = "txtTulaj";
            this.txtTulaj.Size = new System.Drawing.Size(97, 23);
            this.txtTulaj.TabIndex = 0;
            this.txtTulaj.Text = "Tulajdonos:";
            // 
            // txtSuly
            // 
            this.txtSuly.AutoSize = true;
            this.txtSuly.BackColor = System.Drawing.Color.Plum;
            this.txtSuly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSuly.Location = new System.Drawing.Point(79, 171);
            this.txtSuly.Name = "txtSuly";
            this.txtSuly.Size = new System.Drawing.Size(45, 23);
            this.txtSuly.TabIndex = 0;
            this.txtSuly.Text = "Súly:";
            // 
            // txtNem
            // 
            this.txtNem.AutoSize = true;
            this.txtNem.BackColor = System.Drawing.Color.Plum;
            this.txtNem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNem.Location = new System.Drawing.Point(73, 229);
            this.txtNem.Name = "txtNem";
            this.txtNem.Size = new System.Drawing.Size(51, 23);
            this.txtNem.TabIndex = 0;
            this.txtNem.Text = "Nem:";
            // 
            // cbTulajdonosok
            // 
            this.cbTulajdonosok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTulajdonosok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTulajdonosok.FormattingEnabled = true;
            this.cbTulajdonosok.Location = new System.Drawing.Point(149, 110);
            this.cbTulajdonosok.Name = "cbTulajdonosok";
            this.cbTulajdonosok.Size = new System.Drawing.Size(164, 31);
            this.cbTulajdonosok.TabIndex = 1;
            this.cbTulajdonosok.SelectedIndexChanged += new System.EventHandler(this.CbTulajdonosok_SelectedIndexChanged);
            // 
            // rbKanca
            // 
            this.rbKanca.AutoSize = true;
            this.rbKanca.BackColor = System.Drawing.Color.Plum;
            this.rbKanca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbKanca.Location = new System.Drawing.Point(149, 227);
            this.rbKanca.Name = "rbKanca";
            this.rbKanca.Size = new System.Drawing.Size(75, 27);
            this.rbKanca.TabIndex = 5;
            this.rbKanca.Text = "kanca";
            this.rbKanca.UseVisualStyleBackColor = false;
            // 
            // rbCsodor
            // 
            this.rbCsodor.AutoSize = true;
            this.rbCsodor.BackColor = System.Drawing.Color.Plum;
            this.rbCsodor.Checked = true;
            this.rbCsodor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCsodor.Location = new System.Drawing.Point(230, 227);
            this.rbCsodor.Name = "rbCsodor";
            this.rbCsodor.Size = new System.Drawing.Size(82, 27);
            this.rbCsodor.TabIndex = 5;
            this.rbCsodor.TabStop = true;
            this.rbCsodor.Text = "csődör";
            this.rbCsodor.UseVisualStyleBackColor = false;
            // 
            // FrmAdatlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(578, 407);
            this.Controls.Add(this.rbCsodor);
            this.Controls.Add(this.rbKanca);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.nudSuly);
            this.Controls.Add(this.cbTulajdonosok);
            this.Controls.Add(this.cbFajtak);
            this.Controls.Add(this.txtNem);
            this.Controls.Add(this.txtSuly);
            this.Controls.Add(this.txtTulaj);
            this.Controls.Add(this.txtFajta);
            this.Name = "FrmAdatlap";
            this.Text = "FrmAdatlap";
            this.Load += new System.EventHandler(this.FrmAdatlap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtFajta;
        private ComboBox cbFajtak;
        private NumericUpDown nudSuly;
        private PictureBox pbKep;
        private Button btnUj;
        private Label txtTulaj;
        private Label txtSuly;
        private Label txtNem;
        private ComboBox cbTulajdonosok;
        private RadioButton rbKanca;
        private RadioButton rbCsodor;
    }
}