using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Yorum
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Baslik { get; set; }

      
        public string Aciklama { get; set; }
      
       
        public virtual Note YorumNot { get; set; }
      
        public virtual Kullanici YorumKullanici { get; set; }  


    }
}
