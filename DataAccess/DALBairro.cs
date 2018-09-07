using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public class DALBairro: BaseClass<Bairro>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override bool Excluir(Bairro objeto)
        {
            Bairro bairroDeletado = null;
            using (var db = new gaieEntities())
            {
                bairroDeletado = db.Bairros.Where(c => c.id == objeto.id).FirstOrDefault();
            }

            using (var db = new gaieEntities())
            {
                db.Bairros.Attach(bairroDeletado);
                db.Bairros.Remove(bairroDeletado);
                db.SaveChanges();
                return (db.SaveChanges() > 0);
            }
        }

        public override Bairro Pesquisar(int codigo)
        {
            using (var db = new gaieEntities())
            {
                return db.Bairros.Where(c => c.id == codigo).FirstOrDefault();
            }
        }

        public override List<Bairro> PesquisarTexto(string descricao)
        {
            using (var db = new gaieEntities())
            {
                return (from c in db.Bairros
                        where c.nome.ToUpper().Contains(descricao.ToUpper())
                        select c).ToList();
            }
        }

        public override List<Bairro> PesquisarTodos()
        {
            using (var db = new gaieEntities())
            {
                return db.Bairros.ToList();
            }
        }

        public override bool Salvar(bool inserir, Bairro objeto)
        {
            using (var db = new gaieEntities())
            {
                if (inserir)
                    db.Bairros.Add(objeto);
                else
                {
                    db.Bairros.Attach(objeto);
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
