﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YetenekKart.Models.Siniflar
{
    public class Yetenekler
    {
        [Key]
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public byte Deger { get; set; }
    }
}