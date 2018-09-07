using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public class DALMembro: BaseClass<Membro>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override bool Excluir(Membro objeto)
        {
            Membro membroDeletado = null;
            using (var db = new gaieEntities())
            {
                membroDeletado = db.Membros.Where(c => c.CODIRM07 == objeto.CODIRM07).FirstOrDefault();
            }

            using (var db = new gaieEntities())
            {
                db.Membros.Attach(membroDeletado);
                db.Membros.Remove(membroDeletado);
                db.SaveChanges();
                return (db.SaveChanges() > 0);
            }
        }

        public override Membro Pesquisar(int codigo)
        {
            using (var db = new gaieEntities())
            {
                return db.Membros.Where(c => int.Parse(c.CODIRM07.ToString()) == codigo).FirstOrDefault();
            }
        }

        public override List<Membro> PesquisarTexto(string descricao)
        {
            using (var db = new gaieEntities())
            {
                return (from c in db.Membros
                        where c.NOMIRM07.ToUpper().Contains(descricao.ToUpper())
                        select c).ToList();
            }
        }

        public override List<Membro> PesquisarTodos()
        {
            using (var db = new gaieEntities())
            {
                return db.Membros.ToList();
            }
        }

        public override bool Salvar(bool inserir, Membro objeto)
        {
            using (var db = new gaieEntities())
            {
                if (inserir)
                    db.Membros.Add(objeto);
                else
                {
                    db.Membros.Attach(objeto);
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
