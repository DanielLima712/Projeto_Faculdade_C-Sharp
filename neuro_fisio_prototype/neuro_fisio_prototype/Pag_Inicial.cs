using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neuro_fisio_prototype
{
    public partial class Pag_Inicial : Form
    {
        public Pag_Inicial()
        {
            InitializeComponent();
        }

        Cadastro_Fisio Cadastro_fisio = new Cadastro_Fisio();

        private void btnCadastraFisio_Click(object sender, EventArgs e)
        {

        }
    }
}
