using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class ChamadoRepository : BaseRepository<ChamadoEntity>
    {
        public override List<ChamadoEntity> FindALL()
        {
            return context.Set<ChamadoEntity>().AsNoTracking().ToList();
        }
        public override ChamadoEntity CadastroUpdate(ChamadoEntity obj)//Cadastra ou Update
        {
            if (obj == null)
            {
                return null;
            }

            obj.COD_CATEGORIA = obj.CATEGORIA.COD_CATEGORIA;
            obj.COD_STATUS = obj._STATUS.COD_STATUS;
            obj.COD_OWNER = obj.OWNER.COD_USUARIO;
            obj.COD_TECH = obj.TECNICO?.COD_USUARIO;

            return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        }

        protected override ChamadoEntity Cadastro(ChamadoEntity obj)//Cadastrar um novo obj 
        {
            var objCadastro = context.Set<ChamadoEntity>().Add(obj);
            //context.Entry(obj.ANEXOS).State = System.Data.Entity.EntityState.Added;

            //obj.CATEGORIA = null;
            context.Entry(obj.CATEGORIA).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(obj.OWNER.IMAGEM).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(obj._STATUS).State = System.Data.Entity.EntityState.Unchanged;
            //context.Entry(obj._STATUS.COD_STATUS).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(obj.OWNER).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(obj.OWNER.PERFIL).State = System.Data.Entity.EntityState.Unchanged;

            if (obj.TECNICO != null)
            {
                context.Entry(obj.TECNICO).State = System.Data.Entity.EntityState.Unchanged;
                context.Entry(obj.TECNICO.PERFIL).State = System.Data.Entity.EntityState.Unchanged;
                context.Entry(obj.TECNICO.IMAGEM).State = System.Data.Entity.EntityState.Unchanged;
            }
            context.SendChanges();
            return objCadastro;
        }
        protected override private ChamadoEntity Update(ChamadoEntity obj)//Update Obj
        {

            var finded = FindById(obj.EntityKey);
            context.Entry(finded).State = System.Data.Entity.EntityState.Detached;

            //var findbyimagem = new ImagemRepository().FindById(obj.OWNER.IMAGEM.EntityKey);
            //var findbyimagem1 = new ImagemRepository().FindById(obj.TECNICO.IMAGEM.EntityKey);
            //var findbyimagem2 = new UsuarioRepository().FindById(obj.OWNER.EntityKey);
            //var findbyimagem4 = new UsuarioRepository().FindById(obj.TECNICO.EntityKey);
            //ignorar a pk  e inserir 

            //context.Entry(findbyimagem).State = System.Data.Entity.EntityState.Detached;
            //context.Entry(findbyimagem1).State = System.Data.Entity.EntityState.Detached;
            //context.Entry(findbyimagem2).State = System.Data.Entity.EntityState.Detached;
            //context.Entry(findbyimagem4).State = System.Data.Entity.EntityState.Detached;

            var objUpdated = context.Set<ChamadoEntity>().Attach(obj);
            context.Entry(objUpdated).State = System.Data.Entity.EntityState.Modified;
            context.SendChanges();

            return objUpdated;
        }
    }
}
