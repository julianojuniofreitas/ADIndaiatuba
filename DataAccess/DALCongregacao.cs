using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public class DALCongregacao: BaseClass<Congregacao>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override bool Excluir(Congregacao objeto)
        {
            Congregacao congregacaoDeletada = null;
            using (var db = new gaieEntities())
            {
                congregacaoDeletada = db.Congregacoes.Where(c => c.id == objeto.id).FirstOrDefault();
            }

            using (var db = new gaieEntities())
            {
                db.Congregacoes.Attach(congregacaoDeletada);
                db.Congregacoes.Remove(congregacaoDeletada);
                db.SaveChanges();
                return (db.SaveChanges() > 0);
            }
        }

        public override Congregacao Pesquisar(int codigo)
        {
            using (var db = new gaieEntities())
            {
                return db.Congregacoes.Where(c => c.id == codigo).FirstOrDefault();
            }
        }

        public override List<Congregacao> PesquisarTexto(string descricao)
        {
            using (var db = new gaieEntities())
            {
                return (from c in db.Congregacoes
                        where c.nome.ToUpper().Contains(descricao.ToUpper())
                        select c).ToList();
            }
        }

        public override List<Congregacao> PesquisarTodos()
        {
            using (var db = new gaieEntities())
            {
                return db.Congregacoes.ToList();
            }
        }

        public override bool Salvar(bool inserir, Congregacao objeto)
        {
            using (var db = new gaieEntities())
            {
                if (inserir)
                    db.Congregacoes.Add(objeto);
                else
                {
                    db.Congregacoes.Attach(objeto);
                    ((IObjectContextAdapter)db).ObjectContext.ObjectStateManager.ChangeObjectState(objeto, EntityState.Modified);
                }
                return (db.SaveChanges() > 0);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
