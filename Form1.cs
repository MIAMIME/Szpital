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
            string has�o = Has�ookno.Text;
            if (has�o == login && login == "admin")
            {
                this.Hide();
                this.Close();
                Program.administrator();
            }
            else if (Program.logowanie(has�o, login))
            {
                if (Program.pozycja(has�o, login))
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

                DialogResult res = MessageBox.Show("Podane has�o lub/i login nie pasuj� do �adnego z u�ytkownik�w.", "Z�y login lub has�o");
                Program.wyj��ie();
            }
        }
    }
}