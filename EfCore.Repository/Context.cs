using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Repository
{
    public class Context : DbContext //EntityframeWorkCore para o asp.netCore e Entity.SqlServer ||
                                      //Esse Projeto Também precisa do Core.Toll e SQlTools
    {
        public Context(DbContextOptionsBuilder<Context>options) : base()//options
        {

        }


        //Por padrão as referencias ficam em plural
        public DbSet<Heroi> herois  { get; set; }
        public DbSet<Batalha> batalhass { get; set; }
        public DbSet<Arma> armas { get; set; }
        
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) --Esta no contrutor acima */
        
            //optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HeroApp;Data Source=LAPTOP-DNO3086A\\SQLEXPRESS");
            //// Essa CanectionString agora esta em AppSetings e com referencia lá em StartUp


            //Essa Função só funciona com o  Entity.SqlServer
            //no Catalog Você define o nome do banco de dados

            //Abra o Consolole Nuget Package Manage:
            //get-help entityframeworkcore -- Para Mostrar o menu de ajuda
            /*
             * Cmdlet                      Description
            --------------------------  ---------------------------------------------------
            Add-Migration               Adds a new migration.
            Add-Migration Initial       Para Iniciar a migração
            Drop-Database               Drops the database.

            Get-DbContext               Lists and gets information about available DbContext types.

            Get-Migration               Lists available migrations.

            Remove-Migration            Removes the last migration.

            Scaffold-DbContext          Scaffolds a DbContext and entity types for a database.

            Script-DbContext            Generates a SQL script from the DbContext. Bypasses any migrations.
            //Possibilita usar um banco de dados 

            Script-Migration            Generates a SQL script from migrations.

            Update-Database             Updates the database to a specified migration.*/




        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   //Chave Composta Solução
            modelBuilder.Entity<HeroiBatalha>(entity =>
            {
                entity.HasKey(e => new { e.batalha, e.heroiId });
            });
        }




    }
}
