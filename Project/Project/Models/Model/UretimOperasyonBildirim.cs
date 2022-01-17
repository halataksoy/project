using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models.Model
{
    [Table("Üretim Operasyon Bildirimleri")]
    public class UretimOperasyonBildirim
    {
        [Key]
        public int TabloId { get; set; }
        [Required]
        [DisplayName("İş Numarası")]
        public int İsNumarasi { get; set; }
        [Required]
        [DisplayName("Başlama Saati")]
        public DateTime Baslangic { get; set; }
        [Required]
        [DisplayName("Bitirme Saati")]
        public DateTime Bitirme { get; set; }
        [Required]
        [DisplayName("Toplam Süre")]
        public float ToplamSure { get; set; }
        [Required]
        [DisplayName("Statü")]
        public string Statu { get; set; }
        [DisplayName("Duruş Nedeni")]
        public string DurusNedeni { get; set; }
    }
}