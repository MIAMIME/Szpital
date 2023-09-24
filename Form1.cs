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
            string has³o = Has³ookno.Text;
            if (has³o == login && login == "admin")
            {
                this.Hide();
                this.Close();
                Program.administrator();
            }
            else if (Program.logowanie(has³o, login))
            {
                if (Program.pozycja(has³o, login))
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

                DialogResult res = MessageBox.Show("Podane has³o lub/i login nie pasuj¹ do ¿adnego z u¿ytkowników.", "Z³y login lub has³o");
                Program.wyjœæie();
            }
        }
    }
}