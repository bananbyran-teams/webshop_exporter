using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderDetail
    {
        public int IdOrderDetail { get; set; }
        public int IdOrder { get; set; }
        public int IdOrderInvoice { get; set; }
        public int? IdWarehouse { get; set; }
        public int IdShop { get; set; }
        public int ProductId { get; set; }
        public int? ProductAttributeId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductQuantityInStock { get; set; }
        public int ProductQuantityRefunded { get; set; }
        public int ProductQuantityReturn { get; set; }
        public int ProductQuantityReinjected { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ReductionPercent { get; set; }
        public decimal ReductionAmount { get; set; }
        public decimal ReductionAmountTaxIncl { get; set; }
        public decimal ReductionAmountTaxExcl { get; set; }
        public decimal GroupReduction { get; set; }
        public decimal ProductQuantityDiscount { get; set; }
        public string ProductEan13 { get; set; }
        public string ProductUpc { get; set; }
        public string ProductReference { get; set; }
        public string ProductSupplierReference { get; set; }
        public decimal ProductWeight { get; set; }
        public byte TaxComputationMethod { get; set; }
        public string TaxName { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Ecotax { get; set; }
        public decimal EcotaxTaxRate { get; set; }
        public byte DiscountQuantityApplied { get; set; }
        public string DownloadHash { get; set; }
        public int? DownloadNb { get; set; }
        public DateTime? DownloadDeadline { get; set; }
        public decimal TotalPriceTaxIncl { get; set; }
        public decimal TotalPriceTaxExcl { get; set; }
        public decimal UnitPriceTaxIncl { get; set; }
        public decimal UnitPriceTaxExcl { get; set; }
        public decimal TotalShippingPriceTaxIncl { get; set; }
        public decimal TotalShippingPriceTaxExcl { get; set; }
        public decimal PurchaseSupplierPrice { get; set; }
        public decimal OriginalProductPrice { get; set; }
        public string ScAttrInfosV1 { get; set; }
        public decimal OriginalWholesalePrice { get; set; }
    }
}
