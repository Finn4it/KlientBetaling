namespace Q331ny
{
    partial class KlientOversigt
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Klient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SgasType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SagsBehandler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 315);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(576, 208);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Klient,
            this.Type,
            this.Telefon,
            this.Start,
            this.Slut,
            this.SgasType,
            this.SagsBehandler,
            this.feltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // colBindingSource
            // 
            this.colBindingSource.DataMember = "Col";
            this.colBindingSource.DataSource = this.sqlResultBindingSource;
            // 
            // sqlResultBindingSource
            // 
            this.sqlResultBindingSource.DataSource = typeof(Q331ny.Søg.SqlResult);
            // 
            // Klient
            // 
            this.Klient.DataPropertyName = "Klient";
            this.Klient.HeaderText = "Klient";
            this.Klient.Name = "Klient";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Start
            // 
            this.Start.DataPropertyName = "Start";
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            // 
            // Slut
            // 
            this.Slut.DataPropertyName = "Slut";
            this.Slut.HeaderText = "Slut";
            this.Slut.Name = "Slut";
            // 
            // SgasType
            // 
            this.SgasType.DataPropertyName = "SagsType";
            this.SgasType.HeaderText = "SagsType";
            this.SgasType.Name = "SgasType";
            // 
            // SagsBehandler
            // 
            this.SagsBehandler.DataPropertyName = "SagsBehandler";
            this.SagsBehandler.HeaderText = "SagsBehandler";
            this.SagsBehandler.Name = "SagsBehandler";
            // 
            // feltDataGridViewTextBoxColumn
            // 
            this.feltDataGridViewTextBoxColumn.DataPropertyName = "Felt";
            this.feltDataGridViewTextBoxColumn.HeaderText = "Felt";
            this.feltDataGridViewTextBoxColumn.Name = "feltDataGridViewTextBoxColumn";
            // 
            // KlientOversigt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 622);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "KlientOversigt";
            this.Text = "KlientOversigt";
            this.Load += new System.EventHandler(this.KlientOversigt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource sqlResultBindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource colBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slut;
        private System.Windows.Forms.DataGridViewTextBoxColumn SgasType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SagsBehandler;
        private System.Windows.Forms.DataGridViewTextBoxColumn feltDataGridViewTextBoxColumn;
    }
}