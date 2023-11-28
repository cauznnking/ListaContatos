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

        public void AtualizarTudo()
        {
            Classes.Contatoscs produto = new Classes.Contatoscs();
            // Atualizar o DGV:
            DgvContatos.DataSource = produto.ListarTudo();
            // Listar os campos de edição:
            TxbNomeEdit.Clear();
            TxbEmailEdit.Clear();
            LblApagar.Text = "Selecione um contato para apagar.";
            // Desabilitar os grbs:
            GrbApagar.Enabled = false;
            GrbEditarContatos.Enabled = false;
            // Limpar os campos:
            TxbNome.Clear();
            TxbEmail.Clear();
            TxbTelefone.Clear();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Classes.Contatoscs contatos = new Classes.Contatoscs();
            contatos.Id = idSelecionado;
            //apagar:
            var r = MessageBox.Show("Tem certeza que desejas apagar este contato?", "ATENÇÃO",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                //apagar
                if (contatos.Apagar() == true)
                {
                    MessageBox.Show("CONTATO APAGADO ", "SUCESSO",
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Classes.Contatoscs contatos = new Classes.Contatoscs();


            // obter os valores dos Txbs
            contatos.Id = idSelecionado;
            contatos.Nome = TxbNomeEdit.Text;
            contatos.Email = TxbEmailEdit.Text;
            contatos.Telefone = TxbTelefoneEdit.Text;

            //editar
            if (contatos.Modificar() == true)
            {
                MessageBox.Show("CONTATO MODIFICADO ", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //atualizar o dgv:
                DgvContatos.DataSource = contatos.ListarTudo();
                //limpar os campos de edição
                TxbEmailEdit.Clear();
                TxbNomeEdit.Clear();
                TxbTelefoneEdit.Clear();
               
            }
            else
            {
                MessageBox.Show("FALHA AO MODIFICAR O CONTATO ", "FALHA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //isntanciar o ususario
            Classes.Contatoscs contatos = new Classes.Contatoscs();

            //obter valores dos campos 
            contatos.Nome = TxbNome.Text;
            contatos.Email = TxbEmail.Text;
            contatos.Telefone = TxbTelefone.Text;
            contatos.Data_Aniversario = DtpAdicionar.Value;

            if (contatos.Adicionar() == true)
            {
                MessageBox.Show("Usuario cadastrado com exito!!");
                // Limpar os campos:
                TxbNome.Clear();
                TxbEmail.Clear();
                TxbTelefone.Clear();
                DtpAdicionar.ResetText();
                // Atualizar o dgv:
                DgvContatos.DataSource = contatos.ListarTudo();
            }
            else
            {
                MessageBox.Show("falha ao cadastrar o usuario!!");
            }
        }
    }
}
