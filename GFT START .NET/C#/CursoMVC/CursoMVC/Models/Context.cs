﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context:DbContext
    {
        public DbSet<Categoria> categorias { get; set; }

        public DbSet<Produto> produtos { get; set; }
        public object Categoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        }

        public virtual void setModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
