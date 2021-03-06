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
    
    public partial class FORNECEDORES
    {
        public FORNECEDORES()
        {
            this.PRODUTOS = new HashSet<PRODUTOS>();
        }
    
        public string FORNECEDOR { get; set; }
        public string CENTRO_CUSTO { get; set; }
        public string TIPO { get; set; }
        public string SUBTIPO_FORNECEDOR { get; set; }
        public string COD_FORNECEDOR { get; set; }
        public string CLIFOR { get; set; }
        public string CONDICAO_PGTO { get; set; }
        public string CGC_CPF { get; set; }
        public bool FORNECE_MATERIAIS { get; set; }
        public bool FORNECE_PROD_ACAB { get; set; }
        public bool FORNECE_MAT_CONSUMO { get; set; }
        public bool BENEFICIADOR { get; set; }
        public bool FORNECE_OUTROS { get; set; }
        public string MOEDA { get; set; }
        public bool INATIVO { get; set; }
        public Nullable<System.DateTime> DATA_PARA_TRANSFERENCIA { get; set; }
        public Nullable<short> LICENCIADO { get; set; }
        public Nullable<decimal> LICENDIADO_ROYALTIES { get; set; }
        public string CONTA_CONTABIL { get; set; }
        public string CTB_CONTA_CONTABIL { get; set; }
        public Nullable<decimal> LICENCIADO_ROYALTIES { get; set; }
        public Nullable<int> CQFOR_CLASSIFICACAO { get; set; }
        public bool INDICA_CQFOR { get; set; }
        public int DIAS_DESCONTO_VENCIMENTO { get; set; }
        public decimal DESCONTO_VENCIMENTO { get; set; }
    
        public virtual CADASTRO_CLI_FOR CADASTRO_CLI_FOR { get; set; }
        public virtual ICollection<PRODUTOS> PRODUTOS { get; set; }
    }
}
