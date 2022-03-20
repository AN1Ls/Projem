using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Databaseim:DbContext
    {
        public DbSet<Kullanici> kullanicilar { get; set; }  

        public DbSet<Kategori> kategoriler { get; set; }    

        public DbSet<Note> notlar { get; set; } 

        public DbSet<Yorum> yorumlar { get; set; }  

        public DbSet<Begenme> begenmeler { get; set; }  

        public DbSet<Admin> Adminler { get; set; }  

        public Databaseim()
        {
            Database.SetInitializer(new Msa());
        }
  
    }
}
