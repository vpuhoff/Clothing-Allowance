﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseSQLEntities : DbContext
    {
        public DatabaseSQLEntities()
            : base("name=DatabaseSQLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Документы_о_выдаче> Документы_о_выдаче { get; set; }
        public virtual DbSet<Звания> Звания { get; set; }
        public virtual DbSet<Имущество> Имущество { get; set; }
        public virtual DbSet<Нормативы> Нормативы { get; set; }
        public virtual DbSet<Подразделения> Подразделения { get; set; }
        public virtual DbSet<Предметы> Предметы { get; set; }
        public virtual DbSet<Приказы> Приказы { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Справочники> Справочники { get; set; }
        public virtual DbSet<Справочные_значения> Справочные_значения { get; set; }
        public virtual DbSet<ФормыОбеспечения> ФормыОбеспечения { get; set; }
    }
}
