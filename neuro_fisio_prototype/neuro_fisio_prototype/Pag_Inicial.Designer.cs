namespace neuro_fisio_prototype
{
    partial class Pag_Inicial
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
            this.btnCadastraFisio = new System.Windows.Forms.Button();
            this.btnAgendaHorario = new System.Windows.Forms.Button();
            this.btnCadastraPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastraFisio
            // 
            this.btnCadastraFisio.Location = new System.Drawing.Point(150, 169);
            this.btnCadastraFisio.Name = "btnCadastraFisio";
            this.btnCadastraFisio.Size = new System.Drawing.Size(200, 40);
            this.btnCadastraFisio.TabIndex = 0;
            this.btnCadastraFisio.Text = "Cadastrar Fisioterapeuta";
            this.btnCadastraFisio.UseVisualStyleBackColor = true;
            this.btnCadastraFisio.Click += new System.EventHandler(this.btnCadastraFisio_Click);
            // 
            // btnAgendaHorario
            // 
            this.btnAgendaHorario.Location = new System.Drawing.Point(150, 319);
            this.btnAgendaHorario.Name = "btnAgendaHorario";
            this.btnAgendaHorario.Size = new System.Drawing.Size(200, 40);
            this.btnAgendaHorario.TabIndex = 1;
            this.btnAgendaHorario.Text = "Agendar Horário";
            this.btnAgendaHorario.UseVisualStyleBackColor = true;
            this.btnAgendaHorario.Click += new System.EventHandler(this.btnAgendaHorario_Click);
            // 
            // btnCadastraPaciente
            // 
            this.btnCadastraPaciente.Location = new System.Drawing.Point(150, 244);
            this.btnCadastraPaciente.Name = "btnCadastraPaciente";
            this.btnCadastraPaciente.Size = new System.Drawing.Size(200, 40);
            this.btnCadastraPaciente.TabIndex = 2;
            this.btnCadastraPaciente.Text = "Cadastrar Paciente";
            this.btnCadastraPaciente.UseVisualStyleBackColor = true;
            this.btnCadastraPaciente.Click += new System.EventHandler(this.btnCadastraPaciente_Click);
            // 
            // Pag_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnCadastraPaciente);
            this.Controls.Add(this.btnAgendaHorario);
            this.Controls.Add(this.btnCadastraFisio);
            this.Name = "Pag_Inicial";
            this.Text = "Página Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastraFisio;
        private System.Windows.Forms.Button btnAgendaHorario;
        private System.Windows.Forms.Button btnCadastraPaciente;
    }
}

