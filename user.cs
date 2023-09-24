using System.Xml.Serialization;

namespace Projekt
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent(); this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

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
        private void user_Load(object sender, EventArgs e)
        {

        }

        private void Wsteczadm_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
