namespace BibliotekaNET
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ksiazkaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataSet = new BibliotekaNET.BibliotekaDataSet();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.wypozyczenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czytelnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAktualizuj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.tbAUOpis = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbAUTytul = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbAUImie = new System.Windows.Forms.TextBox();
            this.tbAUNazwisko = new System.Windows.Forms.TextBox();
            this.tbAUISBN = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tbAutorNazwisko = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbAutorImie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tytulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiazkaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.imieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbClear = new System.Windows.Forms.Button();
            this.btKSUsun = new System.Windows.Forms.Button();
            this.ksAktualizuj = new System.Windows.Forms.Button();
            this.ksDodaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbKSOpis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbKSTytul = new System.Windows.Forms.TextBox();
            this.tbKSISBN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKSAutorImie = new System.Windows.Forms.TextBox();
            this.tbKSAutorNazwisko = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.kategoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autorTableAdapter = new BibliotekaNET.BibliotekaDataSetTableAdapters.AutorTableAdapter();
            this.kategoriaTableAdapter = new BibliotekaNET.BibliotekaDataSetTableAdapters.KategoriaTableAdapter();
            this.ksiazkaTableAdapter = new BibliotekaNET.BibliotekaDataSetTableAdapters.KsiazkaTableAdapter();
            this.wypozyczenieTableAdapter = new BibliotekaNET.BibliotekaDataSetTableAdapters.WypozyczenieTableAdapter();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.lbImie = new System.Windows.Forms.Label();
            this.lbNazwisko = new System.Windows.Forms.Label();
            this.lbKsiazka = new System.Windows.Forms.Label();
            this.imieDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliotekaDataSet1 = new BibliotekaNET.BibliotekaDataSet();
            this.czytelnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.czytelnikTableAdapter = new BibliotekaNET.BibliotekaDataSetTableAdapters.CzytelnikTableAdapter();
            this.bibliotekaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSBNDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiazkaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.wydanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zwrotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czytelnikBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czytelnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource3)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dtpDo);
            this.tabPage1.Controls.Add(this.dtpOd);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.dataGridView5);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Czytelnicy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.ksiazkaBindingSource2;
            this.listBox1.DisplayMember = "Tytul";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 212);
            this.listBox1.TabIndex = 7;
            this.listBox1.ValueMember = "ID";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ksiazkaBindingSource2
            // 
            this.ksiazkaBindingSource2.DataMember = "Ksiazka";
            this.ksiazkaBindingSource2.DataSource = this.bibliotekaDataSet;
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wydanoDataGridViewTextBoxColumn,
            this.zwrotDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView5.DataSource = this.wypozyczenieBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(306, 255);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(282, 212);
            this.dataGridView5.TabIndex = 4;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            this.dataGridView5.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellValueChanged);
            // 
            // wypozyczenieBindingSource
            // 
            this.wypozyczenieBindingSource.DataMember = "Wypozyczenie";
            this.wypozyczenieBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.czytelnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(306, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(573, 177);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // czytelnikBindingSource
            // 
            this.czytelnikBindingSource.DataMember = "Czytelnik";
            this.czytelnikBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAktualizuj);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btDodaj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTelefon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbPesel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNazwisko);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbImie);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 177);
            this.panel1.TabIndex = 2;
            // 
            // btAktualizuj
            // 
            this.btAktualizuj.Location = new System.Drawing.Point(216, 141);
            this.btAktualizuj.Name = "btAktualizuj";
            this.btAktualizuj.Size = new System.Drawing.Size(75, 23);
            this.btAktualizuj.TabIndex = 2;
            this.btAktualizuj.Text = "Aktualizuj";
            this.btAktualizuj.UseVisualStyleBackColor = true;
            this.btAktualizuj.Click += new System.EventHandler(this.btAktualizuj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(96, 141);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 23);
            this.btDodaj.TabIndex = 2;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(96, 114);
            this.tbTelefon.MaxLength = 12;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(195, 20);
            this.tbTelefon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(96, 88);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "PESEL:";
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(96, 62);
            this.tbPesel.MaxLength = 11;
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(195, 20);
            this.tbPesel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon:";
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(96, 36);
            this.tbNazwisko.MaxLength = 100;
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(195, 20);
            this.tbNazwisko.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(38, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(96, 10);
            this.tbImie.MaxLength = 50;
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(195, 20);
            this.tbImie.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autorzy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(344, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 185);
            this.panel3.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.tbAUOpis);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.tbAUTytul);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.tbAUISBN);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 176);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Książka";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Usuń";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kategoriaBindingSource;
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(327, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "ID";
            // 
            // kategoriaBindingSource
            // 
            this.kategoriaBindingSource.DataMember = "Kategoria";
            this.kategoriaBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(96, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Aktualizuj";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbAUOpis
            // 
            this.tbAUOpis.Location = new System.Drawing.Point(304, 92);
            this.tbAUOpis.Multiline = true;
            this.tbAUOpis.Name = "tbAUOpis";
            this.tbAUOpis.Size = new System.Drawing.Size(221, 74);
            this.tbAUOpis.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(250, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Gatunek:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(177, 128);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Dodaj";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(278, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tytuł:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(253, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Opis:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(274, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "ISBN:";
            // 
            // tbAUTytul
            // 
            this.tbAUTytul.Location = new System.Drawing.Point(327, 16);
            this.tbAUTytul.MaxLength = 50;
            this.tbAUTytul.Name = "tbAUTytul";
            this.tbAUTytul.Size = new System.Drawing.Size(198, 20);
            this.tbAUTytul.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.tbAUImie);
            this.groupBox5.Controls.Add(this.tbAUNazwisko);
            this.groupBox5.Location = new System.Drawing.Point(7, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 73);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Autor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(40, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Imie:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(7, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Nazwisko:";
            // 
            // tbAUImie
            // 
            this.tbAUImie.Location = new System.Drawing.Point(89, 16);
            this.tbAUImie.MaxLength = 50;
            this.tbAUImie.Name = "tbAUImie";
            this.tbAUImie.Size = new System.Drawing.Size(141, 20);
            this.tbAUImie.TabIndex = 3;
            // 
            // tbAUNazwisko
            // 
            this.tbAUNazwisko.Location = new System.Drawing.Point(89, 42);
            this.tbAUNazwisko.MaxLength = 50;
            this.tbAUNazwisko.Name = "tbAUNazwisko";
            this.tbAUNazwisko.Size = new System.Drawing.Size(141, 20);
            this.tbAUNazwisko.TabIndex = 3;
            // 
            // tbAUISBN
            // 
            this.tbAUISBN.Location = new System.Drawing.Point(327, 68);
            this.tbAUISBN.MaxLength = 50;
            this.tbAUISBN.Name = "tbAUISBN";
            this.tbAUISBN.Size = new System.Drawing.Size(198, 20);
            this.tbAUISBN.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.tbAutorNazwisko);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.tbAutorImie);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(6, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 166);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Autor";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(37, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Imie:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(116, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Usuń";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbAutorNazwisko
            // 
            this.tbAutorNazwisko.Location = new System.Drawing.Point(86, 42);
            this.tbAutorNazwisko.MaxLength = 50;
            this.tbAutorNazwisko.Name = "tbAutorNazwisko";
            this.tbAutorNazwisko.Size = new System.Drawing.Size(194, 20);
            this.tbAutorNazwisko.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Aktualizuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbAutorImie
            // 
            this.tbAutorImie.Location = new System.Drawing.Point(86, 16);
            this.tbAutorImie.MaxLength = 50;
            this.tbAutorImie.Name = "tbAutorImie";
            this.tbAutorImie.Size = new System.Drawing.Size(194, 20);
            this.tbAutorImie.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(4, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Nazwisko:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulDataGridViewTextBoxColumn1,
            this.iSBNDataGridViewTextBoxColumn1,
            this.opisDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.ksiazkaBindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(344, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(535, 215);
            this.dataGridView4.TabIndex = 2;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // tytulDataGridViewTextBoxColumn1
            // 
            this.tytulDataGridViewTextBoxColumn1.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn1.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn1.Name = "tytulDataGridViewTextBoxColumn1";
            // 
            // iSBNDataGridViewTextBoxColumn1
            // 
            this.iSBNDataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.Name = "iSBNDataGridViewTextBoxColumn1";
            // 
            // opisDataGridViewTextBoxColumn1
            // 
            this.opisDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn1.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn1.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn1.Name = "opisDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // ksiazkaBindingSource1
            // 
            this.ksiazkaBindingSource1.DataMember = "Ksiazka";
            this.ksiazkaBindingSource1.DataSource = this.bibliotekaDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn1,
            this.nazwiskoDataGridViewTextBoxColumn1,
            this.ID});
            this.dataGridView2.DataSource = this.autorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(338, 215);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // imieDataGridViewTextBoxColumn1
            // 
            this.imieDataGridViewTextBoxColumn1.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn1.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn1.Name = "imieDataGridViewTextBoxColumn1";
            this.imieDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn1
            // 
            this.nazwiskoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwiskoDataGridViewTextBoxColumn1.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn1.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn1.Name = "nazwiskoDataGridViewTextBoxColumn1";
            this.nazwiskoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            this.autorBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(885, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Książki";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbClear);
            this.panel2.Controls.Add(this.btKSUsun);
            this.panel2.Controls.Add(this.ksAktualizuj);
            this.panel2.Controls.Add(this.ksDodaj);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(6, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 185);
            this.panel2.TabIndex = 4;
            // 
            // tbClear
            // 
            this.tbClear.Location = new System.Drawing.Point(540, 146);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(75, 23);
            this.tbClear.TabIndex = 9;
            this.tbClear.Text = "Wyczyść";
            this.tbClear.UseVisualStyleBackColor = true;
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // btKSUsun
            // 
            this.btKSUsun.Location = new System.Drawing.Point(79, 149);
            this.btKSUsun.Name = "btKSUsun";
            this.btKSUsun.Size = new System.Drawing.Size(75, 23);
            this.btKSUsun.TabIndex = 8;
            this.btKSUsun.Text = "Usuń";
            this.btKSUsun.UseVisualStyleBackColor = true;
            this.btKSUsun.Click += new System.EventHandler(this.btKSUsun_Click);
            // 
            // ksAktualizuj
            // 
            this.ksAktualizuj.Location = new System.Drawing.Point(79, 119);
            this.ksAktualizuj.Name = "ksAktualizuj";
            this.ksAktualizuj.Size = new System.Drawing.Size(75, 23);
            this.ksAktualizuj.TabIndex = 7;
            this.ksAktualizuj.Text = "Aktualizuj";
            this.ksAktualizuj.UseVisualStyleBackColor = true;
            this.ksAktualizuj.Click += new System.EventHandler(this.ksAktualizuj_Click);
            // 
            // ksDodaj
            // 
            this.ksDodaj.Location = new System.Drawing.Point(79, 90);
            this.ksDodaj.Name = "ksDodaj";
            this.ksDodaj.Size = new System.Drawing.Size(75, 23);
            this.ksDodaj.TabIndex = 7;
            this.ksDodaj.Text = "Dodaj";
            this.ksDodaj.UseVisualStyleBackColor = true;
            this.ksDodaj.Click += new System.EventHandler(this.ksDodaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.tbKSOpis);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbKSTytul);
            this.groupBox2.Controls.Add(this.tbKSISBN);
            this.groupBox2.Location = new System.Drawing.Point(249, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 176);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Książka";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.kategoriaBindingSource;
            this.comboBox2.DisplayMember = "Nazwa";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(81, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "ID";
            // 
            // tbKSOpis
            // 
            this.tbKSOpis.Location = new System.Drawing.Point(58, 92);
            this.tbKSOpis.Multiline = true;
            this.tbKSOpis.Name = "tbKSOpis";
            this.tbKSOpis.Size = new System.Drawing.Size(221, 74);
            this.tbKSOpis.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(4, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Gatunek:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(32, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tytuł:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(7, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Opis:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(28, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "ISBN:";
            // 
            // tbKSTytul
            // 
            this.tbKSTytul.Location = new System.Drawing.Point(81, 16);
            this.tbKSTytul.MaxLength = 50;
            this.tbKSTytul.Name = "tbKSTytul";
            this.tbKSTytul.Size = new System.Drawing.Size(198, 20);
            this.tbKSTytul.TabIndex = 3;
            // 
            // tbKSISBN
            // 
            this.tbKSISBN.Location = new System.Drawing.Point(81, 68);
            this.tbKSISBN.MaxLength = 50;
            this.tbKSISBN.Name = "tbKSISBN";
            this.tbKSISBN.Size = new System.Drawing.Size(198, 20);
            this.tbKSISBN.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbKSAutorImie);
            this.groupBox1.Controls.Add(this.tbKSAutorNazwisko);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(40, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Imie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(7, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nazwisko:";
            // 
            // tbKSAutorImie
            // 
            this.tbKSAutorImie.Location = new System.Drawing.Point(89, 16);
            this.tbKSAutorImie.MaxLength = 50;
            this.tbKSAutorImie.Name = "tbKSAutorImie";
            this.tbKSAutorImie.Size = new System.Drawing.Size(141, 20);
            this.tbKSAutorImie.TabIndex = 3;
            // 
            // tbKSAutorNazwisko
            // 
            this.tbKSAutorNazwisko.Location = new System.Drawing.Point(89, 42);
            this.tbKSAutorNazwisko.MaxLength = 50;
            this.tbKSAutorNazwisko.Name = "tbKSAutorNazwisko";
            this.tbKSAutorNazwisko.Size = new System.Drawing.Size(141, 20);
            this.tbKSAutorNazwisko.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ksiazkaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(873, 275);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            this.tytulDataGridViewTextBoxColumn.ReadOnly = true;
            this.tytulDataGridViewTextBoxColumn.Width = 150;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataMember = "Ksiazka";
            this.ksiazkaBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.dataGridView7);
            this.tabPage4.Controls.Add(this.dataGridView6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(885, 478);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Wypożyczanie";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // kategoriaBindingSource1
            // 
            this.kategoriaBindingSource1.DataMember = "Kategoria";
            this.kategoriaBindingSource1.DataSource = this.bibliotekaDataSet;
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // kategoriaTableAdapter
            // 
            this.kategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // ksiazkaTableAdapter
            // 
            this.ksiazkaTableAdapter.ClearBeforeFill = true;
            // 
            // wypozyczenieTableAdapter
            // 
            this.wypozyczenieTableAdapter.ClearBeforeFill = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(6, 232);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Wypożyczone książki:";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn2,
            this.nazwiskoDataGridViewTextBoxColumn2,
            this.pESELDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView6.DataSource = this.czytelnikBindingSource1;
            this.dataGridView6.Location = new System.Drawing.Point(43, 61);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(362, 140);
            this.dataGridView6.TabIndex = 0;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulDataGridViewTextBoxColumn2,
            this.iSBNDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView7.DataSource = this.ksiazkaBindingSource3;
            this.dataGridView7.Location = new System.Drawing.Point(43, 259);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.Size = new System.Drawing.Size(362, 156);
            this.dataGridView7.TabIndex = 1;
            this.dataGridView7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView7_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Wypożycz";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbImie
            // 
            this.lbImie.AutoSize = true;
            this.lbImie.Location = new System.Drawing.Point(56, 16);
            this.lbImie.Name = "lbImie";
            this.lbImie.Size = new System.Drawing.Size(0, 13);
            this.lbImie.TabIndex = 5;
            // 
            // lbNazwisko
            // 
            this.lbNazwisko.AutoSize = true;
            this.lbNazwisko.Location = new System.Drawing.Point(56, 34);
            this.lbNazwisko.Name = "lbNazwisko";
            this.lbNazwisko.Size = new System.Drawing.Size(0, 13);
            this.lbNazwisko.TabIndex = 6;
            // 
            // lbKsiazka
            // 
            this.lbKsiazka.AutoSize = true;
            this.lbKsiazka.Location = new System.Drawing.Point(56, 52);
            this.lbKsiazka.Name = "lbKsiazka";
            this.lbKsiazka.Size = new System.Drawing.Size(0, 13);
            this.lbKsiazka.TabIndex = 6;
            // 
            // imieDataGridViewTextBoxColumn2
            // 
            this.imieDataGridViewTextBoxColumn2.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn2.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn2.Name = "imieDataGridViewTextBoxColumn2";
            this.imieDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn2
            // 
            this.nazwiskoDataGridViewTextBoxColumn2.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn2.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn2.Name = "nazwiskoDataGridViewTextBoxColumn2";
            this.nazwiskoDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn1
            // 
            this.pESELDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pESELDataGridViewTextBoxColumn1.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn1.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn1.Name = "pESELDataGridViewTextBoxColumn1";
            this.pESELDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bibliotekaDataSet1
            // 
            this.bibliotekaDataSet1.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // czytelnikBindingSource1
            // 
            this.czytelnikBindingSource1.DataMember = "Czytelnik";
            this.czytelnikBindingSource1.DataSource = this.bibliotekaDataSet1;
            // 
            // czytelnikTableAdapter
            // 
            this.czytelnikTableAdapter.ClearBeforeFill = true;
            // 
            // bibliotekaDataSet1BindingSource
            // 
            this.bibliotekaDataSet1BindingSource.DataSource = this.bibliotekaDataSet1;
            this.bibliotekaDataSet1BindingSource.Position = 0;
            // 
            // iSBNDataGridViewTextBoxColumn2
            // 
            this.iSBNDataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn2.Name = "iSBNDataGridViewTextBoxColumn2";
            this.iSBNDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tytulDataGridViewTextBoxColumn2
            // 
            this.tytulDataGridViewTextBoxColumn2.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn2.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn2.Name = "tytulDataGridViewTextBoxColumn2";
            this.tytulDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ksiazkaBindingSource3
            // 
            this.ksiazkaBindingSource3.DataMember = "Ksiazka";
            this.ksiazkaBindingSource3.DataSource = this.bibliotekaDataSet1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Imie";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Nazwisko";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Książka";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(715, 347);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Modyfikuj";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // wydanoDataGridViewTextBoxColumn
            // 
            this.wydanoDataGridViewTextBoxColumn.DataPropertyName = "Wydano";
            this.wydanoDataGridViewTextBoxColumn.HeaderText = "Wydano";
            this.wydanoDataGridViewTextBoxColumn.Name = "wydanoDataGridViewTextBoxColumn";
            // 
            // zwrotDataGridViewTextBoxColumn
            // 
            this.zwrotDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zwrotDataGridViewTextBoxColumn.DataPropertyName = "Zwrot";
            this.zwrotDataGridViewTextBoxColumn.HeaderText = "Zwrot";
            this.zwrotDataGridViewTextBoxColumn.Name = "zwrotDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.lbImie);
            this.groupBox6.Controls.Add(this.lbKsiazka);
            this.groupBox6.Controls.Add(this.lbNazwisko);
            this.groupBox6.Location = new System.Drawing.Point(502, 159);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(287, 101);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Wypożyczenie";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(594, 289);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "Wypożyczono:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(622, 309);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "Zwrócono:";
            // 
            // dtpOd
            // 
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOd.Location = new System.Drawing.Point(711, 289);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(104, 20);
            this.dtpOd.TabIndex = 10;
            // 
            // dtpDo
            // 
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDo.Location = new System.Drawing.Point(711, 308);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(104, 20);
            this.dtpDo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 528);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czytelnikBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czytelnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAktualizuj;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TabPage tabPage2;
        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource czytelnikBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private BibliotekaDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource kategoriaBindingSource;
        private BibliotekaDataSetTableAdapters.KategoriaTableAdapter kategoriaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
        private BibliotekaDataSetTableAdapters.KsiazkaTableAdapter ksiazkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKSAutorImie;
        private System.Windows.Forms.TextBox tbKSAutorNazwisko;
        private System.Windows.Forms.Button ksAktualizuj;
        private System.Windows.Forms.Button ksDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbKSOpis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbKSTytul;
        private System.Windows.Forms.TextBox tbKSISBN;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btKSUsun;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAutorImie;
        private System.Windows.Forms.TextBox tbAutorNazwisko;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.BindingSource kategoriaBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbAUOpis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbAUTytul;
        private System.Windows.Forms.TextBox tbAUISBN;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbAUImie;
        private System.Windows.Forms.TextBox tbAUNazwisko;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource wypozyczenieBindingSource;
        private BibliotekaDataSetTableAdapters.WypozyczenieTableAdapter wypozyczenieTableAdapter;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Label lbKsiazka;
        private System.Windows.Forms.Label lbNazwisko;
        private System.Windows.Forms.Label lbImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BibliotekaDataSet bibliotekaDataSet1;
        private System.Windows.Forms.BindingSource czytelnikBindingSource1;
        private BibliotekaDataSetTableAdapters.CzytelnikTableAdapter czytelnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bibliotekaDataSet1BindingSource;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zwrotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
    }
}

