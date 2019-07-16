﻿using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class AnexoRepository: BaseRepository<Base64AnexoEntity>
    {
        public override Base64AnexoEntity CadastroUpdate(Base64AnexoEntity obj)//Cadastra ou Update
        {
            if (obj == null)
            {
                return null;
            }

            obj.COD_CHAMADO = obj.CHAMADO.COD_CHAMADO;
            return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        }

        protected override Base64AnexoEntity Cadastro(Base64AnexoEntity obj)//Cadastrar um novo obj 
        {
            var objCadastro = context.Set<Base64AnexoEntity>().Add(obj);
            context.Entry(obj.CHAMADO).State = System.Data.Entity.EntityState.Unchanged;//Nao duplica

            context.SendChanges();
            return objCadastro;
        }
        protected override private Base64AnexoEntity Update(Base64AnexoEntity obj)//Update Obj
        {
            var finded = FindById(obj.EntityKey);
            context.Entry(finded).State = System.Data.Entity.EntityState.Detached;//ignorar a pk  e inserir 

            var objUpdated = context.Set<Base64AnexoEntity>().Attach(obj);
            context.Entry(objUpdated).State = System.Data.Entity.EntityState.Modified;
            context.SendChanges();

            return objUpdated;
        }
    }
}
