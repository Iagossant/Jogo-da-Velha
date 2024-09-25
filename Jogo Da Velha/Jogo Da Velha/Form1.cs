namespace Jogo_Da_Velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Box1_Click(object sender, EventArgs e)
        {
            Vs_Jogador form1 = new Vs_Jogador();
            form1.Show();
            this.Hide();
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            Vs_Computador form2 = new Vs_Computador();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
