﻿using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class CategoriaMapper
    {
        public static CategoriaEntity MapCategoriaEntity(this Categoria categoria)
        {
            if (categoria == null)
            {
                return null;
            }

            return new CategoriaEntity()
            {
                COD_CATEGORIA = categoria.Codigo_categoria,
                NOME = categoria.NomeCategoria
            };
        } 
        public static Categoria MApCategoriaModel(this CategoriaEntity categoriaEntity)
        {
            if (categoriaEntity == null)
            {
                return null;
            }

            return new Categoria()
            {
               Codigo_categoria = categoriaEntity.COD_CATEGORIA,
               NomeCategoria = categoriaEntity.NOME 
            };
        }
    }
}