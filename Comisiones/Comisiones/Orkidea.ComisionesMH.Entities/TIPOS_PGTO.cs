//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orkidea.ComisionesMH.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPOS_PGTO
    {
        public TIPOS_PGTO()
        {
            this.LOJA_VENDA_PARCELAS = new HashSet<LOJA_VENDA_PARCELAS>();
        }
    
        public string TIPO_PGTO { get; set; }
        public string DESC_TIPO_PGTO { get; set; }
        public bool TIPO_A_VISTA { get; set; }
        public byte[] TIMESTAMP { get; set; }
        public Nullable<System.DateTime> DATA_PARA_TRANSFERENCIA { get; set; }
        public bool INATIVO { get; set; }
    
        public virtual ICollection<LOJA_VENDA_PARCELAS> LOJA_VENDA_PARCELAS { get; set; }
    }
}
