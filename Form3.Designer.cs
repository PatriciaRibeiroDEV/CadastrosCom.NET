namespace Projeto_cadastro_de_palestra
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtNomeConv = new System.Windows.Forms.TextBox();
            this.txtFoneConv = new System.Windows.Forms.TextBox();
            this.CboIdadeConv = new System.Windows.Forms.ComboBox();
            this.txtEmailConv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CadastrarConv = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CheckboxTermoConv = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNomeConv
            // 
            this.txtNomeConv.Location = new System.Drawing.Point(55, 90);
            this.txtNomeConv.Name = "txtNomeConv";
            this.txtNomeConv.Size = new System.Drawing.Size(334, 22);
            this.txtNomeConv.TabIndex = 0;
            this.txtNomeConv.TextChanged += new System.EventHandler(this.txtNomeConv_TextChanged);
            // 
            // txtFoneConv
            // 
            this.txtFoneConv.Location = new System.Drawing.Point(55, 237);
            this.txtFoneConv.Name = "txtFoneConv";
            this.txtFoneConv.Size = new System.Drawing.Size(182, 22);
            this.txtFoneConv.TabIndex = 1;
            this.txtFoneConv.TextChanged += new System.EventHandler(this.txtFoneConv_TextChanged);
            this.txtFoneConv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoneConv_KeyPress);
            // 
            // CboIdadeConv
            // 
            this.CboIdadeConv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboIdadeConv.FormattingEnabled = true;
            this.CboIdadeConv.Items.AddRange(new object[] {
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
            this.CboIdadeConv.Location = new System.Drawing.Point(320, 235);
            this.CboIdadeConv.Name = "CboIdadeConv";
            this.CboIdadeConv.Size = new System.Drawing.Size(69, 24);
            this.CboIdadeConv.TabIndex = 2;
            this.CboIdadeConv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtEmailConv
            // 
            this.txtEmailConv.Location = new System.Drawing.Point(55, 159);
            this.txtEmailConv.Name = "txtEmailConv";
            this.txtEmailConv.Size = new System.Drawing.Size(334, 22);
            this.txtEmailConv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // CadastrarConv
            // 
            this.CadastrarConv.Location = new System.Drawing.Point(168, 413);
            this.CadastrarConv.Name = "CadastrarConv";
            this.CadastrarConv.Size = new System.Drawing.Size(159, 43);
            this.CadastrarConv.TabIndex = 8;
            this.CadastrarConv.Text = "Cadastrar";
            this.CadastrarConv.UseVisualStyleBackColor = true;
            this.CadastrarConv.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-39, 308);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckboxTermoConv
            // 
            this.CheckboxTermoConv.AutoSize = true;
            this.CheckboxTermoConv.Location = new System.Drawing.Point(36, 295);
            this.CheckboxTermoConv.Name = "CheckboxTermoConv";
            this.CheckboxTermoConv.Size = new System.Drawing.Size(430, 84);
            this.CheckboxTermoConv.TabIndex = 10;
            this.CheckboxTermoConv.Text = resources.GetString("CheckboxTermoConv.Text");
            this.CheckboxTermoConv.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 479);
            this.Controls.Add(this.CheckboxTermoConv);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CadastrarConv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailConv);
            this.Controls.Add(this.CboIdadeConv);
            this.Controls.Add(this.txtFoneConv);
            this.Controls.Add(this.txtNomeConv);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeConv;
        private System.Windows.Forms.TextBox txtFoneConv;
        private System.Windows.Forms.ComboBox CboIdadeConv;
        private System.Windows.Forms.TextBox txtEmailConv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CadastrarConv;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox CheckboxTermoConv;
    }
}