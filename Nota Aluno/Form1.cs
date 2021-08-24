using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nota_Aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExibirResultado(object sender, EventArgs e)
        {
            Double AV1 = Convert.ToDouble (textBoxAV1.Text);
            Double AV2 = Convert.ToDouble (textBoxAV1.Text) ;

            Double media = (AV1 + AV2) / 2;

            textBoxMedia.Text = Convert.ToString(media);

            if (media >= 0 && media < 3)
            {
                labelResultado.Text = "REPROVADO !";
                pictureBoxResultado.ImageLocation = "img/a.jpg";
            }
            else if (media >= 3 && media < 6)
            {
                labelResultado.Text = "Faltou pouco. Continuem estudando!!";
                pictureBoxResultado.ImageLocation = "img/b.jpg";
            }
            else if (media >= 6 && media < 7)
            {
                labelResultado.Text = "Ufaaa você foi aprovado por pouco!";
                pictureBoxResultado.ImageLocation = "img/c.jpg";
            }
            else if (media >= 7 && media < 9)
            {
                labelResultado.Text = "Parabéns você foi aprovado!";
                pictureBoxResultado.ImageLocation = "img/d.jpg";

            }
            else if (media >= 9 && media <= 10)
            {
                labelResultado.Text = "Parabéns você GABARITOU !!";
                pictureBoxResultado.ImageLocation = "img/e.png";
            }
            else
            {
                labelResultado.Text = "Valor invalido!";
            }

            //também posso mostra usando o MessageBox
                 MessageBox.Show(labelResultado.Text);

        }

        private void Limpar(object sender, EventArgs e)
        {
            //função para limpar os campos
            textBoxAV1.Text = "";
            textBoxAV2.Text = "";
            textBoxMedia.Text = "";
            labelResultado.Text = "";
        }

    }
}
