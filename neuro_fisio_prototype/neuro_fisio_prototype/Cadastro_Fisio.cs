using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace neuro_fisio_prototype
{
    public partial class Cadastro_Fisio : Form
    {
        public Cadastro_Fisio()
        {
            InitializeComponent();
        }

        Fisioterapeuta[] fisios = new Fisioterapeuta[100];
        int indiceFisios = 0;

        struct Fisioterapeuta
        {
            public string nome {  get; set; }
            public string sobrenome { get; set; }
            public string crefito { get; set; }
            public string email { get; set; }
            public int cpf { get; set; }
            public int telefone { get; set; }
            public int id { get; set; }
            public bool ativo { get; set; }

            public Fisioterapeuta(string nome, string sobrenome, string crefito, string email, int cpf, int telefone, int id, bool ativo)
            {
                this.nome = nome;
                this.sobrenome = sobrenome;
                this.crefito = crefito;
                this.email = email;
                this.cpf = cpf;
                this.telefone = telefone;
                this.id = id;
                this.ativo = ativo; // Caso esteja 'false', não será mostrado na lista, e não poderá realizar agendamentos;
            }
        } // Struct para salvar todos os dados dos fisioterapeutas;

        public void verificarCamposCadastro()
        {
            if (TxtBx_CpfFisio.Text == "" || TxtBx_NomeFisio.Text == "" || TxtBx_SobrenomeFisio.Text == "" 
                || TxtBx_CrefitoFisio.Text == "" || TxtBx_TelefoneFisio.Text == "" || TxtBx_EmailFisio.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para realizar o cadastro.", "Atenção!!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show("Deseja realizar o cadastro?\n" +
                                     "Nome: " + TxtBx_NomeFisio.Text + " " + TxtBx_SobrenomeFisio.Text + "\n" +
                                     "CPF: " + TxtBx_CpfFisio.Text + "\n" +
                                     "CREFITO: " + TxtBx_CrefitoFisio.Text + "\n" +
                                     "Telefone: " + TxtBx_TelefoneFisio.Text + "\n" +
                                     "Email: " + TxtBx_EmailFisio.Text, "Confirmação de Cadastro", 
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro realizado com sucesso.", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atribuirValoresStructFisio();

                TxtBx_CpfFisio.Text = "";
                TxtBx_CrefitoFisio.Text = "";
                TxtBx_EmailFisio.Text = "";
                TxtBx_NomeFisio.Text = "";
                TxtBx_SobrenomeFisio.Text = "";
                TxtBx_TelefoneFisio.Text = "";

            }
        } // Verificação dos campos para cadastro de fisioterapeuta;

        public void atribuirValoresStructFisio()
        {
            int cpf, telefone;
            string nome, sobrenome, crefito, email;

            // Atribuição dos valores para as variáveis, para inserir no objeto fisioterapeuta;
            cpf = int.Parse(TxtBx_CpfFisio.Text);
            telefone = int.Parse(TxtBx_TelefoneFisio.Text);
            nome = TxtBx_NomeFisio.Text;
            sobrenome = TxtBx_SobrenomeFisio.Text;
            crefito = TxtBx_CrefitoFisio.Text;
            email = TxtBx_EmailFisio.Text;

            // Atribuição dos valores para o objeto fisioterapeuta;
            fisios[indiceFisios].nome = nome;
            fisios[indiceFisios].sobrenome = sobrenome;
            fisios[indiceFisios].crefito = crefito;
            fisios[indiceFisios].email = email;
            fisios[indiceFisios].cpf = cpf;
            fisios[indiceFisios].telefone = telefone;
            fisios[indiceFisios].id = indiceFisios + 1;
            fisios[indiceFisios].ativo = true;

            string nomeInteiro = $"{nome} {sobrenome}";
            CmbBx_ListaFisio_Alterar.Items.Add(nomeInteiro); // Adicionar o nome do fisioterapeuta na ComboBox de alteração de dados;

            indiceFisios++;
        } // Atribuir os valores no struct Fisioterapeuta;

        private void btnCadastraFisio_Click(object sender, EventArgs e)
        {
            verificarCamposCadastro();
        }
    }
}
