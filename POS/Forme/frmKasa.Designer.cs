namespace POS.Forme
{
    partial class frmKasa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasa));
            this.dgvPorudzba = new System.Windows.Forms.DataGridView();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnPonistiNarudzbu = new System.Windows.Forms.Button();
            this.btnDodajUkorpu = new System.Windows.Forms.Button();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.btnStampajRacun = new System.Windows.Forms.Button();
            this.btnPregledRacuna = new System.Windows.Forms.Button();
            this.txtUkZaPlatiti = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtKolicinaStavke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdNarudzbe = new System.Windows.Forms.TextBox();
            this.txtSifraArtikla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCijenaPoJedinici = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblImeProdavca = new System.Windows.Forms.Label();
            this.lblPrezimeProdavca = new System.Windows.Forms.Label();
            this.lblIdRadnika = new System.Windows.Forms.Label();
            this.cmbArtikli = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorudzba)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPorudzba
            // 
            this.dgvPorudzba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPorudzba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPorudzba.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorudzba.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPorudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPorudzba.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPorudzba.EnableHeadersVisualStyles = false;
            this.dgvPorudzba.Location = new System.Drawing.Point(13, 13);
            this.dgvPorudzba.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPorudzba.Name = "dgvPorudzba";
            this.dgvPorudzba.ReadOnly = true;
            this.dgvPorudzba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorudzba.Size = new System.Drawing.Size(998, 395);
            this.dgvPorudzba.TabIndex = 44;
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrisiStavku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(174)))), ((int)(((byte)(22)))));
            this.btnObrisiStavku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiStavku.FlatAppearance.BorderSize = 0;
            this.btnObrisiStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiStavku.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnObrisiStavku.Location = new System.Drawing.Point(621, 483);
            this.btnObrisiStavku.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(74, 56);
            this.btnObrisiStavku.TabIndex = 49;
            this.btnObrisiStavku.Text = "\r\nObriši stavku\r\n";
            this.btnObrisiStavku.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnObrisiStavku.UseVisualStyleBackColor = false;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnPonistiNarudzbu
            // 
            this.btnPonistiNarudzbu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPonistiNarudzbu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(41)))));
            this.btnPonistiNarudzbu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPonistiNarudzbu.FlatAppearance.BorderSize = 0;
            this.btnPonistiNarudzbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonistiNarudzbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPonistiNarudzbu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPonistiNarudzbu.Location = new System.Drawing.Point(703, 415);
            this.btnPonistiNarudzbu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPonistiNarudzbu.Name = "btnPonistiNarudzbu";
            this.btnPonistiNarudzbu.Size = new System.Drawing.Size(74, 56);
            this.btnPonistiNarudzbu.TabIndex = 50;
            this.btnPonistiNarudzbu.Text = "\r\nPoništi narudžbu\r\n";
            this.btnPonistiNarudzbu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPonistiNarudzbu.UseVisualStyleBackColor = false;
            this.btnPonistiNarudzbu.Click += new System.EventHandler(this.btnPonistiNarudzbu_Click);
            // 
            // btnDodajUkorpu
            // 
            this.btnDodajUkorpu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajUkorpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.btnDodajUkorpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajUkorpu.FlatAppearance.BorderSize = 0;
            this.btnDodajUkorpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajUkorpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajUkorpu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajUkorpu.Location = new System.Drawing.Point(621, 415);
            this.btnDodajUkorpu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajUkorpu.Name = "btnDodajUkorpu";
            this.btnDodajUkorpu.Size = new System.Drawing.Size(74, 56);
            this.btnDodajUkorpu.TabIndex = 57;
            this.btnDodajUkorpu.Text = "\r\nDodaj u korpu\r\n";
            this.btnDodajUkorpu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajUkorpu.UseVisualStyleBackColor = false;
            this.btnDodajUkorpu.Click += new System.EventHandler(this.btnDodajUkorpu_Click);
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUkupanIznos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUkupanIznos.Location = new System.Drawing.Point(329, 93);
            this.txtUkupanIznos.Margin = new System.Windows.Forms.Padding(4);
            this.txtUkupanIznos.Multiline = true;
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.Size = new System.Drawing.Size(16, 17);
            this.txtUkupanIznos.TabIndex = 56;
            this.txtUkupanIznos.Text = "0.00";
            this.txtUkupanIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUkupanIznos.Visible = false;
            // 
            // txtPDV
            // 
            this.txtPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPDV.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPDV.Location = new System.Drawing.Point(353, 90);
            this.txtPDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDV.Multiline = true;
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(10, 21);
            this.txtPDV.TabIndex = 55;
            this.txtPDV.Text = "0.00";
            this.txtPDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPDV.Visible = false;
            // 
            // btnStampajRacun
            // 
            this.btnStampajRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStampajRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(178)))), ((int)(((byte)(5)))));
            this.btnStampajRacun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStampajRacun.FlatAppearance.BorderSize = 0;
            this.btnStampajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStampajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStampajRacun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStampajRacun.Location = new System.Drawing.Point(785, 415);
            this.btnStampajRacun.Margin = new System.Windows.Forms.Padding(4);
            this.btnStampajRacun.Name = "btnStampajRacun";
            this.btnStampajRacun.Size = new System.Drawing.Size(74, 56);
            this.btnStampajRacun.TabIndex = 52;
            this.btnStampajRacun.Text = "\r\nŠtampaj račun\r\nF";
            this.btnStampajRacun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStampajRacun.UseVisualStyleBackColor = false;
            this.btnStampajRacun.Click += new System.EventHandler(this.btnStampajRacun_Click);
            // 
            // btnPregledRacuna
            // 
            this.btnPregledRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPregledRacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnPregledRacuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregledRacuna.FlatAppearance.BorderSize = 0;
            this.btnPregledRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledRacuna.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPregledRacuna.Location = new System.Drawing.Point(703, 483);
            this.btnPregledRacuna.Margin = new System.Windows.Forms.Padding(4);
            this.btnPregledRacuna.Name = "btnPregledRacuna";
            this.btnPregledRacuna.Size = new System.Drawing.Size(74, 56);
            this.btnPregledRacuna.TabIndex = 51;
            this.btnPregledRacuna.Text = "\r\nPregled računa\r\nF11";
            this.btnPregledRacuna.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPregledRacuna.UseVisualStyleBackColor = false;
            this.btnPregledRacuna.Click += new System.EventHandler(this.btnPregledRacuna_Click);
            // 
            // txtUkZaPlatiti
            // 
            this.txtUkZaPlatiti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUkZaPlatiti.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtUkZaPlatiti.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUkZaPlatiti.Location = new System.Drawing.Point(867, 470);
            this.txtUkZaPlatiti.Margin = new System.Windows.Forms.Padding(4);
            this.txtUkZaPlatiti.Multiline = true;
            this.txtUkZaPlatiti.Name = "txtUkZaPlatiti";
            this.txtUkZaPlatiti.ReadOnly = true;
            this.txtUkZaPlatiti.Size = new System.Drawing.Size(144, 69);
            this.txtUkZaPlatiti.TabIndex = 54;
            this.txtUkZaPlatiti.Text = "0,00";
            this.txtUkZaPlatiti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbArtikli);
            this.panel2.Controls.Add(this.txtKolicinaStavke);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIdNarudzbe);
            this.panel2.Controls.Add(this.txtSifraArtikla);
            this.panel2.Controls.Add(this.txtUkupanIznos);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPDV);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtKolicina);
            this.panel2.Controls.Add(this.txtCijenaPoJedinici);
            this.panel2.Controls.Add(this.txtBarkod);
            this.panel2.Controls.Add(this.dtpDatum);
            this.panel2.Controls.Add(this.txtNazivArtikla);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(13, 416);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 123);
            this.panel2.TabIndex = 58;
            // 
            // txtKolicinaStavke
            // 
            this.txtKolicinaStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolicinaStavke.Location = new System.Drawing.Point(361, 4);
            this.txtKolicinaStavke.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicinaStavke.Name = "txtKolicinaStavke";
            this.txtKolicinaStavke.Size = new System.Drawing.Size(23, 20);
            this.txtKolicinaStavke.TabIndex = 37;
            this.txtKolicinaStavke.Text = "1";
            this.txtKolicinaStavke.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Faktura # :";
            // 
            // txtIdNarudzbe
            // 
            this.txtIdNarudzbe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdNarudzbe.Location = new System.Drawing.Point(117, 4);
            this.txtIdNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdNarudzbe.Name = "txtIdNarudzbe";
            this.txtIdNarudzbe.ReadOnly = true;
            this.txtIdNarudzbe.Size = new System.Drawing.Size(163, 22);
            this.txtIdNarudzbe.TabIndex = 33;
            this.txtIdNarudzbe.Text = "1";
            // 
            // txtSifraArtikla
            // 
            this.txtSifraArtikla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifraArtikla.Location = new System.Drawing.Point(332, 4);
            this.txtSifraArtikla.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifraArtikla.Name = "txtSifraArtikla";
            this.txtSifraArtikla.Size = new System.Drawing.Size(11, 20);
            this.txtSifraArtikla.TabIndex = 36;
            this.txtSifraArtikla.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(371, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cijena (KM) :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(30, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Kolicina :";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolicina.Location = new System.Drawing.Point(117, 88);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(86, 22);
            this.txtKolicina.TabIndex = 2;
            this.txtKolicina.Text = "1";
            // 
            // txtCijenaPoJedinici
            // 
            this.txtCijenaPoJedinici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCijenaPoJedinici.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijenaPoJedinici.Location = new System.Drawing.Point(461, 88);
            this.txtCijenaPoJedinici.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijenaPoJedinici.Name = "txtCijenaPoJedinici";
            this.txtCijenaPoJedinici.Size = new System.Drawing.Size(127, 22);
            this.txtCijenaPoJedinici.TabIndex = 31;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarkod.BackColor = System.Drawing.Color.Chartreuse;
            this.txtBarkod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkod.Location = new System.Drawing.Point(117, 32);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(471, 22);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatum.CustomFormat = "dd.MM.yyyy";
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(476, 4);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(112, 20);
            this.dtpDatum.TabIndex = 7;
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazivArtikla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNazivArtikla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNazivArtikla.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivArtikla.Location = new System.Drawing.Point(117, 60);
            this.txtNazivArtikla.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(471, 22);
            this.txtNazivArtikla.TabIndex = 1;
            this.txtNazivArtikla.TextChanged += new System.EventHandler(this.txtNazivArtikla_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(419, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Datum :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(4, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Naziv artikla :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(48, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Šifra : ";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lblImeProdavca
            // 
            this.lblImeProdavca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImeProdavca.AutoSize = true;
            this.lblImeProdavca.Location = new System.Drawing.Point(894, 449);
            this.lblImeProdavca.Name = "lblImeProdavca";
            this.lblImeProdavca.Size = new System.Drawing.Size(35, 13);
            this.lblImeProdavca.TabIndex = 57;
            this.lblImeProdavca.Text = "label1";
            this.lblImeProdavca.Visible = false;
            // 
            // lblPrezimeProdavca
            // 
            this.lblPrezimeProdavca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrezimeProdavca.AutoSize = true;
            this.lblPrezimeProdavca.Location = new System.Drawing.Point(935, 449);
            this.lblPrezimeProdavca.Name = "lblPrezimeProdavca";
            this.lblPrezimeProdavca.Size = new System.Drawing.Size(35, 13);
            this.lblPrezimeProdavca.TabIndex = 58;
            this.lblPrezimeProdavca.Text = "label2";
            this.lblPrezimeProdavca.Visible = false;
            // 
            // lblIdRadnika
            // 
            this.lblIdRadnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdRadnika.AutoSize = true;
            this.lblIdRadnika.Location = new System.Drawing.Point(976, 449);
            this.lblIdRadnika.Name = "lblIdRadnika";
            this.lblIdRadnika.Size = new System.Drawing.Size(35, 13);
            this.lblIdRadnika.TabIndex = 59;
            this.lblIdRadnika.Text = "label5";
            this.lblIdRadnika.Visible = false;
            // 
            // cmbArtikli
            // 
            this.cmbArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbArtikli.FormattingEnabled = true;
            this.cmbArtikli.Location = new System.Drawing.Point(308, 5);
            this.cmbArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArtikli.Name = "cmbArtikli";
            this.cmbArtikli.Size = new System.Drawing.Size(16, 21);
            this.cmbArtikli.TabIndex = 57;
            this.cmbArtikli.Visible = false;
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1024, 550);
            this.Controls.Add(this.lblImeProdavca);
            this.Controls.Add(this.lblPrezimeProdavca);
            this.Controls.Add(this.lblIdRadnika);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnPonistiNarudzbu);
            this.Controls.Add(this.btnDodajUkorpu);
            this.Controls.Add(this.btnStampajRacun);
            this.Controls.Add(this.btnPregledRacuna);
            this.Controls.Add(this.txtUkZaPlatiti);
            this.Controls.Add(this.dgvPorudzba);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmKasa";
            this.Text = "frmKasa";
            this.Load += new System.EventHandler(this.frmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorudzba)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPorudzba;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnPonistiNarudzbu;
        private System.Windows.Forms.Button btnDodajUkorpu;
        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Button btnStampajRacun;
        private System.Windows.Forms.Button btnPregledRacuna;
        private System.Windows.Forms.TextBox txtUkZaPlatiti;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdNarudzbe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCijenaPoJedinici;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKolicinaStavke;
        private System.Windows.Forms.TextBox txtSifraArtikla;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblImeProdavca;
        private System.Windows.Forms.Label lblPrezimeProdavca;
        private System.Windows.Forms.Label lblIdRadnika;
        private System.Windows.Forms.ComboBox cmbArtikli;
    }
}