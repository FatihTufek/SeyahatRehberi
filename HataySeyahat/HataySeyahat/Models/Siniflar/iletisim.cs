using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HataySeyahat.Models.Siniflar
{
    public class iletisim
    {
        [Key]
        public int ID { get; set; }
        public int AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}