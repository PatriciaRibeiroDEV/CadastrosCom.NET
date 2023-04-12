namespace Projeto_cadastro_de_palestra
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
            this.btnConvidado = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvidado
            // 
            this.btnConvidado.Location = new System.Drawing.Point(136, 190);
            this.btnConvidado.Name = "btnConvidado";
            this.btnConvidado.Size = new System.Drawing.Size(172, 112);
            this.btnConvidado.TabIndex = 3;
            this.btnConvidado.Text = "Cadastro Convidado(a)";
            this.btnConvidado.UseVisualStyleBackColor = true;
            this.btnConvidado.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(136, 28);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(172, 112);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.Text = "Cadastro Aluno(a)";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBanco
            // 
            this.btnBanco.Location = new System.Drawing.Point(136, 365);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(172, 112);
            this.btnBanco.TabIndex = 4;
            this.btnBanco.Text = "Cadastrados";
            this.btnBanco.UseVisualStyleBackColor = true;
            this.btnBanco.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 513);
            this.Controls.Add(this.btnBanco);
            this.Controls.Add(this.btnConvidado);
            this.Controls.Add(this.btnAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvidado;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnBanco;
    }
}

