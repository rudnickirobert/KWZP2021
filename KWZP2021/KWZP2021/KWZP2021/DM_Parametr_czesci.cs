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
    
    public partial class DM_Parametr_czesci
    {
        public int Id_parametr_czesci { get; set; }
        public int Id_czesci { get; set; }
        public int Id_wlasciwosc { get; set; }
        public string Wartosc { get; set; }
    
        public virtual DM_Czesc DM_Czesc { get; set; }
        public virtual DM_Wlasciwosc DM_Wlasciwosc { get; set; }
    }
}
