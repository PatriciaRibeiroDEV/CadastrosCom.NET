namespace Projeto_cadastro_de_palestra
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.checkBoxTermoAluno = new System.Windows.Forms.CheckBox();
            this.btnCadastroAluno = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.CboxIdadeAluno = new System.Windows.Forms.ComboBox();
            this.txtFoneAluno = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCursoAluno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxTermoAluno
            // 
            this.checkBoxTermoAluno.AutoSize = true;
            this.checkBoxTermoAluno.Location = new System.Drawing.Point(21, 377);
            this.checkBoxTermoAluno.Name = "checkBoxTermoAluno";
            this.checkBoxTermoAluno.Size = new System.Drawing.Size(430, 84);
            this.checkBoxTermoAluno.TabIndex = 20;
            this.checkBoxTermoAluno.Text = resources.GetString("checkBoxTermoAluno.Text");
            this.checkBoxTermoAluno.UseVisualStyleBackColor = true;
            // 
            // btnCadastroAluno
            // 
            this.btnCadastroAluno.Location = new System.Drawing.Point(143, 491);
            this.btnCadastroAluno.Name = "btnCadastroAluno";
            this.btnCadastroAluno.Size = new System.Drawing.Size(159, 43);
            this.btnCadastroAluno.TabIndex = 19;
            this.btnCadastroAluno.Text = "Cadastrar";
            this.btnCadastroAluno.UseVisualStyleBackColor = true;
            this.btnCadastroAluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(35, 160);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(334, 22);
            this.txtEmailAluno.TabIndex = 14;
            // 
            // CboxIdadeAluno
            // 
            this.CboxIdadeAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxIdadeAluno.FormattingEnabled = true;
            this.CboxIdadeAluno.Items.AddRange(new object[] {
            "Não Informa",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.CboxIdadeAluno.Location = new System.Drawing.Point(300, 236);
            this.CboxIdadeAluno.Name = "CboxIdadeAluno";
            this.CboxIdadeAluno.Size = new System.Drawing.Size(69, 24);
            this.CboxIdadeAluno.TabIndex = 13;
            // 
            // txtFoneAluno
            // 
            this.txtFoneAluno.Location = new System.Drawing.Point(35, 238);
            this.txtFoneAluno.Name = "txtFoneAluno";
            this.txtFoneAluno.Size = new System.Drawing.Size(182, 22);
            this.txtFoneAluno.TabIndex = 12;
            this.txtFoneAluno.TextChanged += new System.EventHandler(this.txtFoneAluno_TextChanged);
            this.txtFoneAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoneAluno_KeyPress);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(35, 91);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(334, 22);
            this.txtNomeAluno.TabIndex = 11;
            this.txtNomeAluno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNomeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAluno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Curso";
            // 
            // txtCursoAluno
            // 
            this.txtCursoAluno.Location = new System.Drawing.Point(35, 312);
            this.txtCursoAluno.Name = "txtCursoAluno";
            this.txtCursoAluno.Size = new System.Drawing.Size(334, 22);
            this.txtCursoAluno.TabIndex = 21;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 567);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCursoAluno);
            this.Controls.Add(this.checkBoxTermoAluno);
            this.Controls.Add(this.btnCadastroAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailAluno);
            this.Controls.Add(this.CboxIdadeAluno);
            this.Controls.Add(this.txtFoneAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTermoAluno;
        private System.Windows.Forms.Button btnCadastroAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.ComboBox CboxIdadeAluno;
        private System.Windows.Forms.TextBox txtFoneAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCursoAluno;
    }
}