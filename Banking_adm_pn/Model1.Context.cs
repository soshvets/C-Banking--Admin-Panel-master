﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banking_adm_pn
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class banking_dbEntities : DbContext
    {
        public banking_dbEntities()
            : base("name=banking_dbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin_Table> Admin_Table { get; set; }
        public virtual DbSet<debit> debit { get; set; }
        public virtual DbSet<Deposit> Deposit { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<FD> FD { get; set; }
        public virtual DbSet<Transfer> Transfer { get; set; }
        public virtual DbSet<userAccount> userAccount { get; set; }
        public virtual DbSet<userTable> userTable { get; set; }
    }
}
