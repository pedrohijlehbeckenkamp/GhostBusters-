﻿using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class BaseRepository<T> where T: BaseEntity
    {
        protected GhostBustersContext context = new GhostBustersContext();

        public virtual List<T> FindALL()
        {
            return context.Set<T>().ToList();
        }
        public virtual T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public virtual T CadastroUpdate(T obj)//Cadastra ou Update
        {
            if (obj == null)
            {
                return null;
            }
            return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        }

        private T Cadastro(T obj)//Cadastrar um novo obj 
        {
            var objCadastro = context.Set<T>().Add(obj);
            context.SaveChanges();
            return objCadastro;
        }
        private T Update(T obj)//Update Obj
        {
            var objUpdated = context.Set<T>().Attach(obj);
            context.Entry(objUpdated).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return objUpdated;
        }

        public void Remove(int id)//Remover obj 
        {
            var obj = FindById(id);
            if (obj != null)
            {
                context.Set<T>().Remove(obj);
                context.SaveChanges();
            }
        }


    }
}
