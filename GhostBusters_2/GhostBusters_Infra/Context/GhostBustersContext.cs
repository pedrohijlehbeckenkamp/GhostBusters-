using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra
{
    public class GhostBustersContext : DbContext 
    {
        public GhostBustersContext() : base("Ghostbusters") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PerfilEntity>()
                .HasKey(x => x.COD_PERFIL);

            modelBuilder.Entity<Base64ImagemEntity>()
                .HasKey(x => x.COD_IMAGEM);

            modelBuilder.Entity<UsuarioEntity>()
                .HasKey(x => x.COD_USUARIO)
                .HasRequired(perfil => perfil.PERFIL);

            modelBuilder.Entity<UsuarioEntity>()
                .HasOptional(imagem => imagem.IMAGEM);
           
        }
    }
}
