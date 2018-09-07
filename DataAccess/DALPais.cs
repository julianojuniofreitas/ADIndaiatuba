using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public class DALPais: BaseClass<Pais>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override bool Excluir(Pais objeto)
        {
            Pais PaisDeletado = null;
            using (var db = new gaieEntities())
            {
                PaisDeletado = db.Paises.Where(c => c.id == objeto.id).FirstOrDefault();
            }

            using (var db = new gaieEntities())
            {
                db.Paises.Attach(PaisDeletado);
                db.Paises.Remove(PaisDeletado);
                db.SaveChanges();
                return (db.SaveChanges() > 0);
            }
        }

        public override Pais Pesquisar(int codigo)
        {
            using (var db = new gaieEntities())
            {
                return db.Paises.Where(c => c.id == codigo).FirstOrDefault();
            }
        }

        public override List<Pais> PesquisarTexto(string descricao)
        {
            using (var db = new gaieEntities())
            {
                return (from c in db.Paises
                        where c.nome.ToUpper().Contains(descricao.ToUpper())
                        select c).ToList();
            }
        }

        public override List<Pais> PesquisarTodos()
        {
            using (var db = new gaieEntities())
            {
                return db.Paises.ToList();
            }
        }

        public override bool Salvar(bool inserir, Pais objeto)
        {
            using (var db = new gaieEntities())
            {
                if (inserir)
                    db.Paises.Add(objeto);
                else
                {
                    db.Paises.Attach(objeto);
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
