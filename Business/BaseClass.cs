using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BaseClass<T>
    {
        public virtual bool Salvar(bool inserir, T objeto)
        {
            return false;
        }
        public virtual bool Excluir(T objeto)
        {
            return false;
        }
        public virtual T Pesquisar(int codigo)
        {
            return default(T);
        }
        public virtual List<T> PesquisarTodos()
        {
            return new List<T>();
        }
        public virtual List<T> PesquisarTexto(string descricao)
        {
            return new List<T>();
        }
    }
}
