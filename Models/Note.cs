using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Note
    {
     
        public string Baslik { get; set; }

       
        public string Text { get; set; }

        
        public int Begenilme { get; set; }

        
        public int KategoriId { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual  Kategori Kategori { get; set; }
        public virtual List<Yorum> Yorumlar { get; set; }
        public virtual List<Begenme> Begenmeler { get; set; }
    }
}
