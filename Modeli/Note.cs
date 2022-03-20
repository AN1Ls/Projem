using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Note
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Baslik { get; set; }

       
        public string Text { get; set; }

   
        public int kullanici_Id { get; set; }   

        public int kategori_Id { get; set; }


        [ForeignKey("kullanici_Id")]
        public virtual Kullanici NotKul { get; set; }

   
        [ForeignKey("kategori_Id")]
        public virtual  Kategori kategori { get; set; }
     
        
        public virtual ICollection<Yorum> Yorumlar { get; set; }
       
     
      
        public virtual ICollection<Begenme> Begenmeler { get; set; }
    }
}
