using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business
{
    public class BALCongregacao : BaseClass<Congregacao>
    {
        private DALCongregacao Congregacao { get; set; }

        public BALCongregacao()
        {
            Congregacao = new DALCongregacao();
        }

        public override bool Excluir(Congregacao objeto)
        {
            return Congregacao.Excluir(objeto);
        }

        public override Congregacao Pesquisar(int codigo)
        {
            return Congregacao.Pesquisar(codigo);
        }

        public override List<Congregacao> PesquisarTexto(string descricao)
        {
            return Congregacao.PesquisarTexto(descricao);
        }

        public override List<Congregacao> PesquisarTodos()
        {
            return Congregacao.PesquisarTodos();
        }

        public override bool Salvar(bool inserir, Congregacao objeto)
        {
            return Congregacao.Salvar(inserir, objeto);
        }
    }
}
