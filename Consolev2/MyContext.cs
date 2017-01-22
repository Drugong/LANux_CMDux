using Consolev2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolev2
{
    public class MyContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Chatroom> Chatrooms { get; set; }

        public DbSet<LoginSecurity> LoginSecurity { get; set; }

        public DbSet<UserChatroom> UserChatroom { get; set; }

        public DbSet<Friends> Friends { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>(); //Tohle tam měl kuba
        }

        public MyContext() : base("name=MyContext")
        {

        }


    }
}