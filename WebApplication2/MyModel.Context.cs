﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class MyDatabaseEntities : DbContext
    {
        public MyDatabaseEntities()
            : base("name=MyDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<User> Users { get; set; }
        public DbSet<Padre> Padres { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    
        public virtual int agregarpadres(string nombre, string apellido, string usuario, string contrasenia)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var contraseniaParameter = contrasenia != null ?
                new ObjectParameter("Contrasenia", contrasenia) :
                new ObjectParameter("Contrasenia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("agregarpadres", nombreParameter, apellidoParameter, usuarioParameter, contraseniaParameter);
        }
    }
}
