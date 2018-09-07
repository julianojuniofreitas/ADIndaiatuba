using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business
{
    public class BALPais : BaseClass<Pais>
    {
        private DALPais Pais { get; set; }

        public BALPais()
        {
            Pais = new DALPais();
        }

        public override bool Excluir(Pais objeto)
        {
            return Pais.Excluir(objeto);
        }

        public override Pais Pesquisar(int codigo)
        {
            return Pais.Pesquisar(codigo);
        }

        public override List<Pais> PesquisarTexto(string descricao)
        {
            return Pais.PesquisarTexto(descricao);
        }

        public override List<Pais> PesquisarTodos()
        {
            return Pais.PesquisarTodos();
        }

        public override bool Salvar(bool inserir, Pais objeto)
        {
            return Pais.Salvar(inserir, objeto);
        }
    }
}
