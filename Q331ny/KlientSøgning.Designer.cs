namespace Q331ny
{
    partial class Q331
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
            this.aktivChb = new System.Windows.Forms.CheckBox();
            this.enhedGb = new System.Windows.Forms.GroupBox();
            this.gruppeEnhedCb = new System.Windows.Forms.ComboBox();
            this.admEnhedCb = new System.Windows.Forms.ComboBox();
            this.gruppeEnhedLb = new System.Windows.Forms.Label();
            this.admEnhedLb = new System.Windows.Forms.Label();
            this.klientGb = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sagsbehandlerLb = new System.Windows.Forms.Label();
            this.klientKategoriLb = new System.Windows.Forms.Label();
            this.intervalKlient = new System.Windows.Forms.TextBox();
            this.førsteKlientTb = new System.Windows.Forms.TextBox();
            this.intervalKlientLb = new System.Windows.Forms.Label();
            this.førsteKlientLb = new System.Windows.Forms.Label();
            this.sagsStatusGb = new System.Windows.Forms.GroupBox();
            this.passivChb = new System.Windows.Forms.CheckBox();
            this.Overskrift = new System.Windows.Forms.Label();
            this.sagstypeGb = new System.Windows.Forms.GroupBox();
            this.erviceChb = new System.Windows.Forms.CheckBox();
            this.klientBetalingChb = new System.Windows.Forms.CheckBox();
            this.startDatoGb = new System.Windows.Forms.GroupBox();
            this.startDatoTilDtp = new System.Windows.Forms.DateTimePicker();
            this.tilDatoStartLb = new System.Windows.Forms.Label();
            this.startDatoFraDtp = new System.Windows.Forms.DateTimePicker();
            this.fraDatoStartLb = new System.Windows.Forms.Label();
            this.slutDatoGb = new System.Windows.Forms.GroupBox();
            this.slutDatoTilDtp = new System.Windows.Forms.DateTimePicker();
            this.tilDatoSlutLb = new System.Windows.Forms.Label();
            this.slutDatoFraDtp = new System.Windows.Forms.DateTimePicker();
            this.fraDatoSlutLb = new System.Windows.Forms.Label();
            this.søgBtn = new System.Windows.Forms.Button();
            this.enhedGb.SuspendLayout();
            this.klientGb.SuspendLayout();
            this.sagsStatusGb.SuspendLayout();
            this.sagstypeGb.SuspendLayout();
            this.startDatoGb.SuspendLayout();
            this.slutDatoGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // aktivChb
            // 
            this.aktivChb.AutoSize = true;
            this.aktivChb.Location = new System.Drawing.Point(6, 28);
            this.aktivChb.Name = "aktivChb";
            this.aktivChb.Size = new System.Drawing.Size(50, 17);
            this.aktivChb.TabIndex = 5;
            this.aktivChb.Text = "Aktiv";
            this.aktivChb.UseVisualStyleBackColor = true;
            // 
            // enhedGb
            // 
            this.enhedGb.Controls.Add(this.gruppeEnhedCb);
            this.enhedGb.Controls.Add(this.admEnhedCb);
            this.enhedGb.Controls.Add(this.gruppeEnhedLb);
            this.enhedGb.Controls.Add(this.admEnhedLb);
            this.enhedGb.Location = new System.Drawing.Point(97, 70);
            this.enhedGb.Name = "enhedGb";
            this.enhedGb.Size = new System.Drawing.Size(261, 95);
            this.enhedGb.TabIndex = 6;
            this.enhedGb.TabStop = false;
            this.enhedGb.Text = "Enhed";
            // 
            // gruppeEnhedCb
            // 
            this.gruppeEnhedCb.FormattingEnabled = true;
            this.gruppeEnhedCb.Items.AddRange(new object[] {
            "Nord",
            "Syd",
            "Øst",
            "Vest"});
            this.gruppeEnhedCb.Location = new System.Drawing.Point(122, 56);
            this.gruppeEnhedCb.Name = "gruppeEnhedCb";
            this.gruppeEnhedCb.Size = new System.Drawing.Size(121, 21);
            this.gruppeEnhedCb.TabIndex = 3;
            // 
            // admEnhedCb
            // 
            this.admEnhedCb.FormattingEnabled = true;
            this.admEnhedCb.Items.AddRange(new object[] {
            "2905",
            "2906",
            "2912"});
            this.admEnhedCb.Location = new System.Drawing.Point(122, 12);
            this.admEnhedCb.Name = "admEnhedCb";
            this.admEnhedCb.Size = new System.Drawing.Size(121, 21);
            this.admEnhedCb.TabIndex = 2;
            // 
            // gruppeEnhedLb
            // 
            this.gruppeEnhedLb.AutoSize = true;
            this.gruppeEnhedLb.Location = new System.Drawing.Point(9, 56);
            this.gruppeEnhedLb.Name = "gruppeEnhedLb";
            this.gruppeEnhedLb.Size = new System.Drawing.Size(77, 13);
            this.gruppeEnhedLb.TabIndex = 1;
            this.gruppeEnhedLb.Text = "Gruppe/enhed";
            // 
            // admEnhedLb
            // 
            this.admEnhedLb.AutoSize = true;
            this.admEnhedLb.Location = new System.Drawing.Point(9, 21);
            this.admEnhedLb.Name = "admEnhedLb";
            this.admEnhedLb.Size = new System.Drawing.Size(87, 13);
            this.admEnhedLb.TabIndex = 0;
            this.admEnhedLb.Text = "Sagsadm. enhed";
            // 
            // klientGb
            // 
            this.klientGb.Controls.Add(this.textBox3);
            this.klientGb.Controls.Add(this.textBox2);
            this.klientGb.Controls.Add(this.sagsbehandlerLb);
            this.klientGb.Controls.Add(this.klientKategoriLb);
            this.klientGb.Controls.Add(this.intervalKlient);
            this.klientGb.Controls.Add(this.førsteKlientTb);
            this.klientGb.Controls.Add(this.intervalKlientLb);
            this.klientGb.Controls.Add(this.førsteKlientLb);
            this.klientGb.Location = new System.Drawing.Point(97, 182);
            this.klientGb.Name = "klientGb";
            this.klientGb.Size = new System.Drawing.Size(261, 181);
            this.klientGb.TabIndex = 7;
            this.klientGb.TabStop = false;
            this.klientGb.Text = "Klient";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // sagsbehandlerLb
            // 
            this.sagsbehandlerLb.AutoSize = true;
            this.sagsbehandlerLb.Location = new System.Drawing.Point(9, 125);
            this.sagsbehandlerLb.Name = "sagsbehandlerLb";
            this.sagsbehandlerLb.Size = new System.Drawing.Size(78, 13);
            this.sagsbehandlerLb.TabIndex = 5;
            this.sagsbehandlerLb.Text = "Sagsbehandler";
            // 
            // klientKategoriLb
            // 
            this.klientKategoriLb.AutoSize = true;
            this.klientKategoriLb.Location = new System.Drawing.Point(9, 93);
            this.klientKategoriLb.Name = "klientKategoriLb";
            this.klientKategoriLb.Size = new System.Drawing.Size(71, 13);
            this.klientKategoriLb.TabIndex = 4;
            this.klientKategoriLb.Text = "Klientkategori";
            // 
            // intervalKlient
            // 
            this.intervalKlient.Location = new System.Drawing.Point(122, 61);
            this.intervalKlient.Name = "intervalKlient";
            this.intervalKlient.Size = new System.Drawing.Size(100, 20);
            this.intervalKlient.TabIndex = 3;
            // 
            // førsteKlientTb
            // 
            this.førsteKlientTb.Location = new System.Drawing.Point(122, 30);
            this.førsteKlientTb.Name = "førsteKlientTb";
            this.førsteKlientTb.Size = new System.Drawing.Size(100, 20);
            this.førsteKlientTb.TabIndex = 2;
            // 
            // intervalKlientLb
            // 
            this.intervalKlientLb.AutoSize = true;
            this.intervalKlientLb.Location = new System.Drawing.Point(9, 61);
            this.intervalKlientLb.Name = "intervalKlientLb";
            this.intervalKlientLb.Size = new System.Drawing.Size(70, 13);
            this.intervalKlientLb.TabIndex = 1;
            this.intervalKlientLb.Text = "Interval klient";
            // 
            // førsteKlientLb
            // 
            this.førsteKlientLb.AutoSize = true;
            this.førsteKlientLb.Location = new System.Drawing.Point(9, 30);
            this.førsteKlientLb.Name = "førsteKlientLb";
            this.førsteKlientLb.Size = new System.Drawing.Size(64, 13);
            this.førsteKlientLb.TabIndex = 0;
            this.førsteKlientLb.Text = "Første klient";
            // 
            // sagsStatusGb
            // 
            this.sagsStatusGb.Controls.Add(this.passivChb);
            this.sagsStatusGb.Controls.Add(this.aktivChb);
            this.sagsStatusGb.Location = new System.Drawing.Point(489, 70);
            this.sagsStatusGb.Name = "sagsStatusGb";
            this.sagsStatusGb.Size = new System.Drawing.Size(200, 84);
            this.sagsStatusGb.TabIndex = 8;
            this.sagsStatusGb.TabStop = false;
            this.sagsStatusGb.Text = "Sagsstatus";
            // 
            // passivChb
            // 
            this.passivChb.AutoSize = true;
            this.passivChb.Location = new System.Drawing.Point(6, 52);
            this.passivChb.Name = "passivChb";
            this.passivChb.Size = new System.Drawing.Size(57, 17);
            this.passivChb.TabIndex = 6;
            this.passivChb.Text = "Passiv";
            this.passivChb.UseVisualStyleBackColor = true;
            // 
            // Overskrift
            // 
            this.Overskrift.AutoSize = true;
            this.Overskrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overskrift.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Overskrift.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Overskrift.Location = new System.Drawing.Point(92, 9);
            this.Overskrift.Name = "Overskrift";
            this.Overskrift.Size = new System.Drawing.Size(177, 25);
            this.Overskrift.TabIndex = 9;
            this.Overskrift.Text = "Klient - søgning";
            // 
            // sagstypeGb
            // 
            this.sagstypeGb.Controls.Add(this.erviceChb);
            this.sagstypeGb.Controls.Add(this.klientBetalingChb);
            this.sagstypeGb.Location = new System.Drawing.Point(489, 199);
            this.sagstypeGb.Name = "sagstypeGb";
            this.sagstypeGb.Size = new System.Drawing.Size(200, 100);
            this.sagstypeGb.TabIndex = 10;
            this.sagstypeGb.TabStop = false;
            this.sagstypeGb.Text = "Sagstype";
            // 
            // erviceChb
            // 
            this.erviceChb.AutoSize = true;
            this.erviceChb.Location = new System.Drawing.Point(6, 61);
            this.erviceChb.Name = "erviceChb";
            this.erviceChb.Size = new System.Drawing.Size(81, 17);
            this.erviceChb.TabIndex = 1;
            this.erviceChb.Text = "Madservice";
            this.erviceChb.UseVisualStyleBackColor = true;
            // 
            // klientBetalingChb
            // 
            this.klientBetalingChb.AutoSize = true;
            this.klientBetalingChb.Location = new System.Drawing.Point(6, 32);
            this.klientBetalingChb.Name = "klientBetalingChb";
            this.klientBetalingChb.Size = new System.Drawing.Size(89, 17);
            this.klientBetalingChb.TabIndex = 0;
            this.klientBetalingChb.Text = "Klientbetaling";
            this.klientBetalingChb.UseVisualStyleBackColor = true;
            // 
            // startDatoGb
            // 
            this.startDatoGb.Controls.Add(this.startDatoTilDtp);
            this.startDatoGb.Controls.Add(this.tilDatoStartLb);
            this.startDatoGb.Controls.Add(this.startDatoFraDtp);
            this.startDatoGb.Controls.Add(this.fraDatoStartLb);
            this.startDatoGb.Location = new System.Drawing.Point(97, 382);
            this.startDatoGb.Name = "startDatoGb";
            this.startDatoGb.Size = new System.Drawing.Size(592, 73);
            this.startDatoGb.TabIndex = 11;
            this.startDatoGb.TabStop = false;
            this.startDatoGb.Text = "Startdato";
            // 
            // startDatoTilDtp
            // 
            this.startDatoTilDtp.Location = new System.Drawing.Point(322, 30);
            this.startDatoTilDtp.Name = "startDatoTilDtp";
            this.startDatoTilDtp.Size = new System.Drawing.Size(200, 20);
            this.startDatoTilDtp.TabIndex = 3;
            // 
            // tilDatoStartLb
            // 
            this.tilDatoStartLb.AutoSize = true;
            this.tilDatoStartLb.Location = new System.Drawing.Point(291, 30);
            this.tilDatoStartLb.Name = "tilDatoStartLb";
            this.tilDatoStartLb.Size = new System.Drawing.Size(14, 13);
            this.tilDatoStartLb.TabIndex = 2;
            this.tilDatoStartLb.Text = "til";
            // 
            // startDatoFraDtp
            // 
            this.startDatoFraDtp.Location = new System.Drawing.Point(43, 30);
            this.startDatoFraDtp.Name = "startDatoFraDtp";
            this.startDatoFraDtp.Size = new System.Drawing.Size(200, 20);
            this.startDatoFraDtp.TabIndex = 1;
            // 
            // fraDatoStartLb
            // 
            this.fraDatoStartLb.AutoSize = true;
            this.fraDatoStartLb.Location = new System.Drawing.Point(12, 30);
            this.fraDatoStartLb.Name = "fraDatoStartLb";
            this.fraDatoStartLb.Size = new System.Drawing.Size(19, 13);
            this.fraDatoStartLb.TabIndex = 0;
            this.fraDatoStartLb.Text = "fra";
            // 
            // slutDatoGb
            // 
            this.slutDatoGb.Controls.Add(this.slutDatoTilDtp);
            this.slutDatoGb.Controls.Add(this.tilDatoSlutLb);
            this.slutDatoGb.Controls.Add(this.slutDatoFraDtp);
            this.slutDatoGb.Controls.Add(this.fraDatoSlutLb);
            this.slutDatoGb.Location = new System.Drawing.Point(97, 474);
            this.slutDatoGb.Name = "slutDatoGb";
            this.slutDatoGb.Size = new System.Drawing.Size(592, 73);
            this.slutDatoGb.TabIndex = 12;
            this.slutDatoGb.TabStop = false;
            this.slutDatoGb.Text = "Slutdato";
            // 
            // slutDatoTilDtp
            // 
            this.slutDatoTilDtp.Location = new System.Drawing.Point(322, 30);
            this.slutDatoTilDtp.Name = "slutDatoTilDtp";
            this.slutDatoTilDtp.Size = new System.Drawing.Size(200, 20);
            this.slutDatoTilDtp.TabIndex = 3;
            // 
            // tilDatoSlutLb
            // 
            this.tilDatoSlutLb.AutoSize = true;
            this.tilDatoSlutLb.Location = new System.Drawing.Point(291, 30);
            this.tilDatoSlutLb.Name = "tilDatoSlutLb";
            this.tilDatoSlutLb.Size = new System.Drawing.Size(14, 13);
            this.tilDatoSlutLb.TabIndex = 2;
            this.tilDatoSlutLb.Text = "til";
            // 
            // slutDatoFraDtp
            // 
            this.slutDatoFraDtp.Location = new System.Drawing.Point(43, 30);
            this.slutDatoFraDtp.Name = "slutDatoFraDtp";
            this.slutDatoFraDtp.Size = new System.Drawing.Size(200, 20);
            this.slutDatoFraDtp.TabIndex = 1;
            // 
            // fraDatoSlutLb
            // 
            this.fraDatoSlutLb.AutoSize = true;
            this.fraDatoSlutLb.Location = new System.Drawing.Point(12, 30);
            this.fraDatoSlutLb.Name = "fraDatoSlutLb";
            this.fraDatoSlutLb.Size = new System.Drawing.Size(19, 13);
            this.fraDatoSlutLb.TabIndex = 0;
            this.fraDatoSlutLb.Text = "fra";
            // 
            // søgBtn
            // 
            this.søgBtn.Location = new System.Drawing.Point(97, 574);
            this.søgBtn.Name = "søgBtn";
            this.søgBtn.Size = new System.Drawing.Size(75, 23);
            this.søgBtn.TabIndex = 13;
            this.søgBtn.Text = "Søg";
            this.søgBtn.UseVisualStyleBackColor = true;
            this.søgBtn.Click += new System.EventHandler(this.søgBtn_Click);
            // 
            // Q331
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 647);
            this.Controls.Add(this.søgBtn);
            this.Controls.Add(this.slutDatoGb);
            this.Controls.Add(this.startDatoGb);
            this.Controls.Add(this.sagstypeGb);
            this.Controls.Add(this.Overskrift);
            this.Controls.Add(this.sagsStatusGb);
            this.Controls.Add(this.klientGb);
            this.Controls.Add(this.enhedGb);
            this.Name = "Q331";
            this.Text = "Q331";
            this.enhedGb.ResumeLayout(false);
            this.enhedGb.PerformLayout();
            this.klientGb.ResumeLayout(false);
            this.klientGb.PerformLayout();
            this.sagsStatusGb.ResumeLayout(false);
            this.sagsStatusGb.PerformLayout();
            this.sagstypeGb.ResumeLayout(false);
            this.sagstypeGb.PerformLayout();
            this.startDatoGb.ResumeLayout(false);
            this.startDatoGb.PerformLayout();
            this.slutDatoGb.ResumeLayout(false);
            this.slutDatoGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox aktivChb;
        private System.Windows.Forms.GroupBox enhedGb;
        private System.Windows.Forms.ComboBox gruppeEnhedCb;
        private System.Windows.Forms.ComboBox admEnhedCb;
        private System.Windows.Forms.Label gruppeEnhedLb;
        private System.Windows.Forms.Label admEnhedLb;
        private System.Windows.Forms.GroupBox klientGb;
        private System.Windows.Forms.GroupBox sagsStatusGb;
        private System.Windows.Forms.Label Overskrift;
        private System.Windows.Forms.CheckBox passivChb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label sagsbehandlerLb;
        private System.Windows.Forms.Label klientKategoriLb;
        private System.Windows.Forms.TextBox intervalKlient;
        private System.Windows.Forms.TextBox førsteKlientTb;
        private System.Windows.Forms.Label intervalKlientLb;
        private System.Windows.Forms.Label førsteKlientLb;
        private System.Windows.Forms.GroupBox sagstypeGb;
        private System.Windows.Forms.CheckBox erviceChb;
        private System.Windows.Forms.CheckBox klientBetalingChb;
        private System.Windows.Forms.GroupBox startDatoGb;
        private System.Windows.Forms.DateTimePicker startDatoTilDtp;
        private System.Windows.Forms.Label tilDatoStartLb;
        private System.Windows.Forms.DateTimePicker startDatoFraDtp;
        private System.Windows.Forms.Label fraDatoStartLb;
        private System.Windows.Forms.GroupBox slutDatoGb;
        private System.Windows.Forms.DateTimePicker slutDatoTilDtp;
        private System.Windows.Forms.Label tilDatoSlutLb;
        private System.Windows.Forms.DateTimePicker slutDatoFraDtp;
        private System.Windows.Forms.Label fraDatoSlutLb;
        private System.Windows.Forms.Button søgBtn;
    }
}

