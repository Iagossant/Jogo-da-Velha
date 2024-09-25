using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Jogo_Da_Velha
{
    public partial class Vs_Computador : Form
    {
        int sequencia, x, o, empate;
        bool fimdejogo = false, jogou = false;
        string turno = "X";
        Image X = Properties.Resources.xNormal;
        Image O = Properties.Resources.oNormal;

        List<PictureBox> Casa = new List<PictureBox>();
        Random random = new Random();

        public Vs_Computador()
        {
            InitializeComponent();
            Casa.AddRange(new PictureBox[] { c1, c2, c3, c4, c5, c6, c7, c8, c9 });
        }
        private void CasaClick(object sender, EventArgs e)
        {
            if (!fimdejogo)
            {
                PictureBox casa = (PictureBox)sender;
                casa.Image = X;
                casa.Enabled = false;
                sequencia++;
                jogou = false;
                VerificarVitoria();
                TrocarTurno();
                JogarComputador();
            }
        }

        private void TrocarTurno()
        {
            turno = (turno == "X") ? "O" : "X";
        }
        private void JogarComputador()
        {
            if (turno == "O" && !fimdejogo)
            {
                ChecarComputador(c1, c5, c9);
                ChecarComputador(c3, c5, c7);
                ChecarComputador(c1, c2, c3);
                ChecarComputador(c4, c5, c6);
                ChecarComputador(c7, c8, c9);
                ChecarComputador(c1, c4, c7);
                ChecarComputador(c2, c5, c8);
                ChecarComputador(c3, c6, c9);
                JogarAleatorio();
            }
        }
        private void ChecarComputador(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (jogou)
                return;

            if (pb1.Image == null && pb2.Image != null && pb2.Image == pb3.Image)
            {
                jogou = true;
                pb1.Image = O;
                pb1.Enabled = false;
                sequencia++;
                VerificarVitoria();
                TrocarTurno();
            }
            else if (pb2.Image == null && pb1.Image != null && pb1.Image == pb3.Image)
            {
                jogou = true;
                pb2.Image = O;
                pb2.Enabled = false;
                sequencia++;
                VerificarVitoria();
                TrocarTurno();
            }
            else if (pb3.Image == null && pb1.Image != null && pb1.Image == pb2.Image)
            {
                jogou = true;
                pb3.Image = O;
                pb3.Enabled = false;
                sequencia++;
                VerificarVitoria();
                TrocarTurno();
            }
        }
        private void JogarAleatorio()
        {
            if (jogou)
                return;

            int i = random.Next(0, 9);
            while (Casa[i].Image != null)
            {
                i = random.Next(0, 8);
            }
            Casa[i].Image = O;
            Casa[i].Enabled = false;
            sequencia++;
            VerificarVitoria();
            TrocarTurno();
        }
        private void VerificarVitoria()
        {
            if (sequencia < 5)
                return;

            if (ExisteVitoria())
            {
                fimdejogo = true;
                if (turno == "X")
                {
                    MessageBox.Show("O Jogador venceu!!");
                    x++;
                    lblVitoriaX.Text = x.ToString();
                }
                else
                {
                    MessageBox.Show("O Computador venceu!!");
                    o++;
                    lblVitoriaO.Text = o.ToString();
                }
                FinalJogo();
            }

            if (sequencia == 9)
            {
                fimdejogo = true;
                MessageBox.Show("O jogo terminou em empate.");
                empate++;
                lblEmpate.Text = empate.ToString();
                FinalJogo();
            }
        }
        private bool ExisteVitoria()
        {
            return Checar(c1, c2, c3) || Checar(c4, c5, c6) || Checar(c7, c8, c9) || Checar(c1, c4, c7) || Checar(c2, c5, c8) || Checar(c3, c6, c9) || Checar(c1, c5, c9) || Checar(c3, c5, c7);
        }
        private bool Checar(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Image != null && pb1.Image == pb2.Image && pb1.Image == pb3.Image)
            {
                pb1.Image = pb2.Image = pb3.Image = (pb1.Image == X) ? Properties.Resources.xVitoria : Properties.Resources.oVitoria;
                return true;
            }
            return false;
        }
        private void Reset()
        {
            fimdejogo = false;
            jogou = false;
            sequencia = 0;
            turno = "O";
            foreach (PictureBox item in Casa)
            {
                item.Image = null;
                item.Enabled = true;
            }
        }
        private void FinalJogo()
        {
            DialogResult msg = MessageBox.Show("Deseja continuar o jogo?", "Caixa de pergunta", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                Reset();
            }
            else
            {
                MessageBox.Show("Obrigado por jogar!");
                Application.Exit();
            }
        }
        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}