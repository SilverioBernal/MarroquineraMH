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
    
    public partial class PROPRIEDADE
    {
        public PROPRIEDADE()
        {
            this.PROP_LOJAS_VAREJO = new HashSet<PROP_LOJAS_VAREJO>();
        }
    
        public string PROPRIEDADE1 { get; set; }
        public string FAIXA_FINAL { get; set; }
        public string FAIXA_INICIAL { get; set; }
        public string MASCARA_VALOR { get; set; }
        public string DESC_PROPRIEDADE { get; set; }
        public bool PROPRIEDADE_REQUERIDA { get; set; }
        public string TIPO_PROPRIEDADE { get; set; }
        public string TIPO_VALIDACAO { get; set; }
        public Nullable<System.DateTime> DATA_PARA_TRANSFERENCIA { get; set; }
        public Nullable<System.DateTime> DATA_ATIVACAO { get; set; }
        public Nullable<System.DateTime> DATA_DESATIVACAO { get; set; }
        public string FILTRO_DE_PROPRIEDADES { get; set; }
        public string TITULO_PROPRIEDADE { get; set; }
        public string TABELA { get; set; }
        public string VALIDACAO_TABELA_CAMPO { get; set; }
        public string VALOR_PADRAO { get; set; }
        public bool CONSULTA_ATIVA { get; set; }
        public string COD_GRUPO { get; set; }
        public string RESPONSAVEL { get; set; }
        public string COLUNAS_AUXILIARES { get; set; }
        public string FILTRO_AUXILIAR { get; set; }
        public string TABELAS_AUXILIARES { get; set; }
    
        public virtual ICollection<PROP_LOJAS_VAREJO> PROP_LOJAS_VAREJO { get; set; }
    }
}
