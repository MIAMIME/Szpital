namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string login = Loginbox.Text;
            string has這 = Has這okno.Text;
            if (has這 == login && login == "admin")
            {
                this.Hide();
                this.Close();
                Program.administrator();
            }
            else if (Program.logowanie(has這, login))
            {
                if (Program.pozycja(has這, login))
                {
                    this.Hide();
                    this.Close();
                    Program.administrator();
                }
                else
                {

                    this.Hide();
                    this.Close();
                    Program.uzytkownik();
                }
            }
            else
            {

                DialogResult res = MessageBox.Show("Podane has這 lub/i login nie pasuj� do 瘸dnego z u篡tkownik闚.", "Z造 login lub has這");
                Program.wyj�熵e();
            }
        }
    }
}