using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Configuration;

namespace SwallowApplicationApi.Models
{
    public class CoreDbContext : DbContext
    {
        public virtual DbSet<UserModel> User { get; set; } //创建实体类添加Context中
        public virtual DbSet<BillModel> Bills { get; set; }

        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseMySQL(@"server=localhost;uid=root;pwd=sophie123456;
        //            port=3306;database=huamao;sslmode=Preferred;");
        //    }
        //}
    }
}
