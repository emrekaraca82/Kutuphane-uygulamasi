//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kitap_Ekleme
    {
        public int Id { get; set; }
        public string Kitabın_Adı { get; set; }
        public string Kitabın_Yazarı { get; set; }
        public string Yayın_Evi { get; set; }
        public string Kitabın_Türü { get; set; }
        public Nullable<System.DateTime> Basım_Tarihi { get; set; }
        public Nullable<short> Sayfa_Sayısı { get; set; }
        public string Raf_Sırası { get; set; }
    }
}