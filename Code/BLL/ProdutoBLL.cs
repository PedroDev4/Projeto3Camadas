using Projeto3Camadas.Code.DAL;
using Projeto3Camadas.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.BLL
{
    public class ProdutoBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados db = new AcessoBancoDados();
        string tabela = "tbl_produtos";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(ProdutoDTO produtoDTO)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{produtoDTO.Nome}','{produtoDTO.Quantidade}')";
            db.ExecutarComando(inserir);
        }
    }
}
