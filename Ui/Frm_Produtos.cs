using System;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;
namespace Projeto3Camadas
{
    public partial class Form1 : Form
    {
        ProdutoBLL produtoBLL = new ProdutoBLL();
        ProdutoDTO produtoDTO = new ProdutoDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            produtoDTO.Nome= txtNome.Text;
            produtoDTO.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            //Envio do dto preenchido para o método inserir
            produtoBLL.Inserir(produtoDTO);

            //Mensagem de sucesso
            MessageBox.Show("Cadastrado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpeza dos componentes
            txtId.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
