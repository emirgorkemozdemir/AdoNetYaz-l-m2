//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoNetYazılım2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class personel_maas_odeme
    {
        public int id { get; set; }
        public int personel_id { get; set; }
        public System.DateTime odeme_tarihi { get; set; }
        public decimal maas_tutari { get; set; }
        public Nullable<decimal> prim_tutari { get; set; }
        public string aciklama { get; set; }
    }
}
