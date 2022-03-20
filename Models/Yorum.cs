using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Yorum
    {
      
        public string Baslik { get; set; }

      
        public string Aciklama { get; set; }

        

        public virtual Note notu { get; set; }  

        public virtual Kullanici kullanicisi { get; set; }  


    }
}
