//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicineDetail
    {
        public long TreatmentRequestId { get; set; }
        public long MedicineId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Usage { get; set; }
    
        public virtual TreatmentRequest TreatmentRequest { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}
