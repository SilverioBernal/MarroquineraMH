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
    
    public partial class CADASTRO_CLI_FOR
    {
        public string NOME_CLIFOR { get; set; }
        public string CARTEIRA { get; set; }
        public string BANCO { get; set; }
        public string CONTA_CONTABIL { get; set; }
        public string CLIFOR { get; set; }
        public string CGC_CPF { get; set; }
        public string RAZAO_SOCIAL { get; set; }
        public bool PJ_PF { get; set; }
        public string RG_IE { get; set; }
        public string CEP { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string TELEFONE1 { get; set; }
        public string PAIS { get; set; }
        public string DDI { get; set; }
        public string TELEFONE2 { get; set; }
        public string FAX { get; set; }
        public string DDD1 { get; set; }
        public string RAMAL1 { get; set; }
        public string RAMAL2 { get; set; }
        public string DDD2 { get; set; }
        public string COBRANCA_ENDERECO { get; set; }
        public string COBRANCA_CIDADE { get; set; }
        public string COBRANCA_BAIRRO { get; set; }
        public string DDDFAX { get; set; }
        public string COBRANCA_UF { get; set; }
        public string COBRANCA_CEP { get; set; }
        public string COBRANCA_TELEFONE { get; set; }
        public string ENTREGA_ENDERECO { get; set; }
        public string ENTREGA_CIDADE { get; set; }
        public string ENTREGA_UF { get; set; }
        public string ENTREGA_BAIRRO { get; set; }
        public string ENTREGA_CEP { get; set; }
        public string ENTREGA_TELEFONE { get; set; }
        public string COBRANCA_DDD { get; set; }
        public string CONTATO { get; set; }
        public string COBRANCA_CGC { get; set; }
        public System.DateTime CADASTRAMENTO { get; set; }
        public string COBRANCA_IE { get; set; }
        public Nullable<System.DateTime> ANIVERSARIO { get; set; }
        public bool INDICA_FORNECEDOR { get; set; }
        public bool INDICA_CLIENTE { get; set; }
        public bool IND_REPRESENTANTE { get; set; }
        public bool INDICA_FILIAL { get; set; }
        public string ENTREGA_DDD { get; set; }
        public string ENTREGA_CGC { get; set; }
        public string ENTREGA_IE { get; set; }
        public string CC_AGENCIA { get; set; }
        public string CC_CONTA { get; set; }
        public string CC_NOME_AGENCIA { get; set; }
        public string REF_ANTERIOR { get; set; }
        public Nullable<System.DateTime> ATUALIZACAO_EXPORTAR { get; set; }
        public Nullable<System.DateTime> DATA_EXPORTACAO { get; set; }
        public string EMAIL { get; set; }
        public string STATUS_ENVIO { get; set; }
        public byte[] TIMESTAMP { get; set; }
        public bool INATIVO { get; set; }
        public Nullable<System.DateTime> DATA_PARA_TRANSFERENCIA { get; set; }
        public string ENTREGA_PAIS { get; set; }
        public string COBRANCA_PAIS { get; set; }
        public string ENTREGA_DDI { get; set; }
        public string COBRANCA_DDI { get; set; }
        public string OBS_DE_FATURAMENTO { get; set; }
        public bool ISENTO_IPI { get; set; }
        public bool ISENTO_ICMS { get; set; }
        public Nullable<decimal> IRRF { get; set; }
        public string MESES_SEM_VENCIMENTO { get; set; }
        public string DATA_FIXA_PGTO { get; set; }
        public Nullable<short> ACEITA_AGRUPAR_FATURA { get; set; }
        public string PASSWEB { get; set; }
        public Nullable<System.DateTime> VENCIMENTO_PASSWEB { get; set; }
        public Nullable<short> NUMERO_VIAS_FATURA { get; set; }
        public string REPORT_FATURA { get; set; }
        public Nullable<short> DIAS_ANTECIPACAO_PGTO { get; set; }
        public Nullable<byte> POSSUI_RECARGO { get; set; }
        public string CODIGO_CHAVE { get; set; }
        public Nullable<short> TIPO_RELACAO_COMERCIAL { get; set; }
        public Nullable<int> ID_CLASIF_CLIFOR { get; set; }
        public string ENTREGA_RAZAO_SOCIAL { get; set; }
        public string COBRANCA_RAZAO_SOCIAL { get; set; }
        public bool ACEITA_DIAS_FIXO { get; set; }
        public string COD_CLIFOR { get; set; }
        public string CTB_CONTA_CONTABIL { get; set; }
        public Nullable<byte> INDICADOR_FISCAL_TERCEIRO { get; set; }
        public Nullable<int> ID_EXCECAO_GRUPO { get; set; }
        public Nullable<short> AGRUPAMENTO_ITENS { get; set; }
        public string CODIGO_CONTATO { get; set; }
        public string IM { get; set; }
        public string IM_ENTREGA { get; set; }
        public string IM_COBRANCA { get; set; }
    
        public virtual FORNECEDORES FORNECEDORES { get; set; }
    }
}
