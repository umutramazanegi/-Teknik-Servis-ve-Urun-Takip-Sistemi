//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_FATURABILGI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_FATURABILGI()
        {
            this.TBL_FATURADETAY = new HashSet<TBL_FATURADETAY>();
        }
    
        public int ID { get; set; }
        public string SERI { get; set; }
        public string SIRANO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string SAAT { get; set; }
        public string VERGIDAIRE { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
    
        public virtual TBL_CARİ TBL_CARİ { get; set; }
        public virtual TBL_PERSONEL TBL_PERSONEL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_FATURADETAY> TBL_FATURADETAY { get; set; }
    }
}
