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
    
    public partial class vDP_Koszt_materialu_dodatkowe_powykonawczy
    {
        public int Id_proces_produkcyjny { get; set; }
        public int Id_prod_czynnosci_dodatkowe { get; set; }
        public int Id_materialu { get; set; }
        public int Ilosc { get; set; }
        public string Nazwa { get; set; }
        public Nullable<int> Koszt_material_cz_dodatkowe_powykonawczy { get; set; }
    }
}
