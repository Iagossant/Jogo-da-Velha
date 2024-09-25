namespace Jogo_Da_Velha
{
    partial class Vs_Jogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vs_Jogador));
            pictureBox1 = new PictureBox();
            c1 = new PictureBox();
            c3 = new PictureBox();
            c2 = new PictureBox();
            c5 = new PictureBox();
            c6 = new PictureBox();
            c4 = new PictureBox();
            c8 = new PictureBox();
            c9 = new PictureBox();
            c7 = new PictureBox();
            lblVitoriaX = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            lblEmpate = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            lblVitoriaO = new Label();
            btnNovoJogo = new Button();
            lblTurno = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tabuleiro;
            pictureBox1.Location = new Point(-64, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // c1
            // 
            c1.Cursor = Cursors.Hand;
            c1.Location = new Point(49, 53);
            c1.Name = "c1";
            c1.Size = new Size(99, 98);
            c1.SizeMode = PictureBoxSizeMode.Zoom;
            c1.TabIndex = 1;
            c1.TabStop = false;
            c1.Tag = "1";
            c1.Click += CasaClick;
            // 
            // c3
            // 
            c3.Cursor = Cursors.Hand;
            c3.Location = new Point(268, 52);
            c3.Name = "c3";
            c3.Size = new Size(99, 98);
            c3.SizeMode = PictureBoxSizeMode.Zoom;
            c3.TabIndex = 2;
            c3.TabStop = false;
            c3.Tag = "1";
            c3.Click += CasaClick;
            // 
            // c2
            // 
            c2.Location = new Point(158, 53);
            c2.Name = "c2";
            c2.Size = new Size(99, 98);
            c2.SizeMode = PictureBoxSizeMode.Zoom;
            c2.TabIndex = 3;
            c2.TabStop = false;
            c2.Tag = "1";
            c2.Click += CasaClick;
            // 
            // c5
            // 
            c5.Cursor = Cursors.Hand;
            c5.Location = new Point(158, 162);
            c5.Name = "c5";
            c5.Size = new Size(99, 98);
            c5.SizeMode = PictureBoxSizeMode.Zoom;
            c5.TabIndex = 6;
            c5.TabStop = false;
            c5.Tag = "1";
            c5.Click += CasaClick;
            // 
            // c6
            // 
            c6.Cursor = Cursors.Hand;
            c6.Location = new Point(268, 162);
            c6.Name = "c6";
            c6.Size = new Size(99, 98);
            c6.SizeMode = PictureBoxSizeMode.Zoom;
            c6.TabIndex = 5;
            c6.TabStop = false;
            c6.Tag = "1";
            c6.Click += CasaClick;
            // 
            // c4
            // 
            c4.Cursor = Cursors.Hand;
            c4.Location = new Point(49, 162);
            c4.Name = "c4";
            c4.Size = new Size(99, 98);
            c4.SizeMode = PictureBoxSizeMode.Zoom;
            c4.TabIndex = 4;
            c4.TabStop = false;
            c4.Tag = "1";
            c4.Click += CasaClick;
            // 
            // c8
            // 
            c8.Cursor = Cursors.Hand;
            c8.Location = new Point(158, 271);
            c8.Name = "c8";
            c8.Size = new Size(99, 98);
            c8.SizeMode = PictureBoxSizeMode.Zoom;
            c8.TabIndex = 9;
            c8.TabStop = false;
            c8.Tag = "1";
            c8.Click += CasaClick;
            // 
            // c9
            // 
            c9.Cursor = Cursors.Hand;
            c9.Location = new Point(268, 270);
            c9.Name = "c9";
            c9.Size = new Size(99, 98);
            c9.SizeMode = PictureBoxSizeMode.Zoom;
            c9.TabIndex = 8;
            c9.TabStop = false;
            c9.Tag = "1";
            c9.Click += CasaClick;
            // 
            // c7
            // 
            c7.Cursor = Cursors.Hand;
            c7.Location = new Point(49, 271);
            c7.Name = "c7";
            c7.Size = new Size(99, 98);
            c7.SizeMode = PictureBoxSizeMode.Zoom;
            c7.TabIndex = 7;
            c7.TabStop = false;
            c7.Tag = "1";
            c7.Click += CasaClick;
            // 
            // lblVitoriaX
            // 
            lblVitoriaX.AutoSize = true;
            lblVitoriaX.BackColor = Color.Transparent;
            lblVitoriaX.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblVitoriaX.Location = new Point(561, 58);
            lblVitoriaX.Name = "lblVitoriaX";
            lblVitoriaX.Size = new Size(56, 65);
            lblVitoriaX.TabIndex = 10;
            lblVitoriaX.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.xNormal;
            pictureBox2.Location = new Point(419, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label1.Location = new Point(510, 58);
            label1.Name = "label1";
            label1.Size = new Size(62, 65);
            label1.TabIndex = 15;
            label1.Text = "=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label2.Location = new Point(510, 230);
            label2.Name = "label2";
            label2.Size = new Size(62, 65);
            label2.TabIndex = 18;
            label2.Text = "=";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.tabuleiro;
            pictureBox3.Location = new Point(419, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // lblEmpate
            // 
            lblEmpate.AutoSize = true;
            lblEmpate.BackColor = Color.Transparent;
            lblEmpate.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblEmpate.Location = new Point(561, 230);
            lblEmpate.Name = "lblEmpate";
            lblEmpate.Size = new Size(56, 65);
            lblEmpate.TabIndex = 16;
            lblEmpate.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label4.Location = new Point(510, 144);
            label4.Name = "label4";
            label4.Size = new Size(62, 65);
            label4.TabIndex = 21;
            label4.Text = "=";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.oNormal;
            pictureBox4.Location = new Point(419, 139);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // lblVitoriaO
            // 
            lblVitoriaO.AutoSize = true;
            lblVitoriaO.BackColor = Color.Transparent;
            lblVitoriaO.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblVitoriaO.Location = new Point(561, 144);
            lblVitoriaO.Name = "lblVitoriaO";
            lblVitoriaO.Size = new Size(56, 65);
            lblVitoriaO.TabIndex = 19;
            lblVitoriaO.Text = "0";
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.Location = new Point(451, 318);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(121, 51);
            btnNovoJogo.TabIndex = 22;
            btnNovoJogo.Text = "Novo Jogo";
            btnNovoJogo.UseVisualStyleBackColor = true;
            btnNovoJogo.Click += btnNovoJogo_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurno.Location = new Point(176, 9);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(72, 21);
            lblTurno.TabIndex = 13;
            lblTurno.Text = "Turno: X";
            // 
            // Vs_Jogador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 401);
            Controls.Add(btnNovoJogo);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(lblVitoriaO);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(lblEmpate);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblTurno);
            Controls.Add(lblVitoriaX);
            Controls.Add(c8);
            Controls.Add(c9);
            Controls.Add(c7);
            Controls.Add(c5);
            Controls.Add(c6);
            Controls.Add(c4);
            Controls.Add(c2);
            Controls.Add(c3);
            Controls.Add(c1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Vs_Jogador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da Velha - Vs Jogador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c3).EndInit();
            ((System.ComponentModel.ISupportInitialize)c2).EndInit();
            ((System.ComponentModel.ISupportInitialize)c5).EndInit();
            ((System.ComponentModel.ISupportInitialize)c6).EndInit();
            ((System.ComponentModel.ISupportInitialize)c4).EndInit();
            ((System.ComponentModel.ISupportInitialize)c8).EndInit();
            ((System.ComponentModel.ISupportInitialize)c9).EndInit();
            ((System.ComponentModel.ISupportInitialize)c7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox c1;
        private PictureBox c3;
        private PictureBox c2;
        private PictureBox c5;
        private PictureBox c6;
        private PictureBox c4;
        private PictureBox c8;
        private PictureBox c9;
        private PictureBox c7;
        private Label lblVitoriaX;
        private Label lblEmpate;
        private Label lblVitoriaO;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private Button btnNovoJogo;
        private Label lblTurno;
    }
}