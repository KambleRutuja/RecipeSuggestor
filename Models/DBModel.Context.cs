﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipSuggestor.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecipesDBEntities : DbContext
    {
        public RecipesDBEntities()
            : base("name=RecipesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<IngredientTab> IngredientTabs { get; set; }
        public virtual DbSet<RecipeTab> RecipeTabs { get; set; }
        public virtual DbSet<RITab> RITabs { get; set; }
    }
}