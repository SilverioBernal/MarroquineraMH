﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orkidea.ComisionesMH.Business;
using Orkidea.ComisionesMH.Entities;

namespace Orkidea.ComisionesMH.UI.Model
{
    public class LojaVenda : LOJA_VENDA
    {
        public decimal SellOutBudgetCompare { get; set; }
        public decimal SellOutBruto { get; set; }
        public decimal sellOutNeto { get; set; }
        public decimal sellOutNetoAdmin { get; set; }
        public decimal vlrImpuestos { get; set; }
        public decimal bonosVendidos { get; set; }
        public decimal bonosRedimidos { get; set; }               
        
        public decimal descuentoTotal { get; set; }
        public decimal pagosTarjeta { get; set; }
        public decimal comisionTarjetas { get; set; }
        public decimal ivaBonosRedimidos { get; set; }
        public decimal ivaBonosVendidos { get; set; }
        public decimal ivaBonosRedimidosAdmin { get; set; }
        public decimal ivaBonosVendidosAdmin { get; set; }

        public decimal comisionVendedor { get; set; }
        public decimal comisionAdministrador { get; set; }

        public decimal porComisionVendedor { get; set; }
        public decimal porComisionAdministrador { get; set; }

        public string nombreVendedor { get; set; }

        /* campos de detalle para el grid... */
        public decimal ventaBrutasSinIva { get; set; }
        public decimal pagosOtrasFormasDePAgo { get; set; }
        public decimal ivaOtrasFormasDePago { get; set; }
        public decimal otrasFormasDePagoSinIva { get; set; }
        public decimal ivaTarjetas { get; set; }
        public decimal pagosTarjetaSinIva { get; set; }

        public decimal porBonosRedimidos { get; set; }
        public decimal porBonosVendidos { get; set; }
        public decimal bonosVendidosSinIva { get; set; }
        public decimal bonosRedimidosSinIva { get; set; }

        public decimal porBonosRedimidosAdmin { get; set; }
        public decimal porBonosVendidosAdmin { get; set; }
        public decimal bonosVendidosSinIvaAdmin { get; set; }
        public decimal bonosRedimidosSinIvaAdmin { get; set; }

        public decimal baseComisionBonosRedimidos { get; set; }
        public decimal baseComisionBonosVendidos { get; set; }
        public decimal baseComision { get; set; }
        /* Fin campos de detalle para el grid... */


        public List<LOJA_VENDA_PRODUTO> lstLojaVendaProduto { get; set; }
        public List<LOJA_VENDA_PGTO> lstLojaVendaPgto { get; set; }
        public List<LOJA_VENDA_PARCELAS> lstLojaVendaParcela { get; set; }

        private BizLojaVenda bizLojaVenda = new BizLojaVenda();
        private BizLojaVendaProduto bizLojaVendaProduto = new BizLojaVendaProduto();
        private BizLojaVendaPgto bizLojaVendaPgto = new BizLojaVendaPgto();

