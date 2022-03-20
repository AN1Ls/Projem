using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Kullanici
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }

        

    
        public string Sifre { get; set; }


        public virtual  List<Note> notlar { get; set; }    

        public virtual List<Yorum> yorumlari    { get; set; }   

        public virtual  List<Begenme> begenmeler { get; set; }

    }
}