using Microsoft.EntityFrameworkCore;
using MyTemplate.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTemplate.DAL
{
    public class MyTemplateDbContext : DbContext
    {
        public MyTemplateDbContext(DbContextOptions<MyTemplateDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 這行程式請勿刪除
            base.OnModelCreating(modelBuilder);

            // 要設定 Entity Mapping 等的程式放在下面
            // 如果沒有需要設定，可將此 Override Method 刪除
        }
        #region DbSets
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonType> PersonType { get; set; }
        #endregion

    }
}
