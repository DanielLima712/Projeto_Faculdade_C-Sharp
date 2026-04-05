namespace neuro_fisio_prototype
{
    partial class Cadastro_Fisio
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCadastraFisio = new System.Windows.Forms.Button();
            this.TxtBx_NomeFisio = new System.Windows.Forms.TextBox();
            this.TxtBx_CrefitoFisio = new System.Windows.Forms.TextBox();
            this.TxtBx_SobrenomeFisio = new System.Windows.Forms.TextBox();
            this.TxtBx_CpfFisio = new System.Windows.Forms.TextBox();
            this.Lbl_NomeFisio = new System.Windows.Forms.Label();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Lbl_Sobrenome = new System.Windows.Forms.Label();
            this.Lbl_Crefito = new System.Windows.Forms.Label();
            this.Lbl_telefone = new System.Windows.Forms.Label();
            this.Lbl_EmailFisio = new System.Windows.Forms.Label();
            this.TxtBx_EmailFisio = new System.Windows.Forms.TextBox();
            this.TxtBx_TelefoneFisio = new System.Windows.Forms.TextBox();
            this.CmbBx_ListaFisio_Alterar = new System.Windows.Forms.ComboBox();
            this.Lbl_NomesFisios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastraFisio
            // 
            this.btnCadastraFisio.Location = new System.Drawing.Point(143, 354);
            this.btnCadastraFisio.Name = "btnCadastraFisio";
            this.btnCadastraFisio.Size = new System.Drawing.Size(200, 40);
            this.btnCadastraFisio.TabIndex = 1;
            this.btnCadastraFisio.Text = "Cadastrar Fisioterapeuta";
            this.btnCadastraFisio.UseVisualStyleBackColor = true;
            this.btnCadastraFisio.Click += new System.EventHandler(this.btnCadastraFisio_Click);
            // 
            // TxtBx_NomeFisio
            // 
            this.TxtBx_NomeFisio.Location = new System.Drawing.Point(70, 126);
            this.TxtBx_NomeFisio.Name = "TxtBx_NomeFisio";
            this.TxtBx_NomeFisio.Size = new System.Drawing.Size(193, 20);
            this.TxtBx_NomeFisio.TabIndex = 2;
            // 
            // TxtBx_CrefitoFisio
            // 
            this.TxtBx_CrefitoFisio.Location = new System.Drawing.Point(315, 203);
            this.TxtBx_CrefitoFisio.Name = "TxtBx_CrefitoFisio";
            this.TxtBx_CrefitoFisio.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_CrefitoFisio.TabIndex = 3;
            // 
            // TxtBx_SobrenomeFisio
            // 
            this.TxtBx_SobrenomeFisio.Location = new System.Drawing.Point(70, 203);
            this.TxtBx_SobrenomeFisio.Name = "TxtBx_SobrenomeFisio";
            this.TxtBx_SobrenomeFisio.Size = new System.Drawing.Size(193, 20);
            this.TxtBx_SobrenomeFisio.TabIndex = 4;
            // 
            // TxtBx_CpfFisio
            // 
            this.TxtBx_CpfFisio.Location = new System.Drawing.Point(315, 126);
            this.TxtBx_CpfFisio.Name = "TxtBx_CpfFisio";
            this.TxtBx_CpfFisio.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_CpfFisio.TabIndex = 5;
            // 
            // Lbl_NomeFisio
            // 
            this.Lbl_NomeFisio.AutoSize = true;
            this.Lbl_NomeFisio.Location = new System.Drawing.Point(70, 110);
            this.Lbl_NomeFisio.Name = "Lbl_NomeFisio";
            this.Lbl_NomeFisio.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeFisio.TabIndex = 6;
            this.Lbl_NomeFisio.Text = "Nome";
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Location = new System.Drawing.Point(316, 110);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Cpf.TabIndex = 7;
            this.Lbl_Cpf.Text = "CPF";
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.AutoSize = true;
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(70, 187);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Sobrenome.TabIndex = 8;
            this.Lbl_Sobrenome.Text = "Sobrenome";
            // 
            // Lbl_Crefito
            // 
            this.Lbl_Crefito.AutoSize = true;
            this.Lbl_Crefito.Location = new System.Drawing.Point(316, 187);
            this.Lbl_Crefito.Name = "Lbl_Crefito";
            this.Lbl_Crefito.Size = new System.Drawing.Size(53, 13);
            this.Lbl_Crefito.TabIndex = 9;
            this.Lbl_Crefito.Text = "CREFITO";
            // 
            // Lbl_telefone
            // 
            this.Lbl_telefone.AutoSize = true;
            this.Lbl_telefone.Location = new System.Drawing.Point(316, 264);
            this.Lbl_telefone.Name = "Lbl_telefone";
            this.Lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.Lbl_telefone.TabIndex = 13;
            this.Lbl_telefone.Text = "Telefone";
            // 
            // Lbl_EmailFisio
            // 
            this.Lbl_EmailFisio.AutoSize = true;
            this.Lbl_EmailFisio.Location = new System.Drawing.Point(70, 264);
            this.Lbl_EmailFisio.Name = "Lbl_EmailFisio";
            this.Lbl_EmailFisio.Size = new System.Drawing.Size(36, 13);
            this.Lbl_EmailFisio.TabIndex = 12;
            this.Lbl_EmailFisio.Text = "E-Mail";
            // 
            // TxtBx_EmailFisio
            // 
            this.TxtBx_EmailFisio.Location = new System.Drawing.Point(70, 280);
            this.TxtBx_EmailFisio.Name = "TxtBx_EmailFisio";
            this.TxtBx_EmailFisio.Size = new System.Drawing.Size(193, 20);
            this.TxtBx_EmailFisio.TabIndex = 11;
            // 
            // TxtBx_TelefoneFisio
            // 
            this.TxtBx_TelefoneFisio.Location = new System.Drawing.Point(315, 280);
            this.TxtBx_TelefoneFisio.Name = "TxtBx_TelefoneFisio";
            this.TxtBx_TelefoneFisio.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_TelefoneFisio.TabIndex = 10;
            // 
            // CmbBx_ListaFisio_Alterar
            // 
            this.CmbBx_ListaFisio_Alterar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBx_ListaFisio_Alterar.FormattingEnabled = true;
            this.CmbBx_ListaFisio_Alterar.Location = new System.Drawing.Point(70, 50);
            this.CmbBx_ListaFisio_Alterar.Name = "CmbBx_ListaFisio_Alterar";
            this.CmbBx_ListaFisio_Alterar.Size = new System.Drawing.Size(345, 21);
            this.CmbBx_ListaFisio_Alterar.TabIndex = 14;
            // 
            // Lbl_NomesFisios
            // 
            this.Lbl_NomesFisios.AutoSize = true;
            this.Lbl_NomesFisios.Location = new System.Drawing.Point(70, 34);
            this.Lbl_NomesFisios.Name = "Lbl_NomesFisios";
            this.Lbl_NomesFisios.Size = new System.Drawing.Size(316, 13);
            this.Lbl_NomesFisios.TabIndex = 15;
            this.Lbl_NomesFisios.Text = "Para alterar os dados de algum fisioterapeuta, selecione-o abaixo:";
            // 
            // Cadastro_Fisio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Lbl_NomesFisios);
            this.Controls.Add(this.CmbBx_ListaFisio_Alterar);
            this.Controls.Add(this.Lbl_telefone);
            this.Controls.Add(this.Lbl_EmailFisio);
            this.Controls.Add(this.TxtBx_EmailFisio);
            this.Controls.Add(this.TxtBx_TelefoneFisio);
            this.Controls.Add(this.Lbl_Crefito);
            this.Controls.Add(this.Lbl_Sobrenome);
            this.Controls.Add(this.Lbl_Cpf);
            this.Controls.Add(this.Lbl_NomeFisio);
            this.Controls.Add(this.TxtBx_CpfFisio);
            this.Controls.Add(this.TxtBx_SobrenomeFisio);
            this.Controls.Add(this.TxtBx_CrefitoFisio);
            this.Controls.Add(this.TxtBx_NomeFisio);
            this.Controls.Add(this.btnCadastraFisio);
            this.Name = "Cadastro_Fisio";
            this.Text = "Cadastro Fisioterapeuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCadastraFisio;
        private System.Windows.Forms.TextBox TxtBx_NomeFisio;
        private System.Windows.Forms.TextBox TxtBx_CrefitoFisio;
        private System.Windows.Forms.TextBox TxtBx_SobrenomeFisio;
        private System.Windows.Forms.TextBox TxtBx_CpfFisio;
        private System.Windows.Forms.Label Lbl_NomeFisio;
        private System.Windows.Forms.Label Lbl_Cpf;
        private System.Windows.Forms.Label Lbl_Sobrenome;
        private System.Windows.Forms.Label Lbl_Crefito;
        private System.Windows.Forms.Label Lbl_telefone;
        private System.Windows.Forms.Label Lbl_EmailFisio;
        private System.Windows.Forms.TextBox TxtBx_EmailFisio;
        private System.Windows.Forms.TextBox TxtBx_TelefoneFisio;
        private System.Windows.Forms.ComboBox CmbBx_ListaFisio_Alterar;
        private System.Windows.Forms.Label Lbl_NomesFisios;
    }
}