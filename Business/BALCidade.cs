using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business
{
    public class BALCidade : BaseClass<Cidade>
    {
        private DALCidade Cidade { get; set; }

        public BALCidade()
        {
            Cidade = new DALCidade();
        }

        public override bool Excluir(Cidade objeto)
        {
            return Cidade.Excluir(objeto);
        }

        public override Cidade Pesquisar(int codigo)
        {
            return Cidade.Pesquisar(codigo);
        }

        public override List<Cidade> PesquisarTexto(string descricao)
        {
            return Cidade.PesquisarTexto(descricao);
        }

        public override List<Cidade> PesquisarTodos()
        {
            return Cidade.PesquisarTodos();
        }

        public override bool Salvar(bool inserir, Cidade objeto)
        {
            return Cidade.Salvar(inserir, objeto);
        }
    }
}
