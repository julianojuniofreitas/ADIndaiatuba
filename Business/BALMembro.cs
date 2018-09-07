using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business
{
    public class BALMembro : BaseClass<Membro>
    {
        private DALMembro Membro { get; set; }

        public BALMembro()
        {
            Membro = new DALMembro();
        }

        public override bool Excluir(Membro objeto)
        {
            return Membro.Excluir(objeto);
        }

        public override Membro Pesquisar(int codigo)
        {
            return Membro.Pesquisar(codigo);
        }

        public override List<Membro> PesquisarTexto(string descricao)
        {
            return Membro.PesquisarTexto(descricao);
        }

        public override List<Membro> PesquisarTodos()
        {
            return Membro.PesquisarTodos();
        }

        public override bool Salvar(bool inserir, Membro objeto)
        {
            return Membro.Salvar(inserir, objeto);
        }
    }
}
