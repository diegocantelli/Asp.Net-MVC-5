using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace AplicacaoComCodeFirst.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext() : base("name=BlogContext")
        {
            
            Database.Connection.ConnectionString = "server=localhost;user id = root;passworD=cursomysql; port=3306;"
                                + " database=BlogBDLivro; SslMode=none";
        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
    }
}