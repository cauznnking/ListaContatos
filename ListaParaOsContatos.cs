using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaContatos
{
    public partial class ListaParaOsContatos : Form
    {
        public ListaParaOsContatos()
        {
            InitializeComponent();
        }

  
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListaParaOsContatos_Load(object sender, EventArgs e)
        {

        }
    }
}
