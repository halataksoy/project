﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models.Model
{
    [Table("StandartDuruslar")]
    public class StandartDuruslar
    {
        [Key]
        public int TabloId { get; set; }
        [Required]
        [DisplayName("İş Numarası")]
        public int IsNumarasi { get; set; }
        [Required]
        [DisplayName("Başlama Saati")]
        public DateTime Baslangic { get; set; }
        [Required]
        [DisplayName("Bitirme Saati")]
        public DateTime Bitirme { get; set; }
        [DisplayName("Duruş Nedeni")]
        public string DurusNedeni { get; set; }
    }
}