using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business
{
    public class BALEstado : BaseClass<Estado>
    {
        private DALEstado Estado { get; set; }

        public BALEstado()
        {
            Estado = new DALEstado();
        }

        public override bool Excluir(Estado objeto)
        {
            return Estado.Excluir(objeto);
        }

        public override Estado Pesquisar(int codigo)
        {
            return Estado.Pesquisar(codigo);
        }

        public override List<Estado> PesquisarTexto(string descricao)
        {
            return Estado.PesquisarTexto(descricao);
        }

        public override List<Estado> PesquisarTodos()
        {
            return Estado.PesquisarTodos();
        }

        public override bool Salvar(bool inserir, Estado objeto)
        {
            return Estado.Salvar(inserir, objeto);
        }
    }
}
