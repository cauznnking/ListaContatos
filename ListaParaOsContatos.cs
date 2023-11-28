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
        //atributos globais 
        int idSelecionado = 0;

        public ListaParaOsContatos()
        {
            InitializeComponent();
            Classes.Contatoscs contato = new Classes.Contatoscs();
            DgvContatos.DataSource = contato.ListarTudo();
        }

  
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListaParaOsContatos_Load(object sender, EventArgs e)
        {

        }

        private void DgvContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os grbs:
            GrbEditarContatos.Enabled = true;
            GrbApagar.Enabled = true;

            //obter a linha clicada:
            int LinhaSelecionada = DgvContatos.CurrentCell.RowIndex;

            //armazenar os dados da linha selecionada em "linha" (tipo um vetor )
            var linha = DgvContatos.Rows[LinhaSelecionada];

            //preencher os campos:
            TxbNomeEdit.Text = linha.Cells[1].Value.ToString();
            TxbEmailEdit.Text = linha.Cells[2].Value.ToString();

            //juntar os id e o nome  para exibir no apagar
            LblApagar.Text = linha.Cells[0].Value.ToString() + "-" +
                linha.Cells[1].Value.ToString();

            //salvar o id do selecionado na variavel global
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Classes.Contatoscs contatos = new Classes.Contatoscs();
            contatos.Id = idSelecionado;
            //apagar:
            var r = MessageBox.Show("Tem certeza que desejas apagar o usuarios?", "ATENÇÃO",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                //apagar
                if (contatos.Apagar() == true)
                {
                    MessageBox.Show("PRODUTO APAGADO ", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarTudo();
                }
                else
                {
                    MessageBox.Show("FALHA AO APAGAR", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
