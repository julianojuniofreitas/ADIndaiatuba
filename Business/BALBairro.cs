using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business
{
    public class BALBairro : BaseClass<Bairro>
    {
        private DALBairro Bairro { get; set; }

        public BALBairro()
        {
            Bairro = new DALBairro();
        }

        public override bool Excluir(Bairro objeto)
        {
            return Bairro.Excluir(objeto);
        }

        public override Bairro Pesquisar(int codigo)
        {
            return Bairro.Pesquisar(codigo);
        }

        public override List<Bairro> PesquisarTexto(string descricao)
        {
            return Bairro.PesquisarTexto(descricao);
        }

        public override List<Bairro> PesquisarTodos()
        {
            return Bairro.PesquisarTodos();
        }

        public override bool Salvar(bool inserir, Bairro objeto)
        {
            return Bairro.Salvar(inserir, objeto);
        }
    }
}
