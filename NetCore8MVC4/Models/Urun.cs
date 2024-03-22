using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NetCore8MVC4.Models
{
    public class Urun
    {
        
        public int Id { get; set; }
        [Required]
        [DisplayName("Urun adı")]
        public string Ad { get; set; }
        [DisplayName("Urun stok bilgisi")]
        [Required]
        public int Stok { get; set; }
    }
}
