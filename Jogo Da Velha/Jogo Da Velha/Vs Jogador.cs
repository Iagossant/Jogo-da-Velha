using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Da_Velha
{
    public partial class Vs_Jogador : Form
    {
        int sequencia, x, o, empate;
        bool fimdejogo = false;
        string turno = "X";
        Image X = Properties.Resources.xNormal;
        Image O = Properties.Resources.oNormal;
        List<PictureBox> Casa = new List<PictureBox>();

        public Vs_Jogador()
        {
            InitializeComponent();
            Casa.AddRange(new PictureBox[] { c1, c2, c3, c4, c5, c6, c7, c8, c9 });
        }
        private void Vs_Jogador_Load(object sender, EventArgs e)
        {
            x = o = empate = 0;
            Reset();
        }
        private void CasaClick(object sender, EventArgs e)
        {
            if (!fimdejogo)
            {
                PictureBox casa = (PictureBox)sender;
                casa.Image = (turno == "X") ? X : O;
                casa.Enabled = false;
                sequencia++;
                VerificarVitoria();
                TrocarTurno();
            }
        }

        private void TrocarTurno()
        {
            turno = (turno == "X") ? "O" : "X";
            lblTurno.Text = $"Turno: {turno}";
        }

        private void VerificarVitoria()
        {
            if (sequencia < 5)
                return;

            if (ExisteVitoria())
            {
                fimdejogo = true;
                MessageBox.Show($"O Jogador {turno} venceu!!");
                if (turno == "X")
                {
                    x++;
                    lblVitoriaX.Text = x.ToString();
                }
                else
                {
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
            sequencia = 0;
            turno = "X";
            lblTurno.Text = $"Turno: {turno}";
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
            form1.ShowDialog();
            this.Close();
        }
    }
}
