//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2021
{
    using System;
    using System.Collections.Generic;
    
    public partial class DP_Po_material_wydruk
    {
        public Nullable<int> Id_materialu { get; set; }
        public Nullable<int> Id_po_wydr_proc { get; set; }
        public double ilosc { get; set; }
    
        public virtual DM_Material DM_Material { get; set; }
        public virtual DP_Po_wydr_proc DP_Po_wydr_proc { get; set; }
    }
}
