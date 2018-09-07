using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public class DALEstado: BaseClass<Estado>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override bool Excluir(Estado objeto)
        {
            Estado EstadoDeletado = null;
            using (var db = new gaieEntities())
            {
                EstadoDeletado = db.Estados.Where(c => c.id == objeto.id).FirstOrDefault();
            }

            using (var db = new gaieEntities())
            {
                db.Estados.Attach(EstadoDeletado);
                db.Estados.Remove(EstadoDeletado);
                db.SaveChanges();
                return (db.SaveChanges() > 0);
            }
        }

        public override Estado Pesquisar(int codigo)
        {
            using (var db = new gaieEntities())
            {
                return db.Estados.Where(c => c.id == codigo).FirstOrDefault();
            }
        }

        public override List<Estado> PesquisarTexto(string descricao)
        {
            using (var db = new gaieEntities())
            {
                return (from c in db.Estados
                        where c.nome.ToUpper().Contains(descricao.ToUpper())
                        select c).ToList();
            }
        }

        public override List<Estado> PesquisarTodos()
        {
            using (var db = new gaieEntities())
            {
                return db.Estados.ToList();
            }
        }

        public override bool Salvar(bool inserir, Estado objeto)
        {
            using (var db = new gaieEntities())
            {
                if (inserir)
                    db.Estados.Add(objeto);
                else
                {
                    db.Estados.Attach(objeto);
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
