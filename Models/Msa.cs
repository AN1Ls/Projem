using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Msa:CreateDatabaseIfNotExists<Databaseim>
    {
        protected override void Seed(Databaseim context)
        {
            Kullanici kull = new Kullanici() {
           KullaniciAdi="Anil",
           Sifre="121221"
           };
            context.kullanicilar.Add(kull);

            context.SaveChanges();
        }
    }
}
