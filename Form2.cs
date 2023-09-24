using System.Xml.Serialization;

namespace Projekt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.WPZ.Mask = "0000000";
            this.pslnum.Mask = "00000000000";
            nrPWZ.Hide();
            label6.Hide();
            WPZ.Hide();
            combospecjalizacja.Hide();
            labelPWZ.Hide();
            label10.Hide();
            label9.Hide();
            labelspec.Hide();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            FileInfo file = new FileInfo("dane.xml");
            if (file.Exists)
            {
                Dictionary<string, string> items = new Dictionary<string, string>();
                foreach (Pracownik wybor in Program.pracownicy)
                {
                    items.Add(wybor.Login, wybor.Username);
                }
                comboBox3.DataSource = new BindingSource(items, null);
                comboBox3.DisplayMember = "Value";
                comboBox3.ValueMember = "Key";
                string terminyString = "";
                string wybrane = comboBox3.SelectedValue.ToString();
                string pozdod = " ";
                List<DateTime> terminy = new List<DateTime>();
                foreach (Pracownik rekord in Program.pracownicy)
                {
                    if (wybrane == rekord.Login)
                    {
                        terminy = rekord.praca;
                        pozdod = rekord.specjalizacja;
                    }
                }
                foreach (DateTime termin in terminy)
                {
                    terminyString += termin.ToString() + "\n";
                }
                label11.Text = terminyString;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Program.wyjśćie();
            }
        }

        private void pozycja(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pozycjawp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (pozycjawp.Text == "Lekarz")
            {
                nrPWZ.Show();
                label6.Show();
                WPZ.Show();
                combospecjalizacja.Show();

            }
            else
            {
                nrPWZ.Hide();
                label6.Hide();
                WPZ.Hide();
                combospecjalizacja.Hide();
            }
        }

        private void Wsteczadm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.pracownicy != null)
            {
                foreach (Pracownik rekord in Program.pracownicy)
                {
                    if (loginset.Text == rekord.Login)
                    {
                        DialogResult res = MessageBox.Show("Podany login już istnieje, nie mogą istnieć dwa konta z tym samym loginem.", "Zły login");
                        return;
                    }
                }
            }
                if (pozycjawp.Text == "Lekarz")
                {
                    Program.pracownicy.Add(new Pracownik { Login = loginset.Text, Password = Hasloset.Text, Username = NAME.Text, pesel = pslnum.Text, Stanowisko = pozycjawp.Text, nr_PWZ = WPZ.Text.ToString(), specjalizacja = combospecjalizacja.Text });
                }
                else if (pozycjawp.Text == "Pielęgniarka" || pozycjawp.Text == "Administrator")
                {
                    Program.pracownicy.Add(new Pracownik { Login = loginset.Text, Password = Hasloset.Text, Username = NAME.Text, pesel = pslnum.Text, Stanowisko = pozycjawp.Text });
                }
                else
                {
                    DialogResult res = MessageBox.Show("Wybierz jedno z trzech dostępnych stanowisk.", "Błędne stanowisko");
                    return;
                }
            
                FileInfo file = new FileInfo("dane.xml");
            if (file.Exists)
            {
                Dictionary<string, string> items = new Dictionary<string, string>();
                foreach (Pracownik wybor in Program.pracownicy)
                {
                    items.Add(wybor.Login, wybor.Username);
                }
                comboBox3.DataSource = new BindingSource(items, null);
                comboBox3.DisplayMember = "Value";
                comboBox3.ValueMember = "Key";
            }
        }

        private void PSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void przegląd_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybrane = comboBox3.SelectedValue.ToString();
            foreach (Pracownik rekord in Program.pracownicy)
            {
                if (wybrane == rekord.Login)
                {
                    if (rekord.Stanowisko == "Lekarz")
                    {

                        labelPWZ.Show();
                        label10.Show();
                        label9.Show();
                        labelspec.Show();
                        labelPWZ.Text = rekord.nr_PWZ.ToString();
                        labelspec.Text = rekord.specjalizacja;
                    }
                    else
                    {
                        labelPWZ.Hide();
                        label10.Hide();
                        label9.Hide();
                        labelspec.Hide();
                    }
                    labelstan.Text = rekord.Stanowisko;
                    labelpes.Text = rekord.pesel.ToString();

                }
            }

            string terminyString = "";
            string pozdod = " ";
            List<DateTime> terminy = new List<DateTime>();
            foreach (Pracownik rekord in Program.pracownicy)
            {
                if (wybrane == rekord.Login)
                {
                    terminy = rekord.praca;
                    pozdod = rekord.specjalizacja;
                }
            }
            foreach (DateTime termin in terminy)
            {
                terminyString += termin.ToString() + "\n";
            }
            label11.Text = terminyString;
        }

        private void pslnum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool wolne = true;
            string wybrane = comboBox3.SelectedValue.ToString();
            string pozdod = " ";
            bool zajęte = false;
            List<DateTime> terminy = new List<DateTime>();
            foreach (Pracownik rekord in Program.pracownicy)
            {
                if (wybrane == rekord.Login)
                {
                    terminy = rekord.praca;
                    pozdod = rekord.specjalizacja;
                }
            }
            foreach (Pracownik rekord2 in Program.pracownicy)
            {
                terminy = rekord2.praca;
                foreach (DateTime data in terminy)
                {
                    if (data == dateTimePicker1.Value)
                    {
                        if (rekord2.specjalizacja == pozdod && wybrane != rekord2.Login)
                        {
                            wolne = false;
                            zajęte = true;
                        }
                    }
                }
            }
            foreach (Pracownik rekord in Program.pracownicy)
            {
                if (wybrane == rekord.Login)
                {
                    terminy = rekord.praca;
                    pozdod = rekord.specjalizacja;
                }
            }
            int mies = dateTimePicker1.Value.Month;
            int i = 0;
            foreach (DateTime data in terminy)
            {
                if (mies == data.Month)
                {
                    i++;
                }
                if (dateTimePicker1.Value == data || i >= 10 || dateTimePicker1.Value.AddDays(1).Day == data.Day || dateTimePicker1.Value.AddDays(-1).Day == data.Day)
                {
                    wolne = false;
                    break;
                }
            }
            if (wolne == true)
            {
                terminy.Add(dateTimePicker1.Value);
                foreach (Pracownik pracownik in Program.pracownicy)
                {
                    if (pracownik.Login == wybrane)
                        pracownik.praca = terminy;
                }
            }
            else
            {
                if (zajęte == true)
                {
                    DialogResult res = MessageBox.Show("Do tego terminu przypisany już jest lekarz z tą specjalizacją.", "Zły Termin");
                }
                else
                {
                    DialogResult res = MessageBox.Show("Nie można dodać tego użytkownika w tym terminie.", "Zły Termin");
                }
            }
            string terminyString = "";
            foreach (DateTime termin in terminy)
            {
                terminyString += termin.ToString() + "\n";
            }
            label11.Text = terminyString;

        }
    }
}
