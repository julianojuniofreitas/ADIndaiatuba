using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public class DALCidade: BaseClass<Cidade>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override bool Excluir(Cidade objeto)
        {
            Cidade CidadeDeletada = null;
            using (var db = new gaieEntities())
            {
                CidadeDeletada = db.Cidades.Where(c => c.id == objeto.id).FirstOrDefault();
            }

            using (var db = new gaieEntities())
            {
                db.Cidades.Attach(CidadeDeletada);
                db.Cidades.Remove(CidadeDeletada);
                db.SaveChanges();
                return (db.SaveChanges() > 0);
            }
        }

        public override Cidade Pesquisar(int codigo)
        {
            using (var db = new gaieEntities())
            {
                return db.Cidades.Where(c => c.id == codigo).FirstOrDefault();
            }
        }

        public override List<Cidade> PesquisarTexto(string descricao)
        {
            using (var db = new gaieEntities())
            {
                return (from c in db.Cidades
                        where c.nome.ToUpper().Contains(descricao.ToUpper())
                        select c).ToList();
            }
        }

        public override List<Cidade> PesquisarTodos()
        {
            using (var db = new gaieEntities())
            {
                return db.Cidades.ToList();
            }
        }

        public override bool Salvar(bool inserir, Cidade objeto)
        {
            using (var db = new gaieEntities())
            {
                if (inserir)
                    db.Cidades.Add(objeto);
                else
                {
                    db.Cidades.Attach(objeto);
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
