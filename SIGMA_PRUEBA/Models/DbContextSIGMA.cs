using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
/* 
            dotnet ef migrations add sigma 
            dotnet ef database update 
*/
namespace SIGMA_PRUEBA.Models
{
    
    public class AllParamsL
    {
        public List<ModulosParams> Lmod{get;set;}
        public List<ProfesoresParams> Lprof{get;set;}
        public List<AlumnosParams> Lalum{get;set;}
        public List<RelacionesModulosParams> Lrela{get;set;}
        public int valpr{get;set;}
        public string Info{get;set;}
    }
public class DbContextSIGMA : DbContext
{
    //
    //
    // TABLA Modulo
    public DbSet<ModulosParams> Modulos { get; set; }
    //
    //
    // TABLA Profesor
    public DbSet<ProfesoresParams> Profesores { get; set; }
    //
    //
    // TABLA Alumno
    public DbSet<AlumnosParams> Alumnos { get; set; }
    //
    //
    // TABLA de relacion entre MODULOS y los ( profesores/alumnos ).
    public DbSet<RelacionesModulosParams> RelacionesModulos { get; set; }
    //
    //
    //
    // Configuracion de la vbase de datos.
    protected override void OnConfiguring(DbContextOptionsBuilder options) => 
                            options.UseSqlite("Data Source=SIGMADBModel.db");
    public DbContextSIGMA(DbContextOptions<DbContextSIGMA> options) : base(options)
    {
        // COMPRUEBA QUE LA BD ESTÁ CREADA Y SI NO LA CREA.
        Database.EnsureCreated();
    }
    //
    //
    //
    //
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ModulosParams>().HasKey(o => o.Id);
        modelBuilder.Entity<ProfesoresParams>().HasKey(o => o.Id);
        modelBuilder.Entity<AlumnosParams>().HasKey(o => o.Id);
        modelBuilder.Entity<RelacionesModulosParams>().HasKey(o => o.Id);
    }
    //
    //
    //
    //
}
}
