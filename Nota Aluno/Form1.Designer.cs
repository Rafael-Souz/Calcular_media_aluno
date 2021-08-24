
namespace Nota_Aluno
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAV1 = new System.Windows.Forms.TextBox();
            this.textBoxAV2 = new System.Windows.Forms.TextBox();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(106, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(34, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota AV1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(34, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota AV2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(50, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Média";
            // 
            // textBoxAV1
            // 
            this.textBoxAV1.Location = new System.Drawing.Point(118, 164);
            this.textBoxAV1.Name = "textBoxAV1";
            this.textBoxAV1.Size = new System.Drawing.Size(141, 20);
            this.textBoxAV1.TabIndex = 4;
            // 
            // textBoxAV2
            // 
            this.textBoxAV2.Location = new System.Drawing.Point(118, 194);
            this.textBoxAV2.Name = "textBoxAV2";
            this.textBoxAV2.Size = new System.Drawing.Size(141, 20);
            this.textBoxAV2.TabIndex = 5;
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.Location = new System.Drawing.Point(118, 232);
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.ReadOnly = true;
            this.textBoxMedia.Size = new System.Drawing.Size(141, 20);
            this.textBoxMedia.TabIndex = 6;
            // 
            // buttonResultado
            // 
            this.buttonResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonResultado.Location = new System.Drawing.Point(129, 294);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(100, 28);
            this.buttonResultado.TabIndex = 7;
            this.buttonResultado.Text = "Resultado";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.ExibirResultado);
            // 
            // pictureBoxResultado
            // 
            this.pictureBoxResultado.Location = new System.Drawing.Point(267, 164);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(128, 125);
            this.pictureBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResultado.TabIndex = 8;
            this.pictureBoxResultado.TabStop = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(269, 308);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(10, 13);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "-";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLimpar.Location = new System.Drawing.Point(129, 328);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(100, 28);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.pictureBoxResultado);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.textBoxMedia);
            this.Controls.Add(this.textBoxAV2);
            this.Controls.Add(this.textBoxAV1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MÉDIA DO ALUNO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAV1;
        private System.Windows.Forms.TextBox textBoxAV2;
        private System.Windows.Forms.TextBox textBoxMedia;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.PictureBox pictureBoxResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