        public LojaVenda(LOJA_VENDA lojaVenda, LojaDefinition lojaDefinition)
        {
            if (lojaDefinition.gerenteLoja != null)
            {
                CODIGO_FILIAL = lojaVenda.CODIGO_FILIAL;
                DATA_VENDA = lojaVenda.DATA_VENDA;
                TICKET = lojaVenda.TICKET;
                VENDEDOR = lojaVenda.VENDEDOR;
                DESCONTO = lojaVenda.DESCONTO;
                VALOR_TIKET = lojaVenda.VALOR_TIKET;
                VALOR_PAGO = lojaVenda.VALOR_PAGO;
                VALOR_VENDA_BRUTA = lojaVenda.VALOR_VENDA_BRUTA;
                VALOR_TROCA = lojaVenda.VALOR_TROCA;
                TERMINAL = lojaVenda.TERMINAL;
                //GERENTE_LOJA = lojaVenda.GERENTE_LOJA;
                GERENTE_PERIODO = lojaDefinition.gerenteLoja.admin; //OJO CORREGIR EXCEPCION DE FALTA DE PARAMETRIZACION;
                LANCAMENTO_CAIXA = lojaVenda.LANCAMENTO_CAIXA;
                nombreVendedor = lojaDefinition.lstvendedores.Where(x => x.VENDEDOR == lojaVenda.VENDEDOR).Select(x => x.NOME_VENDEDOR).FirstOrDefault();

                lstLojaVendaProduto = bizLojaVendaProduto.getLojaVendaProdutoList(lojaVenda);
                lstLojaVendaPgto = bizLojaVendaPgto.getLojaVendaPgtoList(lojaVenda);

                CalculateCardCommission(lojaDefinition);

                SellOutBudgetCompare = SellOutBruto - (bonosVendidos + (VALOR_TROCA == null ? 0 : (decimal)VALOR_TROCA) + descuentoTotal + vlrImpuestos);
            }
            else
            {
                throw new Exception("No tiene asociado un administrador a la tienda ");
            }
        }

        public void CalculateCardCommission(LojaDefinition lojaDefinition)
        {
            try
            {
                descuentoTotal = DESCONTO != null ? (decimal)DESCONTO : 0;
                pagosTarjeta = 0;
                bonosRedimidos = 0;
                ivaTarjetas = 0;

                

                foreach (LOJA_VENDA_PRODUTO item in lstLojaVendaProduto)
                {
                    if (item.QTDE_BRINDE == 0)
                    {
                        decimal precio = (decimal)item.PRECO_LIQUIDO * (decimal)item.QTDE;

                        /* Bonos vendidos */
                        if (lojaDefinition.lstProdBonos.Where(x => x.PRODUTO == item.PRODUTO.Trim()).Count() > 0)
                        {
                            bonosVendidos += precio;
                            ivaBonosVendidos = 0; //(precio * (decimal)lojaDefinition.IVA) / (100 + lojaDefinition.IVA);
                        }
                        //else
                        //{
                        SellOutBruto += precio;
                        vlrImpuestos += (precio * lojaDefinition.IVA) / (100 + lojaDefinition.IVA);
                        //}

                        /* descuentos por item */
                        if (item.DESCONTO_ITEM != null)
                            descuentoTotal += (decimal)item.DESCONTO_ITEM;
                    }
                }

                
                foreach (LOJA_VENDA_PGTO item in lstLojaVendaPgto)
                {
                    foreach (LOJA_VENDA_PARCELAS itemParcelas in item.LOJA_VENDA_PARCELAS)
                    {
                        /* Comisiones de tarjeta */
                        if (itemParcelas.CODIGO_ADMINISTRADORA != null)
                        {
                            decimal? porComision = lojaDefinition.lstAdministradorasCartao.Where(x => x.CODIGO_ADMINISTRADORA == itemParcelas.CODIGO_ADMINISTRADORA).Select(x => x.TAXA_ADMINISTRACAO).FirstOrDefault();
                            pagosTarjeta += (decimal)itemParcelas.VALOR;

                            comisionTarjetas += ((decimal)itemParcelas.VALOR * (decimal)(porComision != null ? porComision : 0)) / 100;
                            ivaTarjetas += ((decimal)itemParcelas.VALOR * (decimal)lojaDefinition.IVA) / (100 + lojaDefinition.IVA);
                        }

                        /* pagos con bonos */
                        if (lojaDefinition.lstTiposPgtoBonos.Where(x => x.TIPO_PGTO == itemParcelas.TIPO_PGTO).Count() > 0)
                        {
                            bonosRedimidos += (decimal)itemParcelas.VALOR;
                            ivaBonosRedimidos += ((decimal)itemParcelas.VALOR * (decimal)lojaDefinition.IVA) / (100 + lojaDefinition.IVA);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
