using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    public class ProdutoDTO
    {
        private int _id, _quantidade;
        private string _nome;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
    }
}
