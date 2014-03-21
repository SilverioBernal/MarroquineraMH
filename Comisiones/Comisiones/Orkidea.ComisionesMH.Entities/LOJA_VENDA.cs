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
    
    public partial class LOJA_VENDA
    {
        public string CODIGO_FILIAL { get; set; }
        public string TICKET { get; set; }
        public System.DateTime DATA_VENDA { get; set; }
        public string CODIGO_DESCONTO { get; set; }
        public string CODIGO_CLIENTE { get; set; }
        public string PERIODO { get; set; }
        public Nullable<System.DateTime> DATA_DIGITACAO { get; set; }
        public string VENDEDOR { get; set; }
        public string OPERACAO_VENDA { get; set; }
        public string CODIGO_TAB_PRECO { get; set; }
        public Nullable<decimal> COMISSAO { get; set; }
        public Nullable<decimal> DESCONTO { get; set; }
        public Nullable<int> QTDE_TOTAL { get; set; }
        public Nullable<decimal> VALOR_TIKET { get; set; }
        public Nullable<decimal> VALOR_PAGO { get; set; }
        public Nullable<decimal> VALOR_VENDA_BRUTA { get; set; }
        public Nullable<decimal> VALOR_TROCA { get; set; }
        public Nullable<int> QTDE_TROCA_TOTAL { get; set; }
        public bool TICKET_IMPRESSO { get; set; }
        public string TERMINAL { get; set; }
        public string GERENTE_LOJA { get; set; }
        public string GERENTE_PERIODO { get; set; }
        public string CODIGO_FILIAL_PGTO { get; set; }
        public string TERMINAL_PGTO { get; set; }
        public string LANCAMENTO_CAIXA { get; set; }
        public byte[] TIMESTAMP { get; set; }
        public Nullable<decimal> VALOR_CANCELADO { get; set; }
        public Nullable<int> TOTAL_QTDE_CANCELADA { get; set; }
        public Nullable<System.DateTime> DATA_HORA_CANCELAMENTO { get; set; }
        public string PERIODO_FECHAMENTO { get; set; }
        public Nullable<System.DateTime> DATA_PARA_TRANSFERENCIA { get; set; }
        public Nullable<decimal> FATOR { get; set; }
        public string SUGESTAO_COD_FORMA_PGTO { get; set; }
        public Nullable<decimal> VALOR_IPI { get; set; }
        public Nullable<short> QTDE_ITEM { get; set; }
        public Nullable<short> MOTIVO_CANCELAMENTO { get; set; }
        public string TERMINAL_VERNDA_SUSPENSA { get; set; }
        public string TERMINAL_VENDA_SUSPENSA { get; set; }
        public Nullable<int> COD_FIDELIDADE_PROGRAMA { get; set; }
        public Nullable<decimal> QTDE_PONTOS_ACUMULADOS { get; set; }
        public Nullable<decimal> QTDE_PONTOS_RESGATADOS { get; set; }
    }
}
