using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Kullanici
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }

        
        public string Email { get; set; }   
    
        public string Sifre { get; set; }
    
        public virtual  ICollection<Note> notlar { get; set; }

      
        public virtual ICollection<Yorum> yorumlari    { get; set; }

      
        public virtual  ICollection<Begenme> begenmeler { get; set; }

    }
}