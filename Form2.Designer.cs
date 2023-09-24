namespace Projekt
{
    partial class Form2
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
            this.Wsteczadm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pslnum = new System.Windows.Forms.MaskedTextBox();
            this.WPZ = new System.Windows.Forms.MaskedTextBox();
            this.combospecjalizacja = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.Hasloset = new System.Windows.Forms.TextBox();
            this.loginset = new System.Windows.Forms.TextBox();
            this.pozycjawp = new System.Windows.Forms.ComboBox();
            this.nrPWZ = new System.Windows.Forms.Label();
            this.nrpesel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.przegląd = new System.Windows.Forms.GroupBox();
            this.labelspec = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPWZ = new System.Windows.Forms.Label();
            this.labelpes = new System.Windows.Forms.Label();
            this.labelstan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.przegląd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Wsteczadm
            // 
            this.Wsteczadm.Location = new System.Drawing.Point(12, 415);
            this.Wsteczadm.Name = "Wsteczadm";
            this.Wsteczadm.Size = new System.Drawing.Size(75, 23);
            this.Wsteczadm.TabIndex = 0;
            this.Wsteczadm.Text = "Wyloguj";
            this.Wsteczadm.UseVisualStyleBackColor = true;
            this.Wsteczadm.Click += new System.EventHandler(this.Wsteczadm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj użytkownika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pslnum);
            this.groupBox1.Controls.Add(this.WPZ);
            this.groupBox1.Controls.Add(this.combospecjalizacja);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NAME);
            this.groupBox1.Controls.Add(this.Hasloset);
            this.groupBox1.Controls.Add(this.loginset);
            this.groupBox1.Controls.Add(this.pozycjawp);
            this.groupBox1.Controls.Add(this.nrPWZ);
            this.groupBox1.Controls.Add(this.nrpesel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 380);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj użytkownika";
            this.groupBox1.Enter += new System.EventHandler(this.pozycja);
            // 
            // pslnum
            // 
            this.pslnum.Location = new System.Drawing.Point(79, 155);
            this.pslnum.Name = "pslnum";
            this.pslnum.Size = new System.Drawing.Size(100, 23);
            this.pslnum.TabIndex = 20;
            // 
            // WPZ
            // 
            this.WPZ.Location = new System.Drawing.Point(79, 184);
            this.WPZ.Name = "WPZ";
            this.WPZ.Size = new System.Drawing.Size(100, 23);
            this.WPZ.TabIndex = 19;
            // 
            // combospecjalizacja
            // 
            this.combospecjalizacja.FormattingEnabled = true;
            this.combospecjalizacja.Items.AddRange(new object[] {
            "Kardiolog",
            "Urolog",
            "Neurolog",
            "Laryngolog"});
            this.combospecjalizacja.Location = new System.Drawing.Point(79, 213);
            this.combospecjalizacja.Name = "combospecjalizacja";
            this.combospecjalizacja.Size = new System.Drawing.Size(100, 23);
            this.combospecjalizacja.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Specjalizacja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stanowisko";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(79, 97);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(100, 23);
            this.NAME.TabIndex = 11;
            // 
            // Hasloset
            // 
            this.Hasloset.Location = new System.Drawing.Point(79, 68);
            this.Hasloset.Name = "Hasloset";
            this.Hasloset.Size = new System.Drawing.Size(100, 23);
            this.Hasloset.TabIndex = 10;
            // 
            // loginset
            // 
            this.loginset.Location = new System.Drawing.Point(79, 39);
            this.loginset.Name = "loginset";
            this.loginset.Size = new System.Drawing.Size(100, 23);
            this.loginset.TabIndex = 9;
            // 
            // pozycjawp
            // 
            this.pozycjawp.FormattingEnabled = true;
            this.pozycjawp.Items.AddRange(new object[] {
            "Lekarz",
            "Pielęgniarka",
            "Administrator"});
            this.pozycjawp.Location = new System.Drawing.Point(79, 126);
            this.pozycjawp.Name = "pozycjawp";
            this.pozycjawp.Size = new System.Drawing.Size(100, 23);
            this.pozycjawp.TabIndex = 8;
            this.pozycjawp.SelectedIndexChanged += new System.EventHandler(this.pozycjawp_SelectedIndexChanged);
            // 
            // nrPWZ
            // 
            this.nrPWZ.AutoSize = true;
            this.nrPWZ.Location = new System.Drawing.Point(6, 187);
            this.nrPWZ.Name = "nrPWZ";
            this.nrPWZ.Size = new System.Drawing.Size(72, 15);
            this.nrPWZ.TabIndex = 7;
            this.nrPWZ.Text = "Numer PWZ";
            this.nrPWZ.Click += new System.EventHandler(this.label5_Click);
            // 
            // nrpesel
            // 
            this.nrpesel.AutoSize = true;
            this.nrpesel.Location = new System.Drawing.Point(6, 158);
            this.nrpesel.Name = "nrpesel";
            this.nrpesel.Size = new System.Drawing.Size(50, 15);
            this.nrpesel.TabIndex = 6;
            this.nrpesel.Text = "Nr pesel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // przegląd
            // 
            this.przegląd.Controls.Add(this.label11);
            this.przegląd.Controls.Add(this.labelspec);
            this.przegląd.Controls.Add(this.label10);
            this.przegląd.Controls.Add(this.labelPWZ);
            this.przegląd.Controls.Add(this.labelpes);
            this.przegląd.Controls.Add(this.labelstan);
            this.przegląd.Controls.Add(this.label9);
            this.przegląd.Controls.Add(this.label8);
            this.przegląd.Controls.Add(this.label7);
            this.przegląd.Controls.Add(this.label5);
            this.przegląd.Controls.Add(this.comboBox3);
            this.przegląd.Location = new System.Drawing.Point(226, 12);
            this.przegląd.Name = "przegląd";
            this.przegląd.Size = new System.Drawing.Size(562, 380);
            this.przegląd.TabIndex = 4;
            this.przegląd.TabStop = false;
            this.przegląd.Text = "Przegląd";
            this.przegląd.Enter += new System.EventHandler(this.przegląd_Enter);
            // 
            // labelspec
            // 
            this.labelspec.AutoSize = true;
            this.labelspec.Location = new System.Drawing.Point(375, 27);
            this.labelspec.Name = "labelspec";
            this.labelspec.Size = new System.Drawing.Size(73, 15);
            this.labelspec.TabIndex = 24;
            this.labelspec.Text = "Specjalizacja";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Specjalizacja";
            // 
            // labelPWZ
            // 
            this.labelPWZ.AutoSize = true;
            this.labelPWZ.Location = new System.Drawing.Point(375, 58);
            this.labelPWZ.Name = "labelPWZ";
            this.labelPWZ.Size = new System.Drawing.Size(67, 15);
            this.labelPWZ.TabIndex = 21;
            this.labelPWZ.Text = "Stanowisko";
            // 
            // labelpes
            // 
            this.labelpes.AutoSize = true;
            this.labelpes.Location = new System.Drawing.Point(375, 97);
            this.labelpes.Name = "labelpes";
            this.labelpes.Size = new System.Drawing.Size(0, 15);
            this.labelpes.TabIndex = 20;
            // 
            // labelstan
            // 
            this.labelstan.AutoSize = true;
            this.labelstan.Location = new System.Drawing.Point(375, 134);
            this.labelstan.Name = "labelstan";
            this.labelstan.Size = new System.Drawing.Size(0, 15);
            this.labelstan.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Numer PWZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nr pesel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stanowisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Użytkownik";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Username", true));
            this.comboBox3.DisplayMember = "Username";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(80, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 23);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.ValueMember = "Username";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataSource = typeof(Projekt.Pracownik);
            // 
            // pracownikBindingSource1
            // 
            this.pracownikBindingSource1.DataSource = typeof(Projekt.Pracownik);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Dodaj dyżur\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(444, 413);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 23);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 14, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.przegląd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Wsteczadm);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.przegląd.ResumeLayout(false);
            this.przegląd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Wsteczadm;
        private Button button2;
        private GroupBox groupBox1;
        private Label nrPWZ;
        private Label nrpesel;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox pozycjawp;
        private Label label4;
        private TextBox NAME;
        private TextBox Hasloset;
        private TextBox loginset;
        private GroupBox przegląd;
        private Label label5;
        private ComboBox comboBox3;
        private Label labelPWZ;
        private Label labelpes;
        private Label labelstan;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox combospecjalizacja;
        private Label label6;
        private Label labelspec;
        private Label label10;
        private BindingSource pracownikBindingSource;
        private BindingSource pracownikBindingSource1;
        public MaskedTextBox pslnum;
        private MaskedTextBox WPZ;
        private Label label11;
    }
}