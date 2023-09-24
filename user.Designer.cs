namespace Projekt
{
    partial class user
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
            this.Wsteczadm = new System.Windows.Forms.Button();
            this.przegląd = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.przegląd.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wsteczadm
            // 
            this.Wsteczadm.Location = new System.Drawing.Point(590, 26);
            this.Wsteczadm.Name = "Wsteczadm";
            this.Wsteczadm.Size = new System.Drawing.Size(90, 36);
            this.Wsteczadm.TabIndex = 6;
            this.Wsteczadm.Text = "Wyloguj";
            this.Wsteczadm.UseVisualStyleBackColor = true;
            this.Wsteczadm.Click += new System.EventHandler(this.Wsteczadm_Click);
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
            this.przegląd.Location = new System.Drawing.Point(12, 12);
            this.przegląd.Name = "przegląd";
            this.przegląd.Size = new System.Drawing.Size(562, 380);
            this.przegląd.TabIndex = 7;
            this.przegląd.TabStop = false;
            this.przegląd.Text = "Przegląd";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 25;
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
            this.comboBox3.DisplayMember = "Username";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(80, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 23);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.ValueMember = "Username";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.przegląd);
            this.Controls.Add(this.Wsteczadm);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.przegląd.ResumeLayout(false);
            this.przegląd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Wsteczadm;
        private GroupBox przegląd;
        private Label label11;
        private Label labelspec;
        private Label label10;
        private Label labelPWZ;
        private Label labelpes;
        private Label labelstan;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private ComboBox comboBox3;
    }
}