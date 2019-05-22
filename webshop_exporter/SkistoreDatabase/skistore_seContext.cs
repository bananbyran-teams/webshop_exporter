using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class skistore_seContext : DbContext
    {
        public skistore_seContext()
        {
        }

        public skistore_seContext(DbContextOptions<skistore_seContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PsAccess> PsAccess { get; set; }
        public virtual DbSet<PsAddress> PsAddress { get; set; }
        public virtual DbSet<PsAddressFormat> PsAddressFormat { get; set; }
        public virtual DbSet<PsAdvancedexport> PsAdvancedexport { get; set; }
        public virtual DbSet<PsAjaxFilters> PsAjaxFilters { get; set; }
        public virtual DbSet<PsAlias> PsAlias { get; set; }
        public virtual DbSet<PsAttachment> PsAttachment { get; set; }
        public virtual DbSet<PsAttachmentLang> PsAttachmentLang { get; set; }
        public virtual DbSet<PsAttribute> PsAttribute { get; set; }
        public virtual DbSet<PsAttributeGroup> PsAttributeGroup { get; set; }
        public virtual DbSet<PsAttributeGroupLang> PsAttributeGroupLang { get; set; }
        public virtual DbSet<PsAttributeGroupShop> PsAttributeGroupShop { get; set; }
        public virtual DbSet<PsAttributeImpact> PsAttributeImpact { get; set; }
        public virtual DbSet<PsAttributeLang> PsAttributeLang { get; set; }
        public virtual DbSet<PsAttributeShop> PsAttributeShop { get; set; }
        public virtual DbSet<PsBdDiscount> PsBdDiscount { get; set; }
        public virtual DbSet<PsBlocklinkShop> PsBlocklinkShop { get; set; }
        public virtual DbSet<PsCarrier> PsCarrier { get; set; }
        public virtual DbSet<PsCarrierLang> PsCarrierLang { get; set; }
        public virtual DbSet<PsCarrierShop> PsCarrierShop { get; set; }
        public virtual DbSet<PsCarrierTaxRulesGroupShop> PsCarrierTaxRulesGroupShop { get; set; }
        public virtual DbSet<PsCarrierZone> PsCarrierZone { get; set; }
        public virtual DbSet<PsCart> PsCart { get; set; }
        public virtual DbSet<PsCartRule> PsCartRule { get; set; }
        public virtual DbSet<PsCartRuleCarrier> PsCartRuleCarrier { get; set; }
        public virtual DbSet<PsCartRuleCombination> PsCartRuleCombination { get; set; }
        public virtual DbSet<PsCartRuleCountry> PsCartRuleCountry { get; set; }
        public virtual DbSet<PsCartRuleGroup> PsCartRuleGroup { get; set; }
        public virtual DbSet<PsCartRuleLang> PsCartRuleLang { get; set; }
        public virtual DbSet<PsCartRuleProductRule> PsCartRuleProductRule { get; set; }
        public virtual DbSet<PsCartRuleProductRuleGroup> PsCartRuleProductRuleGroup { get; set; }
        public virtual DbSet<PsCartRuleProductRuleValue> PsCartRuleProductRuleValue { get; set; }
        public virtual DbSet<PsCartRuleShop> PsCartRuleShop { get; set; }
        public virtual DbSet<PsCategory> PsCategory { get; set; }
        public virtual DbSet<PsCategoryLang> PsCategoryLang { get; set; }
        public virtual DbSet<PsCategoryProduct> PsCategoryProduct { get; set; }
        public virtual DbSet<PsCategoryShop> PsCategoryShop { get; set; }
        public virtual DbSet<PsCms> PsCms { get; set; }
        public virtual DbSet<PsCmsBlock> PsCmsBlock { get; set; }
        public virtual DbSet<PsCmsBlockLang> PsCmsBlockLang { get; set; }
        public virtual DbSet<PsCmsBlockPage> PsCmsBlockPage { get; set; }
        public virtual DbSet<PsCmsBlockShop> PsCmsBlockShop { get; set; }
        public virtual DbSet<PsCmsCategory> PsCmsCategory { get; set; }
        public virtual DbSet<PsCmsCategoryLang> PsCmsCategoryLang { get; set; }
        public virtual DbSet<PsCmsLang> PsCmsLang { get; set; }
        public virtual DbSet<PsCmsShop> PsCmsShop { get; set; }
        public virtual DbSet<PsCompare> PsCompare { get; set; }
        public virtual DbSet<PsCompareProduct> PsCompareProduct { get; set; }
        public virtual DbSet<PsConfiguration> PsConfiguration { get; set; }
        public virtual DbSet<PsConfigurationKpi> PsConfigurationKpi { get; set; }
        public virtual DbSet<PsConfigurationKpiLang> PsConfigurationKpiLang { get; set; }
        public virtual DbSet<PsConfigurationLang> PsConfigurationLang { get; set; }
        public virtual DbSet<PsConnections> PsConnections { get; set; }
        public virtual DbSet<PsConnectionsPage> PsConnectionsPage { get; set; }
        public virtual DbSet<PsConnectionsSource> PsConnectionsSource { get; set; }
        public virtual DbSet<PsContact> PsContact { get; set; }
        public virtual DbSet<PsContactShop> PsContactShop { get; set; }
        public virtual DbSet<PsCountry> PsCountry { get; set; }
        public virtual DbSet<PsCountryShop> PsCountryShop { get; set; }
        public virtual DbSet<PsCronjobs> PsCronjobs { get; set; }
        public virtual DbSet<PsCsslider> PsCsslider { get; set; }
        public virtual DbSet<PsCurrency> PsCurrency { get; set; }
        public virtual DbSet<PsCurrencyShop> PsCurrencyShop { get; set; }
        public virtual DbSet<PsCustomer> PsCustomer { get; set; }
        public virtual DbSet<PsCustomerGroup> PsCustomerGroup { get; set; }
        public virtual DbSet<PsCustomerMessage> PsCustomerMessage { get; set; }
        public virtual DbSet<PsCustomerThread> PsCustomerThread { get; set; }
        public virtual DbSet<PsCustomization> PsCustomization { get; set; }
        public virtual DbSet<PsCustomizationField> PsCustomizationField { get; set; }
        public virtual DbSet<PsCustomizationFieldLang> PsCustomizationFieldLang { get; set; }
        public virtual DbSet<PsCustomizedData> PsCustomizedData { get; set; }
        public virtual DbSet<PsDateRange> PsDateRange { get; set; }
        public virtual DbSet<PsDelivery> PsDelivery { get; set; }
        public virtual DbSet<PsDibsSecurity> PsDibsSecurity { get; set; }
        public virtual DbSet<PsDibsSimplifiedCheckout> PsDibsSimplifiedCheckout { get; set; }
        public virtual DbSet<PsEditorial> PsEditorial { get; set; }
        public virtual DbSet<PsEditorialLang> PsEditorialLang { get; set; }
        public virtual DbSet<PsEmployee> PsEmployee { get; set; }
        public virtual DbSet<PsEmployeeShop> PsEmployeeShop { get; set; }
        public virtual DbSet<PsFeature> PsFeature { get; set; }
        public virtual DbSet<PsFeatureLang> PsFeatureLang { get; set; }
        public virtual DbSet<PsFeatureProduct> PsFeatureProduct { get; set; }
        public virtual DbSet<PsFeatureShop> PsFeatureShop { get; set; }
        public virtual DbSet<PsFeatureValue> PsFeatureValue { get; set; }
        public virtual DbSet<PsFeatureValueLang> PsFeatureValueLang { get; set; }
        public virtual DbSet<PsGender> PsGender { get; set; }
        public virtual DbSet<PsGenderLang> PsGenderLang { get; set; }
        public virtual DbSet<PsGiftCard> PsGiftCard { get; set; }
        public virtual DbSet<PsGmcFeaturesByCat> PsGmcFeaturesByCat { get; set; }
        public virtual DbSet<PsGmcTags> PsGmcTags { get; set; }
        public virtual DbSet<PsGmcTaxonomy> PsGmcTaxonomy { get; set; }
        public virtual DbSet<PsGroup> PsGroup { get; set; }
        public virtual DbSet<PsGroupReduction> PsGroupReduction { get; set; }
        public virtual DbSet<PsGroupShop> PsGroupShop { get; set; }
        public virtual DbSet<PsGuest> PsGuest { get; set; }
        public virtual DbSet<PsHomeslider> PsHomeslider { get; set; }
        public virtual DbSet<PsHomesliderSlides> PsHomesliderSlides { get; set; }
        public virtual DbSet<PsHomesliderSlidesLang> PsHomesliderSlidesLang { get; set; }
        public virtual DbSet<PsHook> PsHook { get; set; }
        public virtual DbSet<PsHookAlias> PsHookAlias { get; set; }
        public virtual DbSet<PsHookModule> PsHookModule { get; set; }
        public virtual DbSet<PsHookModuleExceptions> PsHookModuleExceptions { get; set; }
        public virtual DbSet<PsImage> PsImage { get; set; }
        public virtual DbSet<PsImageType> PsImageType { get; set; }
        public virtual DbSet<PsImportMatch> PsImportMatch { get; set; }
        public virtual DbSet<PsInfo> PsInfo { get; set; }
        public virtual DbSet<PsInfoLang> PsInfoLang { get; set; }
        public virtual DbSet<PsJqzoomconfig> PsJqzoomconfig { get; set; }
        public virtual DbSet<PsKlarnaErrors> PsKlarnaErrors { get; set; }
        public virtual DbSet<PsKlarnaOrders> PsKlarnaOrders { get; set; }
        public virtual DbSet<PsLang> PsLang { get; set; }
        public virtual DbSet<PsLangShop> PsLangShop { get; set; }
        public virtual DbSet<PsLayeredCategory> PsLayeredCategory { get; set; }
        public virtual DbSet<PsLayeredFilter> PsLayeredFilter { get; set; }
        public virtual DbSet<PsLayeredFilterShop> PsLayeredFilterShop { get; set; }
        public virtual DbSet<PsLayeredFriendlyUrl> PsLayeredFriendlyUrl { get; set; }
        public virtual DbSet<PsLayeredIndexableAttributeGroup> PsLayeredIndexableAttributeGroup { get; set; }
        public virtual DbSet<PsLayeredIndexableAttributeGroupLangValue> PsLayeredIndexableAttributeGroupLangValue { get; set; }
        public virtual DbSet<PsLayeredIndexableAttributeLangValue> PsLayeredIndexableAttributeLangValue { get; set; }
        public virtual DbSet<PsLayeredIndexableFeature> PsLayeredIndexableFeature { get; set; }
        public virtual DbSet<PsLayeredIndexableFeatureLangValue> PsLayeredIndexableFeatureLangValue { get; set; }
        public virtual DbSet<PsLayeredIndexableFeatureValueLangValue> PsLayeredIndexableFeatureValueLangValue { get; set; }
        public virtual DbSet<PsLayeredPriceIndex> PsLayeredPriceIndex { get; set; }
        public virtual DbSet<PsLengowLogsImport> PsLengowLogsImport { get; set; }
        public virtual DbSet<PsLengowOrderLine> PsLengowOrderLine { get; set; }
        public virtual DbSet<PsLengowOrders> PsLengowOrders { get; set; }
        public virtual DbSet<PsLengowProduct> PsLengowProduct { get; set; }
        public virtual DbSet<PsLinksmenutop> PsLinksmenutop { get; set; }
        public virtual DbSet<PsLog> PsLog { get; set; }
        public virtual DbSet<PsLoyalty> PsLoyalty { get; set; }
        public virtual DbSet<PsLoyaltyHistory> PsLoyaltyHistory { get; set; }
        public virtual DbSet<PsLoyaltyState> PsLoyaltyState { get; set; }
        public virtual DbSet<PsMailalertCustomerOos> PsMailalertCustomerOos { get; set; }
        public virtual DbSet<PsManufacturer> PsManufacturer { get; set; }
        public virtual DbSet<PsManufacturerLang> PsManufacturerLang { get; set; }
        public virtual DbSet<PsManufacturerShop> PsManufacturerShop { get; set; }
        public virtual DbSet<PsMemcachedServers> PsMemcachedServers { get; set; }
        public virtual DbSet<PsMessage> PsMessage { get; set; }
        public virtual DbSet<PsMessageReaded> PsMessageReaded { get; set; }
        public virtual DbSet<PsMeta> PsMeta { get; set; }
        public virtual DbSet<PsMetaLang> PsMetaLang { get; set; }
        public virtual DbSet<PsModule> PsModule { get; set; }
        public virtual DbSet<PsModuleAccess> PsModuleAccess { get; set; }
        public virtual DbSet<PsModuleCountry> PsModuleCountry { get; set; }
        public virtual DbSet<PsModuleCurrency> PsModuleCurrency { get; set; }
        public virtual DbSet<PsModuleGroup> PsModuleGroup { get; set; }
        public virtual DbSet<PsModulePreference> PsModulePreference { get; set; }
        public virtual DbSet<PsModuleShop> PsModuleShop { get; set; }
        public virtual DbSet<PsNewsletter> PsNewsletter { get; set; }
        public virtual DbSet<PsNostotaggingCustomerLink> PsNostotaggingCustomerLink { get; set; }
        public virtual DbSet<PsNostotaggingCustomerReference> PsNostotaggingCustomerReference { get; set; }
        public virtual DbSet<PsOperatingSystem> PsOperatingSystem { get; set; }
        public virtual DbSet<PsOrderCarrier> PsOrderCarrier { get; set; }
        public virtual DbSet<PsOrderCartRule> PsOrderCartRule { get; set; }
        public virtual DbSet<PsOrderDetail> PsOrderDetail { get; set; }
        public virtual DbSet<PsOrderDiscount> PsOrderDiscount { get; set; }
        public virtual DbSet<PsOrderHistory> PsOrderHistory { get; set; }
        public virtual DbSet<PsOrderInvoice> PsOrderInvoice { get; set; }
        public virtual DbSet<PsOrderInvoicePayment> PsOrderInvoicePayment { get; set; }
        public virtual DbSet<PsOrderMessage> PsOrderMessage { get; set; }
        public virtual DbSet<PsOrderMessageLang> PsOrderMessageLang { get; set; }
        public virtual DbSet<PsOrderPayment> PsOrderPayment { get; set; }
        public virtual DbSet<PsOrderReturn> PsOrderReturn { get; set; }
        public virtual DbSet<PsOrderReturnDetail> PsOrderReturnDetail { get; set; }
        public virtual DbSet<PsOrderReturnState> PsOrderReturnState { get; set; }
        public virtual DbSet<PsOrderSlip> PsOrderSlip { get; set; }
        public virtual DbSet<PsOrderSlipDetail> PsOrderSlipDetail { get; set; }
        public virtual DbSet<PsOrderState> PsOrderState { get; set; }
        public virtual DbSet<PsOrders> PsOrders { get; set; }
        public virtual DbSet<PsPack> PsPack { get; set; }
        public virtual DbSet<PsPage> PsPage { get; set; }
        public virtual DbSet<PsPageType> PsPageType { get; set; }
        public virtual DbSet<PsPageViewed> PsPageViewed { get; set; }
        public virtual DbSet<PsPagenotfound> PsPagenotfound { get; set; }
        public virtual DbSet<PsPaymentCc> PsPaymentCc { get; set; }
        public virtual DbSet<PsPaypalCustomer> PsPaypalCustomer { get; set; }
        public virtual DbSet<PsPaypalOrder> PsPaypalOrder { get; set; }
        public virtual DbSet<PsPetTab> PsPetTab { get; set; }
        public virtual DbSet<PsPetTabContent> PsPetTabContent { get; set; }
        public virtual DbSet<PsPmAdsandslideshow> PsPmAdsandslideshow { get; set; }
        public virtual DbSet<PsPmAdsandslideshowAutoConf> PsPmAdsandslideshowAutoConf { get; set; }
        public virtual DbSet<PsPmAdsandslideshowElement> PsPmAdsandslideshowElement { get; set; }
        public virtual DbSet<PsPmAdvancedsearch> PsPmAdvancedsearch { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProduct1> PsPmAdvancedsearchCacheProduct1 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProduct2> PsPmAdvancedsearchCacheProduct2 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProduct3> PsPmAdvancedsearchCacheProduct3 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProduct4> PsPmAdvancedsearchCacheProduct4 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProduct5> PsPmAdvancedsearchCacheProduct5 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProduct6> PsPmAdvancedsearchCacheProduct6 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProduct7> PsPmAdvancedsearchCacheProduct7 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProductCriterion1> PsPmAdvancedsearchCacheProductCriterion1 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProductCriterion2> PsPmAdvancedsearchCacheProductCriterion2 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProductCriterion3> PsPmAdvancedsearchCacheProductCriterion3 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProductCriterion4> PsPmAdvancedsearchCacheProductCriterion4 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProductCriterion5> PsPmAdvancedsearchCacheProductCriterion5 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProductCriterion6> PsPmAdvancedsearchCacheProductCriterion6 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCacheProductCriterion7> PsPmAdvancedsearchCacheProductCriterion7 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCategory> PsPmAdvancedsearchCategory { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCms> PsPmAdvancedsearchCms { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion1> PsPmAdvancedsearchCriterion1 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion1Lang> PsPmAdvancedsearchCriterion1Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion1Link> PsPmAdvancedsearchCriterion1Link { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion1List> PsPmAdvancedsearchCriterion1List { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion2> PsPmAdvancedsearchCriterion2 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion2Lang> PsPmAdvancedsearchCriterion2Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion2Link> PsPmAdvancedsearchCriterion2Link { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion2List> PsPmAdvancedsearchCriterion2List { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion3> PsPmAdvancedsearchCriterion3 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion3Lang> PsPmAdvancedsearchCriterion3Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion3Link> PsPmAdvancedsearchCriterion3Link { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion3List> PsPmAdvancedsearchCriterion3List { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion4> PsPmAdvancedsearchCriterion4 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion4Lang> PsPmAdvancedsearchCriterion4Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion4Link> PsPmAdvancedsearchCriterion4Link { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion4List> PsPmAdvancedsearchCriterion4List { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion5> PsPmAdvancedsearchCriterion5 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion5Lang> PsPmAdvancedsearchCriterion5Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion5Link> PsPmAdvancedsearchCriterion5Link { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion5List> PsPmAdvancedsearchCriterion5List { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion6> PsPmAdvancedsearchCriterion6 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion6Lang> PsPmAdvancedsearchCriterion6Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion6Link> PsPmAdvancedsearchCriterion6Link { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion6List> PsPmAdvancedsearchCriterion6List { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion7> PsPmAdvancedsearchCriterion7 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion7Lang> PsPmAdvancedsearchCriterion7Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion7Link> PsPmAdvancedsearchCriterion7Link { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterion7List> PsPmAdvancedsearchCriterion7List { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup1> PsPmAdvancedsearchCriterionGroup1 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup1Lang> PsPmAdvancedsearchCriterionGroup1Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup2> PsPmAdvancedsearchCriterionGroup2 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup2Lang> PsPmAdvancedsearchCriterionGroup2Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup3> PsPmAdvancedsearchCriterionGroup3 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup3Lang> PsPmAdvancedsearchCriterionGroup3Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup4> PsPmAdvancedsearchCriterionGroup4 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup4Lang> PsPmAdvancedsearchCriterionGroup4Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup5> PsPmAdvancedsearchCriterionGroup5 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup5Lang> PsPmAdvancedsearchCriterionGroup5Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup6> PsPmAdvancedsearchCriterionGroup6 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup6Lang> PsPmAdvancedsearchCriterionGroup6Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup7> PsPmAdvancedsearchCriterionGroup7 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchCriterionGroup7Lang> PsPmAdvancedsearchCriterionGroup7Lang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchLang> PsPmAdvancedsearchLang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchManufacturers> PsPmAdvancedsearchManufacturers { get; set; }
        public virtual DbSet<PsPmAdvancedsearchProductPrice1> PsPmAdvancedsearchProductPrice1 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchProductPrice2> PsPmAdvancedsearchProductPrice2 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchProductPrice3> PsPmAdvancedsearchProductPrice3 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchProductPrice4> PsPmAdvancedsearchProductPrice4 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchProductPrice5> PsPmAdvancedsearchProductPrice5 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchProductPrice6> PsPmAdvancedsearchProductPrice6 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchProductPrice7> PsPmAdvancedsearchProductPrice7 { get; set; }
        public virtual DbSet<PsPmAdvancedsearchProducts> PsPmAdvancedsearchProducts { get; set; }
        public virtual DbSet<PsPmAdvancedsearchSeo> PsPmAdvancedsearchSeo { get; set; }
        public virtual DbSet<PsPmAdvancedsearchSeoCrosslinks> PsPmAdvancedsearchSeoCrosslinks { get; set; }
        public virtual DbSet<PsPmAdvancedsearchSeoLang> PsPmAdvancedsearchSeoLang { get; set; }
        public virtual DbSet<PsPmAdvancedsearchShop> PsPmAdvancedsearchShop { get; set; }
        public virtual DbSet<PsPmAdvancedsearchSpecialPages> PsPmAdvancedsearchSpecialPages { get; set; }
        public virtual DbSet<PsPmAdvancedsearchSuppliers> PsPmAdvancedsearchSuppliers { get; set; }
        public virtual DbSet<PsProdtabs> PsProdtabs { get; set; }
        public virtual DbSet<PsProduct> PsProduct { get; set; }
        public virtual DbSet<PsProductAttachment> PsProductAttachment { get; set; }
        public virtual DbSet<PsProductAttribute> PsProductAttribute { get; set; }
        public virtual DbSet<PsProductAttributeCombination> PsProductAttributeCombination { get; set; }
        public virtual DbSet<PsProductAttributeImage> PsProductAttributeImage { get; set; }
        public virtual DbSet<PsProductAttributeShop> PsProductAttributeShop { get; set; }
        public virtual DbSet<PsProductCarrier> PsProductCarrier { get; set; }
        public virtual DbSet<PsProductComment> PsProductComment { get; set; }
        public virtual DbSet<PsProductCommentCriterion> PsProductCommentCriterion { get; set; }
        public virtual DbSet<PsProductCommentCriterionCategory> PsProductCommentCriterionCategory { get; set; }
        public virtual DbSet<PsProductCommentCriterionLang> PsProductCommentCriterionLang { get; set; }
        public virtual DbSet<PsProductCommentCriterionProduct> PsProductCommentCriterionProduct { get; set; }
        public virtual DbSet<PsProductCommentGrade> PsProductCommentGrade { get; set; }
        public virtual DbSet<PsProductCommentReport> PsProductCommentReport { get; set; }
        public virtual DbSet<PsProductCommentUsefulness> PsProductCommentUsefulness { get; set; }
        public virtual DbSet<PsProductDownload> PsProductDownload { get; set; }
        public virtual DbSet<PsProductFaq> PsProductFaq { get; set; }
        public virtual DbSet<PsProductGroupReductionCache> PsProductGroupReductionCache { get; set; }
        public virtual DbSet<PsProductLang> PsProductLang { get; set; }
        public virtual DbSet<PsProductSale> PsProductSale { get; set; }
        public virtual DbSet<PsProductShop> PsProductShop { get; set; }
        public virtual DbSet<PsProductSupplier> PsProductSupplier { get; set; }
        public virtual DbSet<PsProductTag> PsProductTag { get; set; }
        public virtual DbSet<PsProfile> PsProfile { get; set; }
        public virtual DbSet<PsProfileLang> PsProfileLang { get; set; }
        public virtual DbSet<PsPsgdprConsent> PsPsgdprConsent { get; set; }
        public virtual DbSet<PsPsgdprConsentLang> PsPsgdprConsentLang { get; set; }
        public virtual DbSet<PsPsgdprLog> PsPsgdprLog { get; set; }
        public virtual DbSet<PsQuickAccess> PsQuickAccess { get; set; }
        public virtual DbSet<PsQuickAccessLang> PsQuickAccessLang { get; set; }
        public virtual DbSet<PsRangePrice> PsRangePrice { get; set; }
        public virtual DbSet<PsRangeWeight> PsRangeWeight { get; set; }
        public virtual DbSet<PsRcPgtagmanagerOrdersSent> PsRcPgtagmanagerOrdersSent { get; set; }
        public virtual DbSet<PsReferrer> PsReferrer { get; set; }
        public virtual DbSet<PsReferrerCache> PsReferrerCache { get; set; }
        public virtual DbSet<PsReferrerShop> PsReferrerShop { get; set; }
        public virtual DbSet<PsRequestSql> PsRequestSql { get; set; }
        public virtual DbSet<PsRequiredField> PsRequiredField { get; set; }
        public virtual DbSet<PsRisk> PsRisk { get; set; }
        public virtual DbSet<PsRiskLang> PsRiskLang { get; set; }
        public virtual DbSet<PsScExport> PsScExport { get; set; }
        public virtual DbSet<PsScExportProduct> PsScExportProduct { get; set; }
        public virtual DbSet<PsScQueueLog> PsScQueueLog { get; set; }
        public virtual DbSet<PsScene> PsScene { get; set; }
        public virtual DbSet<PsSceneCategory> PsSceneCategory { get; set; }
        public virtual DbSet<PsSceneLang> PsSceneLang { get; set; }
        public virtual DbSet<PsSceneProducts> PsSceneProducts { get; set; }
        public virtual DbSet<PsSceneShop> PsSceneShop { get; set; }
        public virtual DbSet<PsSearchEngine> PsSearchEngine { get; set; }
        public virtual DbSet<PsSearchIndex> PsSearchIndex { get; set; }
        public virtual DbSet<PsSearchWord> PsSearchWord { get; set; }
        public virtual DbSet<PsSekeyword> PsSekeyword { get; set; }
        public virtual DbSet<PsShop> PsShop { get; set; }
        public virtual DbSet<PsShopGroup> PsShopGroup { get; set; }
        public virtual DbSet<PsShopUrl> PsShopUrl { get; set; }
        public virtual DbSet<PsSpecificPrice> PsSpecificPrice { get; set; }
        public virtual DbSet<PsSpecificPricePriority> PsSpecificPricePriority { get; set; }
        public virtual DbSet<PsSpecificPriceRule> PsSpecificPriceRule { get; set; }
        public virtual DbSet<PsSpecificPriceRuleCondition> PsSpecificPriceRuleCondition { get; set; }
        public virtual DbSet<PsSpecificPriceRuleConditionGroup> PsSpecificPriceRuleConditionGroup { get; set; }
        public virtual DbSet<PsSpecterdata> PsSpecterdata { get; set; }
        public virtual DbSet<PsStBanner> PsStBanner { get; set; }
        public virtual DbSet<PsStBannerGroup> PsStBannerGroup { get; set; }
        public virtual DbSet<PsStBannerGroupShop> PsStBannerGroupShop { get; set; }
        public virtual DbSet<PsStBannerLang> PsStBannerLang { get; set; }
        public virtual DbSet<PsStBlog> PsStBlog { get; set; }
        public virtual DbSet<PsStBlogCategory> PsStBlogCategory { get; set; }
        public virtual DbSet<PsStBlogCategoryBlog> PsStBlogCategoryBlog { get; set; }
        public virtual DbSet<PsStBlogCategoryLang> PsStBlogCategoryLang { get; set; }
        public virtual DbSet<PsStBlogCategoryShop> PsStBlogCategoryShop { get; set; }
        public virtual DbSet<PsStBlogComment> PsStBlogComment { get; set; }
        public virtual DbSet<PsStBlogImage> PsStBlogImage { get; set; }
        public virtual DbSet<PsStBlogImageLang> PsStBlogImageLang { get; set; }
        public virtual DbSet<PsStBlogLang> PsStBlogLang { get; set; }
        public virtual DbSet<PsStBlogProductLink> PsStBlogProductLink { get; set; }
        public virtual DbSet<PsStBlogShop> PsStBlogShop { get; set; }
        public virtual DbSet<PsStBlogTag> PsStBlogTag { get; set; }
        public virtual DbSet<PsStBlogTagMap> PsStBlogTagMap { get; set; }
        public virtual DbSet<PsStBrandsSlider> PsStBrandsSlider { get; set; }
        public virtual DbSet<PsStCameraSlideshow> PsStCameraSlideshow { get; set; }
        public virtual DbSet<PsStCameraSlideshowGroup> PsStCameraSlideshowGroup { get; set; }
        public virtual DbSet<PsStCameraSlideshowGroupShop> PsStCameraSlideshowGroupShop { get; set; }
        public virtual DbSet<PsStCameraSlideshowLang> PsStCameraSlideshowLang { get; set; }
        public virtual DbSet<PsStEasyContent> PsStEasyContent { get; set; }
        public virtual DbSet<PsStEasyContentLang> PsStEasyContentLang { get; set; }
        public virtual DbSet<PsStEasyContentShop> PsStEasyContentShop { get; set; }
        public virtual DbSet<PsStEasyTabs> PsStEasyTabs { get; set; }
        public virtual DbSet<PsStEasyTabsLang> PsStEasyTabsLang { get; set; }
        public virtual DbSet<PsStFeaturedCategory> PsStFeaturedCategory { get; set; }
        public virtual DbSet<PsStIosslider> PsStIosslider { get; set; }
        public virtual DbSet<PsStIossliderGroup> PsStIossliderGroup { get; set; }
        public virtual DbSet<PsStIossliderGroupShop> PsStIossliderGroupShop { get; set; }
        public virtual DbSet<PsStIossliderLang> PsStIossliderLang { get; set; }
        public virtual DbSet<PsStMegaMenu> PsStMegaMenu { get; set; }
        public virtual DbSet<PsStMegaMenuLang> PsStMegaMenuLang { get; set; }
        public virtual DbSet<PsStMultiLink> PsStMultiLink { get; set; }
        public virtual DbSet<PsStMultiLinkGroup> PsStMultiLinkGroup { get; set; }
        public virtual DbSet<PsStMultiLinkGroupLang> PsStMultiLinkGroupLang { get; set; }
        public virtual DbSet<PsStMultiLinkGroupShop> PsStMultiLinkGroupShop { get; set; }
        public virtual DbSet<PsStMultiLinkLang> PsStMultiLinkLang { get; set; }
        public virtual DbSet<PsStProductCategoriesSlider> PsStProductCategoriesSlider { get; set; }
        public virtual DbSet<PsStRelatedProducts> PsStRelatedProducts { get; set; }
        public virtual DbSet<PsState> PsState { get; set; }
        public virtual DbSet<PsStaticblock> PsStaticblock { get; set; }
        public virtual DbSet<PsStatssearch> PsStatssearch { get; set; }
        public virtual DbSet<PsStock> PsStock { get; set; }
        public virtual DbSet<PsStockAvailable> PsStockAvailable { get; set; }
        public virtual DbSet<PsStockMvt> PsStockMvt { get; set; }
        public virtual DbSet<PsStockMvtReason> PsStockMvtReason { get; set; }
        public virtual DbSet<PsStockMvtReasonLang> PsStockMvtReasonLang { get; set; }
        public virtual DbSet<PsStore> PsStore { get; set; }
        public virtual DbSet<PsStoreShop> PsStoreShop { get; set; }
        public virtual DbSet<PsStorecomHistory> PsStorecomHistory { get; set; }
        public virtual DbSet<PsSupplier> PsSupplier { get; set; }
        public virtual DbSet<PsSupplierLang> PsSupplierLang { get; set; }
        public virtual DbSet<PsSupplierShop> PsSupplierShop { get; set; }
        public virtual DbSet<PsSupplyOrder> PsSupplyOrder { get; set; }
        public virtual DbSet<PsSupplyOrderDetail> PsSupplyOrderDetail { get; set; }
        public virtual DbSet<PsSupplyOrderHistory> PsSupplyOrderHistory { get; set; }
        public virtual DbSet<PsSupplyOrderReceiptHistory> PsSupplyOrderReceiptHistory { get; set; }
        public virtual DbSet<PsSupplyOrderState> PsSupplyOrderState { get; set; }
        public virtual DbSet<PsSupplyOrderStateLang> PsSupplyOrderStateLang { get; set; }
        public virtual DbSet<PsTab> PsTab { get; set; }
        public virtual DbSet<PsTabLang> PsTabLang { get; set; }
        public virtual DbSet<PsTabModulePreference> PsTabModulePreference { get; set; }
        public virtual DbSet<PsTag> PsTag { get; set; }
        public virtual DbSet<PsTax> PsTax { get; set; }
        public virtual DbSet<PsTaxRule> PsTaxRule { get; set; }
        public virtual DbSet<PsTaxRulesGroup> PsTaxRulesGroup { get; set; }
        public virtual DbSet<PsTaxRulesGroupShop> PsTaxRulesGroupShop { get; set; }
        public virtual DbSet<PsTheme> PsTheme { get; set; }
        public virtual DbSet<PsThemeMeta> PsThemeMeta { get; set; }
        public virtual DbSet<PsThemeSpecific> PsThemeSpecific { get; set; }
        public virtual DbSet<PsThemeconfigurator> PsThemeconfigurator { get; set; }
        public virtual DbSet<PsTimezone> PsTimezone { get; set; }
        public virtual DbSet<PsWarehouse> PsWarehouse { get; set; }
        public virtual DbSet<PsWarehouseCarrier> PsWarehouseCarrier { get; set; }
        public virtual DbSet<PsWarehouseProductLocation> PsWarehouseProductLocation { get; set; }
        public virtual DbSet<PsWarehouseShop> PsWarehouseShop { get; set; }
        public virtual DbSet<PsWebBrowser> PsWebBrowser { get; set; }
        public virtual DbSet<PsWebserviceAccount> PsWebserviceAccount { get; set; }
        public virtual DbSet<PsWebserviceAccountShop> PsWebserviceAccountShop { get; set; }
        public virtual DbSet<PsWebservicePermission> PsWebservicePermission { get; set; }
        public virtual DbSet<PsWishlist> PsWishlist { get; set; }
        public virtual DbSet<PsWishlistProduct> PsWishlistProduct { get; set; }
        public virtual DbSet<PsZone> PsZone { get; set; }
        public virtual DbSet<PsZoneShop> PsZoneShop { get; set; }
        public virtual DbSet<WpBooking> WpBooking { get; set; }
        public virtual DbSet<WpCommentmeta> WpCommentmeta { get; set; }
        public virtual DbSet<WpComments> WpComments { get; set; }
        public virtual DbSet<WpInstagrabberImages> WpInstagrabberImages { get; set; }
        public virtual DbSet<WpInstagrabberStreams> WpInstagrabberStreams { get; set; }
        public virtual DbSet<WpLinks> WpLinks { get; set; }
        public virtual DbSet<WpNewfield> WpNewfield { get; set; }
        public virtual DbSet<WpOptionTree> WpOptionTree { get; set; }
        public virtual DbSet<WpOptions> WpOptions { get; set; }
        public virtual DbSet<WpPostmeta> WpPostmeta { get; set; }
        public virtual DbSet<WpPosts> WpPosts { get; set; }
        public virtual DbSet<WpTermRelationships> WpTermRelationships { get; set; }
        public virtual DbSet<WpTermTaxonomy> WpTermTaxonomy { get; set; }
        public virtual DbSet<WpTerms> WpTerms { get; set; }
        public virtual DbSet<WpUsermeta> WpUsermeta { get; set; }
        public virtual DbSet<WpUsers> WpUsers { get; set; }
        public virtual DbSet<WpWpdevCrmCustomers> WpWpdevCrmCustomers { get; set; }
        public virtual DbSet<WpWpdevCrmOrders> WpWpdevCrmOrders { get; set; }

        // Unable to generate entity type for table 'skistore_se.ps_accessory'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_ajax_product_filters'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_bd_discount_category'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_bd_discount_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_bd_discount_product'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_carrier_group'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_cart_cart_rule'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_cart_product'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_category_group'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_contact_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_country_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_csslider_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_customer_message_sync_imap'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_gmc_brands'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_gmc_categories'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_gmc_tags_brands'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_gmc_tags_cats'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_gmc_tags_suppliers'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_gmc_taxonomy_categories'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_group_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_gsitemap_sitemap'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_image_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_image_shop'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_image_shop2'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_kpmpclasses'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_layered_product_attribute'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_linksmenutop_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_loyalty_state_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_order_detail_tax'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_order_invoice_tax'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_order_return_state_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_order_state_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_pet_tab_content_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_pet_tab_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_pm_adsandslideshow_auto_conf_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_pm_adsandslideshow_category'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_pm_adsandslideshow_element_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_pm_adsandslideshow_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_pm_adsandslideshow_product'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_pm_adsandslideshow_product_category'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_prodtabs_data'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_product_country_tax'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_sociallogin'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_st_blog_image_shop'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_staticblock_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_tax_lang'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_wishlist_email'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.ps_wishlist_product_cart'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.wp_bookingdates'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.wp_videourl'. Please see the warning messages.
        // Unable to generate entity type for table 'skistore_se.wp_wpinstaroll_instapics_track_table'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=password;database=skistore_se;Convert Zero Datetime=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<PsAccess>(entity =>
            {
                entity.HasKey(e => new { e.IdProfile, e.IdTab });

                entity.ToTable("ps_access", "skistore_se");

                entity.Property(e => e.IdProfile)
                    .HasColumnName("id_profile")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdTab)
                    .HasColumnName("id_tab")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Add)
                    .HasColumnName("add")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Delete)
                    .HasColumnName("delete")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Edit)
                    .HasColumnName("edit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.View)
                    .HasColumnName("view")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsAddress>(entity =>
            {
                entity.HasKey(e => e.IdAddress);

                entity.ToTable("ps_address", "skistore_se");

                entity.HasIndex(e => e.IdCountry)
                    .HasName("id_country");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("address_customer");

                entity.HasIndex(e => e.IdManufacturer)
                    .HasName("id_manufacturer");

                entity.HasIndex(e => e.IdState)
                    .HasName("id_state");

                entity.HasIndex(e => e.IdSupplier)
                    .HasName("id_supplier");

                entity.Property(e => e.IdAddress)
                    .HasColumnName("id_address")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdAddressImporterosc)
                    .HasColumnName("id_address_importerosc")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdState)
                    .HasColumnName("id_state")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("id_warehouse")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasColumnName("other")
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasColumnName("postcode")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VatNumber)
                    .HasColumnName("vat_number")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAddressFormat>(entity =>
            {
                entity.HasKey(e => e.IdCountry);

                entity.ToTable("ps_address_format", "skistore_se");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAdvancedexport>(entity =>
            {
                entity.HasKey(e => e.IdAdvancedexport);

                entity.ToTable("ps_advancedexport", "skistore_se");

                entity.Property(e => e.IdAdvancedexport)
                    .HasColumnName("id_advancedexport")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Carrier)
                    .IsRequired()
                    .HasColumnName("carrier")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cron)
                    .HasColumnName("cron")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomersGroups)
                    .IsRequired()
                    .HasColumnName("customers_groups")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom)
                    .HasColumnName("date_from")
                    .HasColumnType("date");

                entity.Property(e => e.DateTo)
                    .HasColumnName("date_to")
                    .HasColumnType("date");

                entity.Property(e => e.Delimiter)
                    .IsRequired()
                    .HasColumnName("delimiter")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fields)
                    .IsRequired()
                    .HasColumnName("fields")
                    .IsUnicode(false);

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("manufacturer")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasColumnName("payment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .IsRequired()
                    .HasColumnName("supplier")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAjaxFilters>(entity =>
            {
                entity.HasKey(e => e.IdAjaxFilter);

                entity.ToTable("ps_ajax_filters", "skistore_se");

                entity.HasIndex(e => e.Enabled)
                    .HasName("idx10_ajax_filters");

                entity.HasIndex(e => e.FilterType)
                    .HasName("idx9_ajax_filters");

                entity.HasIndex(e => e.IdFilter)
                    .HasName("idx7_ajax_filters");

                entity.HasIndex(e => e.IdFilterValue)
                    .HasName("idx8_ajax_filters");

                entity.HasIndex(e => new { e.FilterType, e.IdFilter, e.IdFilterValue })
                    .HasName("idx1_ajax_filters");

                entity.HasIndex(e => new { e.IdFilter, e.FilterType, e.Enabled })
                    .HasName("idx2_ajax_filters");

                entity.HasIndex(e => new { e.IdFilter, e.FilterType, e.IdFilterValue })
                    .HasName("id_filter")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdFilter, e.IdFilterValue, e.Enabled })
                    .HasName("idx6_ajax_filters");

                entity.HasIndex(e => new { e.IdFilter, e.IdFilterValue, e.FilterType })
                    .HasName("idx4_ajax_filters");

                entity.HasIndex(e => new { e.IdFilterValue, e.IdFilter, e.FilterType })
                    .HasName("idx5_ajax_filters");

                entity.Property(e => e.IdAjaxFilter)
                    .HasColumnName("id_ajax_filter")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Extra)
                    .IsRequired()
                    .HasColumnName("extra")
                    .IsUnicode(false);

                entity.Property(e => e.FilterPosition)
                    .HasColumnName("filter_position")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.FilterType)
                    .HasColumnName("filter_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.GroupEnabled)
                    .HasColumnName("group_enabled")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.GroupPosition)
                    .HasColumnName("group_position")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IdFilter)
                    .HasColumnName("id_filter")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdFilterValue)
                    .HasColumnName("id_filter_value")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Increment)
                    .HasColumnName("increment")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Postfix)
                    .HasColumnName("postfix")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAlias>(entity =>
            {
                entity.HasKey(e => e.IdAlias);

                entity.ToTable("ps_alias", "skistore_se");

                entity.HasIndex(e => e.Alias)
                    .HasName("alias")
                    .IsUnique();

                entity.Property(e => e.IdAlias)
                    .HasColumnName("id_alias")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Search)
                    .IsRequired()
                    .HasColumnName("search")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAttachment>(entity =>
            {
                entity.HasKey(e => e.IdAttachment);

                entity.ToTable("ps_attachment", "skistore_se");

                entity.Property(e => e.IdAttachment)
                    .HasColumnName("id_attachment")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasColumnName("file_size")
                    .HasColumnType("bigint(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mime)
                    .IsRequired()
                    .HasColumnName("mime")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAttachmentLang>(entity =>
            {
                entity.HasKey(e => new { e.IdAttachment, e.IdLang });

                entity.ToTable("ps_attachment_lang", "skistore_se");

                entity.Property(e => e.IdAttachment)
                    .HasColumnName("id_attachment")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAttribute>(entity =>
            {
                entity.HasKey(e => e.IdAttribute);

                entity.ToTable("ps_attribute", "skistore_se");

                entity.HasIndex(e => e.IdAttributeGroup)
                    .HasName("attribute_group");

                entity.Property(e => e.IdAttribute)
                    .HasColumnName("id_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdAttributeGroup)
                    .HasColumnName("id_attribute_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsAttributeGroup>(entity =>
            {
                entity.HasKey(e => e.IdAttributeGroup);

                entity.ToTable("ps_attribute_group", "skistore_se");

                entity.Property(e => e.IdAttributeGroup)
                    .HasColumnName("id_attribute_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.GroupType)
                    .IsRequired()
                    .HasColumnName("group_type")
                    .HasColumnType("enum('select','radio','color')")
                    .HasDefaultValueSql("select");

                entity.Property(e => e.IsColorGroup)
                    .HasColumnName("is_color_group")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsAttributeGroupLang>(entity =>
            {
                entity.HasKey(e => new { e.IdAttributeGroup, e.IdLang });

                entity.ToTable("ps_attribute_group_lang", "skistore_se");

                entity.Property(e => e.IdAttributeGroup)
                    .HasColumnName("id_attribute_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PublicName)
                    .IsRequired()
                    .HasColumnName("public_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAttributeGroupShop>(entity =>
            {
                entity.HasKey(e => new { e.IdAttributeGroup, e.IdShop });

                entity.ToTable("ps_attribute_group_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdAttributeGroup)
                    .HasColumnName("id_attribute_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsAttributeImpact>(entity =>
            {
                entity.HasKey(e => e.IdAttributeImpact);

                entity.ToTable("ps_attribute_impact", "skistore_se");

                entity.HasIndex(e => new { e.IdProduct, e.IdAttribute })
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdAttributeImpact)
                    .HasColumnName("id_attribute_impact")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdAttribute)
                    .HasColumnName("id_attribute")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");
            });

            modelBuilder.Entity<PsAttributeLang>(entity =>
            {
                entity.HasKey(e => new { e.IdAttribute, e.IdLang });

                entity.ToTable("ps_attribute_lang", "skistore_se");

                entity.HasIndex(e => new { e.IdLang, e.Name })
                    .HasName("id_lang");

                entity.Property(e => e.IdAttribute)
                    .HasColumnName("id_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsAttributeShop>(entity =>
            {
                entity.HasKey(e => new { e.IdAttribute, e.IdShop });

                entity.ToTable("ps_attribute_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdAttribute)
                    .HasColumnName("id_attribute")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsBdDiscount>(entity =>
            {
                entity.HasKey(e => e.IdDiscount);

                entity.ToTable("ps_bd_discount", "skistore_se");

                entity.Property(e => e.IdDiscount)
                    .HasColumnName("id_discount")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("double unsigned");

                entity.Property(e => e.Cumulable)
                    .HasColumnName("cumulable")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsBlocklinkShop>(entity =>
            {
                entity.HasKey(e => new { e.IdBlocklink, e.IdShop });

                entity.ToTable("ps_blocklink_shop", "skistore_se");

                entity.Property(e => e.IdBlocklink)
                    .HasColumnName("id_blocklink")
                    .HasColumnType("int(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCarrier>(entity =>
            {
                entity.HasKey(e => e.IdCarrier);

                entity.ToTable("ps_carrier", "skistore_se");

                entity.HasIndex(e => new { e.Deleted, e.Active })
                    .HasName("deleted");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExternalModuleName)
                    .HasColumnName("external_module_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdReference)
                    .HasColumnName("id_reference")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdTaxRulesGroup)
                    .HasColumnName("id_tax_rules_group")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsFree)
                    .HasColumnName("is_free")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsModule)
                    .HasColumnName("is_module")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDepth)
                    .HasColumnName("max_depth")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxHeight)
                    .HasColumnName("max_height")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxWeight)
                    .HasColumnName("max_weight")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.MaxWidth)
                    .HasColumnName("max_width")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NeedRange)
                    .HasColumnName("need_range")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeBehavior)
                    .HasColumnName("range_behavior")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShippingExternal)
                    .HasColumnName("shipping_external")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShippingHandling)
                    .HasColumnName("shipping_handling")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShippingMethod)
                    .HasColumnName("shipping_method")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCarrierLang>(entity =>
            {
                entity.HasKey(e => new { e.IdCarrier, e.IdShop, e.IdLang });

                entity.ToTable("ps_carrier_lang", "skistore_se");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Delay)
                    .HasColumnName("delay")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCarrierShop>(entity =>
            {
                entity.HasKey(e => new { e.IdCarrier, e.IdShop });

                entity.ToTable("ps_carrier_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsCarrierTaxRulesGroupShop>(entity =>
            {
                entity.HasKey(e => new { e.IdCarrier, e.IdTaxRulesGroup, e.IdShop });

                entity.ToTable("ps_carrier_tax_rules_group_shop", "skistore_se");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdTaxRulesGroup)
                    .HasColumnName("id_tax_rules_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsCarrierZone>(entity =>
            {
                entity.HasKey(e => new { e.IdCarrier, e.IdZone });

                entity.ToTable("ps_carrier_zone", "skistore_se");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdZone)
                    .HasColumnName("id_zone")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCart>(entity =>
            {
                entity.HasKey(e => e.IdCart);

                entity.ToTable("ps_cart", "skistore_se");

                entity.HasIndex(e => e.IdAddressDelivery)
                    .HasName("id_address_delivery");

                entity.HasIndex(e => e.IdAddressInvoice)
                    .HasName("id_address_invoice");

                entity.HasIndex(e => e.IdCarrier)
                    .HasName("id_carrier");

                entity.HasIndex(e => e.IdCurrency)
                    .HasName("id_currency");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("cart_customer");

                entity.HasIndex(e => e.IdGuest)
                    .HasName("id_guest");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_group_shop");

                entity.Property(e => e.IdCart)
                    .HasColumnName("id_cart")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AllowSeperatedPackage)
                    .HasColumnName("allow_seperated_package")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.DeliveryOption)
                    .IsRequired()
                    .HasColumnName("delivery_option")
                    .IsUnicode(false);

                entity.Property(e => e.Gift)
                    .HasColumnName("gift")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GiftMessage)
                    .HasColumnName("gift_message")
                    .IsUnicode(false);

                entity.Property(e => e.IdAddressDelivery)
                    .HasColumnName("id_address_delivery")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdAddressInvoice)
                    .HasColumnName("id_address_invoice")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGuest)
                    .HasColumnName("id_guest")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MobileTheme)
                    .HasColumnName("mobile_theme")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recyclable)
                    .HasColumnName("recyclable")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SecureKey)
                    .IsRequired()
                    .HasColumnName("secure_key")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("-1");
            });

            modelBuilder.Entity<PsCartRule>(entity =>
            {
                entity.HasKey(e => e.IdCartRule);

                entity.ToTable("ps_cart_rule", "skistore_se");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CarrierRestriction)
                    .HasColumnName("carrier_restriction")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CartRuleRestriction)
                    .HasColumnName("cart_rule_restriction")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRestriction)
                    .HasColumnName("country_restriction")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateFrom).HasColumnName("date_from");

                entity.Property(e => e.DateTo).HasColumnName("date_to");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.FreeShipping)
                    .HasColumnName("free_shipping")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GiftProduct)
                    .HasColumnName("gift_product")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GiftProductAttribute)
                    .HasColumnName("gift_product_attribute")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupRestriction)
                    .HasColumnName("group_restriction")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Highlight)
                    .HasColumnName("highlight")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinimumAmount)
                    .HasColumnName("minimum_amount")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.MinimumAmountCurrency)
                    .HasColumnName("minimum_amount_currency")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinimumAmountShipping)
                    .HasColumnName("minimum_amount_shipping")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinimumAmountTax)
                    .HasColumnName("minimum_amount_tax")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PartialUse)
                    .HasColumnName("partial_use")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ProductRestriction)
                    .HasColumnName("product_restriction")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuantityPerUser)
                    .HasColumnName("quantity_per_user")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ReductionCurrency)
                    .HasColumnName("reduction_currency")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionPercent)
                    .HasColumnName("reduction_percent")
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ReductionProduct)
                    .HasColumnName("reduction_product")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionTax)
                    .HasColumnName("reduction_tax")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShopRestriction)
                    .HasColumnName("shop_restriction")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsCartRuleCarrier>(entity =>
            {
                entity.HasKey(e => new { e.IdCartRule, e.IdCarrier });

                entity.ToTable("ps_cart_rule_carrier", "skistore_se");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCartRuleCombination>(entity =>
            {
                entity.HasKey(e => new { e.IdCartRule1, e.IdCartRule2 });

                entity.ToTable("ps_cart_rule_combination", "skistore_se");

                entity.HasIndex(e => e.IdCartRule1)
                    .HasName("id_cart_rule_1");

                entity.HasIndex(e => e.IdCartRule2)
                    .HasName("id_cart_rule_2");

                entity.Property(e => e.IdCartRule1)
                    .HasColumnName("id_cart_rule_1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCartRule2)
                    .HasColumnName("id_cart_rule_2")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCartRuleCountry>(entity =>
            {
                entity.HasKey(e => new { e.IdCartRule, e.IdCountry });

                entity.ToTable("ps_cart_rule_country", "skistore_se");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCartRuleGroup>(entity =>
            {
                entity.HasKey(e => new { e.IdCartRule, e.IdGroup });

                entity.ToTable("ps_cart_rule_group", "skistore_se");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCartRuleLang>(entity =>
            {
                entity.HasKey(e => new { e.IdCartRule, e.IdLang });

                entity.ToTable("ps_cart_rule_lang", "skistore_se");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCartRuleProductRule>(entity =>
            {
                entity.HasKey(e => e.IdProductRule);

                entity.ToTable("ps_cart_rule_product_rule", "skistore_se");

                entity.Property(e => e.IdProductRule)
                    .HasColumnName("id_product_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductRuleGroup)
                    .HasColumnName("id_product_rule_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('products','categories','attributes','manufacturers','suppliers')");
            });

            modelBuilder.Entity<PsCartRuleProductRuleGroup>(entity =>
            {
                entity.HasKey(e => e.IdProductRuleGroup);

                entity.ToTable("ps_cart_rule_product_rule_group", "skistore_se");

                entity.Property(e => e.IdProductRuleGroup)
                    .HasColumnName("id_product_rule_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsCartRuleProductRuleValue>(entity =>
            {
                entity.HasKey(e => new { e.IdItem, e.IdProductRule });

                entity.ToTable("ps_cart_rule_product_rule_value", "skistore_se");

                entity.HasIndex(e => e.IdProductRule)
                    .HasName("discount");

                entity.Property(e => e.IdItem)
                    .HasColumnName("id_item")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductRule)
                    .HasColumnName("id_product_rule")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCartRuleShop>(entity =>
            {
                entity.HasKey(e => new { e.IdCartRule, e.IdShop });

                entity.ToTable("ps_cart_rule_shop", "skistore_se");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCategory>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.ToTable("ps_category", "skistore_se");

                entity.HasIndex(e => e.IdParent)
                    .HasName("category_parent");

                entity.HasIndex(e => e.LevelDepth)
                    .HasName("level_depth");

                entity.HasIndex(e => e.Nleft)
                    .HasName("nleft");

                entity.HasIndex(e => e.Nright)
                    .HasName("nright");

                entity.HasIndex(e => new { e.Nleft, e.Nright })
                    .HasName("nleftright");

                entity.HasIndex(e => new { e.Nleft, e.Nright, e.Active })
                    .HasName("nleftrightactive");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShopDefault)
                    .HasColumnName("id_shop_default")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsRootCategory)
                    .HasColumnName("is_root_category")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nleft)
                    .HasColumnName("nleft")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nright)
                    .HasColumnName("nright")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsCategoryLang>(entity =>
            {
                entity.HasKey(e => new { e.IdCategory, e.IdShop, e.IdLang });

                entity.ToTable("ps_category_lang", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("category_name");

                entity.HasIndex(e => new { e.IdCategory, e.IdShop, e.IdLang })
                    .HasName("id_category")
                    .IsUnique();

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.LinkRewrite)
                    .IsRequired()
                    .HasColumnName("link_rewrite")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCategoryProduct>(entity =>
            {
                entity.HasKey(e => new { e.IdCategory, e.IdProduct });

                entity.ToTable("ps_category_product", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.HasIndex(e => new { e.IdCategory, e.IdProduct })
                    .HasName("id_category")
                    .IsUnique();

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsCategoryShop>(entity =>
            {
                entity.HasKey(e => new { e.IdCategory, e.IdShop });

                entity.ToTable("ps_category_shop", "skistore_se");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsCms>(entity =>
            {
                entity.HasKey(e => e.IdCms);

                entity.ToTable("ps_cms", "skistore_se");

                entity.HasIndex(e => e.IdCmsCategory)
                    .HasName("id_cms_category");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCmsCategory)
                    .HasColumnName("id_cms_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Indexation)
                    .HasColumnName("indexation")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsCmsBlock>(entity =>
            {
                entity.HasKey(e => e.IdCmsBlock);

                entity.ToTable("ps_cms_block", "skistore_se");

                entity.Property(e => e.IdCmsBlock)
                    .HasColumnName("id_cms_block")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DisplayStore)
                    .HasColumnName("display_store")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdCmsCategory)
                    .HasColumnName("id_cms_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsCmsBlockLang>(entity =>
            {
                entity.HasKey(e => new { e.IdCmsBlock, e.IdLang });

                entity.ToTable("ps_cms_block_lang", "skistore_se");

                entity.Property(e => e.IdCmsBlock)
                    .HasColumnName("id_cms_block")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCmsBlockPage>(entity =>
            {
                entity.HasKey(e => e.IdCmsBlockPage);

                entity.ToTable("ps_cms_block_page", "skistore_se");

                entity.Property(e => e.IdCmsBlockPage)
                    .HasColumnName("id_cms_block_page")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCmsBlock)
                    .HasColumnName("id_cms_block")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCategory)
                    .HasColumnName("is_category")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<PsCmsBlockShop>(entity =>
            {
                entity.HasKey(e => new { e.IdCmsBlock, e.IdShop });

                entity.ToTable("ps_cms_block_shop", "skistore_se");

                entity.Property(e => e.IdCmsBlock)
                    .HasColumnName("id_cms_block")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCmsCategory>(entity =>
            {
                entity.HasKey(e => e.IdCmsCategory);

                entity.ToTable("ps_cms_category", "skistore_se");

                entity.HasIndex(e => e.IdParent)
                    .HasName("category_parent");

                entity.Property(e => e.IdCmsCategory)
                    .HasColumnName("id_cms_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsCmsCategoryLang>(entity =>
            {
                entity.HasKey(e => new { e.IdCmsCategory, e.IdLang });

                entity.ToTable("ps_cms_category_lang", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("category_name");

                entity.Property(e => e.IdCmsCategory)
                    .HasColumnName("id_cms_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.LinkRewrite)
                    .IsRequired()
                    .HasColumnName("link_rewrite")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCmsLang>(entity =>
            {
                entity.HasKey(e => new { e.IdCms, e.IdLang });

                entity.ToTable("ps_cms_lang", "skistore_se");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("longtext");

                entity.Property(e => e.LinkRewrite)
                    .IsRequired()
                    .HasColumnName("link_rewrite")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCmsShop>(entity =>
            {
                entity.HasKey(e => new { e.IdCms, e.IdShop });

                entity.ToTable("ps_cms_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsCompare>(entity =>
            {
                entity.HasKey(e => e.IdCompare);

                entity.ToTable("ps_compare", "skistore_se");

                entity.Property(e => e.IdCompare)
                    .HasColumnName("id_compare")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCompareProduct>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdCompare });

                entity.ToTable("ps_compare_product", "skistore_se");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCompare)
                    .HasColumnName("id_compare")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");
            });

            modelBuilder.Entity<PsConfiguration>(entity =>
            {
                entity.HasKey(e => e.IdConfiguration);

                entity.ToTable("ps_configuration", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_group_shop");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.IdConfiguration)
                    .HasColumnName("id_configuration")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsConfigurationKpi>(entity =>
            {
                entity.HasKey(e => e.IdConfigurationKpi);

                entity.ToTable("ps_configuration_kpi", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_shop_group");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.IdConfigurationKpi)
                    .HasColumnName("id_configuration_kpi")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsConfigurationKpiLang>(entity =>
            {
                entity.HasKey(e => new { e.IdConfigurationKpi, e.IdLang });

                entity.ToTable("ps_configuration_kpi_lang", "skistore_se");

                entity.Property(e => e.IdConfigurationKpi)
                    .HasColumnName("id_configuration_kpi")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsConfigurationLang>(entity =>
            {
                entity.HasKey(e => new { e.IdConfiguration, e.IdLang });

                entity.ToTable("ps_configuration_lang", "skistore_se");

                entity.Property(e => e.IdConfiguration)
                    .HasColumnName("id_configuration")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsConnections>(entity =>
            {
                entity.HasKey(e => e.IdConnections);

                entity.ToTable("ps_connections", "skistore_se");

                entity.HasIndex(e => e.DateAdd)
                    .HasName("date_add");

                entity.HasIndex(e => e.IdGuest)
                    .HasName("id_guest");

                entity.HasIndex(e => e.IdPage)
                    .HasName("id_page");

                entity.Property(e => e.IdConnections)
                    .HasColumnName("id_connections")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.HttpReferer)
                    .HasColumnName("http_referer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdGuest)
                    .HasColumnName("id_guest")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdPage)
                    .HasColumnName("id_page")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<PsConnectionsPage>(entity =>
            {
                entity.HasKey(e => new { e.IdConnections, e.IdPage, e.TimeStart });

                entity.ToTable("ps_connections_page", "skistore_se");

                entity.Property(e => e.IdConnections)
                    .HasColumnName("id_connections")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdPage)
                    .HasColumnName("id_page")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TimeStart).HasColumnName("time_start");

                entity.Property(e => e.TimeEnd).HasColumnName("time_end");
            });

            modelBuilder.Entity<PsConnectionsSource>(entity =>
            {
                entity.HasKey(e => e.IdConnectionsSource);

                entity.ToTable("ps_connections_source", "skistore_se");

                entity.HasIndex(e => e.DateAdd)
                    .HasName("orderby");

                entity.HasIndex(e => e.HttpReferer)
                    .HasName("http_referer");

                entity.HasIndex(e => e.IdConnections)
                    .HasName("connections");

                entity.HasIndex(e => e.RequestUri)
                    .HasName("request_uri");

                entity.Property(e => e.IdConnectionsSource)
                    .HasColumnName("id_connections_source")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.HttpReferer)
                    .HasColumnName("http_referer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdConnections)
                    .HasColumnName("id_connections")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUri)
                    .HasColumnName("request_uri")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsContact>(entity =>
            {
                entity.HasKey(e => e.IdContact);

                entity.ToTable("ps_contact", "skistore_se");

                entity.Property(e => e.IdContact)
                    .HasColumnName("id_contact")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CustomerService)
                    .HasColumnName("customer_service")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsContactShop>(entity =>
            {
                entity.HasKey(e => new { e.IdContact, e.IdShop });

                entity.ToTable("ps_contact_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdContact)
                    .HasColumnName("id_contact")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsCountry>(entity =>
            {
                entity.HasKey(e => e.IdCountry);

                entity.ToTable("ps_country", "skistore_se");

                entity.HasIndex(e => e.IdZone)
                    .HasName("country_");

                entity.HasIndex(e => e.IsoCode)
                    .HasName("country_iso_code");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CallPrefix)
                    .HasColumnName("call_prefix")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContainsStates)
                    .HasColumnName("contains_states")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayTaxLabel)
                    .HasColumnName("display_tax_label")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdZone)
                    .HasColumnName("id_zone")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsoCode)
                    .IsRequired()
                    .HasColumnName("iso_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NeedIdentificationNumber)
                    .HasColumnName("need_identification_number")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NeedZipCode)
                    .HasColumnName("need_zip_code")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ZipCodeFormat)
                    .IsRequired()
                    .HasColumnName("zip_code_format")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCountryShop>(entity =>
            {
                entity.HasKey(e => new { e.IdCountry, e.IdShop });

                entity.ToTable("ps_country_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsCronjobs>(entity =>
            {
                entity.HasKey(e => e.IdCronjob);

                entity.ToTable("ps_cronjobs", "skistore_se");

                entity.HasIndex(e => e.IdModule)
                    .HasName("id_module");

                entity.Property(e => e.IdCronjob)
                    .HasColumnName("id_cronjob")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Day)
                    .HasColumnName("day")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.DayOfWeek)
                    .HasColumnName("day_of_week")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Hour)
                    .HasColumnName("hour")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.OneShot)
                    .HasColumnName("one_shot")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Task)
                    .HasColumnName("task")
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<PsCsslider>(entity =>
            {
                entity.HasKey(e => e.IdSlider);

                entity.ToTable("ps_csslider", "skistore_se");

                entity.Property(e => e.IdSlider)
                    .HasColumnName("id_slider")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Display)
                    .HasColumnName("display")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCurrency>(entity =>
            {
                entity.HasKey(e => e.IdCurrency);

                entity.ToTable("ps_currency", "skistore_se");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Blank)
                    .HasColumnName("blank")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ConversionRate)
                    .HasColumnName("conversion_rate")
                    .HasColumnType("decimal(13,6)")
                    .HasDefaultValueSql("1.000000");

                entity.Property(e => e.Decimals)
                    .HasColumnName("decimals")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsoCode)
                    .IsRequired()
                    .HasColumnName("iso_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsoCodeNum)
                    .IsRequired()
                    .HasColumnName("iso_code_num")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sign)
                    .IsRequired()
                    .HasColumnName("sign")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCurrencyShop>(entity =>
            {
                entity.HasKey(e => new { e.IdCurrency, e.IdShop });

                entity.ToTable("ps_currency_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ConversionRate)
                    .HasColumnName("conversion_rate")
                    .HasColumnType("decimal(13,6)");
            });

            modelBuilder.Entity<PsCustomer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.ToTable("ps_customer", "skistore_se");

                entity.HasIndex(e => e.Email)
                    .HasName("customer_email");

                entity.HasIndex(e => e.IdGender)
                    .HasName("id_gender");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_group_shop");

                entity.HasIndex(e => new { e.Email, e.Passwd })
                    .HasName("customer_login");

                entity.HasIndex(e => new { e.IdCustomer, e.Passwd })
                    .HasName("id_customer_passwd");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ape)
                    .HasColumnName("ape")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomerImporterosc)
                    .HasColumnName("id_customer_importerosc")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdDefaultGroup)
                    .HasColumnName("id_default_group")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdGender)
                    .HasColumnName("id_gender")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdRisk)
                    .HasColumnName("id_risk")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdSpecter)
                    .HasColumnName("id_specter")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IpRegistrationNewsletter)
                    .HasColumnName("ip_registration_newsletter")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsGuest)
                    .HasColumnName("is_guest")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastPasswdGen)
                    .HasColumnName("last_passwd_gen")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MaxPaymentDays)
                    .HasColumnName("max_payment_days")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("60");

                entity.Property(e => e.Newsletter)
                    .HasColumnName("newsletter")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterDateAdd).HasColumnName("newsletter_date_add");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .IsUnicode(false);

                entity.Property(e => e.Optin)
                    .HasColumnName("optin")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OutstandingAllowAmount)
                    .HasColumnName("outstanding_allow_amount")
                    .HasColumnType("decimal(10,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Passwd)
                    .IsRequired()
                    .HasColumnName("passwd")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PasswdImporterosc)
                    .IsRequired()
                    .HasColumnName("passwd_importerosc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecureKey)
                    .IsRequired()
                    .HasColumnName("secure_key")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.ShowPublicPrices)
                    .HasColumnName("show_public_prices")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Siret)
                    .HasColumnName("siret")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCustomerGroup>(entity =>
            {
                entity.HasKey(e => new { e.IdCustomer, e.IdGroup });

                entity.ToTable("ps_customer_group", "skistore_se");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("id_customer");

                entity.HasIndex(e => e.IdGroup)
                    .HasName("customer_login");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsCustomerMessage>(entity =>
            {
                entity.HasKey(e => e.IdCustomerMessage);

                entity.ToTable("ps_customer_message", "skistore_se");

                entity.HasIndex(e => e.IdCustomerThread)
                    .HasName("id_customer_thread");

                entity.HasIndex(e => e.IdEmployee)
                    .HasName("id_employee");

                entity.Property(e => e.IdCustomerMessage)
                    .HasColumnName("id_customer_message")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomerThread)
                    .HasColumnName("id_customer_thread")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Private)
                    .HasColumnName("private")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Read)
                    .HasColumnName("read")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserAgent)
                    .HasColumnName("user_agent")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCustomerThread>(entity =>
            {
                entity.HasKey(e => e.IdCustomerThread);

                entity.ToTable("ps_customer_thread", "skistore_se");

                entity.HasIndex(e => e.IdContact)
                    .HasName("id_contact");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("id_customer");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("id_order");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdCustomerThread)
                    .HasColumnName("id_customer_thread")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IdContact)
                    .HasColumnName("id_contact")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('open','closed','pending1','pending2')")
                    .HasDefaultValueSql("open");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCustomization>(entity =>
            {
                entity.HasKey(e => new { e.IdCustomization, e.IdAddressDelivery, e.IdCart, e.IdProduct });

                entity.ToTable("ps_customization", "skistore_se");

                entity.HasIndex(e => e.IdProductAttribute)
                    .HasName("id_product_attribute");

                entity.Property(e => e.IdCustomization)
                    .HasColumnName("id_customization")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdAddressDelivery)
                    .HasColumnName("id_address_delivery")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCart)
                    .HasColumnName("id_cart")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InCart)
                    .HasColumnName("in_cart")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10)");

                entity.Property(e => e.QuantityRefunded)
                    .HasColumnName("quantity_refunded")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuantityReturned)
                    .HasColumnName("quantity_returned")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsCustomizationField>(entity =>
            {
                entity.HasKey(e => e.IdCustomizationField);

                entity.ToTable("ps_customization_field", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.Property(e => e.IdCustomizationField)
                    .HasColumnName("id_customization_field")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsCustomizationFieldLang>(entity =>
            {
                entity.HasKey(e => new { e.IdCustomizationField, e.IdLang });

                entity.ToTable("ps_customization_field_lang", "skistore_se");

                entity.Property(e => e.IdCustomizationField)
                    .HasColumnName("id_customization_field")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCustomizedData>(entity =>
            {
                entity.HasKey(e => new { e.IdCustomization, e.Type, e.Index });

                entity.ToTable("ps_customized_data", "skistore_se");

                entity.Property(e => e.IdCustomization)
                    .HasColumnName("id_customization")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Index)
                    .HasColumnName("index")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsDateRange>(entity =>
            {
                entity.HasKey(e => e.IdDateRange);

                entity.ToTable("ps_date_range", "skistore_se");

                entity.Property(e => e.IdDateRange)
                    .HasColumnName("id_date_range")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TimeEnd).HasColumnName("time_end");

                entity.Property(e => e.TimeStart).HasColumnName("time_start");
            });

            modelBuilder.Entity<PsDelivery>(entity =>
            {
                entity.HasKey(e => e.IdDelivery);

                entity.ToTable("ps_delivery", "skistore_se");

                entity.HasIndex(e => e.IdRangePrice)
                    .HasName("id_range_price");

                entity.HasIndex(e => e.IdRangeWeight)
                    .HasName("id_range_weight");

                entity.HasIndex(e => e.IdZone)
                    .HasName("id_zone");

                entity.HasIndex(e => new { e.IdCarrier, e.IdZone })
                    .HasName("id_carrier");

                entity.Property(e => e.IdDelivery)
                    .HasColumnName("id_delivery")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdRangePrice)
                    .HasColumnName("id_range_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdRangeWeight)
                    .HasColumnName("id_range_weight")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdZone)
                    .HasColumnName("id_zone")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(20,6)");
            });

            modelBuilder.Entity<PsDibsSecurity>(entity =>
            {
                entity.ToTable("ps_dibs_security", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(16)");

                entity.Property(e => e.CartId)
                    .HasColumnName("cart_id")
                    .HasColumnType("int(16)");

                entity.Property(e => e.Severity)
                    .HasColumnName("severity")
                    .HasColumnType("int(16)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsDibsSimplifiedCheckout>(entity =>
            {
                entity.ToTable("ps_dibs_simplified_checkout", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(16)");

                entity.Property(e => e.CardNum)
                    .HasColumnName("card_num")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasColumnName("card_type")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(16)");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsEditorial>(entity =>
            {
                entity.HasKey(e => e.IdEditorial);

                entity.ToTable("ps_editorial", "skistore_se");

                entity.Property(e => e.IdEditorial)
                    .HasColumnName("id_editorial")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BodyHomeLogoLink)
                    .IsRequired()
                    .HasColumnName("body_home_logo_link")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsEditorialLang>(entity =>
            {
                entity.HasKey(e => new { e.IdEditorial, e.IdLang });

                entity.ToTable("ps_editorial_lang", "skistore_se");

                entity.Property(e => e.IdEditorial)
                    .HasColumnName("id_editorial")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BodyLogoSubheading)
                    .IsRequired()
                    .HasColumnName("body_logo_subheading")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BodyParagraph)
                    .IsRequired()
                    .HasColumnName("body_paragraph")
                    .IsUnicode(false);

                entity.Property(e => e.BodySubheading)
                    .IsRequired()
                    .HasColumnName("body_subheading")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BodyTitle)
                    .IsRequired()
                    .HasColumnName("body_title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsEmployee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.ToTable("ps_employee", "skistore_se");

                entity.HasIndex(e => e.IdProfile)
                    .HasName("id_profile");

                entity.HasIndex(e => new { e.Email, e.Passwd })
                    .HasName("employee_login");

                entity.HasIndex(e => new { e.IdEmployee, e.Passwd })
                    .HasName("id_employee_passwd");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BoColor)
                    .HasColumnName("bo_color")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BoCss)
                    .HasColumnName("bo_css")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("admin-theme.css");

                entity.Property(e => e.BoMenu)
                    .HasColumnName("bo_menu")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BoTheme)
                    .HasColumnName("bo_theme")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BoWidth)
                    .HasColumnName("bo_width")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultTab)
                    .HasColumnName("default_tab")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdLastCustomer)
                    .HasColumnName("id_last_customer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdLastCustomerMessage)
                    .HasColumnName("id_last_customer_message")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdLastOrder)
                    .HasColumnName("id_last_order")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdProfile)
                    .HasColumnName("id_profile")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LastPasswdGen)
                    .HasColumnName("last_passwd_gen")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Optin)
                    .HasColumnName("optin")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Passwd)
                    .IsRequired()
                    .HasColumnName("passwd")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PreselectDateRange)
                    .HasColumnName("preselect_date_range")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StatsCompareFrom)
                    .HasColumnName("stats_compare_from")
                    .HasColumnType("date");

                entity.Property(e => e.StatsCompareOption)
                    .HasColumnName("stats_compare_option")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.StatsCompareTo)
                    .HasColumnName("stats_compare_to")
                    .HasColumnType("date");

                entity.Property(e => e.StatsDateFrom)
                    .HasColumnName("stats_date_from")
                    .HasColumnType("date");

                entity.Property(e => e.StatsDateTo)
                    .HasColumnName("stats_date_to")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<PsEmployeeShop>(entity =>
            {
                entity.HasKey(e => new { e.IdEmployee, e.IdShop });

                entity.ToTable("ps_employee_shop", "skistore_se");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsFeature>(entity =>
            {
                entity.HasKey(e => e.IdFeature);

                entity.ToTable("ps_feature", "skistore_se");

                entity.Property(e => e.IdFeature)
                    .HasColumnName("id_feature")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsFeatureLang>(entity =>
            {
                entity.HasKey(e => new { e.IdFeature, e.IdLang });

                entity.ToTable("ps_feature_lang", "skistore_se");

                entity.HasIndex(e => new { e.IdLang, e.Name })
                    .HasName("feature_name");

                entity.Property(e => e.IdFeature)
                    .HasColumnName("id_feature")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsFeatureProduct>(entity =>
            {
                entity.HasKey(e => new { e.IdFeature, e.IdProduct });

                entity.ToTable("ps_feature_product", "skistore_se");

                entity.HasIndex(e => e.IdFeatureValue)
                    .HasName("id_feature_value");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.Property(e => e.IdFeature)
                    .HasColumnName("id_feature")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdFeatureValue)
                    .HasColumnName("id_feature_value")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsFeatureShop>(entity =>
            {
                entity.HasKey(e => new { e.IdFeature, e.IdShop });

                entity.ToTable("ps_feature_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdFeature)
                    .HasColumnName("id_feature")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsFeatureValue>(entity =>
            {
                entity.HasKey(e => e.IdFeatureValue);

                entity.ToTable("ps_feature_value", "skistore_se");

                entity.HasIndex(e => e.IdFeature)
                    .HasName("feature");

                entity.Property(e => e.IdFeatureValue)
                    .HasColumnName("id_feature_value")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Custom)
                    .HasColumnName("custom")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IdFeature)
                    .HasColumnName("id_feature")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsFeatureValueLang>(entity =>
            {
                entity.HasKey(e => new { e.IdFeatureValue, e.IdLang });

                entity.ToTable("ps_feature_value_lang", "skistore_se");

                entity.HasIndex(e => e.IdFeatureValue)
                    .HasName("id_feature_value");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.Property(e => e.IdFeatureValue)
                    .HasColumnName("id_feature_value")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsGender>(entity =>
            {
                entity.HasKey(e => e.IdGender);

                entity.ToTable("ps_gender", "skistore_se");

                entity.Property(e => e.IdGender)
                    .HasColumnName("id_gender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsGenderLang>(entity =>
            {
                entity.HasKey(e => new { e.IdGender, e.IdLang });

                entity.ToTable("ps_gender_lang", "skistore_se");

                entity.HasIndex(e => e.IdGender)
                    .HasName("id_gender");

                entity.Property(e => e.IdGender)
                    .HasColumnName("id_gender")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsGiftCard>(entity =>
            {
                entity.HasKey(e => e.IdGiftCard);

                entity.ToTable("ps_gift_card", "skistore_se");

                entity.HasIndex(e => new { e.IdProduct, e.IdProductAttribute, e.IdCart })
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdGiftCard)
                    .HasColumnName("id_gift_card")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdCart)
                    .HasColumnName("id_cart")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdOrderDetail)
                    .HasColumnName("id_order_detail")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MailBody)
                    .IsRequired()
                    .HasColumnName("mail_body")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.MailDate)
                    .HasColumnName("mail_date")
                    .HasColumnType("date");

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasColumnName("mail_from")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MailIdImage)
                    .HasColumnName("mail_id_image")
                    .HasColumnType("int(10)");

                entity.Property(e => e.MailStatus)
                    .HasColumnName("mail_status")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasColumnName("mail_to")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(20,6)");
            });

            modelBuilder.Entity<PsGmcFeaturesByCat>(entity =>
            {
                entity.HasKey(e => e.IdCat);

                entity.ToTable("ps_gmc_features_by_cat", "skistore_se");

                entity.Property(e => e.IdCat)
                    .HasColumnName("id_cat")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Values)
                    .IsRequired()
                    .HasColumnName("values")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsGmcTags>(entity =>
            {
                entity.HasKey(e => e.IdTag);

                entity.ToTable("ps_gmc_tags", "skistore_se");

                entity.Property(e => e.IdTag)
                    .HasColumnName("id_tag")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(255)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("char(255)");
            });

            modelBuilder.Entity<PsGmcTaxonomy>(entity =>
            {
                entity.HasKey(e => e.IdTaxonomy);

                entity.ToTable("ps_gmc_taxonomy", "skistore_se");

                entity.HasIndex(e => e.Lang)
                    .HasName("lang");

                entity.HasIndex(e => e.Value)
                    .HasName("ft_index");

                entity.Property(e => e.IdTaxonomy)
                    .HasColumnName("id_taxonomy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasColumnName("lang")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<PsGroup>(entity =>
            {
                entity.HasKey(e => e.IdGroup);

                entity.ToTable("ps_group", "skistore_se");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.PriceDisplayMethod)
                    .HasColumnName("price_display_method")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reduction)
                    .HasColumnName("reduction")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ShowPrices)
                    .HasColumnName("show_prices")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsGroupReduction>(entity =>
            {
                entity.HasKey(e => e.IdGroupReduction);

                entity.ToTable("ps_group_reduction", "skistore_se");

                entity.HasIndex(e => new { e.IdGroup, e.IdCategory })
                    .HasName("id_group")
                    .IsUnique();

                entity.Property(e => e.IdGroupReduction)
                    .HasColumnName("id_group_reduction")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Reduction)
                    .HasColumnName("reduction")
                    .HasColumnType("decimal(4,4)");
            });

            modelBuilder.Entity<PsGroupShop>(entity =>
            {
                entity.HasKey(e => new { e.IdGroup, e.IdShop });

                entity.ToTable("ps_group_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsGuest>(entity =>
            {
                entity.HasKey(e => e.IdGuest);

                entity.ToTable("ps_guest", "skistore_se");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("id_customer");

                entity.HasIndex(e => e.IdOperatingSystem)
                    .HasName("id_operating_system");

                entity.HasIndex(e => e.IdWebBrowser)
                    .HasName("id_web_browser");

                entity.Property(e => e.IdGuest)
                    .HasColumnName("id_guest")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AcceptLanguage)
                    .HasColumnName("accept_language")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AdobeDirector)
                    .HasColumnName("adobe_director")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.AdobeFlash)
                    .HasColumnName("adobe_flash")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.AppleQuicktime)
                    .HasColumnName("apple_quicktime")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOperatingSystem)
                    .HasColumnName("id_operating_system")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdWebBrowser)
                    .HasColumnName("id_web_browser")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Javascript)
                    .HasColumnName("javascript")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobileTheme)
                    .HasColumnName("mobile_theme")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RealPlayer)
                    .HasColumnName("real_player")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ScreenColor)
                    .HasColumnName("screen_color")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ScreenResolutionX)
                    .HasColumnName("screen_resolution_x")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ScreenResolutionY)
                    .HasColumnName("screen_resolution_y")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.SunJava)
                    .HasColumnName("sun_java")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.WindowsMedia)
                    .HasColumnName("windows_media")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsHomeslider>(entity =>
            {
                entity.HasKey(e => new { e.IdHomesliderSlides, e.IdShop });

                entity.ToTable("ps_homeslider", "skistore_se");

                entity.Property(e => e.IdHomesliderSlides)
                    .HasColumnName("id_homeslider_slides")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsHomesliderSlides>(entity =>
            {
                entity.HasKey(e => e.IdHomesliderSlides);

                entity.ToTable("ps_homeslider_slides", "skistore_se");

                entity.Property(e => e.IdHomesliderSlides)
                    .HasColumnName("id_homeslider_slides")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsHomesliderSlidesLang>(entity =>
            {
                entity.HasKey(e => new { e.IdHomesliderSlides, e.IdLang });

                entity.ToTable("ps_homeslider_slides_lang", "skistore_se");

                entity.Property(e => e.IdHomesliderSlides)
                    .HasColumnName("id_homeslider_slides")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Legend)
                    .IsRequired()
                    .HasColumnName("legend")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsHook>(entity =>
            {
                entity.HasKey(e => e.IdHook);

                entity.ToTable("ps_hook", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("hook_name")
                    .IsUnique();

                entity.Property(e => e.IdHook)
                    .HasColumnName("id_hook")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.LiveEdit)
                    .HasColumnName("live_edit")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsHookAlias>(entity =>
            {
                entity.HasKey(e => e.IdHookAlias);

                entity.ToTable("ps_hook_alias", "skistore_se");

                entity.HasIndex(e => e.Alias)
                    .HasName("alias")
                    .IsUnique();

                entity.Property(e => e.IdHookAlias)
                    .HasColumnName("id_hook_alias")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsHookModule>(entity =>
            {
                entity.HasKey(e => new { e.IdModule, e.IdHook, e.IdShop });

                entity.ToTable("ps_hook_module", "skistore_se");

                entity.HasIndex(e => e.IdHook)
                    .HasName("id_hook");

                entity.HasIndex(e => e.IdModule)
                    .HasName("id_module");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdHook)
                    .HasColumnName("id_hook")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(2) unsigned");
            });

            modelBuilder.Entity<PsHookModuleExceptions>(entity =>
            {
                entity.HasKey(e => e.IdHookModuleExceptions);

                entity.ToTable("ps_hook_module_exceptions", "skistore_se");

                entity.HasIndex(e => e.IdHook)
                    .HasName("id_hook");

                entity.HasIndex(e => e.IdModule)
                    .HasName("id_module");

                entity.Property(e => e.IdHookModuleExceptions)
                    .HasColumnName("id_hook_module_exceptions")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdHook)
                    .HasColumnName("id_hook")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsImage>(entity =>
            {
                entity.HasKey(e => e.IdImage);

                entity.ToTable("ps_image", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("image_product");

                entity.HasIndex(e => new { e.IdProduct, e.Cover })
                    .HasName("id_product_cover");

                entity.HasIndex(e => new { e.IdImage, e.IdProduct, e.Cover })
                    .HasName("idx_product_image")
                    .IsUnique();

                entity.Property(e => e.IdImage)
                    .HasColumnName("id_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hover)
                    .HasColumnName("hover")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("smallint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScPath)
                    .IsRequired()
                    .HasColumnName("sc_path")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsImageType>(entity =>
            {
                entity.HasKey(e => e.IdImageType);

                entity.ToTable("ps_image_type", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("image_type_name");

                entity.Property(e => e.IdImageType)
                    .HasColumnName("id_image_type")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Categories)
                    .HasColumnName("categories")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Manufacturers)
                    .HasColumnName("manufacturers")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Products)
                    .HasColumnName("products")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Scenes)
                    .HasColumnName("scenes")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Stores)
                    .HasColumnName("stores")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Suppliers)
                    .HasColumnName("suppliers")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsImportMatch>(entity =>
            {
                entity.HasKey(e => e.IdImportMatch);

                entity.ToTable("ps_import_match", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.IdImportMatch)
                    .HasColumnName("id_import_match")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Match)
                    .IsRequired()
                    .HasColumnName("match")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Skip)
                    .HasColumnName("skip")
                    .HasColumnType("int(2)");
            });

            modelBuilder.Entity<PsInfo>(entity =>
            {
                entity.HasKey(e => e.IdInfo);

                entity.ToTable("ps_info", "skistore_se");

                entity.Property(e => e.IdInfo)
                    .HasColumnName("id_info")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsInfoLang>(entity =>
            {
                entity.HasKey(e => new { e.IdInfo, e.IdLang });

                entity.ToTable("ps_info_lang", "skistore_se");

                entity.Property(e => e.IdInfo)
                    .HasColumnName("id_info")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsJqzoomconfig>(entity =>
            {
                entity.HasKey(e => e.IdJqzoomconfig);

                entity.ToTable("ps_jqzoomconfig", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.IdJqzoomconfig)
                    .HasColumnName("id_jqzoomconfig")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsKlarnaErrors>(entity =>
            {
                entity.ToTable("ps_klarna_errors", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnName("error_message")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsKlarnaOrders>(entity =>
            {
                entity.ToTable("ps_klarna_orders", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Invoicenumber)
                    .IsRequired()
                    .HasColumnName("invoicenumber")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Reservation)
                    .IsRequired()
                    .HasColumnName("reservation")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RiskStatus)
                    .IsRequired()
                    .HasColumnName("risk_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .IsRequired()
                    .HasColumnName("ssn")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLang>(entity =>
            {
                entity.HasKey(e => e.IdLang);

                entity.ToTable("ps_lang", "skistore_se");

                entity.HasIndex(e => e.IsoCode)
                    .HasName("lang_iso_code");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateFormatFull)
                    .IsRequired()
                    .HasColumnName("date_format_full")
                    .HasColumnType("char(32)")
                    .HasDefaultValueSql("Y-m-d H:i:s");

                entity.Property(e => e.DateFormatLite)
                    .IsRequired()
                    .HasColumnName("date_format_lite")
                    .HasColumnType("char(32)")
                    .HasDefaultValueSql("Y-m-d");

                entity.Property(e => e.IdLangImporterosc)
                    .HasColumnName("id_lang_importerosc")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IsRtl)
                    .HasColumnName("is_rtl")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsoCode)
                    .IsRequired()
                    .HasColumnName("iso_code")
                    .HasColumnType("char(2)");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("language_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLangShop>(entity =>
            {
                entity.HasKey(e => new { e.IdLang, e.IdShop });

                entity.ToTable("ps_lang_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsLayeredCategory>(entity =>
            {
                entity.HasKey(e => e.IdLayeredCategory);

                entity.ToTable("ps_layered_category", "skistore_se");

                entity.HasIndex(e => new { e.IdCategory, e.Type })
                    .HasName("id_category");

                entity.Property(e => e.IdLayeredCategory)
                    .HasColumnName("id_layered_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FilterShowLimit)
                    .HasColumnName("filter_show_limit")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FilterType)
                    .HasColumnName("filter_type")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdValue)
                    .HasColumnName("id_value")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('category','id_feature','id_attribute_group','quantity','condition','manufacturer','weight','price')");
            });

            modelBuilder.Entity<PsLayeredFilter>(entity =>
            {
                entity.HasKey(e => e.IdLayeredFilter);

                entity.ToTable("ps_layered_filter", "skistore_se");

                entity.Property(e => e.IdLayeredFilter)
                    .HasColumnName("id_layered_filter")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.Filters)
                    .HasColumnName("filters")
                    .IsUnicode(false);

                entity.Property(e => e.NCategories)
                    .HasColumnName("n_categories")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLayeredFilterShop>(entity =>
            {
                entity.HasKey(e => new { e.IdLayeredFilter, e.IdShop });

                entity.ToTable("ps_layered_filter_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdLayeredFilter)
                    .HasColumnName("id_layered_filter")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsLayeredFriendlyUrl>(entity =>
            {
                entity.HasKey(e => e.IdLayeredFriendlyUrl);

                entity.ToTable("ps_layered_friendly_url", "skistore_se");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.UrlKey)
                    .HasName("url_key");

                entity.Property(e => e.IdLayeredFriendlyUrl)
                    .HasColumnName("id_layered_friendly_url")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UrlKey)
                    .IsRequired()
                    .HasColumnName("url_key")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLayeredIndexableAttributeGroup>(entity =>
            {
                entity.HasKey(e => e.IdAttributeGroup);

                entity.ToTable("ps_layered_indexable_attribute_group", "skistore_se");

                entity.Property(e => e.IdAttributeGroup)
                    .HasColumnName("id_attribute_group")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Indexable)
                    .HasColumnName("indexable")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsLayeredIndexableAttributeGroupLangValue>(entity =>
            {
                entity.HasKey(e => new { e.IdAttributeGroup, e.IdLang });

                entity.ToTable("ps_layered_indexable_attribute_group_lang_value", "skistore_se");

                entity.Property(e => e.IdAttributeGroup)
                    .HasColumnName("id_attribute_group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrlName)
                    .HasColumnName("url_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLayeredIndexableAttributeLangValue>(entity =>
            {
                entity.HasKey(e => new { e.IdAttribute, e.IdLang });

                entity.ToTable("ps_layered_indexable_attribute_lang_value", "skistore_se");

                entity.Property(e => e.IdAttribute)
                    .HasColumnName("id_attribute")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrlName)
                    .HasColumnName("url_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLayeredIndexableFeature>(entity =>
            {
                entity.HasKey(e => e.IdFeature);

                entity.ToTable("ps_layered_indexable_feature", "skistore_se");

                entity.Property(e => e.IdFeature)
                    .HasColumnName("id_feature")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Indexable)
                    .HasColumnName("indexable")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsLayeredIndexableFeatureLangValue>(entity =>
            {
                entity.HasKey(e => new { e.IdFeature, e.IdLang });

                entity.ToTable("ps_layered_indexable_feature_lang_value", "skistore_se");

                entity.Property(e => e.IdFeature)
                    .HasColumnName("id_feature")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrlName)
                    .IsRequired()
                    .HasColumnName("url_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLayeredIndexableFeatureValueLangValue>(entity =>
            {
                entity.HasKey(e => new { e.IdFeatureValue, e.IdLang });

                entity.ToTable("ps_layered_indexable_feature_value_lang_value", "skistore_se");

                entity.Property(e => e.IdFeatureValue)
                    .HasColumnName("id_feature_value")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrlName)
                    .HasColumnName("url_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLayeredPriceIndex>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdCurrency, e.IdShop });

                entity.ToTable("ps_layered_price_index", "skistore_se");

                entity.HasIndex(e => e.IdCurrency)
                    .HasName("id_currency");

                entity.HasIndex(e => e.PriceMax)
                    .HasName("price_max");

                entity.HasIndex(e => e.PriceMin)
                    .HasName("price_min");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PriceMax)
                    .HasColumnName("price_max")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PriceMin)
                    .HasColumnName("price_min")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsLengowLogsImport>(entity =>
            {
                entity.ToTable("ps_lengow_logs_import", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DeliveryAddressId)
                    .HasColumnName("delivery_address_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Extra)
                    .IsRequired()
                    .HasColumnName("extra")
                    .IsUnicode(false);

                entity.Property(e => e.IsFinished)
                    .HasColumnName("is_finished")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsProcessing)
                    .HasColumnName("is_processing")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LengowOrderId)
                    .IsRequired()
                    .HasColumnName("lengow_order_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLengowOrderLine>(entity =>
            {
                entity.ToTable("ps_lengow_order_line", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdOrderLine)
                    .IsRequired()
                    .HasColumnName("id_order_line")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLengowOrders>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("ps_lengow_orders", "skistore_se");

                entity.HasIndex(e => e.DateAdd)
                    .HasName("date_add");

                entity.HasIndex(e => e.IdOrderLengow)
                    .HasName("id_order_lengow");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_shop_group");

                entity.HasIndex(e => e.Marketplace)
                    .HasName("marketplace");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Carrier)
                    .HasColumnName("carrier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DeliveryAddressId)
                    .HasColumnName("delivery_address_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Extra)
                    .HasColumnName("extra")
                    .IsUnicode(false);

                entity.Property(e => e.IdFlux)
                    .HasColumnName("id_flux")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdOrderLengow)
                    .HasColumnName("id_order_lengow")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsDisabled)
                    .HasColumnName("is_disabled")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Marketplace)
                    .HasColumnName("marketplace")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasColumnName("method")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SentMarketplace)
                    .HasColumnName("sent_marketplace")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalPaid)
                    .HasColumnName("total_paid")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.Tracking)
                    .HasColumnName("tracking")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsLengowProduct>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.ToTable("ps_lengow_product", "skistore_se");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_shop_group");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsLinksmenutop>(entity =>
            {
                entity.HasKey(e => e.IdLinksmenutop);

                entity.ToTable("ps_linksmenutop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdLinksmenutop)
                    .HasColumnName("id_linksmenutop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.NewWindow)
                    .HasColumnName("new_window")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("ps_log", "skistore_se");

                entity.Property(e => e.IdLog)
                    .HasColumnName("id_log")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.ErrorCode)
                    .HasColumnName("error_code")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ObjectType)
                    .HasColumnName("object_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Severity)
                    .HasColumnName("severity")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsLoyalty>(entity =>
            {
                entity.HasKey(e => e.IdLoyalty);

                entity.ToTable("ps_loyalty", "skistore_se");

                entity.HasIndex(e => e.IdCartRule)
                    .HasName("index_loyalty_discount");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("index_loyalty_customer");

                entity.HasIndex(e => e.IdLoyaltyState)
                    .HasName("index_loyalty_loyalty_state");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("index_loyalty_order");

                entity.Property(e => e.IdLoyalty)
                    .HasColumnName("id_loyalty")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLoyaltyState)
                    .HasColumnName("id_loyalty_state")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsLoyaltyHistory>(entity =>
            {
                entity.HasKey(e => e.IdLoyaltyHistory);

                entity.ToTable("ps_loyalty_history", "skistore_se");

                entity.HasIndex(e => e.IdLoyalty)
                    .HasName("index_loyalty_history_loyalty");

                entity.HasIndex(e => e.IdLoyaltyState)
                    .HasName("index_loyalty_history_loyalty_state");

                entity.Property(e => e.IdLoyaltyHistory)
                    .HasColumnName("id_loyalty_history")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdLoyalty)
                    .HasColumnName("id_loyalty")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLoyaltyState)
                    .HasColumnName("id_loyalty_state")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsLoyaltyState>(entity =>
            {
                entity.HasKey(e => e.IdLoyaltyState);

                entity.ToTable("ps_loyalty_state", "skistore_se");

                entity.HasIndex(e => e.IdOrderState)
                    .HasName("index_loyalty_state_order_state");

                entity.Property(e => e.IdLoyaltyState)
                    .HasColumnName("id_loyalty_state")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrderState)
                    .HasColumnName("id_order_state")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsMailalertCustomerOos>(entity =>
            {
                entity.HasKey(e => new { e.IdCustomer, e.CustomerEmail, e.IdProduct, e.IdProductAttribute, e.IdShop });

                entity.ToTable("ps_mailalert_customer_oos", "skistore_se");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CustomerEmail)
                    .HasColumnName("customer_email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsManufacturer>(entity =>
            {
                entity.HasKey(e => e.IdManufacturer);

                entity.ToTable("ps_manufacturer", "skistore_se");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdManufacturerImporterosc)
                    .HasColumnName("id_manufacturer_importerosc")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ShowOnFront)
                    .HasColumnName("show_on_front")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsManufacturerLang>(entity =>
            {
                entity.HasKey(e => new { e.IdManufacturer, e.IdLang });

                entity.ToTable("ps_manufacturer_lang", "skistore_se");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("short_description")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsManufacturerShop>(entity =>
            {
                entity.HasKey(e => new { e.IdManufacturer, e.IdShop });

                entity.ToTable("ps_manufacturer_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsMemcachedServers>(entity =>
            {
                entity.HasKey(e => e.IdMemcachedServer);

                entity.ToTable("ps_memcached_servers", "skistore_se");

                entity.Property(e => e.IdMemcachedServer)
                    .HasColumnName("id_memcached_server")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsMessage>(entity =>
            {
                entity.HasKey(e => e.IdMessage);

                entity.ToTable("ps_message", "skistore_se");

                entity.HasIndex(e => e.IdCart)
                    .HasName("id_cart");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("id_customer");

                entity.HasIndex(e => e.IdEmployee)
                    .HasName("id_employee");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("message_order");

                entity.Property(e => e.IdMessage)
                    .HasColumnName("id_message")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdCart)
                    .HasColumnName("id_cart")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Private)
                    .HasColumnName("private")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsMessageReaded>(entity =>
            {
                entity.HasKey(e => new { e.IdMessage, e.IdEmployee });

                entity.ToTable("ps_message_readed", "skistore_se");

                entity.Property(e => e.IdMessage)
                    .HasColumnName("id_message")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");
            });

            modelBuilder.Entity<PsMeta>(entity =>
            {
                entity.HasKey(e => e.IdMeta);

                entity.ToTable("ps_meta", "skistore_se");

                entity.HasIndex(e => e.Page)
                    .HasName("meta_name");

                entity.Property(e => e.IdMeta)
                    .HasColumnName("id_meta")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Configurable)
                    .HasColumnName("configurable")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasColumnName("page")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsMetaLang>(entity =>
            {
                entity.HasKey(e => new { e.IdMeta, e.IdShop, e.IdLang });

                entity.ToTable("ps_meta_lang", "skistore_se");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdMeta)
                    .HasColumnName("id_meta")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UrlRewrite)
                    .IsRequired()
                    .HasColumnName("url_rewrite")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsModule>(entity =>
            {
                entity.HasKey(e => e.IdModule);

                entity.ToTable("ps_module", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsModuleAccess>(entity =>
            {
                entity.HasKey(e => new { e.IdProfile, e.IdModule });

                entity.ToTable("ps_module_access", "skistore_se");

                entity.Property(e => e.IdProfile)
                    .HasColumnName("id_profile")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Configure)
                    .HasColumnName("configure")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.View)
                    .HasColumnName("view")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsModuleCountry>(entity =>
            {
                entity.HasKey(e => new { e.IdModule, e.IdShop, e.IdCountry });

                entity.ToTable("ps_module_country", "skistore_se");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsModuleCurrency>(entity =>
            {
                entity.HasKey(e => new { e.IdModule, e.IdShop, e.IdCurrency });

                entity.ToTable("ps_module_currency", "skistore_se");

                entity.HasIndex(e => e.IdModule)
                    .HasName("id_module");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsModuleGroup>(entity =>
            {
                entity.HasKey(e => new { e.IdModule, e.IdShop, e.IdGroup });

                entity.ToTable("ps_module_group", "skistore_se");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsModulePreference>(entity =>
            {
                entity.HasKey(e => e.IdModulePreference);

                entity.ToTable("ps_module_preference", "skistore_se");

                entity.HasIndex(e => new { e.IdEmployee, e.Module })
                    .HasName("employee_module")
                    .IsUnique();

                entity.Property(e => e.IdModulePreference)
                    .HasColumnName("id_module_preference")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Favorite)
                    .HasColumnName("favorite")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Interest)
                    .HasColumnName("interest")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsModuleShop>(entity =>
            {
                entity.HasKey(e => new { e.IdModule, e.IdShop });

                entity.ToTable("ps_module_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.EnableDevice)
                    .HasColumnName("enable_device")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("7");
            });

            modelBuilder.Entity<PsNewsletter>(entity =>
            {
                entity.ToTable("ps_newsletter", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(6)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HttpReferer)
                    .HasColumnName("http_referer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IpRegistrationNewsletter)
                    .IsRequired()
                    .HasColumnName("ip_registration_newsletter")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterDateAdd).HasColumnName("newsletter_date_add");
            });

            modelBuilder.Entity<PsNostotaggingCustomerLink>(entity =>
            {
                entity.HasKey(e => new { e.IdCart, e.IdNostoCustomer });

                entity.ToTable("ps_nostotagging_customer_link", "skistore_se");

                entity.Property(e => e.IdCart)
                    .HasColumnName("id_cart")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdNostoCustomer)
                    .HasColumnName("id_nosto_customer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");
            });

            modelBuilder.Entity<PsNostotaggingCustomerReference>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.ToTable("ps_nostotagging_customer_reference", "skistore_se");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerReference)
                    .IsRequired()
                    .HasColumnName("customer_reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsOperatingSystem>(entity =>
            {
                entity.HasKey(e => e.IdOperatingSystem);

                entity.ToTable("ps_operating_system", "skistore_se");

                entity.Property(e => e.IdOperatingSystem)
                    .HasColumnName("id_operating_system")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsOrderCarrier>(entity =>
            {
                entity.HasKey(e => e.IdOrderCarrier);

                entity.ToTable("ps_order_carrier", "skistore_se");

                entity.HasIndex(e => e.IdCarrier)
                    .HasName("id_carrier");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("id_order");

                entity.HasIndex(e => e.IdOrderInvoice)
                    .HasName("id_order_invoice");

                entity.Property(e => e.IdOrderCarrier)
                    .HasColumnName("id_order_carrier")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdOrderInvoice)
                    .HasColumnName("id_order_invoice")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ShippingCostTaxExcl)
                    .HasColumnName("shipping_cost_tax_excl")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ShippingCostTaxIncl)
                    .HasColumnName("shipping_cost_tax_incl")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.TrackingNumber)
                    .HasColumnName("tracking_number")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");
            });

            modelBuilder.Entity<PsOrderCartRule>(entity =>
            {
                entity.HasKey(e => e.IdOrderCartRule);

                entity.ToTable("ps_order_cart_rule", "skistore_se");

                entity.HasIndex(e => e.IdCartRule)
                    .HasName("id_discount");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("order_discount_order");

                entity.Property(e => e.IdOrderCartRule)
                    .HasColumnName("id_order_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FreeShipping)
                    .HasColumnName("free_shipping")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrderInvoice)
                    .HasColumnName("id_order_invoice")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValueTaxExcl)
                    .HasColumnName("value_tax_excl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<PsOrderDetail>(entity =>
            {
                entity.HasKey(e => e.IdOrderDetail);

                entity.ToTable("ps_order_detail", "skistore_se");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("order_detail_order");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.ProductAttributeId)
                    .HasName("product_attribute_id");

                entity.HasIndex(e => e.ProductId)
                    .HasName("product_id");

                entity.HasIndex(e => new { e.IdOrder, e.IdOrderDetail })
                    .HasName("id_order_id_order_detail");

                entity.Property(e => e.IdOrderDetail)
                    .HasColumnName("id_order_detail")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DiscountQuantityApplied)
                    .HasColumnName("discount_quantity_applied")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DownloadDeadline)
                    .HasColumnName("download_deadline")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DownloadHash)
                    .HasColumnName("download_hash")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DownloadNb)
                    .HasColumnName("download_nb")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ecotax)
                    .HasColumnName("ecotax")
                    .HasColumnType("decimal(21,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.EcotaxTaxRate)
                    .HasColumnName("ecotax_tax_rate")
                    .HasColumnType("decimal(5,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.GroupReduction)
                    .HasColumnName("group_reduction")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrderInvoice)
                    .HasColumnName("id_order_invoice")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("id_warehouse")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OriginalProductPrice)
                    .HasColumnName("original_product_price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.OriginalWholesalePrice)
                    .HasColumnName("original_wholesale_price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ProductAttributeId)
                    .HasColumnName("product_attribute_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ProductEan13)
                    .HasColumnName("product_ean13")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("product_price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ProductQuantity)
                    .HasColumnName("product_quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductQuantityDiscount)
                    .HasColumnName("product_quantity_discount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ProductQuantityInStock)
                    .HasColumnName("product_quantity_in_stock")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductQuantityRefunded)
                    .HasColumnName("product_quantity_refunded")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductQuantityReinjected)
                    .HasColumnName("product_quantity_reinjected")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductQuantityReturn)
                    .HasColumnName("product_quantity_return")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductReference)
                    .HasColumnName("product_reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSupplierReference)
                    .HasColumnName("product_supplier_reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUpc)
                    .HasColumnName("product_upc")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ProductWeight)
                    .HasColumnName("product_weight")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.PurchaseSupplierPrice)
                    .HasColumnName("purchase_supplier_price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ReductionAmountTaxExcl)
                    .HasColumnName("reduction_amount_tax_excl")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ReductionAmountTaxIncl)
                    .HasColumnName("reduction_amount_tax_incl")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ReductionPercent)
                    .HasColumnName("reduction_percent")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ScAttrInfosV1)
                    .IsRequired()
                    .HasColumnName("sc_attr_infos_v1")
                    .IsUnicode(false);

                entity.Property(e => e.TaxComputationMethod)
                    .HasColumnName("tax_computation_method")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxName)
                    .IsRequired()
                    .HasColumnName("tax_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate)
                    .HasColumnName("tax_rate")
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.TotalPriceTaxExcl)
                    .HasColumnName("total_price_tax_excl")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TotalPriceTaxIncl)
                    .HasColumnName("total_price_tax_incl")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TotalShippingPriceTaxExcl)
                    .HasColumnName("total_shipping_price_tax_excl")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TotalShippingPriceTaxIncl)
                    .HasColumnName("total_shipping_price_tax_incl")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.UnitPriceTaxExcl)
                    .HasColumnName("unit_price_tax_excl")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.UnitPriceTaxIncl)
                    .HasColumnName("unit_price_tax_incl")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");
            });

            modelBuilder.Entity<PsOrderDiscount>(entity =>
            {
                entity.HasKey(e => e.IdOrderCartRule);

                entity.ToTable("ps_order_discount", "skistore_se");

                entity.HasIndex(e => e.IdCartRule)
                    .HasName("id_discount");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("order_discount_order");

                entity.Property(e => e.IdOrderCartRule)
                    .HasColumnName("id_order_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCartRule)
                    .HasColumnName("id_cart_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<PsOrderHistory>(entity =>
            {
                entity.HasKey(e => e.IdOrderHistory);

                entity.ToTable("ps_order_history", "skistore_se");

                entity.HasIndex(e => e.IdEmployee)
                    .HasName("id_employee");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("order_history_order");

                entity.HasIndex(e => e.IdOrderState)
                    .HasName("id_order_state");

                entity.Property(e => e.IdOrderHistory)
                    .HasColumnName("id_order_history")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrderState)
                    .HasColumnName("id_order_state")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsOrderInvoice>(entity =>
            {
                entity.HasKey(e => e.IdOrderInvoice);

                entity.ToTable("ps_order_invoice", "skistore_se");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("id_order");

                entity.Property(e => e.IdOrderInvoice)
                    .HasColumnName("id_order_invoice")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShippingTaxComputationMethod)
                    .HasColumnName("shipping_tax_computation_method")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalDiscountTaxExcl)
                    .HasColumnName("total_discount_tax_excl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalDiscountTaxIncl)
                    .HasColumnName("total_discount_tax_incl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalPaidTaxExcl)
                    .HasColumnName("total_paid_tax_excl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalPaidTaxIncl)
                    .HasColumnName("total_paid_tax_incl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalProducts)
                    .HasColumnName("total_products")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalProductsWt)
                    .HasColumnName("total_products_wt")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalShippingTaxExcl)
                    .HasColumnName("total_shipping_tax_excl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalShippingTaxIncl)
                    .HasColumnName("total_shipping_tax_incl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalWrappingTaxExcl)
                    .HasColumnName("total_wrapping_tax_excl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalWrappingTaxIncl)
                    .HasColumnName("total_wrapping_tax_incl")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<PsOrderInvoicePayment>(entity =>
            {
                entity.HasKey(e => new { e.IdOrderInvoice, e.IdOrderPayment });

                entity.ToTable("ps_order_invoice_payment", "skistore_se");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("id_order");

                entity.HasIndex(e => e.IdOrderPayment)
                    .HasName("order_payment");

                entity.Property(e => e.IdOrderInvoice)
                    .HasColumnName("id_order_invoice")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdOrderPayment)
                    .HasColumnName("id_order_payment")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsOrderMessage>(entity =>
            {
                entity.HasKey(e => e.IdOrderMessage);

                entity.ToTable("ps_order_message", "skistore_se");

                entity.Property(e => e.IdOrderMessage)
                    .HasColumnName("id_order_message")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");
            });

            modelBuilder.Entity<PsOrderMessageLang>(entity =>
            {
                entity.HasKey(e => new { e.IdOrderMessage, e.IdLang });

                entity.ToTable("ps_order_message_lang", "skistore_se");

                entity.Property(e => e.IdOrderMessage)
                    .HasColumnName("id_order_message")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsOrderPayment>(entity =>
            {
                entity.HasKey(e => e.IdOrderPayment);

                entity.ToTable("ps_order_payment", "skistore_se");

                entity.HasIndex(e => e.OrderReference)
                    .HasName("order_reference");

                entity.Property(e => e.IdOrderPayment)
                    .HasColumnName("id_order_payment")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.CardBrand)
                    .HasColumnName("card_brand")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.CardExpiration)
                    .HasColumnName("card_expiration")
                    .HasColumnType("char(7)");

                entity.Property(e => e.CardHolder)
                    .HasColumnName("card_holder")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ConversionRate)
                    .HasColumnName("conversion_rate")
                    .HasColumnType("decimal(13,6)")
                    .HasDefaultValueSql("1.000000");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.OrderReference)
                    .HasColumnName("order_reference")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasColumnName("payment_method")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsOrderReturn>(entity =>
            {
                entity.HasKey(e => e.IdOrderReturn);

                entity.ToTable("ps_order_return", "skistore_se");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("order_return_customer");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("id_order");

                entity.Property(e => e.IdOrderReturn)
                    .HasColumnName("id_order_return")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question")
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsOrderReturnDetail>(entity =>
            {
                entity.HasKey(e => new { e.IdOrderReturn, e.IdOrderDetail, e.IdCustomization });

                entity.ToTable("ps_order_return_detail", "skistore_se");

                entity.Property(e => e.IdOrderReturn)
                    .HasColumnName("id_order_return")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrderDetail)
                    .HasColumnName("id_order_detail")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomization)
                    .HasColumnName("id_customization")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductQuantity)
                    .HasColumnName("product_quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsOrderReturnState>(entity =>
            {
                entity.HasKey(e => e.IdOrderReturnState);

                entity.ToTable("ps_order_return_state", "skistore_se");

                entity.Property(e => e.IdOrderReturnState)
                    .HasColumnName("id_order_return_state")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsOrderSlip>(entity =>
            {
                entity.HasKey(e => e.IdOrderSlip);

                entity.ToTable("ps_order_slip", "skistore_se");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("order_slip_customer");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("id_order");

                entity.Property(e => e.IdOrderSlip)
                    .HasColumnName("id_order_slip")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ConversionRate)
                    .HasColumnName("conversion_rate")
                    .HasColumnType("decimal(13,6)")
                    .HasDefaultValueSql("1.000000");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Partial)
                    .HasColumnName("partial")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ShippingCost)
                    .HasColumnName("shipping_cost")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShippingCostAmount)
                    .HasColumnName("shipping_cost_amount")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<PsOrderSlipDetail>(entity =>
            {
                entity.HasKey(e => new { e.IdOrderSlip, e.IdOrderDetail });

                entity.ToTable("ps_order_slip_detail", "skistore_se");

                entity.Property(e => e.IdOrderSlip)
                    .HasColumnName("id_order_slip")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrderDetail)
                    .HasColumnName("id_order_detail")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AmountTaxExcl)
                    .HasColumnName("amount_tax_excl")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.AmountTaxIncl)
                    .HasColumnName("amount_tax_incl")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ProductQuantity)
                    .HasColumnName("product_quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsOrderState>(entity =>
            {
                entity.HasKey(e => e.IdOrderState);

                entity.ToTable("ps_order_state", "skistore_se");

                entity.Property(e => e.IdOrderState)
                    .HasColumnName("id_order_state")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Delivery)
                    .HasColumnName("delivery")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Logable)
                    .HasColumnName("logable")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Paid)
                    .HasColumnName("paid")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SendEmail)
                    .HasColumnName("send_email")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Shipped)
                    .HasColumnName("shipped")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Unremovable)
                    .HasColumnName("unremovable")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<PsOrders>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("ps_orders", "skistore_se");

                entity.HasIndex(e => e.CurrentState)
                    .HasName("current_state");

                entity.HasIndex(e => e.DateAdd)
                    .HasName("date_add");

                entity.HasIndex(e => e.IdAddressDelivery)
                    .HasName("id_address_delivery");

                entity.HasIndex(e => e.IdAddressInvoice)
                    .HasName("id_address_invoice");

                entity.HasIndex(e => e.IdCarrier)
                    .HasName("id_carrier");

                entity.HasIndex(e => e.IdCart)
                    .HasName("id_cart");

                entity.HasIndex(e => e.IdCurrency)
                    .HasName("id_currency");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("id_customer");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_group_shop");

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("invoice_number");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CarrierTaxRate)
                    .HasColumnName("carrier_tax_rate")
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.ConversionRate)
                    .HasColumnName("conversion_rate")
                    .HasColumnType("decimal(13,6)")
                    .HasDefaultValueSql("1.000000");

                entity.Property(e => e.CurrentState)
                    .HasColumnName("current_state")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gift)
                    .HasColumnName("gift")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GiftMessage)
                    .HasColumnName("gift_message")
                    .IsUnicode(false);

                entity.Property(e => e.IdAddressDelivery)
                    .HasColumnName("id_address_delivery")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdAddressInvoice)
                    .HasColumnName("id_address_invoice")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCart)
                    .HasColumnName("id_cart")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdSpecter)
                    .HasColumnName("id_specter")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvoiceDate).HasColumnName("invoice_date");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoice_number")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobileTheme)
                    .HasColumnName("mobile_theme")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasColumnName("payment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Recyclable)
                    .HasColumnName("recyclable")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecureKey)
                    .IsRequired()
                    .HasColumnName("secure_key")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.ShippingNumber)
                    .HasColumnName("shipping_number")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SpecterInvoice)
                    .HasColumnName("specterInvoice")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDiscounts)
                    .HasColumnName("total_discounts")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalDiscountsTaxExcl)
                    .HasColumnName("total_discounts_tax_excl")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.TotalDiscountsTaxIncl)
                    .HasColumnName("total_discounts_tax_incl")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.TotalPaid)
                    .HasColumnName("total_paid")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalPaidReal)
                    .HasColumnName("total_paid_real")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalPaidTaxExcl)
                    .HasColumnName("total_paid_tax_excl")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.TotalPaidTaxIncl)
                    .HasColumnName("total_paid_tax_incl")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.TotalProducts)
                    .HasColumnName("total_products")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalProductsWt)
                    .HasColumnName("total_products_wt")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalShipping)
                    .HasColumnName("total_shipping")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalShippingTaxExcl)
                    .HasColumnName("total_shipping_tax_excl")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.TotalShippingTaxIncl)
                    .HasColumnName("total_shipping_tax_incl")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.TotalWrapping)
                    .HasColumnName("total_wrapping")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalWrappingTaxExcl)
                    .HasColumnName("total_wrapping_tax_excl")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.TotalWrappingTaxIncl)
                    .HasColumnName("total_wrapping_tax_incl")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.Valid)
                    .HasColumnName("valid")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPack>(entity =>
            {
                entity.HasKey(e => new { e.IdProductPack, e.IdProductItem });

                entity.ToTable("ps_pack", "skistore_se");

                entity.Property(e => e.IdProductPack)
                    .HasColumnName("id_product_pack")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductItem)
                    .HasColumnName("id_product_item")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsPage>(entity =>
            {
                entity.HasKey(e => e.IdPage);

                entity.ToTable("ps_page", "skistore_se");

                entity.HasIndex(e => e.IdObject)
                    .HasName("id_object");

                entity.HasIndex(e => e.IdPageType)
                    .HasName("id_page_type");

                entity.Property(e => e.IdPage)
                    .HasColumnName("id_page")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdObject)
                    .HasColumnName("id_object")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdPageType)
                    .HasColumnName("id_page_type")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPageType>(entity =>
            {
                entity.HasKey(e => e.IdPageType);

                entity.ToTable("ps_page_type", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.IdPageType)
                    .HasColumnName("id_page_type")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPageViewed>(entity =>
            {
                entity.HasKey(e => new { e.IdPage, e.IdShop, e.IdDateRange });

                entity.ToTable("ps_page_viewed", "skistore_se");

                entity.Property(e => e.IdPage)
                    .HasColumnName("id_page")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdDateRange)
                    .HasColumnName("id_date_range")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsPagenotfound>(entity =>
            {
                entity.HasKey(e => e.IdPagenotfound);

                entity.ToTable("ps_pagenotfound", "skistore_se");

                entity.Property(e => e.IdPagenotfound)
                    .HasColumnName("id_pagenotfound")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.HttpReferer)
                    .IsRequired()
                    .HasColumnName("http_referer")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(10)");

                entity.Property(e => e.RequestUri)
                    .IsRequired()
                    .HasColumnName("request_uri")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPaymentCc>(entity =>
            {
                entity.HasKey(e => e.IdOrderPayment);

                entity.ToTable("ps_payment_cc", "skistore_se");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("id_order");

                entity.Property(e => e.IdOrderPayment)
                    .HasColumnName("id_order_payment")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.CardBrand)
                    .HasColumnName("card_brand")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.CardExpiration)
                    .HasColumnName("card_expiration")
                    .HasColumnType("char(7)");

                entity.Property(e => e.CardHolder)
                    .HasColumnName("card_holder")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ConversionRate)
                    .HasColumnName("conversion_rate")
                    .HasColumnType("decimal(13,6)")
                    .HasDefaultValueSql("1.000000");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdOrderInvoice)
                    .IsRequired()
                    .HasColumnName("id_order_invoice")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasColumnName("payment_method")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPaypalCustomer>(entity =>
            {
                entity.HasKey(e => e.IdPaypalCustomer);

                entity.ToTable("ps_paypal_customer", "skistore_se");

                entity.Property(e => e.IdPaypalCustomer)
                    .HasColumnName("id_paypal_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PaypalEmail)
                    .IsRequired()
                    .HasColumnName("paypal_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPaypalOrder>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("ps_paypal_order", "skistore_se");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Capture)
                    .HasColumnName("capture")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdInvoice)
                    .HasColumnName("id_invoice")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdTransaction)
                    .IsRequired()
                    .HasColumnName("id_transaction")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .IsRequired()
                    .HasColumnName("payment_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("payment_method")
                    .HasColumnType("int(2) unsigned");

                entity.Property(e => e.PaymentStatus)
                    .HasColumnName("payment_status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Shipping)
                    .IsRequired()
                    .HasColumnName("shipping")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPaid)
                    .IsRequired()
                    .HasColumnName("total_paid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPetTab>(entity =>
            {
                entity.HasKey(e => e.IdTab);

                entity.ToTable("ps_pet_tab", "skistore_se");

                entity.Property(e => e.IdTab)
                    .HasColumnName("id_tab")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPetTabContent>(entity =>
            {
                entity.HasKey(e => e.IdTabContent);

                entity.ToTable("ps_pet_tab_content", "skistore_se");

                entity.Property(e => e.IdTabContent)
                    .HasColumnName("id_tab_content")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdTab)
                    .HasColumnName("id_tab")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<PsPmAdsandslideshow>(entity =>
            {
                entity.HasKey(e => e.IdSlideshow);

                entity.ToTable("ps_pm_adsandslideshow", "skistore_se");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.DeleteAfter)
                    .HasName("delete_after");

                entity.HasIndex(e => e.IdHook)
                    .HasName("id_hook");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => new { e.DateStart, e.DateEnd })
                    .HasName("date_start");

                entity.Property(e => e.IdSlideshow)
                    .HasColumnName("id_slideshow")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ajax)
                    .HasColumnName("ajax")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BackgroundColor)
                    .IsRequired()
                    .HasColumnName("background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundImage)
                    .IsRequired()
                    .HasColumnName("background_image")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CaptionBackgroundColor)
                    .IsRequired()
                    .HasColumnName("caption_background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CaptionHeight)
                    .HasColumnName("caption_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CaptionOpacity)
                    .HasColumnName("caption_opacity")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CaptionPosition)
                    .HasColumnName("caption_position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CaptionTextColor)
                    .IsRequired()
                    .HasColumnName("caption_text_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClearAbove)
                    .HasColumnName("clear_above")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ClearBellow)
                    .HasColumnName("clear_bellow")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateEnd).HasColumnName("date_end");

                entity.Property(e => e.DateStart).HasColumnName("date_start");

                entity.Property(e => e.DeleteAfter)
                    .HasColumnName("delete_after")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DisplayAsBlock)
                    .HasColumnName("display_as_block")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectDuration)
                    .HasColumnName("effect_duration")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FitBackgroundImage)
                    .HasColumnName("fit_background_image")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Floating)
                    .HasColumnName("floating")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GanalyticsStats)
                    .HasColumnName("ganalytics_stats")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdHook)
                    .HasColumnName("id_hook")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.InternalName)
                    .IsRequired()
                    .HasColumnName("internal_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Margin)
                    .IsRequired()
                    .HasColumnName("margin")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBackgroundColor)
                    .IsRequired()
                    .HasColumnName("navigation_background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBackgroundColorOver)
                    .IsRequired()
                    .HasColumnName("navigation_background_color_over")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBorderColor)
                    .IsRequired()
                    .HasColumnName("navigation_border_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBorderColorOver)
                    .IsRequired()
                    .HasColumnName("navigation_border_color_over")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBorderSize)
                    .IsRequired()
                    .HasColumnName("navigation_border_size")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBtn)
                    .IsRequired()
                    .HasColumnName("navigation_btn")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationElementMargin)
                    .IsRequired()
                    .HasColumnName("navigation_element_margin")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationGlobalBackgroundColor)
                    .IsRequired()
                    .HasColumnName("navigation_global_background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationHeight)
                    .HasColumnName("navigation_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NavigationInner)
                    .HasColumnName("navigation_inner")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NavigationMargin)
                    .IsRequired()
                    .HasColumnName("navigation_margin")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationPosition)
                    .HasColumnName("navigation_position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NavigationTextColor)
                    .IsRequired()
                    .HasColumnName("navigation_text_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationTextColorOver)
                    .IsRequired()
                    .HasColumnName("navigation_text_color_over")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationType)
                    .HasColumnName("navigation_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NavigationWidth)
                    .HasColumnName("navigation_width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PauseDuration)
                    .HasColumnName("pause_duration")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevnextBtn)
                    .IsRequired()
                    .HasColumnName("prevnext_btn")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PrevnextInner)
                    .HasColumnName("prevnext_inner")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevnextMargin)
                    .IsRequired()
                    .HasColumnName("prevnext_margin")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PrevnextPosition)
                    .HasColumnName("prevnext_position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Privacy)
                    .HasColumnName("privacy")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ramdom)
                    .HasColumnName("ramdom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShowCaption)
                    .HasColumnName("show_caption")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShowPrevnext)
                    .HasColumnName("show_prevnext")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SlideAuto)
                    .HasColumnName("slide_auto")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SlideContinuous)
                    .HasColumnName("slide_continuous")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Theme)
                    .HasColumnName("theme")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TransitionEffect)
                    .IsRequired()
                    .HasColumnName("transition_effect")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdsandslideshowAutoConf>(entity =>
            {
                entity.HasKey(e => e.IdSlideshowConf);

                entity.ToTable("ps_pm_adsandslideshow_auto_conf", "skistore_se");

                entity.Property(e => e.IdSlideshowConf)
                    .HasColumnName("id_slideshow_conf")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BackgroundColor)
                    .IsRequired()
                    .HasColumnName("background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CaptionBackgroundColor)
                    .IsRequired()
                    .HasColumnName("caption_background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CaptionHeight)
                    .HasColumnName("caption_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CaptionOpacity)
                    .HasColumnName("caption_opacity")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CaptionPosition)
                    .HasColumnName("caption_position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CaptionTextColor)
                    .IsRequired()
                    .HasColumnName("caption_text_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.EffectDuration)
                    .HasColumnName("effect_duration")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Margin)
                    .IsRequired()
                    .HasColumnName("margin")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBackgroundColor)
                    .IsRequired()
                    .HasColumnName("navigation_background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBackgroundColorOver)
                    .IsRequired()
                    .HasColumnName("navigation_background_color_over")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBorderColor)
                    .IsRequired()
                    .HasColumnName("navigation_border_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBorderColorOver)
                    .IsRequired()
                    .HasColumnName("navigation_border_color_over")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationBorderSize)
                    .IsRequired()
                    .HasColumnName("navigation_border_size")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationElementMargin)
                    .IsRequired()
                    .HasColumnName("navigation_element_margin")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationGlobalBackgroundColor)
                    .IsRequired()
                    .HasColumnName("navigation_global_background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationHeight)
                    .HasColumnName("navigation_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NavigationInner)
                    .HasColumnName("navigation_inner")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NavigationMargin)
                    .IsRequired()
                    .HasColumnName("navigation_margin")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationPosition)
                    .HasColumnName("navigation_position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NavigationTextColor)
                    .IsRequired()
                    .HasColumnName("navigation_text_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationTextColorOver)
                    .IsRequired()
                    .HasColumnName("navigation_text_color_over")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NavigationType)
                    .HasColumnName("navigation_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NavigationWidth)
                    .HasColumnName("navigation_width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PauseDuration)
                    .HasColumnName("pause_duration")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevnextInner)
                    .HasColumnName("prevnext_inner")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevnextMargin)
                    .IsRequired()
                    .HasColumnName("prevnext_margin")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PrevnextPosition)
                    .HasColumnName("prevnext_position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Ramdom)
                    .HasColumnName("ramdom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShowCaption)
                    .HasColumnName("show_caption")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShowPrevnext)
                    .HasColumnName("show_prevnext")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SlideAuto)
                    .HasColumnName("slide_auto")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SlideContinuous)
                    .HasColumnName("slide_continuous")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TransitionEffect)
                    .IsRequired()
                    .HasColumnName("transition_effect")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdsandslideshowElement>(entity =>
            {
                entity.HasKey(e => e.IdElement);

                entity.ToTable("ps_pm_adsandslideshow_element", "skistore_se");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.DeleteAfter)
                    .HasName("delete_after");

                entity.HasIndex(e => e.IdSlideshow)
                    .HasName("id_slideshow");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => new { e.DateStart, e.DateEnd })
                    .HasName("date_start");

                entity.Property(e => e.IdElement)
                    .HasColumnName("id_element")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BackgroundColor)
                    .IsRequired()
                    .HasColumnName("background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateEnd).HasColumnName("date_end");

                entity.Property(e => e.DateStart).HasColumnName("date_start");

                entity.Property(e => e.DeleteAfter)
                    .HasColumnName("delete_after")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FitBackgroundImage)
                    .HasColumnName("fit_background_image")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSlideshow)
                    .HasColumnName("id_slideshow")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PauseDuration)
                    .HasColumnName("pause_duration")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Privacy)
                    .HasColumnName("privacy")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Products)
                    .IsRequired()
                    .HasColumnName("products")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProductsImageSize)
                    .IsRequired()
                    .HasColumnName("products_image_size")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Target)
                    .IsRequired()
                    .HasColumnName("target")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearch>(entity =>
            {
                entity.HasKey(e => e.IdSearch);

                entity.ToTable("ps_pm_advancedsearch", "skistore_se");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.IdHook)
                    .HasName("id_hook");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AddAnchorToUrl)
                    .HasColumnName("add_anchor_to_url")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BackgroundColor)
                    .HasColumnName("background_color")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BorderColor)
                    .HasColumnName("border_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BorderRadius)
                    .HasColumnName("border_radius")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BorderSize)
                    .HasColumnName("border_size")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.CollapsableCriterias)
                    .HasColumnName("collapsable_criterias")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ColorGroupTitle)
                    .HasColumnName("color_group_title")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ColorTitle)
                    .HasColumnName("color_title")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayEmptyCriteria)
                    .HasColumnName("display_empty_criteria")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayNbResultCriterion)
                    .HasColumnName("display_nb_result_criterion")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayNbResultOnBlc)
                    .HasColumnName("display_nb_result_on_blc")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DynamicCriterion)
                    .HasColumnName("dynamic_criterion")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FilterByEmplacement)
                    .HasColumnName("filter_by_emplacement")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FontSizeGroupTitle)
                    .HasColumnName("font_size_group_title")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FontSizeTitle)
                    .HasColumnName("font_size_title")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideEmptyCritGroup)
                    .HasColumnName("hide_empty_crit_group")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCategoryRoot)
                    .HasColumnName("id_category_root")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdHook)
                    .HasColumnName("id_hook")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertInCenterColumn)
                    .HasColumnName("insert_in_center_column")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InternalName)
                    .IsRequired()
                    .HasColumnName("internal_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KeepCategoryInformation)
                    .HasColumnName("keep_category_information")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PriorityOnCombinationImage)
                    .HasColumnName("priority_on_combination_image")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductsOrderBy)
                    .HasColumnName("products_order_by")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductsOrderWay)
                    .HasColumnName("products_order_way")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductsPerPage)
                    .HasColumnName("products_per_page")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecursingIndexing)
                    .HasColumnName("recursing_indexing")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RedirectOneProduct)
                    .HasColumnName("redirect_one_product")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RemindSelection)
                    .HasColumnName("remind_selection")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResetGroup)
                    .HasColumnName("reset_group")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SaveSelection)
                    .HasColumnName("save_selection")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScrolltopActive)
                    .HasColumnName("scrolltop_active")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SearchMethod)
                    .HasColumnName("search_method")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SearchOnStock)
                    .HasColumnName("search_on_stock")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SearchResultsSelector)
                    .IsRequired()
                    .HasColumnName("search_results_selector")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("#center_column");

                entity.Property(e => e.Share)
                    .HasColumnName("share")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShowHideCritMethod)
                    .HasColumnName("show_hide_crit_method")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SmartyVarName)
                    .IsRequired()
                    .HasColumnName("smarty_var_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StepSearch)
                    .HasColumnName("step_search")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UniqueSearch)
                    .HasColumnName("unique_search")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseCache)
                    .HasColumnName("use_cache")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProduct1>(entity =>
            {
                entity.HasKey(e => e.IdCacheProduct);

                entity.ToTable("ps_pm_advancedsearch_cache_product_1", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProduct2>(entity =>
            {
                entity.HasKey(e => e.IdCacheProduct);

                entity.ToTable("ps_pm_advancedsearch_cache_product_2", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProduct3>(entity =>
            {
                entity.HasKey(e => e.IdCacheProduct);

                entity.ToTable("ps_pm_advancedsearch_cache_product_3", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProduct4>(entity =>
            {
                entity.HasKey(e => e.IdCacheProduct);

                entity.ToTable("ps_pm_advancedsearch_cache_product_4", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProduct5>(entity =>
            {
                entity.HasKey(e => e.IdCacheProduct);

                entity.ToTable("ps_pm_advancedsearch_cache_product_5", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProduct6>(entity =>
            {
                entity.HasKey(e => e.IdCacheProduct);

                entity.ToTable("ps_pm_advancedsearch_cache_product_6", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProduct7>(entity =>
            {
                entity.HasKey(e => e.IdCacheProduct);

                entity.ToTable("ps_pm_advancedsearch_cache_product_7", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProductCriterion1>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCacheProduct });

                entity.ToTable("ps_pm_advancedsearch_cache_product_criterion_1", "skistore_se");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion2");

                entity.HasIndex(e => new { e.IdCriterion, e.IdCacheProduct })
                    .HasName("id_criterion");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProductCriterion2>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCacheProduct });

                entity.ToTable("ps_pm_advancedsearch_cache_product_criterion_2", "skistore_se");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion2");

                entity.HasIndex(e => new { e.IdCriterion, e.IdCacheProduct })
                    .HasName("id_criterion");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProductCriterion3>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCacheProduct });

                entity.ToTable("ps_pm_advancedsearch_cache_product_criterion_3", "skistore_se");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion2");

                entity.HasIndex(e => new { e.IdCriterion, e.IdCacheProduct })
                    .HasName("id_criterion");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProductCriterion4>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCacheProduct });

                entity.ToTable("ps_pm_advancedsearch_cache_product_criterion_4", "skistore_se");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion2");

                entity.HasIndex(e => new { e.IdCriterion, e.IdCacheProduct })
                    .HasName("id_criterion");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProductCriterion5>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCacheProduct });

                entity.ToTable("ps_pm_advancedsearch_cache_product_criterion_5", "skistore_se");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion2");

                entity.HasIndex(e => new { e.IdCriterion, e.IdCacheProduct })
                    .HasName("id_criterion");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProductCriterion6>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCacheProduct });

                entity.ToTable("ps_pm_advancedsearch_cache_product_criterion_6", "skistore_se");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion2");

                entity.HasIndex(e => new { e.IdCriterion, e.IdCacheProduct })
                    .HasName("id_criterion");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCacheProductCriterion7>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCacheProduct });

                entity.ToTable("ps_pm_advancedsearch_cache_product_criterion_7", "skistore_se");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion2");

                entity.HasIndex(e => new { e.IdCriterion, e.IdCacheProduct })
                    .HasName("id_criterion");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCategory>(entity =>
            {
                entity.HasKey(e => new { e.IdSearch, e.IdCategory });

                entity.ToTable("ps_pm_advancedsearch_category", "skistore_se");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCms>(entity =>
            {
                entity.HasKey(e => new { e.IdSearch, e.IdCms });

                entity.ToTable("ps_pm_advancedsearch_cms", "skistore_se");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion1>(entity =>
            {
                entity.HasKey(e => e.IdCriterion);

                entity.ToTable("ps_pm_advancedsearch_criterion_1", "skistore_se");

                entity.HasIndex(e => e.IdCriterionGroup)
                    .HasName("id_criterion_group");

                entity.HasIndex(e => e.IdParent)
                    .HasName("id_parent");

                entity.HasIndex(e => e.IsCustom)
                    .HasName("is_custom");

                entity.HasIndex(e => e.LevelDepth)
                    .HasName("level_depth");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => e.SingleValue)
                    .HasName("single_value");

                entity.HasIndex(e => e.Visible)
                    .HasName("visible");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SingleValue)
                    .HasColumnName("single_value")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion1Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_1_lang", "skistore_se");

                entity.HasIndex(e => e.Value)
                    .HasName("value");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion1Link>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCriterionLinked });

                entity.ToTable("ps_pm_advancedsearch_criterion_1_link", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionLinked)
                    .HasName("id_criterion_linked");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterionLinked)
                    .HasColumnName("id_criterion_linked")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion1List>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionParent, e.IdCriterion });

                entity.ToTable("ps_pm_advancedsearch_criterion_1_list", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionParent)
                    .HasName("id_criterion_parent");

                entity.Property(e => e.IdCriterionParent)
                    .HasColumnName("id_criterion_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion2>(entity =>
            {
                entity.HasKey(e => e.IdCriterion);

                entity.ToTable("ps_pm_advancedsearch_criterion_2", "skistore_se");

                entity.HasIndex(e => e.IdCriterionGroup)
                    .HasName("id_criterion_group");

                entity.HasIndex(e => e.IdParent)
                    .HasName("id_parent");

                entity.HasIndex(e => e.IsCustom)
                    .HasName("is_custom");

                entity.HasIndex(e => e.LevelDepth)
                    .HasName("level_depth");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => e.SingleValue)
                    .HasName("single_value");

                entity.HasIndex(e => e.Visible)
                    .HasName("visible");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SingleValue)
                    .HasColumnName("single_value")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion2Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_2_lang", "skistore_se");

                entity.HasIndex(e => e.Value)
                    .HasName("value");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion2Link>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCriterionLinked });

                entity.ToTable("ps_pm_advancedsearch_criterion_2_link", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionLinked)
                    .HasName("id_criterion_linked");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterionLinked)
                    .HasColumnName("id_criterion_linked")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion2List>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionParent, e.IdCriterion });

                entity.ToTable("ps_pm_advancedsearch_criterion_2_list", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionParent)
                    .HasName("id_criterion_parent");

                entity.Property(e => e.IdCriterionParent)
                    .HasColumnName("id_criterion_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion3>(entity =>
            {
                entity.HasKey(e => e.IdCriterion);

                entity.ToTable("ps_pm_advancedsearch_criterion_3", "skistore_se");

                entity.HasIndex(e => e.IdCriterionGroup)
                    .HasName("id_criterion_group");

                entity.HasIndex(e => e.IdParent)
                    .HasName("id_parent");

                entity.HasIndex(e => e.IsCustom)
                    .HasName("is_custom");

                entity.HasIndex(e => e.LevelDepth)
                    .HasName("level_depth");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => e.SingleValue)
                    .HasName("single_value");

                entity.HasIndex(e => e.Visible)
                    .HasName("visible");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SingleValue)
                    .HasColumnName("single_value")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion3Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_3_lang", "skistore_se");

                entity.HasIndex(e => e.Value)
                    .HasName("value");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion3Link>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCriterionLinked });

                entity.ToTable("ps_pm_advancedsearch_criterion_3_link", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionLinked)
                    .HasName("id_criterion_linked");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterionLinked)
                    .HasColumnName("id_criterion_linked")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion3List>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionParent, e.IdCriterion });

                entity.ToTable("ps_pm_advancedsearch_criterion_3_list", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionParent)
                    .HasName("id_criterion_parent");

                entity.Property(e => e.IdCriterionParent)
                    .HasColumnName("id_criterion_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion4>(entity =>
            {
                entity.HasKey(e => e.IdCriterion);

                entity.ToTable("ps_pm_advancedsearch_criterion_4", "skistore_se");

                entity.HasIndex(e => e.IdCriterionGroup)
                    .HasName("id_criterion_group");

                entity.HasIndex(e => e.IdParent)
                    .HasName("id_parent");

                entity.HasIndex(e => e.IsCustom)
                    .HasName("is_custom");

                entity.HasIndex(e => e.LevelDepth)
                    .HasName("level_depth");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => e.SingleValue)
                    .HasName("single_value");

                entity.HasIndex(e => e.Visible)
                    .HasName("visible");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SingleValue)
                    .HasColumnName("single_value")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion4Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_4_lang", "skistore_se");

                entity.HasIndex(e => e.Value)
                    .HasName("value");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion4Link>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCriterionLinked });

                entity.ToTable("ps_pm_advancedsearch_criterion_4_link", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionLinked)
                    .HasName("id_criterion_linked");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterionLinked)
                    .HasColumnName("id_criterion_linked")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion4List>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionParent, e.IdCriterion });

                entity.ToTable("ps_pm_advancedsearch_criterion_4_list", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionParent)
                    .HasName("id_criterion_parent");

                entity.Property(e => e.IdCriterionParent)
                    .HasColumnName("id_criterion_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion5>(entity =>
            {
                entity.HasKey(e => e.IdCriterion);

                entity.ToTable("ps_pm_advancedsearch_criterion_5", "skistore_se");

                entity.HasIndex(e => e.IdCriterionGroup)
                    .HasName("id_criterion_group");

                entity.HasIndex(e => e.IdParent)
                    .HasName("id_parent");

                entity.HasIndex(e => e.IsCustom)
                    .HasName("is_custom");

                entity.HasIndex(e => e.LevelDepth)
                    .HasName("level_depth");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => e.SingleValue)
                    .HasName("single_value");

                entity.HasIndex(e => e.Visible)
                    .HasName("visible");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SingleValue)
                    .HasColumnName("single_value")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion5Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_5_lang", "skistore_se");

                entity.HasIndex(e => e.Value)
                    .HasName("value");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion5Link>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCriterionLinked });

                entity.ToTable("ps_pm_advancedsearch_criterion_5_link", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionLinked)
                    .HasName("id_criterion_linked");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterionLinked)
                    .HasColumnName("id_criterion_linked")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion5List>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionParent, e.IdCriterion });

                entity.ToTable("ps_pm_advancedsearch_criterion_5_list", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionParent)
                    .HasName("id_criterion_parent");

                entity.Property(e => e.IdCriterionParent)
                    .HasColumnName("id_criterion_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion6>(entity =>
            {
                entity.HasKey(e => e.IdCriterion);

                entity.ToTable("ps_pm_advancedsearch_criterion_6", "skistore_se");

                entity.HasIndex(e => e.IdCriterionGroup)
                    .HasName("id_criterion_group");

                entity.HasIndex(e => e.IdParent)
                    .HasName("id_parent");

                entity.HasIndex(e => e.IsCustom)
                    .HasName("is_custom");

                entity.HasIndex(e => e.LevelDepth)
                    .HasName("level_depth");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => e.SingleValue)
                    .HasName("single_value");

                entity.HasIndex(e => e.Visible)
                    .HasName("visible");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SingleValue)
                    .HasColumnName("single_value")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion6Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_6_lang", "skistore_se");

                entity.HasIndex(e => e.Value)
                    .HasName("value");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion6Link>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCriterionLinked });

                entity.ToTable("ps_pm_advancedsearch_criterion_6_link", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionLinked)
                    .HasName("id_criterion_linked");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterionLinked)
                    .HasColumnName("id_criterion_linked")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion6List>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionParent, e.IdCriterion });

                entity.ToTable("ps_pm_advancedsearch_criterion_6_list", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionParent)
                    .HasName("id_criterion_parent");

                entity.Property(e => e.IdCriterionParent)
                    .HasColumnName("id_criterion_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion7>(entity =>
            {
                entity.HasKey(e => e.IdCriterion);

                entity.ToTable("ps_pm_advancedsearch_criterion_7", "skistore_se");

                entity.HasIndex(e => e.IdCriterionGroup)
                    .HasName("id_criterion_group");

                entity.HasIndex(e => e.IdParent)
                    .HasName("id_parent");

                entity.HasIndex(e => e.IsCustom)
                    .HasName("is_custom");

                entity.HasIndex(e => e.LevelDepth)
                    .HasName("level_depth");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => e.SingleValue)
                    .HasName("single_value");

                entity.HasIndex(e => e.Visible)
                    .HasName("visible");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SingleValue)
                    .HasColumnName("single_value")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion7Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_7_lang", "skistore_se");

                entity.HasIndex(e => e.Value)
                    .HasName("value");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion7Link>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterion, e.IdCriterionLinked });

                entity.ToTable("ps_pm_advancedsearch_criterion_7_link", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionLinked)
                    .HasName("id_criterion_linked");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterionLinked)
                    .HasColumnName("id_criterion_linked")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterion7List>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionParent, e.IdCriterion });

                entity.ToTable("ps_pm_advancedsearch_criterion_7_list", "skistore_se");

                entity.HasIndex(e => e.IdCriterion)
                    .HasName("id_criterion");

                entity.HasIndex(e => e.IdCriterionParent)
                    .HasName("id_criterion_parent");

                entity.Property(e => e.IdCriterionParent)
                    .HasColumnName("id_criterion_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCriterion)
                    .HasColumnName("id_criterion")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup1>(entity =>
            {
                entity.HasKey(e => e.IdCriterionGroup);

                entity.ToTable("ps_pm_advancedsearch_criterion_group_1", "skistore_se");

                entity.HasIndex(e => new { e.IdSearch, e.Visible, e.Position })
                    .HasName("id_search");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CriterionGroupType)
                    .IsRequired()
                    .HasColumnName("criterion_group_type")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayType)
                    .HasColumnName("display_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroupLinked)
                    .HasColumnName("id_criterion_group_linked")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCollapsed)
                    .HasColumnName("is_collapsed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMulticriteria)
                    .HasColumnName("is_multicriteria")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDisplay)
                    .HasColumnName("max_display")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlyChildren)
                    .HasColumnName("only_children")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverflowHeight)
                    .HasColumnName("overflow_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeNb)
                    .HasColumnName("range_nb")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("15.00");

                entity.Property(e => e.ShowAllDepth)
                    .HasColumnName("show_all_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SortBy)
                    .HasColumnName("sort_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("position");

                entity.Property(e => e.SortWay)
                    .HasColumnName("sort_way")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("ASC");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup1Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionGroup, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_group_1_lang", "skistore_se");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeInterval)
                    .HasColumnName("range_interval")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeSign)
                    .HasColumnName("range_sign")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup2>(entity =>
            {
                entity.HasKey(e => e.IdCriterionGroup);

                entity.ToTable("ps_pm_advancedsearch_criterion_group_2", "skistore_se");

                entity.HasIndex(e => new { e.IdSearch, e.Visible, e.Position })
                    .HasName("id_search");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CriterionGroupType)
                    .IsRequired()
                    .HasColumnName("criterion_group_type")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayType)
                    .HasColumnName("display_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroupLinked)
                    .HasColumnName("id_criterion_group_linked")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCollapsed)
                    .HasColumnName("is_collapsed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMulticriteria)
                    .HasColumnName("is_multicriteria")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDisplay)
                    .HasColumnName("max_display")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlyChildren)
                    .HasColumnName("only_children")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverflowHeight)
                    .HasColumnName("overflow_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeNb)
                    .HasColumnName("range_nb")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("15.00");

                entity.Property(e => e.ShowAllDepth)
                    .HasColumnName("show_all_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SortBy)
                    .HasColumnName("sort_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("position");

                entity.Property(e => e.SortWay)
                    .HasColumnName("sort_way")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("ASC");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup2Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionGroup, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_group_2_lang", "skistore_se");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeInterval)
                    .HasColumnName("range_interval")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeSign)
                    .HasColumnName("range_sign")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup3>(entity =>
            {
                entity.HasKey(e => e.IdCriterionGroup);

                entity.ToTable("ps_pm_advancedsearch_criterion_group_3", "skistore_se");

                entity.HasIndex(e => new { e.IdSearch, e.Visible, e.Position })
                    .HasName("id_search");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CriterionGroupType)
                    .IsRequired()
                    .HasColumnName("criterion_group_type")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayType)
                    .HasColumnName("display_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroupLinked)
                    .HasColumnName("id_criterion_group_linked")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCollapsed)
                    .HasColumnName("is_collapsed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMulticriteria)
                    .HasColumnName("is_multicriteria")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDisplay)
                    .HasColumnName("max_display")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlyChildren)
                    .HasColumnName("only_children")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverflowHeight)
                    .HasColumnName("overflow_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeNb)
                    .HasColumnName("range_nb")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("15.00");

                entity.Property(e => e.ShowAllDepth)
                    .HasColumnName("show_all_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SortBy)
                    .HasColumnName("sort_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("position");

                entity.Property(e => e.SortWay)
                    .HasColumnName("sort_way")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("ASC");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup3Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionGroup, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_group_3_lang", "skistore_se");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeInterval)
                    .HasColumnName("range_interval")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeSign)
                    .HasColumnName("range_sign")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup4>(entity =>
            {
                entity.HasKey(e => e.IdCriterionGroup);

                entity.ToTable("ps_pm_advancedsearch_criterion_group_4", "skistore_se");

                entity.HasIndex(e => new { e.IdSearch, e.Visible, e.Position })
                    .HasName("id_search");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CriterionGroupType)
                    .IsRequired()
                    .HasColumnName("criterion_group_type")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayType)
                    .HasColumnName("display_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroupLinked)
                    .HasColumnName("id_criterion_group_linked")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCollapsed)
                    .HasColumnName("is_collapsed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMulticriteria)
                    .HasColumnName("is_multicriteria")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDisplay)
                    .HasColumnName("max_display")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlyChildren)
                    .HasColumnName("only_children")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverflowHeight)
                    .HasColumnName("overflow_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeNb)
                    .HasColumnName("range_nb")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("15.00");

                entity.Property(e => e.ShowAllDepth)
                    .HasColumnName("show_all_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SortBy)
                    .HasColumnName("sort_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("position");

                entity.Property(e => e.SortWay)
                    .HasColumnName("sort_way")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("ASC");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup4Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionGroup, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_group_4_lang", "skistore_se");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeInterval)
                    .HasColumnName("range_interval")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeSign)
                    .HasColumnName("range_sign")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup5>(entity =>
            {
                entity.HasKey(e => e.IdCriterionGroup);

                entity.ToTable("ps_pm_advancedsearch_criterion_group_5", "skistore_se");

                entity.HasIndex(e => new { e.IdSearch, e.Visible, e.Position })
                    .HasName("id_search");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CriterionGroupType)
                    .IsRequired()
                    .HasColumnName("criterion_group_type")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayType)
                    .HasColumnName("display_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroupLinked)
                    .HasColumnName("id_criterion_group_linked")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCollapsed)
                    .HasColumnName("is_collapsed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMulticriteria)
                    .HasColumnName("is_multicriteria")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDisplay)
                    .HasColumnName("max_display")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlyChildren)
                    .HasColumnName("only_children")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverflowHeight)
                    .HasColumnName("overflow_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeNb)
                    .HasColumnName("range_nb")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("15.00");

                entity.Property(e => e.ShowAllDepth)
                    .HasColumnName("show_all_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SortBy)
                    .HasColumnName("sort_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("position");

                entity.Property(e => e.SortWay)
                    .HasColumnName("sort_way")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("ASC");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup5Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionGroup, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_group_5_lang", "skistore_se");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeInterval)
                    .HasColumnName("range_interval")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeSign)
                    .HasColumnName("range_sign")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup6>(entity =>
            {
                entity.HasKey(e => e.IdCriterionGroup);

                entity.ToTable("ps_pm_advancedsearch_criterion_group_6", "skistore_se");

                entity.HasIndex(e => new { e.IdSearch, e.Visible, e.Position })
                    .HasName("id_search");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CriterionGroupType)
                    .IsRequired()
                    .HasColumnName("criterion_group_type")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayType)
                    .HasColumnName("display_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroupLinked)
                    .HasColumnName("id_criterion_group_linked")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCollapsed)
                    .HasColumnName("is_collapsed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMulticriteria)
                    .HasColumnName("is_multicriteria")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDisplay)
                    .HasColumnName("max_display")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlyChildren)
                    .HasColumnName("only_children")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverflowHeight)
                    .HasColumnName("overflow_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeNb)
                    .HasColumnName("range_nb")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("15.00");

                entity.Property(e => e.ShowAllDepth)
                    .HasColumnName("show_all_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SortBy)
                    .HasColumnName("sort_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("position");

                entity.Property(e => e.SortWay)
                    .HasColumnName("sort_way")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("ASC");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup6Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionGroup, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_group_6_lang", "skistore_se");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeInterval)
                    .HasColumnName("range_interval")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeSign)
                    .HasColumnName("range_sign")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup7>(entity =>
            {
                entity.HasKey(e => e.IdCriterionGroup);

                entity.ToTable("ps_pm_advancedsearch_criterion_group_7", "skistore_se");

                entity.HasIndex(e => new { e.IdSearch, e.Visible, e.Position })
                    .HasName("id_search");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CriterionGroupType)
                    .IsRequired()
                    .HasColumnName("criterion_group_type")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayType)
                    .HasColumnName("display_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroupLinked)
                    .HasColumnName("id_criterion_group_linked")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsCollapsed)
                    .HasColumnName("is_collapsed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMulticriteria)
                    .HasColumnName("is_multicriteria")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDisplay)
                    .HasColumnName("max_display")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlyChildren)
                    .HasColumnName("only_children")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverflowHeight)
                    .HasColumnName("overflow_height")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeNb)
                    .HasColumnName("range_nb")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("15.00");

                entity.Property(e => e.ShowAllDepth)
                    .HasColumnName("show_all_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SortBy)
                    .HasColumnName("sort_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("position");

                entity.Property(e => e.SortWay)
                    .HasColumnName("sort_way")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("ASC");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchCriterionGroup7Lang>(entity =>
            {
                entity.HasKey(e => new { e.IdCriterionGroup, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_criterion_group_7_lang", "skistore_se");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeInterval)
                    .HasColumnName("range_interval")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RangeSign)
                    .HasColumnName("range_sign")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchLang>(entity =>
            {
                entity.HasKey(e => new { e.IdSearch, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_lang", "skistore_se");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchManufacturers>(entity =>
            {
                entity.HasKey(e => new { e.IdSearch, e.IdManufacturer });

                entity.ToTable("ps_pm_advancedsearch_manufacturers", "skistore_se");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchProductPrice1>(entity =>
            {
                entity.HasKey(e => new { e.IdCacheProduct, e.IdCurrency, e.IdCountry, e.IdGroup, e.PriceWt, e.ReductionAmount, e.From, e.To });

                entity.ToTable("ps_pm_advancedsearch_product_price_1", "skistore_se");

                entity.HasIndex(e => e.HasNoSpecific)
                    .HasName("has_no_specific");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IsSpecific)
                    .HasName("is_specific");

                entity.HasIndex(e => e.ValidIdSpecificPrice)
                    .HasName("valid_id_specific_price");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PriceWt)
                    .HasColumnName("price_wt")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.HasNoSpecific)
                    .HasColumnName("has_no_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSpecificPrice)
                    .HasColumnName("id_specific_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsSpecific)
                    .HasColumnName("is_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionTax)
                    .HasColumnName("reduction_tax")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReductionType)
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.ValidIdSpecificPrice)
                    .HasColumnName("valid_id_specific_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchProductPrice2>(entity =>
            {
                entity.HasKey(e => new { e.IdCacheProduct, e.IdCurrency, e.IdCountry, e.IdGroup, e.PriceWt, e.ReductionAmount, e.From, e.To });

                entity.ToTable("ps_pm_advancedsearch_product_price_2", "skistore_se");

                entity.HasIndex(e => e.HasNoSpecific)
                    .HasName("has_no_specific");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IsSpecific)
                    .HasName("is_specific");

                entity.HasIndex(e => e.ValidIdSpecificPrice)
                    .HasName("valid_id_specific_price");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PriceWt)
                    .HasColumnName("price_wt")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.HasNoSpecific)
                    .HasColumnName("has_no_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSpecificPrice)
                    .HasColumnName("id_specific_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsSpecific)
                    .HasColumnName("is_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionTax)
                    .HasColumnName("reduction_tax")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReductionType)
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.ValidIdSpecificPrice)
                    .HasColumnName("valid_id_specific_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchProductPrice3>(entity =>
            {
                entity.HasKey(e => new { e.IdCacheProduct, e.IdCurrency, e.IdCountry, e.IdGroup, e.PriceWt, e.ReductionAmount, e.From, e.To });

                entity.ToTable("ps_pm_advancedsearch_product_price_3", "skistore_se");

                entity.HasIndex(e => e.HasNoSpecific)
                    .HasName("has_no_specific");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IsSpecific)
                    .HasName("is_specific");

                entity.HasIndex(e => e.ValidIdSpecificPrice)
                    .HasName("valid_id_specific_price");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PriceWt)
                    .HasColumnName("price_wt")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.HasNoSpecific)
                    .HasColumnName("has_no_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSpecificPrice)
                    .HasColumnName("id_specific_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsSpecific)
                    .HasColumnName("is_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionTax)
                    .HasColumnName("reduction_tax")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReductionType)
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.ValidIdSpecificPrice)
                    .HasColumnName("valid_id_specific_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchProductPrice4>(entity =>
            {
                entity.HasKey(e => new { e.IdCacheProduct, e.IdCurrency, e.IdCountry, e.IdGroup, e.PriceWt, e.ReductionAmount, e.From, e.To });

                entity.ToTable("ps_pm_advancedsearch_product_price_4", "skistore_se");

                entity.HasIndex(e => e.HasNoSpecific)
                    .HasName("has_no_specific");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IsSpecific)
                    .HasName("is_specific");

                entity.HasIndex(e => e.ValidIdSpecificPrice)
                    .HasName("valid_id_specific_price");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PriceWt)
                    .HasColumnName("price_wt")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.HasNoSpecific)
                    .HasColumnName("has_no_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSpecificPrice)
                    .HasColumnName("id_specific_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsSpecific)
                    .HasColumnName("is_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionTax)
                    .HasColumnName("reduction_tax")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReductionType)
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.ValidIdSpecificPrice)
                    .HasColumnName("valid_id_specific_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchProductPrice5>(entity =>
            {
                entity.HasKey(e => new { e.IdCacheProduct, e.IdCurrency, e.IdCountry, e.IdGroup, e.PriceWt, e.ReductionAmount, e.From, e.To });

                entity.ToTable("ps_pm_advancedsearch_product_price_5", "skistore_se");

                entity.HasIndex(e => e.HasNoSpecific)
                    .HasName("has_no_specific");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IsSpecific)
                    .HasName("is_specific");

                entity.HasIndex(e => e.ValidIdSpecificPrice)
                    .HasName("valid_id_specific_price");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PriceWt)
                    .HasColumnName("price_wt")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.HasNoSpecific)
                    .HasColumnName("has_no_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSpecificPrice)
                    .HasColumnName("id_specific_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsSpecific)
                    .HasColumnName("is_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionTax)
                    .HasColumnName("reduction_tax")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReductionType)
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.ValidIdSpecificPrice)
                    .HasColumnName("valid_id_specific_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchProductPrice6>(entity =>
            {
                entity.HasKey(e => new { e.IdCacheProduct, e.IdCurrency, e.IdCountry, e.IdGroup, e.PriceWt, e.ReductionAmount, e.From, e.To });

                entity.ToTable("ps_pm_advancedsearch_product_price_6", "skistore_se");

                entity.HasIndex(e => e.HasNoSpecific)
                    .HasName("has_no_specific");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IsSpecific)
                    .HasName("is_specific");

                entity.HasIndex(e => e.ValidIdSpecificPrice)
                    .HasName("valid_id_specific_price");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PriceWt)
                    .HasColumnName("price_wt")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.HasNoSpecific)
                    .HasColumnName("has_no_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSpecificPrice)
                    .HasColumnName("id_specific_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsSpecific)
                    .HasColumnName("is_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionTax)
                    .HasColumnName("reduction_tax")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReductionType)
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.ValidIdSpecificPrice)
                    .HasColumnName("valid_id_specific_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchProductPrice7>(entity =>
            {
                entity.HasKey(e => new { e.IdCacheProduct, e.IdCurrency, e.IdCountry, e.IdGroup, e.PriceWt, e.ReductionAmount, e.From, e.To });

                entity.ToTable("ps_pm_advancedsearch_product_price_7", "skistore_se");

                entity.HasIndex(e => e.HasNoSpecific)
                    .HasName("has_no_specific");

                entity.HasIndex(e => e.IdCacheProduct)
                    .HasName("id_cache_product");

                entity.HasIndex(e => e.IsSpecific)
                    .HasName("is_specific");

                entity.HasIndex(e => e.ValidIdSpecificPrice)
                    .HasName("valid_id_specific_price");

                entity.Property(e => e.IdCacheProduct)
                    .HasColumnName("id_cache_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PriceWt)
                    .HasColumnName("price_wt")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionAmount)
                    .HasColumnName("reduction_amount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.HasNoSpecific)
                    .HasColumnName("has_no_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCriterionGroup)
                    .HasColumnName("id_criterion_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSpecificPrice)
                    .HasColumnName("id_specific_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsSpecific)
                    .HasColumnName("is_specific")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReductionTax)
                    .HasColumnName("reduction_tax")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReductionType)
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.ValidIdSpecificPrice)
                    .HasColumnName("valid_id_specific_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsPmAdvancedsearchProducts>(entity =>
            {
                entity.HasKey(e => new { e.IdSearch, e.IdProduct });

                entity.ToTable("ps_pm_advancedsearch_products", "skistore_se");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchSeo>(entity =>
            {
                entity.HasKey(e => e.IdSeo);

                entity.ToTable("ps_pm_advancedsearch_seo", "skistore_se");

                entity.HasIndex(e => e.Deleted)
                    .HasName("deleted");

                entity.HasIndex(e => e.IdSearch)
                    .HasName("id_search");

                entity.HasIndex(e => e.SeoKey)
                    .HasName("seo_key")
                    .IsUnique();

                entity.Property(e => e.IdSeo)
                    .HasColumnName("id_seo")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Criteria)
                    .IsRequired()
                    .HasColumnName("criteria")
                    .IsUnicode(false);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SeoKey)
                    .IsRequired()
                    .HasColumnName("seo_key")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchSeoCrosslinks>(entity =>
            {
                entity.HasKey(e => new { e.IdSeo, e.IdSeoLinked });

                entity.ToTable("ps_pm_advancedsearch_seo_crosslinks", "skistore_se");

                entity.Property(e => e.IdSeo)
                    .HasColumnName("id_seo")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSeoLinked)
                    .HasColumnName("id_seo_linked")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsPmAdvancedsearchSeoLang>(entity =>
            {
                entity.HasKey(e => new { e.IdSeo, e.IdLang });

                entity.ToTable("ps_pm_advancedsearch_seo_lang", "skistore_se");

                entity.Property(e => e.IdSeo)
                    .HasColumnName("id_seo")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .IsRequired()
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SeoUrl)
                    .IsRequired()
                    .HasColumnName("seo_url")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchShop>(entity =>
            {
                entity.HasKey(e => new { e.IdSearch, e.IdShop });

                entity.ToTable("ps_pm_advancedsearch_shop", "skistore_se");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsPmAdvancedsearchSpecialPages>(entity =>
            {
                entity.HasKey(e => new { e.IdSearch, e.Page });

                entity.ToTable("ps_pm_advancedsearch_special_pages", "skistore_se");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Page)
                    .HasColumnName("page")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPmAdvancedsearchSuppliers>(entity =>
            {
                entity.HasKey(e => new { e.IdSearch, e.IdSupplier });

                entity.ToTable("ps_pm_advancedsearch_suppliers", "skistore_se");

                entity.Property(e => e.IdSearch)
                    .HasColumnName("id_search")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProdtabs>(entity =>
            {
                entity.ToTable("ps_prodtabs", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsProduct>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.ToTable("ps_product", "skistore_se");

                entity.HasIndex(e => e.DateAdd)
                    .HasName("date_add");

                entity.HasIndex(e => e.IdCategoryDefault)
                    .HasName("id_category_default");

                entity.HasIndex(e => e.IdManufacturer)
                    .HasName("product_manufacturer");

                entity.HasIndex(e => e.IdSupplier)
                    .HasName("product_supplier");

                entity.HasIndex(e => e.Indexed)
                    .HasName("indexed");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AdditionalShippingCost)
                    .HasColumnName("additional_shipping_cost")
                    .HasColumnType("decimal(20,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.AdvancedStockManagement)
                    .HasColumnName("advanced_stock_management")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AvailableDate)
                    .HasColumnName("available_date")
                    .HasColumnType("date");

                entity.Property(e => e.AvailableForOrder)
                    .HasColumnName("available_for_order")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CacheDefaultAttribute)
                    .HasColumnName("cache_default_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CacheHasAttachments)
                    .HasColumnName("cache_has_attachments")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CacheIsPack)
                    .HasColumnName("cache_is_pack")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasColumnName("condition")
                    .HasColumnType("enum('new','used','refurbished')")
                    .HasDefaultValueSql("new");

                entity.Property(e => e.Customizable)
                    .HasColumnName("customizable")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Ean13)
                    .HasColumnName("ean13")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Ecotax)
                    .HasColumnName("ecotax")
                    .HasColumnType("decimal(17,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ExtraImg)
                    .HasColumnName("extra_img")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.IdCategoryDefault)
                    .HasColumnName("id_category_default")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductImporterosc)
                    .HasColumnName("id_product_importerosc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProductRedirected)
                    .HasColumnName("id_product_redirected")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdShopDefault)
                    .HasColumnName("id_shop_default")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdTaxRulesGroup)
                    .HasColumnName("id_tax_rules_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Indexed)
                    .HasColumnName("indexed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsVirtual)
                    .HasColumnName("is_virtual")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MinimalQuantity)
                    .HasColumnName("minimal_quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OnSale)
                    .HasColumnName("on_sale")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlineOnly)
                    .HasColumnName("online_only")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OutOfStock)
                    .HasColumnName("out_of_stock")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuantityDiscount)
                    .HasColumnName("quantity_discount")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RedirectType)
                    .IsRequired()
                    .HasColumnName("redirect_type")
                    .HasColumnType("enum('','404','301','302')")
                    .HasDefaultValueSql("404");

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShowPrice)
                    .HasColumnName("show_price")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SupplierReference)
                    .HasColumnName("supplier_reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TextFields)
                    .HasColumnName("text_fields")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnitPriceRatio)
                    .HasColumnName("unit_price_ratio")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Unity)
                    .HasColumnName("unity")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasColumnName("upc")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UploadableFiles)
                    .HasColumnName("uploadable_files")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Visibility)
                    .IsRequired()
                    .HasColumnName("visibility")
                    .HasColumnType("enum('both','catalog','search','none')")
                    .HasDefaultValueSql("both");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.WholesalePrice)
                    .HasColumnName("wholesale_price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");
            });

            modelBuilder.Entity<PsProductAttachment>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdAttachment });

                entity.ToTable("ps_product_attachment", "skistore_se");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdAttachment)
                    .HasColumnName("id_attachment")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProductAttribute>(entity =>
            {
                entity.HasKey(e => e.IdProductAttribute);

                entity.ToTable("ps_product_attribute", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("product_attribute_product");

                entity.HasIndex(e => e.Reference)
                    .HasName("reference");

                entity.HasIndex(e => e.SupplierReference)
                    .HasName("supplier_reference");

                entity.HasIndex(e => new { e.IdProduct, e.DefaultOn })
                    .HasName("product_default");

                entity.HasIndex(e => new { e.IdProductAttribute, e.IdProduct })
                    .HasName("id_product_id_product_attribute");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AvailableDate)
                    .HasColumnName("available_date")
                    .HasColumnType("date");

                entity.Property(e => e.DateUpd)
                    .HasColumnName("date_upd")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DefaultOn)
                    .HasColumnName("default_on")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ean13)
                    .HasColumnName("ean13")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Ecotax)
                    .HasColumnName("ecotax")
                    .HasColumnType("decimal(17,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductAttributeImporterosc)
                    .HasColumnName("id_product_attribute_importerosc")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdProductImporterosc)
                    .HasColumnName("id_product_importerosc")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MinimalQuantity)
                    .HasColumnName("minimal_quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierReference)
                    .HasColumnName("supplier_reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPriceImpact)
                    .HasColumnName("unit_price_impact")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Upc)
                    .HasColumnName("upc")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.WholesalePrice)
                    .HasColumnName("wholesale_price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");
            });

            modelBuilder.Entity<PsProductAttributeCombination>(entity =>
            {
                entity.HasKey(e => new { e.IdAttribute, e.IdProductAttribute });

                entity.ToTable("ps_product_attribute_combination", "skistore_se");

                entity.HasIndex(e => e.IdProductAttribute)
                    .HasName("id_product_attribute");

                entity.Property(e => e.IdAttribute)
                    .HasColumnName("id_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProductAttributeImage>(entity =>
            {
                entity.HasKey(e => new { e.IdProductAttribute, e.IdImage });

                entity.ToTable("ps_product_attribute_image", "skistore_se");

                entity.HasIndex(e => e.IdImage)
                    .HasName("id_image");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdImage)
                    .HasColumnName("id_image")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProductAttributeShop>(entity =>
            {
                entity.HasKey(e => new { e.IdProductAttribute, e.IdShop });

                entity.ToTable("ps_product_attribute_shop", "skistore_se");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AvailableDate)
                    .HasColumnName("available_date")
                    .HasColumnType("date");

                entity.Property(e => e.DefaultOn)
                    .HasColumnName("default_on")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ecotax)
                    .HasColumnName("ecotax")
                    .HasColumnType("decimal(17,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.MinimalQuantity)
                    .HasColumnName("minimal_quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.UnitPriceImpact)
                    .HasColumnName("unit_price_impact")
                    .HasColumnType("decimal(17,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.WholesalePrice)
                    .HasColumnName("wholesale_price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");
            });

            modelBuilder.Entity<PsProductCarrier>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdCarrierReference, e.IdShop });

                entity.ToTable("ps_product_carrier", "skistore_se");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCarrierReference)
                    .HasColumnName("id_carrier_reference")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProductComment>(entity =>
            {
                entity.HasKey(e => e.IdProductComment);

                entity.ToTable("ps_product_comment", "skistore_se");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("id_customer");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.Property(e => e.IdProductComment)
                    .HasColumnName("id_product_comment")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasColumnType("float unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGuest)
                    .HasColumnName("id_guest")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Validate)
                    .HasColumnName("validate")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsProductCommentCriterion>(entity =>
            {
                entity.HasKey(e => e.IdProductCommentCriterion);

                entity.ToTable("ps_product_comment_criterion", "skistore_se");

                entity.Property(e => e.IdProductCommentCriterion)
                    .HasColumnName("id_product_comment_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdProductCommentCriterionType)
                    .HasColumnName("id_product_comment_criterion_type")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsProductCommentCriterionCategory>(entity =>
            {
                entity.HasKey(e => new { e.IdProductCommentCriterion, e.IdCategory });

                entity.ToTable("ps_product_comment_criterion_category", "skistore_se");

                entity.HasIndex(e => e.IdCategory)
                    .HasName("id_category");

                entity.Property(e => e.IdProductCommentCriterion)
                    .HasColumnName("id_product_comment_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProductCommentCriterionLang>(entity =>
            {
                entity.HasKey(e => new { e.IdProductCommentCriterion, e.IdLang });

                entity.ToTable("ps_product_comment_criterion_lang", "skistore_se");

                entity.Property(e => e.IdProductCommentCriterion)
                    .HasColumnName("id_product_comment_criterion")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsProductCommentCriterionProduct>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdProductCommentCriterion });

                entity.ToTable("ps_product_comment_criterion_product", "skistore_se");

                entity.HasIndex(e => e.IdProductCommentCriterion)
                    .HasName("id_product_comment_criterion");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductCommentCriterion)
                    .HasColumnName("id_product_comment_criterion")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProductCommentGrade>(entity =>
            {
                entity.HasKey(e => new { e.IdProductComment, e.IdProductCommentCriterion });

                entity.ToTable("ps_product_comment_grade", "skistore_se");

                entity.HasIndex(e => e.IdProductCommentCriterion)
                    .HasName("id_product_comment_criterion");

                entity.Property(e => e.IdProductComment)
                    .HasColumnName("id_product_comment")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductCommentCriterion)
                    .HasColumnName("id_product_comment_criterion")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProductCommentReport>(entity =>
            {
                entity.HasKey(e => new { e.IdProductComment, e.IdCustomer });

                entity.ToTable("ps_product_comment_report", "skistore_se");

                entity.Property(e => e.IdProductComment)
                    .HasColumnName("id_product_comment")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProductCommentUsefulness>(entity =>
            {
                entity.HasKey(e => new { e.IdProductComment, e.IdCustomer });

                entity.ToTable("ps_product_comment_usefulness", "skistore_se");

                entity.Property(e => e.IdProductComment)
                    .HasColumnName("id_product_comment")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Usefulness)
                    .HasColumnName("usefulness")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<PsProductDownload>(entity =>
            {
                entity.HasKey(e => e.IdProductDownload);

                entity.ToTable("ps_product_download", "skistore_se");

                entity.HasIndex(e => new { e.IdProduct, e.Active })
                    .HasName("product_active");

                entity.Property(e => e.IdProductDownload)
                    .HasColumnName("id_product_download")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateExpiration).HasColumnName("date_expiration");

                entity.Property(e => e.DisplayFilename)
                    .HasColumnName("display_filename")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsShareable)
                    .HasColumnName("is_shareable")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NbDaysAccessible)
                    .HasColumnName("nb_days_accessible")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.NbDownloadable)
                    .HasColumnName("nb_downloadable")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsProductFaq>(entity =>
            {
                entity.HasKey(e => e.IdProductComment);

                entity.ToTable("ps_product_faq", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.Property(e => e.IdProductComment)
                    .HasColumnName("id_product_comment")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Answer)
                    .HasColumnName("answer")
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question")
                    .IsUnicode(false);

                entity.Property(e => e.Validate)
                    .HasColumnName("validate")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsProductGroupReductionCache>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdGroup });

                entity.ToTable("ps_product_group_reduction_cache", "skistore_se");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Reduction)
                    .HasColumnName("reduction")
                    .HasColumnType("decimal(4,3)");
            });

            modelBuilder.Entity<PsProductLang>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdShop, e.IdLang });

                entity.ToTable("ps_product_lang", "skistore_se");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => new { e.IdProduct, e.IdShop, e.IdLang })
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AvailableLater)
                    .HasColumnName("available_later")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableNow)
                    .HasColumnName("available_now")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionShort)
                    .HasColumnName("description_short")
                    .IsUnicode(false);

                entity.Property(e => e.LinkRewrite)
                    .IsRequired()
                    .HasColumnName("link_rewrite")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsProductSale>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.ToTable("ps_product_sale", "skistore_se");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateUpd)
                    .HasColumnName("date_upd")
                    .HasColumnType("date");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SaleNbr)
                    .HasColumnName("sale_nbr")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsProductShop>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdShop });

                entity.ToTable("ps_product_shop", "skistore_se");

                entity.HasIndex(e => e.IdCategoryDefault)
                    .HasName("id_category_default");

                entity.HasIndex(e => new { e.DateAdd, e.Active, e.Visibility })
                    .HasName("date_add");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AdditionalShippingCost)
                    .HasColumnName("additional_shipping_cost")
                    .HasColumnType("decimal(20,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.AdvancedStockManagement)
                    .HasColumnName("advanced_stock_management")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AvailableDate)
                    .HasColumnName("available_date")
                    .HasColumnType("date");

                entity.Property(e => e.AvailableForOrder)
                    .HasColumnName("available_for_order")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CacheDefaultAttribute)
                    .HasColumnName("cache_default_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasColumnName("condition")
                    .HasColumnType("enum('new','used','refurbished')")
                    .HasDefaultValueSql("new");

                entity.Property(e => e.Customizable)
                    .HasColumnName("customizable")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Ecotax)
                    .HasColumnName("ecotax")
                    .HasColumnType("decimal(17,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.IdCategoryDefault)
                    .HasColumnName("id_category_default")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductRedirected)
                    .HasColumnName("id_product_redirected")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdTaxRulesGroup)
                    .HasColumnName("id_tax_rules_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Indexed)
                    .HasColumnName("indexed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinimalQuantity)
                    .HasColumnName("minimal_quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OnSale)
                    .HasColumnName("on_sale")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OnlineOnly)
                    .HasColumnName("online_only")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.RedirectType)
                    .IsRequired()
                    .HasColumnName("redirect_type")
                    .HasColumnType("enum('','404','301','302')")
                    .HasDefaultValueSql("404");

                entity.Property(e => e.ShowPrice)
                    .HasColumnName("show_price")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TextFields)
                    .HasColumnName("text_fields")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnitPriceRatio)
                    .HasColumnName("unit_price_ratio")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Unity)
                    .HasColumnName("unity")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UploadableFiles)
                    .HasColumnName("uploadable_files")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Visibility)
                    .IsRequired()
                    .HasColumnName("visibility")
                    .HasColumnType("enum('both','catalog','search','none')")
                    .HasDefaultValueSql("both");

                entity.Property(e => e.WholesalePrice)
                    .HasColumnName("wholesale_price")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");
            });

            modelBuilder.Entity<PsProductSupplier>(entity =>
            {
                entity.HasKey(e => e.IdProductSupplier);

                entity.ToTable("ps_product_supplier", "skistore_se");

                entity.HasIndex(e => new { e.IdProduct, e.IdProductAttribute, e.IdSupplier })
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdProductSupplier)
                    .HasColumnName("id_product_supplier")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ProductSupplierPriceTe)
                    .HasColumnName("product_supplier_price_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ProductSupplierReference)
                    .HasColumnName("product_supplier_reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsProductTag>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdTag });

                entity.ToTable("ps_product_tag", "skistore_se");

                entity.HasIndex(e => e.IdTag)
                    .HasName("id_tag");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdTag)
                    .HasColumnName("id_tag")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProfile>(entity =>
            {
                entity.HasKey(e => e.IdProfile);

                entity.ToTable("ps_profile", "skistore_se");

                entity.Property(e => e.IdProfile)
                    .HasColumnName("id_profile")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsProfileLang>(entity =>
            {
                entity.HasKey(e => new { e.IdLang, e.IdProfile });

                entity.ToTable("ps_profile_lang", "skistore_se");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProfile)
                    .HasColumnName("id_profile")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPsgdprConsent>(entity =>
            {
                entity.HasKey(e => new { e.IdGdprConsent, e.IdModule });

                entity.ToTable("ps_psgdpr_consent", "skistore_se");

                entity.Property(e => e.IdGdprConsent)
                    .HasColumnName("id_gdpr_consent")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("error_message")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPsgdprConsentLang>(entity =>
            {
                entity.HasKey(e => new { e.IdGdprConsent, e.IdLang, e.IdShop });

                entity.ToTable("ps_psgdpr_consent_lang", "skistore_se");

                entity.Property(e => e.IdGdprConsent)
                    .HasColumnName("id_gdpr_consent")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsPsgdprLog>(entity =>
            {
                entity.HasKey(e => e.IdGdprLog);

                entity.ToTable("ps_psgdpr_log", "skistore_se");

                entity.Property(e => e.IdGdprLog)
                    .HasColumnName("id_gdpr_log")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ClientName)
                    .HasColumnName("client_name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGuest)
                    .HasColumnName("id_guest")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdModule)
                    .HasColumnName("id_module")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RequestType)
                    .HasColumnName("request_type")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<PsQuickAccess>(entity =>
            {
                entity.HasKey(e => e.IdQuickAccess);

                entity.ToTable("ps_quick_access", "skistore_se");

                entity.Property(e => e.IdQuickAccess)
                    .HasColumnName("id_quick_access")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NewWindow)
                    .HasColumnName("new_window")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsQuickAccessLang>(entity =>
            {
                entity.HasKey(e => new { e.IdQuickAccess, e.IdLang });

                entity.ToTable("ps_quick_access_lang", "skistore_se");

                entity.Property(e => e.IdQuickAccess)
                    .HasColumnName("id_quick_access")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsRangePrice>(entity =>
            {
                entity.HasKey(e => e.IdRangePrice);

                entity.ToTable("ps_range_price", "skistore_se");

                entity.HasIndex(e => new { e.IdCarrier, e.Delimiter1, e.Delimiter2 })
                    .HasName("id_carrier")
                    .IsUnique();

                entity.Property(e => e.IdRangePrice)
                    .HasColumnName("id_range_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Delimiter1)
                    .HasColumnName("delimiter1")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.Delimiter2)
                    .HasColumnName("delimiter2")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsRangeWeight>(entity =>
            {
                entity.HasKey(e => e.IdRangeWeight);

                entity.ToTable("ps_range_weight", "skistore_se");

                entity.HasIndex(e => new { e.IdCarrier, e.Delimiter1, e.Delimiter2 })
                    .HasName("id_carrier")
                    .IsUnique();

                entity.Property(e => e.IdRangeWeight)
                    .HasColumnName("id_range_weight")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Delimiter1)
                    .HasColumnName("delimiter1")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.Delimiter2)
                    .HasColumnName("delimiter2")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsRcPgtagmanagerOrdersSent>(entity =>
            {
                entity.HasKey(e => new { e.IdOrder, e.IdShop });

                entity.ToTable("ps_rc_pgtagmanager_orders_sent", "skistore_se");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SentAt).HasColumnName("sent_at");

                entity.Property(e => e.SentFrom)
                    .IsRequired()
                    .HasColumnName("sent_from")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsReferrer>(entity =>
            {
                entity.HasKey(e => e.IdReferrer);

                entity.ToTable("ps_referrer", "skistore_se");

                entity.Property(e => e.IdReferrer)
                    .HasColumnName("id_referrer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BaseFee)
                    .HasColumnName("base_fee")
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ClickFee)
                    .HasColumnName("click_fee")
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.HttpRefererLike)
                    .HasColumnName("http_referer_like")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.HttpRefererLikeNot)
                    .HasColumnName("http_referer_like_not")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.HttpRefererRegexp)
                    .HasColumnName("http_referer_regexp")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.HttpRefererRegexpNot)
                    .HasColumnName("http_referer_regexp_not")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Passwd)
                    .HasColumnName("passwd")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PercentFee)
                    .HasColumnName("percent_fee")
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.RequestUriLike)
                    .HasColumnName("request_uri_like")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUriLikeNot)
                    .HasColumnName("request_uri_like_not")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUriRegexp)
                    .HasColumnName("request_uri_regexp")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUriRegexpNot)
                    .HasColumnName("request_uri_regexp_not")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsReferrerCache>(entity =>
            {
                entity.HasKey(e => new { e.IdConnectionsSource, e.IdReferrer });

                entity.ToTable("ps_referrer_cache", "skistore_se");

                entity.Property(e => e.IdConnectionsSource)
                    .HasColumnName("id_connections_source")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdReferrer)
                    .HasColumnName("id_referrer")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsReferrerShop>(entity =>
            {
                entity.HasKey(e => new { e.IdReferrer, e.IdShop });

                entity.ToTable("ps_referrer_shop", "skistore_se");

                entity.Property(e => e.IdReferrer)
                    .HasColumnName("id_referrer")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CacheOrderRate)
                    .HasColumnName("cache_order_rate")
                    .HasColumnType("decimal(5,4)");

                entity.Property(e => e.CacheOrders)
                    .HasColumnName("cache_orders")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CachePages)
                    .HasColumnName("cache_pages")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CacheRegRate)
                    .HasColumnName("cache_reg_rate")
                    .HasColumnType("decimal(5,4)");

                entity.Property(e => e.CacheRegistrations)
                    .HasColumnName("cache_registrations")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CacheSales)
                    .HasColumnName("cache_sales")
                    .HasColumnType("decimal(17,2)");

                entity.Property(e => e.CacheVisitors)
                    .HasColumnName("cache_visitors")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CacheVisits)
                    .HasColumnName("cache_visits")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsRequestSql>(entity =>
            {
                entity.HasKey(e => e.IdRequestSql);

                entity.ToTable("ps_request_sql", "skistore_se");

                entity.Property(e => e.IdRequestSql)
                    .HasColumnName("id_request_sql")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sql)
                    .IsRequired()
                    .HasColumnName("sql")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsRequiredField>(entity =>
            {
                entity.HasKey(e => e.IdRequiredField);

                entity.ToTable("ps_required_field", "skistore_se");

                entity.HasIndex(e => e.ObjectName)
                    .HasName("object_name");

                entity.Property(e => e.IdRequiredField)
                    .HasColumnName("id_required_field")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnName("field_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasColumnName("object_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsRisk>(entity =>
            {
                entity.HasKey(e => e.IdRisk);

                entity.ToTable("ps_risk", "skistore_se");

                entity.Property(e => e.IdRisk)
                    .HasColumnName("id_risk")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Percent)
                    .HasColumnName("percent")
                    .HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<PsRiskLang>(entity =>
            {
                entity.HasKey(e => new { e.IdRisk, e.IdLang });

                entity.ToTable("ps_risk_lang", "skistore_se");

                entity.HasIndex(e => e.IdRisk)
                    .HasName("id_risk");

                entity.Property(e => e.IdRisk)
                    .HasColumnName("id_risk")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsScExport>(entity =>
            {
                entity.HasKey(e => e.IdScExport);

                entity.ToTable("ps_sc_export", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.IdScExport)
                    .HasColumnName("id_sc_export")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Exporting)
                    .HasColumnName("exporting")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCombinationNext)
                    .HasColumnName("id_combination_next")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdNext)
                    .HasColumnName("id_next")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastExport).HasColumnName("last_export");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLines)
                    .HasColumnName("total_lines")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsScExportProduct>(entity =>
            {
                entity.HasKey(e => e.IdScExportProduct);

                entity.ToTable("ps_sc_export_product", "skistore_se");

                entity.Property(e => e.IdScExportProduct)
                    .HasColumnName("id_sc_export_product")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Exported)
                    .HasColumnName("exported")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Handled)
                    .HasColumnName("handled")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdScExport)
                    .HasColumnName("id_sc_export")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsScQueueLog>(entity =>
            {
                entity.HasKey(e => e.IdScQueueLog);

                entity.ToTable("ps_sc_queue_log", "skistore_se");

                entity.Property(e => e.IdScQueueLog)
                    .HasColumnName("id_sc_queue_log")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Callback)
                    .HasColumnName("callback")
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Params)
                    .HasColumnName("params")
                    .IsUnicode(false);

                entity.Property(e => e.Row)
                    .IsRequired()
                    .HasColumnName("row")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsScene>(entity =>
            {
                entity.HasKey(e => e.IdScene);

                entity.ToTable("ps_scene", "skistore_se");

                entity.Property(e => e.IdScene)
                    .HasColumnName("id_scene")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsSceneCategory>(entity =>
            {
                entity.HasKey(e => new { e.IdScene, e.IdCategory });

                entity.ToTable("ps_scene_category", "skistore_se");

                entity.Property(e => e.IdScene)
                    .HasColumnName("id_scene")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsSceneLang>(entity =>
            {
                entity.HasKey(e => new { e.IdScene, e.IdLang });

                entity.ToTable("ps_scene_lang", "skistore_se");

                entity.Property(e => e.IdScene)
                    .HasColumnName("id_scene")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSceneProducts>(entity =>
            {
                entity.HasKey(e => new { e.IdScene, e.IdProduct, e.XAxis, e.YAxis });

                entity.ToTable("ps_scene_products", "skistore_se");

                entity.Property(e => e.IdScene)
                    .HasColumnName("id_scene")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.XAxis)
                    .HasColumnName("x_axis")
                    .HasColumnType("int(4)");

                entity.Property(e => e.YAxis)
                    .HasColumnName("y_axis")
                    .HasColumnType("int(4)");

                entity.Property(e => e.ZoneHeight)
                    .HasColumnName("zone_height")
                    .HasColumnType("int(3)");

                entity.Property(e => e.ZoneWidth)
                    .HasColumnName("zone_width")
                    .HasColumnType("int(3)");
            });

            modelBuilder.Entity<PsSceneShop>(entity =>
            {
                entity.HasKey(e => new { e.IdScene, e.IdShop });

                entity.ToTable("ps_scene_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdScene)
                    .HasColumnName("id_scene")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsSearchEngine>(entity =>
            {
                entity.HasKey(e => e.IdSearchEngine);

                entity.ToTable("ps_search_engine", "skistore_se");

                entity.Property(e => e.IdSearchEngine)
                    .HasColumnName("id_search_engine")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Getvar)
                    .IsRequired()
                    .HasColumnName("getvar")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasColumnName("server")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSearchIndex>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdWord });

                entity.ToTable("ps_search_index", "skistore_se");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdWord)
                    .HasColumnName("id_word")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsSearchWord>(entity =>
            {
                entity.HasKey(e => e.IdWord);

                entity.ToTable("ps_search_word", "skistore_se");

                entity.HasIndex(e => new { e.IdLang, e.IdShop, e.Word })
                    .HasName("id_lang")
                    .IsUnique();

                entity.Property(e => e.IdWord)
                    .HasColumnName("id_word")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasColumnName("word")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSekeyword>(entity =>
            {
                entity.HasKey(e => e.IdSekeyword);

                entity.ToTable("ps_sekeyword", "skistore_se");

                entity.Property(e => e.IdSekeyword)
                    .HasColumnName("id_sekeyword")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsShop>(entity =>
            {
                entity.HasKey(e => e.IdShop);

                entity.ToTable("ps_shop", "skistore_se");

                entity.HasIndex(e => e.IdCategory)
                    .HasName("id_category");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_group_shop");

                entity.HasIndex(e => e.IdTheme)
                    .HasName("id_theme");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdTheme)
                    .HasColumnName("id_theme")
                    .HasColumnType("int(1) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsShopGroup>(entity =>
            {
                entity.HasKey(e => e.IdShopGroup);

                entity.ToTable("ps_shop_group", "skistore_se");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ShareCustomer)
                    .HasColumnName("share_customer")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ShareOrder)
                    .HasColumnName("share_order")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ShareStock)
                    .HasColumnName("share_stock")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<PsShopUrl>(entity =>
            {
                entity.HasKey(e => e.IdShopUrl);

                entity.ToTable("ps_shop_url", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => new { e.Domain, e.VirtualUri })
                    .HasName("shop_url")
                    .IsUnique();

                entity.Property(e => e.IdShopUrl)
                    .HasColumnName("id_shop_url")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasColumnName("domain")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DomainSsl)
                    .IsRequired()
                    .HasColumnName("domain_ssl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Main)
                    .HasColumnName("main")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PhysicalUri)
                    .IsRequired()
                    .HasColumnName("physical_uri")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.VirtualUri)
                    .IsRequired()
                    .HasColumnName("virtual_uri")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSpecificPrice>(entity =>
            {
                entity.HasKey(e => e.IdSpecificPrice);

                entity.ToTable("ps_specific_price", "skistore_se");

                entity.HasIndex(e => e.FromQuantity)
                    .HasName("from_quantity");

                entity.HasIndex(e => e.IdCart)
                    .HasName("id_cart_2");

                entity.HasIndex(e => e.IdSpecificPriceRule)
                    .HasName("id_specific_price_rule");

                entity.HasIndex(e => new { e.IdProduct, e.IdShop, e.IdCurrency, e.IdCountry, e.IdGroup, e.IdCustomer, e.FromQuantity, e.From, e.To })
                    .HasName("id_product");

                entity.HasIndex(e => new { e.IdProduct, e.IdShop, e.IdShopGroup, e.IdCurrency, e.IdCountry, e.IdGroup, e.IdCustomer, e.IdProductAttribute, e.FromQuantity, e.From, e.To })
                    .HasName("id_product_2");

                entity.Property(e => e.IdSpecificPrice)
                    .HasColumnName("id_specific_price")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.FromQuantity)
                    .HasColumnName("from_quantity")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IdCart)
                    .HasColumnName("id_cart")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSpecificPriceRule)
                    .HasColumnName("id_specific_price_rule")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.Reduction)
                    .HasColumnName("reduction")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionType)
                    .IsRequired()
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.To).HasColumnName("to");
            });

            modelBuilder.Entity<PsSpecificPricePriority>(entity =>
            {
                entity.HasKey(e => new { e.IdSpecificPricePriority, e.IdProduct });

                entity.ToTable("ps_specific_price_priority", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdSpecificPricePriority)
                    .HasColumnName("id_specific_price_priority")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasColumnName("priority")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSpecificPriceRule>(entity =>
            {
                entity.HasKey(e => e.IdSpecificPriceRule);

                entity.ToTable("ps_specific_price_rule", "skistore_se");

                entity.HasIndex(e => new { e.IdShop, e.IdCurrency, e.IdCountry, e.IdGroup, e.FromQuantity, e.From, e.To })
                    .HasName("id_product");

                entity.Property(e => e.IdSpecificPriceRule)
                    .HasColumnName("id_specific_price_rule")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.FromQuantity)
                    .HasColumnName("from_quantity")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.Reduction)
                    .HasColumnName("reduction")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ReductionType)
                    .IsRequired()
                    .HasColumnName("reduction_type")
                    .HasColumnType("enum('amount','percentage')");

                entity.Property(e => e.To).HasColumnName("to");
            });

            modelBuilder.Entity<PsSpecificPriceRuleCondition>(entity =>
            {
                entity.HasKey(e => e.IdSpecificPriceRuleCondition);

                entity.ToTable("ps_specific_price_rule_condition", "skistore_se");

                entity.HasIndex(e => e.IdSpecificPriceRuleConditionGroup)
                    .HasName("id_specific_price_rule_condition_group");

                entity.Property(e => e.IdSpecificPriceRuleCondition)
                    .HasColumnName("id_specific_price_rule_condition")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSpecificPriceRuleConditionGroup)
                    .HasColumnName("id_specific_price_rule_condition_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSpecificPriceRuleConditionGroup>(entity =>
            {
                entity.HasKey(e => new { e.IdSpecificPriceRuleConditionGroup, e.IdSpecificPriceRule });

                entity.ToTable("ps_specific_price_rule_condition_group", "skistore_se");

                entity.Property(e => e.IdSpecificPriceRuleConditionGroup)
                    .HasColumnName("id_specific_price_rule_condition_group")
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSpecificPriceRule)
                    .HasColumnName("id_specific_price_rule")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsSpecterdata>(entity =>
            {
                entity.HasKey(e => e.IdSpecterData);

                entity.ToTable("ps_specterdata", "skistore_se");

                entity.Property(e => e.IdSpecterData)
                    .HasColumnName("id_specter_data")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ArticleNumber)
                    .IsRequired()
                    .HasColumnName("article_number")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.InStock)
                    .HasColumnName("in_stock")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasColumnName("invoice_id")
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.ProductData)
                    .IsRequired()
                    .HasColumnName("product_data")
                    .IsUnicode(false);

                entity.Property(e => e.SpecterOrderId)
                    .IsRequired()
                    .HasColumnName("specter_order_id")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNumber)
                    .IsRequired()
                    .HasColumnName("tracking_number")
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsStBanner>(entity =>
            {
                entity.HasKey(e => e.IdStBanner);

                entity.ToTable("ps_st_banner", "skistore_se");

                entity.Property(e => e.IdStBanner)
                    .HasColumnName("id_st_banner")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdStBannerGroup)
                    .HasColumnName("id_st_banner_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewWindow)
                    .HasColumnName("new_window")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStBannerGroup>(entity =>
            {
                entity.HasKey(e => e.IdStBannerGroup);

                entity.ToTable("ps_st_banner_group", "skistore_se");

                entity.Property(e => e.IdStBannerGroup)
                    .HasColumnName("id_st_banner_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HideOnMobile)
                    .HasColumnName("hide_on_mobile")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HoverEffect)
                    .HasColumnName("hover_effect")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Layout)
                    .HasColumnName("layout")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStBannerGroupShop>(entity =>
            {
                entity.HasKey(e => new { e.IdStBannerGroup, e.IdShop });

                entity.ToTable("ps_st_banner_group_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdStBannerGroup)
                    .HasColumnName("id_st_banner_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsStBannerLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStBanner, e.IdLang });

                entity.ToTable("ps_st_banner_lang", "skistore_se");

                entity.Property(e => e.IdStBanner)
                    .HasColumnName("id_st_banner")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImageMultiLang)
                    .HasColumnName("image_multi_lang")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStBlog>(entity =>
            {
                entity.HasKey(e => e.IdStBlog);

                entity.ToTable("ps_st_blog", "skistore_se");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(10)");

                entity.Property(e => e.AcceptComment)
                    .HasColumnName("accept_comment")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CommentsStatus)
                    .HasColumnName("comments_status")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdStBlogCategoryDefault)
                    .HasColumnName("id_st_blog_category_default")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsStBlogCategory>(entity =>
            {
                entity.HasKey(e => e.IdStBlogCategory);

                entity.ToTable("ps_st_blog_category", "skistore_se");

                entity.HasIndex(e => e.IdParent)
                    .HasName("category_parent");

                entity.Property(e => e.IdStBlogCategory)
                    .HasColumnName("id_st_blog_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsRootCategory)
                    .HasColumnName("is_root_category")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nleft)
                    .HasColumnName("nleft")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nright)
                    .HasColumnName("nright")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStBlogCategoryBlog>(entity =>
            {
                entity.HasKey(e => new { e.IdStBlogCategory, e.IdStBlog });

                entity.ToTable("ps_st_blog_category_blog", "skistore_se");

                entity.HasIndex(e => e.IdStBlog)
                    .HasName("id_st_blog");

                entity.Property(e => e.IdStBlogCategory)
                    .HasColumnName("id_st_blog_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStBlogCategoryLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStBlogCategory, e.IdLang });

                entity.ToTable("ps_st_blog_category_lang", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("category_name");

                entity.Property(e => e.IdStBlogCategory)
                    .HasColumnName("id_st_blog_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.LinkRewrite)
                    .IsRequired()
                    .HasColumnName("link_rewrite")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStBlogCategoryShop>(entity =>
            {
                entity.HasKey(e => new { e.IdStBlogCategory, e.IdShop });

                entity.ToTable("ps_st_blog_category_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdStBlogCategory)
                    .HasColumnName("id_st_blog_category")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStBlogComment>(entity =>
            {
                entity.HasKey(e => e.IdStBlogComment);

                entity.ToTable("ps_st_blog_comment", "skistore_se");

                entity.HasIndex(e => e.IdCustomer)
                    .HasName("id_customer");

                entity.HasIndex(e => e.IdStBlog)
                    .HasName("id_st_blog");

                entity.Property(e => e.IdStBlogComment)
                    .HasColumnName("id_st_blog_comment")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEmail)
                    .HasColumnName("customer_email")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerWebsite)
                    .HasColumnName("customer_website")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdGuest)
                    .HasColumnName("id_guest")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsStBlogImage>(entity =>
            {
                entity.HasKey(e => e.IdStBlogImage);

                entity.ToTable("ps_st_blog_image", "skistore_se");

                entity.HasIndex(e => e.IdStBlog)
                    .HasName("image_blog");

                entity.Property(e => e.IdStBlogImage)
                    .HasColumnName("id_st_blog_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("smallint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsStBlogImageLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStBlogImage, e.IdLang });

                entity.ToTable("ps_st_blog_image_lang", "skistore_se");

                entity.HasIndex(e => e.IdStBlogImage)
                    .HasName("id_st_blog_image");

                entity.Property(e => e.IdStBlogImage)
                    .HasColumnName("id_st_blog_image")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsStBlogLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStBlog, e.IdLang });

                entity.ToTable("ps_st_blog_lang", "skistore_se");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("longtext");

                entity.Property(e => e.ContentShort)
                    .HasColumnName("content_short")
                    .IsUnicode(false);

                entity.Property(e => e.LinkRewrite)
                    .IsRequired()
                    .HasColumnName("link_rewrite")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStBlogProductLink>(entity =>
            {
                entity.HasKey(e => new { e.IdStBlog, e.IdProduct });

                entity.ToTable("ps_st_blog_product_link", "skistore_se");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStBlogShop>(entity =>
            {
                entity.HasKey(e => new { e.IdStBlog, e.IdShop });

                entity.ToTable("ps_st_blog_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdStBlogCategoryDefault)
                    .HasColumnName("id_st_blog_category_default")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsStBlogTag>(entity =>
            {
                entity.HasKey(e => e.IdStBlogTag);

                entity.ToTable("ps_st_blog_tag", "skistore_se");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.Name)
                    .HasName("tag_name");

                entity.Property(e => e.IdStBlogTag)
                    .HasColumnName("id_st_blog_tag")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStBlogTagMap>(entity =>
            {
                entity.HasKey(e => new { e.IdStBlogTag, e.IdStBlog });

                entity.ToTable("ps_st_blog_tag_map", "skistore_se");

                entity.HasIndex(e => e.IdStBlogTag)
                    .HasName("id_st_blog_tag");

                entity.Property(e => e.IdStBlogTag)
                    .HasColumnName("id_st_blog_tag")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsStBrandsSlider>(entity =>
            {
                entity.HasKey(e => new { e.IdManufacturer, e.IdShop });

                entity.ToTable("ps_st_brands_slider", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsStCameraSlideshow>(entity =>
            {
                entity.HasKey(e => e.IdStCameraSlideshow);

                entity.ToTable("ps_st_camera_slideshow", "skistore_se");

                entity.Property(e => e.IdStCameraSlideshow)
                    .HasColumnName("id_st_camera_slideshow")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DescriptionBg)
                    .HasColumnName("description_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionColor)
                    .HasColumnName("description_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdStCameraSlideshowGroup)
                    .HasColumnName("id_st_camera_slideshow_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Isbanner)
                    .HasColumnName("isbanner")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewWindow)
                    .HasColumnName("new_window")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextAlign)
                    .HasColumnName("text_align")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TextPosition)
                    .HasColumnName("text_position")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Thumb)
                    .HasColumnName("thumb")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TitleBg)
                    .HasColumnName("title_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TitleColor)
                    .HasColumnName("title_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TitleFontFamily)
                    .HasColumnName("title_font_family")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStCameraSlideshowGroup>(entity =>
            {
                entity.HasKey(e => e.IdStCameraSlideshowGroup);

                entity.ToTable("ps_st_camera_slideshow_group", "skistore_se");

                entity.Property(e => e.IdStCameraSlideshowGroup)
                    .HasColumnName("id_st_camera_slideshow_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AutoAdvance)
                    .HasColumnName("auto_advance")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BarPosition)
                    .HasColumnName("bar_position")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BlindRows)
                    .HasColumnName("blind_rows")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.CurtainColumns)
                    .HasColumnName("curtain_columns")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("12");

                entity.Property(e => e.Easing)
                    .HasColumnName("easing")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Effects)
                    .HasColumnName("effects")
                    .IsUnicode(false);

                entity.Property(e => e.HeightRatio)
                    .HasColumnName("height_ratio")
                    .HasColumnType("float(8,2) unsigned")
                    .HasDefaultValueSql("35.00");

                entity.Property(e => e.HideOnMobile)
                    .HasColumnName("hide_on_mobile")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCmsCategory)
                    .HasColumnName("id_cms_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Loader)
                    .HasColumnName("loader")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LoaderBg)
                    .HasColumnName("loader_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LoaderColor)
                    .HasColumnName("loader_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MosaicColumns)
                    .HasColumnName("mosaic_columns")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.MosaicRows)
                    .HasColumnName("mosaic_rows")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PagNav)
                    .HasColumnName("pag_nav")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pause)
                    .HasColumnName("pause")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PiePosition)
                    .HasColumnName("pie_position")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevNext)
                    .HasColumnName("prev_next")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PrevNextOnHover)
                    .HasColumnName("prev_next_on_hover")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("7000");

                entity.Property(e => e.TransPeriod)
                    .HasColumnName("trans_period")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1000");
            });

            modelBuilder.Entity<PsStCameraSlideshowGroupShop>(entity =>
            {
                entity.HasKey(e => new { e.IdStCameraSlideshowGroup, e.IdShop });

                entity.ToTable("ps_st_camera_slideshow_group_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdStCameraSlideshowGroup)
                    .HasColumnName("id_st_camera_slideshow_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsStCameraSlideshowLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStCameraSlideshow, e.IdLang });

                entity.ToTable("ps_st_camera_slideshow_lang", "skistore_se");

                entity.Property(e => e.IdStCameraSlideshow)
                    .HasColumnName("id_st_camera_slideshow")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Button)
                    .HasColumnName("button")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.ImageMultiLang)
                    .HasColumnName("image_multi_lang")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbMultiLang)
                    .HasColumnName("thumb_multi_lang")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStEasyContent>(entity =>
            {
                entity.HasKey(e => e.IdStEasyContent);

                entity.ToTable("ps_st_easy_content", "skistore_se");

                entity.Property(e => e.IdStEasyContent)
                    .HasColumnName("id_st_easy_content")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HideOnMobile)
                    .HasColumnName("hide_on_mobile")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Span)
                    .HasColumnName("span")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStEasyContentLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStEasyContent, e.IdLang });

                entity.ToTable("ps_st_easy_content_lang", "skistore_se");

                entity.Property(e => e.IdStEasyContent)
                    .HasColumnName("id_st_easy_content")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStEasyContentShop>(entity =>
            {
                entity.HasKey(e => new { e.IdStEasyContent, e.IdShop });

                entity.ToTable("ps_st_easy_content_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdStEasyContent)
                    .HasColumnName("id_st_easy_content")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsStEasyTabs>(entity =>
            {
                entity.HasKey(e => e.IdStEasyTabs);

                entity.ToTable("ps_st_easy_tabs", "skistore_se");

                entity.Property(e => e.IdStEasyTabs)
                    .HasColumnName("id_st_easy_tabs")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Allitems)
                    .HasColumnName("allitems")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdProductSpecific)
                    .HasColumnName("id_product_specific")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStEasyTabsLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStEasyTabs, e.IdLang });

                entity.ToTable("ps_st_easy_tabs_lang", "skistore_se");

                entity.Property(e => e.IdStEasyTabs)
                    .HasColumnName("id_st_easy_tabs")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStFeaturedCategory>(entity =>
            {
                entity.HasKey(e => e.IdStFeaturedCategory);

                entity.ToTable("ps_st_featured_category", "skistore_se");

                entity.Property(e => e.IdStFeaturedCategory)
                    .HasColumnName("id_st_featured_category")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AutoSub)
                    .HasColumnName("auto_sub")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TxtColor)
                    .HasColumnName("txt_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TxtColorOver)
                    .HasColumnName("txt_color_over")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStIosslider>(entity =>
            {
                entity.HasKey(e => e.IdStIosslider);

                entity.ToTable("ps_st_iosslider", "skistore_se");

                entity.Property(e => e.IdStIosslider)
                    .HasColumnName("id_st_iosslider")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DescriptionBg)
                    .HasColumnName("description_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionColor)
                    .HasColumnName("description_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.HideTextOnMobile)
                    .HasColumnName("hide_text_on_mobile")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdStIossliderGroup)
                    .HasColumnName("id_st_iosslider_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Isbanner)
                    .HasColumnName("isbanner")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewWindow)
                    .HasColumnName("new_window")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextAlign)
                    .HasColumnName("text_align")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TextAnimation)
                    .HasColumnName("text_animation")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextConBg)
                    .HasColumnName("text_con_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TextPosition)
                    .HasColumnName("text_position")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TextWidth)
                    .HasColumnName("text_width")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("40");

                entity.Property(e => e.TitleBg)
                    .HasColumnName("title_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TitleColor)
                    .HasColumnName("title_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TitleFontFamily)
                    .HasColumnName("title_font_family")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStIossliderGroup>(entity =>
            {
                entity.HasKey(e => e.IdStIossliderGroup);

                entity.ToTable("ps_st_iosslider_group", "skistore_se");

                entity.Property(e => e.IdStIossliderGroup)
                    .HasColumnName("id_st_iosslider_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AutoAdvance)
                    .HasColumnName("auto_advance")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BgColor)
                    .HasColumnName("bg_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BgImg)
                    .HasColumnName("bg_img")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BgPattern)
                    .HasColumnName("bg_pattern")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BgPosition)
                    .HasColumnName("bg_position")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BgRepeat)
                    .HasColumnName("bg_repeat")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DesktopClickDrag)
                    .HasColumnName("desktopClickDrag")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("500");

                entity.Property(e => e.HideOnMobile)
                    .HasColumnName("hide_on_mobile")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCmsCategory)
                    .HasColumnName("id_cms_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InfiniteSlider)
                    .HasColumnName("infiniteSlider")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaddingTb)
                    .HasColumnName("padding_tb")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PagNav)
                    .HasColumnName("pag_nav")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PagNavBg)
                    .HasColumnName("pag_nav_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PagNavBgActive)
                    .HasColumnName("pag_nav_bg_active")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Pause)
                    .HasColumnName("pause")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevNext)
                    .HasColumnName("prev_next")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PrevNextBg)
                    .HasColumnName("prev_next_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PrevNextColor)
                    .HasColumnName("prev_next_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Scrollbar)
                    .HasColumnName("scrollbar")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScrollbarBg)
                    .HasColumnName("scrollbar_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ScrollbarColor)
                    .HasColumnName("scrollbar_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SlidePadding)
                    .HasColumnName("slide_padding")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SlideShadow)
                    .HasColumnName("slide_shadow")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Templates)
                    .HasColumnName("templates")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("7000");

                entity.Property(e => e.TransPeriod)
                    .HasColumnName("trans_period")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("900");
            });

            modelBuilder.Entity<PsStIossliderGroupShop>(entity =>
            {
                entity.HasKey(e => new { e.IdStIossliderGroup, e.IdShop });

                entity.ToTable("ps_st_iosslider_group_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdStIossliderGroup)
                    .HasColumnName("id_st_iosslider_group")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsStIossliderLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStIosslider, e.IdLang });

                entity.ToTable("ps_st_iosslider_lang", "skistore_se");

                entity.Property(e => e.IdStIosslider)
                    .HasColumnName("id_st_iosslider")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Button)
                    .HasColumnName("button")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.ImageMultiLang)
                    .HasColumnName("image_multi_lang")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbMultiLang)
                    .HasColumnName("thumb_multi_lang")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStMegaMenu>(entity =>
            {
                entity.HasKey(e => e.IdStMegaMenu);

                entity.ToTable("ps_st_mega_menu", "skistore_se");

                entity.Property(e => e.IdStMegaMenu)
                    .HasColumnName("id_st_mega_menu")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Alignment)
                    .HasColumnName("alignment")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AutoSub)
                    .HasColumnName("auto_sub")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BgColor)
                    .HasColumnName("bg_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BgColorOver)
                    .HasColumnName("bg_color_over")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("smallint(7) unsigned");

                entity.Property(e => e.HideOnMobile)
                    .HasColumnName("hide_on_mobile")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCmsCategory)
                    .HasColumnName("id_cms_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdIcon)
                    .HasColumnName("id_icon")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdStBlog)
                    .HasColumnName("id_st_blog")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdStBlogCategory)
                    .HasColumnName("id_st_blog_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Left)
                    .HasColumnName("left")
                    .HasColumnType("smallint(7)");

                entity.Property(e => e.LevelDepth)
                    .HasColumnName("level_depth")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewWindow)
                    .HasColumnName("new_window")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nleft)
                    .HasColumnName("nleft")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nofollow)
                    .HasColumnName("nofollow")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nright)
                    .HasColumnName("nright")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pagename)
                    .HasColumnName("pagename")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Spans)
                    .HasColumnName("spans")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Style)
                    .HasColumnName("style")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabContentBg)
                    .HasColumnName("tab_content_bg")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TxtColor)
                    .HasColumnName("txt_color")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TxtColorOver)
                    .HasColumnName("txt_color_over")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(7) unsigned");
            });

            modelBuilder.Entity<PsStMegaMenuLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStMegaMenu, e.IdLang });

                entity.ToTable("ps_st_mega_menu_lang", "skistore_se");

                entity.Property(e => e.IdStMegaMenu)
                    .HasColumnName("id_st_mega_menu")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Html)
                    .HasColumnName("html")
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStMultiLink>(entity =>
            {
                entity.HasKey(e => e.IdStMultiLink);

                entity.ToTable("ps_st_multi_link", "skistore_se");

                entity.Property(e => e.IdStMultiLink)
                    .HasColumnName("id_st_multi_link")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IdCms)
                    .HasColumnName("id_cms")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCmsCategory)
                    .HasColumnName("id_cms_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdManufacturer)
                    .HasColumnName("id_manufacturer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdStMultiLinkGroup)
                    .HasColumnName("id_st_multi_link_group")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewWindow)
                    .HasColumnName("new_window")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nofollow)
                    .HasColumnName("nofollow")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Pagename)
                    .HasColumnName("pagename")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStMultiLinkGroup>(entity =>
            {
                entity.HasKey(e => e.IdStMultiLinkGroup);

                entity.ToTable("ps_st_multi_link_group", "skistore_se");

                entity.Property(e => e.IdStMultiLinkGroup)
                    .HasColumnName("id_st_multi_link_group")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.HideOnMobile)
                    .HasColumnName("hide_on_mobile")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewWindow)
                    .HasColumnName("new_window")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nofollow)
                    .HasColumnName("nofollow")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStMultiLinkGroupLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStMultiLinkGroup, e.IdLang });

                entity.ToTable("ps_st_multi_link_group_lang", "skistore_se");

                entity.Property(e => e.IdStMultiLinkGroup)
                    .HasColumnName("id_st_multi_link_group")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStMultiLinkGroupShop>(entity =>
            {
                entity.HasKey(e => new { e.IdStMultiLinkGroup, e.IdShop });

                entity.ToTable("ps_st_multi_link_group_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdStMultiLinkGroup)
                    .HasColumnName("id_st_multi_link_group")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PsStMultiLinkLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStMultiLink, e.IdLang });

                entity.ToTable("ps_st_multi_link_lang", "skistore_se");

                entity.Property(e => e.IdStMultiLink)
                    .HasColumnName("id_st_multi_link")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStProductCategoriesSlider>(entity =>
            {
                entity.HasKey(e => e.IdStProductCategoriesSlider);

                entity.ToTable("ps_st_product_categories_slider", "skistore_se");

                entity.Property(e => e.IdStProductCategoriesSlider)
                    .HasColumnName("id_st_product_categories_slider")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DisplayOn)
                    .HasColumnName("display_on")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductNbr)
                    .HasColumnName("product_nbr")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductOrder)
                    .HasColumnName("product_order")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStRelatedProducts>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct1, e.IdProduct2 });

                entity.ToTable("ps_st_related_products", "skistore_se");

                entity.Property(e => e.IdProduct1)
                    .HasColumnName("id_product_1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdProduct2)
                    .HasColumnName("id_product_2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsState>(entity =>
            {
                entity.HasKey(e => e.IdState);

                entity.ToTable("ps_state", "skistore_se");

                entity.HasIndex(e => e.IdCountry)
                    .HasName("id_country");

                entity.HasIndex(e => e.IdZone)
                    .HasName("id_zone");

                entity.HasIndex(e => e.Name)
                    .HasName("statename");

                entity.Property(e => e.IdState)
                    .HasColumnName("id_state")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdZone)
                    .HasColumnName("id_zone")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IsoCode)
                    .IsRequired()
                    .HasColumnName("iso_code")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TaxBehavior)
                    .HasColumnName("tax_behavior")
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStaticblock>(entity =>
            {
                entity.HasKey(e => e.IdBlock);

                entity.ToTable("ps_staticblock", "skistore_se");

                entity.HasIndex(e => e.IdentifierBlock)
                    .HasName("identifier_block")
                    .IsUnique();

                entity.Property(e => e.IdBlock)
                    .HasColumnName("id_block")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Hook)
                    .HasColumnName("hook")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdentifierBlock)
                    .IsRequired()
                    .HasColumnName("identifier_block")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsStatssearch>(entity =>
            {
                entity.HasKey(e => e.IdStatssearch);

                entity.ToTable("ps_statssearch", "skistore_se");

                entity.Property(e => e.IdStatssearch)
                    .HasColumnName("id_statssearch")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasColumnName("keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Results)
                    .HasColumnName("results")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStock>(entity =>
            {
                entity.HasKey(e => e.IdStock);

                entity.ToTable("ps_stock", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.HasIndex(e => e.IdProductAttribute)
                    .HasName("id_product_attribute");

                entity.HasIndex(e => e.IdWarehouse)
                    .HasName("id_warehouse");

                entity.Property(e => e.IdStock)
                    .HasColumnName("id_stock")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Ean13)
                    .HasColumnName("ean13")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("id_warehouse")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PhysicalQuantity)
                    .HasColumnName("physical_quantity")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PriceTe)
                    .HasColumnName("price_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnName("reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasColumnName("upc")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UsableQuantity)
                    .HasColumnName("usable_quantity")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsStockAvailable>(entity =>
            {
                entity.HasKey(e => e.IdStockAvailable);

                entity.ToTable("ps_stock_available", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.HasIndex(e => e.IdProductAttribute)
                    .HasName("id_product_attribute");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdShopGroup)
                    .HasName("id_group_shop");

                entity.HasIndex(e => new { e.IdProduct, e.IdProductAttribute, e.IdShop, e.IdShopGroup })
                    .HasName("product_sqlstock")
                    .IsUnique();

                entity.Property(e => e.IdStockAvailable)
                    .HasColumnName("id_stock_available")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DependsOnStock)
                    .HasColumnName("depends_on_stock")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.OutOfStock)
                    .HasColumnName("out_of_stock")
                    .HasColumnType("int(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsStockMvt>(entity =>
            {
                entity.HasKey(e => e.IdStockMvt);

                entity.ToTable("ps_stock_mvt", "skistore_se");

                entity.HasIndex(e => e.IdStock)
                    .HasName("id_stock");

                entity.HasIndex(e => e.IdStockMvtReason)
                    .HasName("id_stock_mvt_reason");

                entity.Property(e => e.IdStockMvt)
                    .HasColumnName("id_stock_mvt")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CurrentWa)
                    .HasColumnName("current_wa")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.EmployeeFirstname)
                    .HasColumnName("employee_firstname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLastname)
                    .HasColumnName("employee_lastname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdStock)
                    .HasColumnName("id_stock")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdStockMvtReason)
                    .HasColumnName("id_stock_mvt_reason")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSupplyOrder)
                    .HasColumnName("id_supply_order")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.LastWa)
                    .HasColumnName("last_wa")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.PhysicalQuantity)
                    .HasColumnName("physical_quantity")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PriceTe)
                    .HasColumnName("price_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Referer)
                    .HasColumnName("referer")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Sign)
                    .HasColumnName("sign")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsStockMvtReason>(entity =>
            {
                entity.HasKey(e => e.IdStockMvtReason);

                entity.ToTable("ps_stock_mvt_reason", "skistore_se");

                entity.Property(e => e.IdStockMvtReason)
                    .HasColumnName("id_stock_mvt_reason")
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sign)
                    .HasColumnName("sign")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsStockMvtReasonLang>(entity =>
            {
                entity.HasKey(e => new { e.IdStockMvtReason, e.IdLang });

                entity.ToTable("ps_stock_mvt_reason_lang", "skistore_se");

                entity.Property(e => e.IdStockMvtReason)
                    .HasColumnName("id_stock_mvt_reason")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStore>(entity =>
            {
                entity.HasKey(e => e.IdStore);

                entity.ToTable("ps_store", "skistore_se");

                entity.Property(e => e.IdStore)
                    .HasColumnName("id_store")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Hours)
                    .HasColumnName("hours")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdState)
                    .HasColumnName("id_state")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("decimal(13,8)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("decimal(13,8)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasColumnName("postcode")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsStoreShop>(entity =>
            {
                entity.HasKey(e => new { e.IdStore, e.IdShop });

                entity.ToTable("ps_store_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdStore)
                    .HasColumnName("id_store")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsStorecomHistory>(entity =>
            {
                entity.HasKey(e => e.IdHistory);

                entity.ToTable("ps_storecom_history", "skistore_se");

                entity.Property(e => e.IdHistory)
                    .HasColumnName("id_history")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.Dbtable)
                    .IsRequired()
                    .HasColumnName("dbtable")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LangId)
                    .HasColumnName("lang_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Newvalue)
                    .IsRequired()
                    .HasColumnName("newvalue")
                    .IsUnicode(false);

                entity.Property(e => e.Object)
                    .IsRequired()
                    .HasColumnName("object")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Oldvalue)
                    .IsRequired()
                    .HasColumnName("oldvalue")
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasColumnName("section")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Shops)
                    .IsRequired()
                    .HasColumnName("shops")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsSupplier>(entity =>
            {
                entity.HasKey(e => e.IdSupplier);

                entity.ToTable("ps_supplier", "skistore_se");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSupplierLang>(entity =>
            {
                entity.HasKey(e => new { e.IdSupplier, e.IdLang });

                entity.ToTable("ps_supplier_lang", "skistore_se");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSupplierShop>(entity =>
            {
                entity.HasKey(e => new { e.IdSupplier, e.IdShop });

                entity.ToTable("ps_supplier_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsSupplyOrder>(entity =>
            {
                entity.HasKey(e => e.IdSupplyOrder);

                entity.ToTable("ps_supply_order", "skistore_se");

                entity.HasIndex(e => e.IdSupplier)
                    .HasName("id_supplier");

                entity.HasIndex(e => e.IdWarehouse)
                    .HasName("id_warehouse");

                entity.HasIndex(e => e.Reference)
                    .HasName("reference")
                    .IsUnique();

                entity.Property(e => e.IdSupplyOrder)
                    .HasColumnName("id_supply_order")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateDeliveryExpected).HasColumnName("date_delivery_expected");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.DiscountRate)
                    .HasColumnName("discount_rate")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.DiscountValueTe)
                    .HasColumnName("discount_value_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdRefCurrency)
                    .HasColumnName("id_ref_currency")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSupplier)
                    .HasColumnName("id_supplier")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSupplyOrderState)
                    .HasColumnName("id_supply_order_state")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("id_warehouse")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IsTemplate)
                    .HasColumnName("is_template")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnName("reference")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasColumnName("supplier_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TotalTax)
                    .HasColumnName("total_tax")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TotalTe)
                    .HasColumnName("total_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TotalTi)
                    .HasColumnName("total_ti")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TotalWithDiscountTe)
                    .HasColumnName("total_with_discount_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");
            });

            modelBuilder.Entity<PsSupplyOrderDetail>(entity =>
            {
                entity.HasKey(e => e.IdSupplyOrderDetail);

                entity.ToTable("ps_supply_order_detail", "skistore_se");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.HasIndex(e => e.IdProductAttribute)
                    .HasName("id_product_attribute");

                entity.HasIndex(e => e.IdSupplyOrder)
                    .HasName("id_supply_order");

                entity.HasIndex(e => new { e.IdProduct, e.IdProductAttribute })
                    .HasName("id_product_product_attribute");

                entity.Property(e => e.IdSupplyOrderDetail)
                    .HasColumnName("id_supply_order_detail")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DiscountRate)
                    .HasColumnName("discount_rate")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.DiscountValueTe)
                    .HasColumnName("discount_value_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Ean13)
                    .HasColumnName("ean13")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchange_rate")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSupplyOrder)
                    .HasColumnName("id_supply_order")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PriceTe)
                    .HasColumnName("price_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.PriceTi)
                    .HasColumnName("price_ti")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.PriceWithDiscountTe)
                    .HasColumnName("price_with_discount_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.PriceWithOrderDiscountTe)
                    .HasColumnName("price_with_order_discount_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.QuantityExpected)
                    .HasColumnName("quantity_expected")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.QuantityReceived)
                    .HasColumnName("quantity_received")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnName("reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierReference)
                    .IsRequired()
                    .HasColumnName("supplier_reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate)
                    .HasColumnName("tax_rate")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TaxValue)
                    .HasColumnName("tax_value")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TaxValueWithOrderDiscount)
                    .HasColumnName("tax_value_with_order_discount")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.UnitPriceTe)
                    .HasColumnName("unit_price_te")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Upc)
                    .HasColumnName("upc")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsSupplyOrderHistory>(entity =>
            {
                entity.HasKey(e => e.IdSupplyOrderHistory);

                entity.ToTable("ps_supply_order_history", "skistore_se");

                entity.HasIndex(e => e.IdEmployee)
                    .HasName("id_employee");

                entity.HasIndex(e => e.IdState)
                    .HasName("id_state");

                entity.HasIndex(e => e.IdSupplyOrder)
                    .HasName("id_supply_order");

                entity.Property(e => e.IdSupplyOrderHistory)
                    .HasColumnName("id_supply_order_history")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.EmployeeFirstname)
                    .HasColumnName("employee_firstname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLastname)
                    .HasColumnName("employee_lastname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdState)
                    .HasColumnName("id_state")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSupplyOrder)
                    .HasColumnName("id_supply_order")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsSupplyOrderReceiptHistory>(entity =>
            {
                entity.HasKey(e => e.IdSupplyOrderReceiptHistory);

                entity.ToTable("ps_supply_order_receipt_history", "skistore_se");

                entity.HasIndex(e => e.IdSupplyOrderDetail)
                    .HasName("id_supply_order_detail");

                entity.HasIndex(e => e.IdSupplyOrderState)
                    .HasName("id_supply_order_state");

                entity.Property(e => e.IdSupplyOrderReceiptHistory)
                    .HasColumnName("id_supply_order_receipt_history")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.EmployeeFirstname)
                    .HasColumnName("employee_firstname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLastname)
                    .HasColumnName("employee_lastname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSupplyOrderDetail)
                    .HasColumnName("id_supply_order_detail")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdSupplyOrderState)
                    .HasColumnName("id_supply_order_state")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsSupplyOrderState>(entity =>
            {
                entity.HasKey(e => e.IdSupplyOrderState);

                entity.ToTable("ps_supply_order_state", "skistore_se");

                entity.Property(e => e.IdSupplyOrderState)
                    .HasColumnName("id_supply_order_state")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNote)
                    .HasColumnName("delivery_note")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Editable)
                    .HasColumnName("editable")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enclosed)
                    .HasColumnName("enclosed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PendingReceipt)
                    .HasColumnName("pending_receipt")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReceiptState)
                    .HasColumnName("receipt_state")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsSupplyOrderStateLang>(entity =>
            {
                entity.HasKey(e => new { e.IdSupplyOrderState, e.IdLang });

                entity.ToTable("ps_supply_order_state_lang", "skistore_se");

                entity.Property(e => e.IdSupplyOrderState)
                    .HasColumnName("id_supply_order_state")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsTab>(entity =>
            {
                entity.HasKey(e => e.IdTab);

                entity.ToTable("ps_tab", "skistore_se");

                entity.HasIndex(e => e.ClassName)
                    .HasName("class_name");

                entity.HasIndex(e => e.IdParent)
                    .HasName("id_parent");

                entity.Property(e => e.IdTab)
                    .HasColumnName("id_tab")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasColumnName("class_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.HideHostMode)
                    .HasColumnName("hide_host_mode")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdParent)
                    .HasColumnName("id_parent")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsTabLang>(entity =>
            {
                entity.HasKey(e => new { e.IdTab, e.IdLang });

                entity.ToTable("ps_tab_lang", "skistore_se");

                entity.Property(e => e.IdTab)
                    .HasColumnName("id_tab")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsTabModulePreference>(entity =>
            {
                entity.HasKey(e => e.IdTabModulePreference);

                entity.ToTable("ps_tab_module_preference", "skistore_se");

                entity.HasIndex(e => new { e.IdEmployee, e.IdTab, e.Module })
                    .HasName("employee_module")
                    .IsUnique();

                entity.Property(e => e.IdTabModulePreference)
                    .HasColumnName("id_tab_module_preference")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTab)
                    .HasColumnName("id_tab")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsTag>(entity =>
            {
                entity.HasKey(e => e.IdTag);

                entity.ToTable("ps_tag", "skistore_se");

                entity.HasIndex(e => e.IdLang)
                    .HasName("id_lang");

                entity.HasIndex(e => e.Name)
                    .HasName("tag_name");

                entity.Property(e => e.IdTag)
                    .HasColumnName("id_tag")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsTax>(entity =>
            {
                entity.HasKey(e => e.IdTax);

                entity.ToTable("ps_tax", "skistore_se");

                entity.Property(e => e.IdTax)
                    .HasColumnName("id_tax")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(10,3)");
            });

            modelBuilder.Entity<PsTaxRule>(entity =>
            {
                entity.HasKey(e => e.IdTaxRule);

                entity.ToTable("ps_tax_rule", "skistore_se");

                entity.HasIndex(e => e.IdTax)
                    .HasName("id_tax");

                entity.HasIndex(e => e.IdTaxRulesGroup)
                    .HasName("id_tax_rules_group");

                entity.HasIndex(e => new { e.IdTaxRulesGroup, e.IdCountry, e.IdState })
                    .HasName("tax_rule")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdTaxRulesGroup, e.IdCountry, e.IdState, e.ZipcodeFrom })
                    .HasName("category_getproducts");

                entity.Property(e => e.IdTaxRule)
                    .HasColumnName("id_tax_rule")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Behavior)
                    .HasColumnName("behavior")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCountry)
                    .HasColumnName("id_country")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdState)
                    .HasColumnName("id_state")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTax)
                    .HasColumnName("id_tax")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTaxRulesGroup)
                    .HasColumnName("id_tax_rules_group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZipcodeFrom)
                    .IsRequired()
                    .HasColumnName("zipcode_from")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ZipcodeTo)
                    .IsRequired()
                    .HasColumnName("zipcode_to")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsTaxRulesGroup>(entity =>
            {
                entity.HasKey(e => e.IdTaxRulesGroup);

                entity.ToTable("ps_tax_rules_group", "skistore_se");

                entity.Property(e => e.IdTaxRulesGroup)
                    .HasColumnName("id_tax_rules_group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsTaxRulesGroupShop>(entity =>
            {
                entity.HasKey(e => new { e.IdTaxRulesGroup, e.IdShop });

                entity.ToTable("ps_tax_rules_group_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdTaxRulesGroup)
                    .HasColumnName("id_tax_rules_group")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsTheme>(entity =>
            {
                entity.HasKey(e => e.IdTheme);

                entity.ToTable("ps_theme", "skistore_se");

                entity.Property(e => e.IdTheme)
                    .HasColumnName("id_theme")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefaultLeftColumn)
                    .HasColumnName("default_left_column")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DefaultRightColumn)
                    .HasColumnName("default_right_column")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Directory)
                    .IsRequired()
                    .HasColumnName("directory")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPerPage)
                    .HasColumnName("product_per_page")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Responsive)
                    .HasColumnName("responsive")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PsThemeMeta>(entity =>
            {
                entity.HasKey(e => e.IdThemeMeta);

                entity.ToTable("ps_theme_meta", "skistore_se");

                entity.HasIndex(e => e.IdMeta)
                    .HasName("id_meta");

                entity.HasIndex(e => e.IdTheme)
                    .HasName("id_theme");

                entity.HasIndex(e => new { e.IdTheme, e.IdMeta })
                    .HasName("id_theme_2")
                    .IsUnique();

                entity.Property(e => e.IdThemeMeta)
                    .HasColumnName("id_theme_meta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMeta)
                    .HasColumnName("id_meta")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdTheme)
                    .HasColumnName("id_theme")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LeftColumn)
                    .HasColumnName("left_column")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RightColumn)
                    .HasColumnName("right_column")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PsThemeSpecific>(entity =>
            {
                entity.HasKey(e => new { e.IdTheme, e.IdShop, e.Entity, e.IdObject });

                entity.ToTable("ps_theme_specific", "skistore_se");

                entity.Property(e => e.IdTheme)
                    .HasColumnName("id_theme")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Entity)
                    .HasColumnName("entity")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdObject)
                    .HasColumnName("id_object")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsThemeconfigurator>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.ToTable("ps_themeconfigurator", "skistore_se");

                entity.Property(e => e.IdItem)
                    .HasColumnName("id_item")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Hook)
                    .HasColumnName("hook")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Html)
                    .HasColumnName("html")
                    .IsUnicode(false);

                entity.Property(e => e.IdLang)
                    .HasColumnName("id_lang")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageH)
                    .HasColumnName("image_h")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImageW)
                    .HasColumnName("image_w")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemOrder)
                    .HasColumnName("item_order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TitleUse)
                    .HasColumnName("title_use")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsTimezone>(entity =>
            {
                entity.HasKey(e => e.IdTimezone);

                entity.ToTable("ps_timezone", "skistore_se");

                entity.Property(e => e.IdTimezone)
                    .HasColumnName("id_timezone")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsWarehouse>(entity =>
            {
                entity.HasKey(e => e.IdWarehouse);

                entity.ToTable("ps_warehouse", "skistore_se");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("id_warehouse")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdAddress)
                    .HasColumnName("id_address")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("id_currency")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("id_employee")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ManagementType)
                    .IsRequired()
                    .HasColumnName("management_type")
                    .HasColumnType("enum('WA','FIFO','LIFO')")
                    .HasDefaultValueSql("WA");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsWarehouseCarrier>(entity =>
            {
                entity.HasKey(e => new { e.IdCarrier, e.IdWarehouse });

                entity.ToTable("ps_warehouse_carrier", "skistore_se");

                entity.HasIndex(e => e.IdCarrier)
                    .HasName("id_carrier");

                entity.HasIndex(e => e.IdWarehouse)
                    .HasName("id_warehouse");

                entity.Property(e => e.IdCarrier)
                    .HasColumnName("id_carrier")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("id_warehouse")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsWarehouseProductLocation>(entity =>
            {
                entity.HasKey(e => e.IdWarehouseProductLocation);

                entity.ToTable("ps_warehouse_product_location", "skistore_se");

                entity.HasIndex(e => new { e.IdProduct, e.IdProductAttribute, e.IdWarehouse })
                    .HasName("id_product")
                    .IsUnique();

                entity.Property(e => e.IdWarehouseProductLocation)
                    .HasColumnName("id_warehouse_product_location")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("id_warehouse")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsWarehouseShop>(entity =>
            {
                entity.HasKey(e => new { e.IdShop, e.IdWarehouse });

                entity.ToTable("ps_warehouse_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.HasIndex(e => e.IdWarehouse)
                    .HasName("id_warehouse");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("id_warehouse")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsWebBrowser>(entity =>
            {
                entity.HasKey(e => e.IdWebBrowser);

                entity.ToTable("ps_web_browser", "skistore_se");

                entity.Property(e => e.IdWebBrowser)
                    .HasColumnName("id_web_browser")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsWebserviceAccount>(entity =>
            {
                entity.HasKey(e => e.IdWebserviceAccount);

                entity.ToTable("ps_webservice_account", "skistore_se");

                entity.HasIndex(e => e.Key)
                    .HasName("key");

                entity.Property(e => e.IdWebserviceAccount)
                    .HasColumnName("id_webservice_account")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasColumnName("class_name")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("WebserviceRequest");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.IsModule)
                    .HasColumnName("is_module")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsWebserviceAccountShop>(entity =>
            {
                entity.HasKey(e => new { e.IdWebserviceAccount, e.IdShop });

                entity.ToTable("ps_webservice_account_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdWebserviceAccount)
                    .HasColumnName("id_webservice_account")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<PsWebservicePermission>(entity =>
            {
                entity.HasKey(e => e.IdWebservicePermission);

                entity.ToTable("ps_webservice_permission", "skistore_se");

                entity.HasIndex(e => e.IdWebserviceAccount)
                    .HasName("id_webservice_account");

                entity.HasIndex(e => e.Method)
                    .HasName("method");

                entity.HasIndex(e => e.Resource)
                    .HasName("resource");

                entity.HasIndex(e => new { e.Resource, e.Method, e.IdWebserviceAccount })
                    .HasName("resource_2")
                    .IsUnique();

                entity.Property(e => e.IdWebservicePermission)
                    .HasColumnName("id_webservice_permission")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdWebserviceAccount)
                    .HasColumnName("id_webservice_account")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnName("method")
                    .HasColumnType("enum('GET','POST','PUT','DELETE','HEAD')");

                entity.Property(e => e.Resource)
                    .IsRequired()
                    .HasColumnName("resource")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsWishlist>(entity =>
            {
                entity.HasKey(e => e.IdWishlist);

                entity.ToTable("ps_wishlist", "skistore_se");

                entity.Property(e => e.IdWishlist)
                    .HasColumnName("id_wishlist")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateUpd).HasColumnName("date_upd");

                entity.Property(e => e.Default)
                    .HasColumnName("default")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("id_customer")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdShopGroup)
                    .HasColumnName("id_shop_group")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsWishlistProduct>(entity =>
            {
                entity.HasKey(e => e.IdWishlistProduct);

                entity.ToTable("ps_wishlist_product", "skistore_se");

                entity.Property(e => e.IdWishlistProduct)
                    .HasColumnName("id_wishlist_product")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdProductAttribute)
                    .HasColumnName("id_product_attribute")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IdWishlist)
                    .HasColumnName("id_wishlist")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PsZone>(entity =>
            {
                entity.HasKey(e => e.IdZone);

                entity.ToTable("ps_zone", "skistore_se");

                entity.Property(e => e.IdZone)
                    .HasColumnName("id_zone")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsZoneShop>(entity =>
            {
                entity.HasKey(e => new { e.IdZone, e.IdShop });

                entity.ToTable("ps_zone_shop", "skistore_se");

                entity.HasIndex(e => e.IdShop)
                    .HasName("id_shop");

                entity.Property(e => e.IdZone)
                    .HasColumnName("id_zone")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<WpBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("wp_booking", "skistore_se");

                entity.Property(e => e.BookingId)
                    .HasColumnName("booking_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BookingType)
                    .HasColumnName("booking_type")
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Form)
                    .HasColumnName("form")
                    .IsUnicode(false);

                entity.Property(e => e.IsNew)
                    .HasColumnName("is_new")
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModificationDate).HasColumnName("modification_date");

                entity.Property(e => e.SortDate).HasColumnName("sort_date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WpCommentmeta>(entity =>
            {
                entity.HasKey(e => e.MetaId);

                entity.ToTable("wp_commentmeta", "skistore_se");

                entity.HasIndex(e => e.CommentId)
                    .HasName("comment_id");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key");

                entity.Property(e => e.MetaId)
                    .HasColumnName("meta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<WpComments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("wp_comments", "skistore_se");

                entity.HasIndex(e => e.CommentDateGmt)
                    .HasName("comment_date_gmt");

                entity.HasIndex(e => e.CommentParent)
                    .HasName("comment_parent");

                entity.HasIndex(e => e.CommentPostId)
                    .HasName("comment_post_ID");

                entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt })
                    .HasName("comment_approved_date_gmt");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommentAgent)
                    .IsRequired()
                    .HasColumnName("comment_agent")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CommentApproved)
                    .IsRequired()
                    .HasColumnName("comment_approved")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CommentAuthor)
                    .IsRequired()
                    .HasColumnName("comment_author")
                    .HasColumnType("tinytext");

                entity.Property(e => e.CommentAuthorEmail)
                    .IsRequired()
                    .HasColumnName("comment_author_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommentAuthorIp)
                    .IsRequired()
                    .HasColumnName("comment_author_IP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommentAuthorUrl)
                    .IsRequired()
                    .HasColumnName("comment_author_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CommentContent)
                    .IsRequired()
                    .HasColumnName("comment_content")
                    .IsUnicode(false);

                entity.Property(e => e.CommentDate)
                    .HasColumnName("comment_date")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CommentDateGmt)
                    .HasColumnName("comment_date_gmt")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CommentKarma)
                    .HasColumnName("comment_karma")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommentParent)
                    .HasColumnName("comment_parent")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommentPostId)
                    .HasColumnName("comment_post_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommentType)
                    .IsRequired()
                    .HasColumnName("comment_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WpInstagrabberImages>(entity =>
            {
                entity.ToTable("wp_instagrabber_images", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Caption)
                    .HasColumnName("caption")
                    .IsUnicode(false);

                entity.Property(e => e.CommentCount)
                    .HasColumnName("comment_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Filter)
                    .HasColumnName("filter")
                    .IsUnicode(false);

                entity.Property(e => e.LikeCount)
                    .HasColumnName("like_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .IsUnicode(false);

                entity.Property(e => e.MediaId)
                    .HasColumnName("media_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.PicId)
                    .IsRequired()
                    .HasColumnName("pic_id")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PicLink)
                    .HasColumnName("pic_link")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PicThumbnail)
                    .HasColumnName("pic_thumbnail")
                    .IsUnicode(false);

                entity.Property(e => e.PicTimestamp).HasColumnName("pic_timestamp");

                entity.Property(e => e.PicUrl)
                    .HasColumnName("pic_url")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stream)
                    .HasColumnName("stream")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .IsUnicode(false);

                entity.Property(e => e.TimeAdded)
                    .HasColumnName("time_added")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WpInstagrabberStreams>(entity =>
            {
                entity.ToTable("wp_instagrabber_streams", "skistore_se");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .IsUnicode(false);

                entity.Property(e => e.Administrators)
                    .HasColumnName("administrators")
                    .IsUnicode(false);

                entity.Property(e => e.AllowHashtags)
                    .HasColumnName("allow_hashtags")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AutoPost)
                    .HasColumnName("auto_post")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.AutoTags)
                    .HasColumnName("auto_tags")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.BackupPlaceholderTitle)
                    .HasColumnName("backup_placeholder_title")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CustomlinkUrl)
                    .HasColumnName("customlink_url")
                    .IsUnicode(false);

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("error_message")
                    .IsUnicode(false);

                entity.Property(e => e.GetToDate).HasColumnName("get_to_date");

                entity.Property(e => e.ImageAttachment)
                    .HasColumnName("image_attachment")
                    .IsUnicode(false);

                entity.Property(e => e.ImageLink)
                    .HasColumnName("image_link")
                    .IsUnicode(false);

                entity.Property(e => e.ImageSize)
                    .HasColumnName("image_size")
                    .IsUnicode(false);

                entity.Property(e => e.LastId)
                    .HasColumnName("last_id")
                    .IsUnicode(false);

                entity.Property(e => e.LocalTags)
                    .HasColumnName("local_tags")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.PlaceholderTitle)
                    .IsRequired()
                    .HasColumnName("placeholder_title")
                    .IsUnicode(false);

                entity.Property(e => e.PostFormat)
                    .HasColumnName("post_format")
                    .IsUnicode(false);

                entity.Property(e => e.PostStatus)
                    .HasColumnName("post_status")
                    .IsUnicode(false);

                entity.Property(e => e.PostType)
                    .HasColumnName("post_type")
                    .IsUnicode(false);

                entity.Property(e => e.SaveImages)
                    .HasColumnName("save_images")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .IsUnicode(false);

                entity.Property(e => e.TagsTax)
                    .HasColumnName("tags_tax")
                    .IsUnicode(false);

                entity.Property(e => e.TaxTerm)
                    .HasColumnName("tax_term")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Taxonomy)
                    .HasColumnName("taxonomy")
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<WpLinks>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("wp_links", "skistore_se");

                entity.HasIndex(e => e.LinkVisible)
                    .HasName("link_visible");

                entity.Property(e => e.LinkId)
                    .HasColumnName("link_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LinkDescription)
                    .IsRequired()
                    .HasColumnName("link_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkImage)
                    .IsRequired()
                    .HasColumnName("link_image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasColumnName("link_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkNotes)
                    .IsRequired()
                    .HasColumnName("link_notes")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.LinkOwner)
                    .HasColumnName("link_owner")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LinkRating)
                    .HasColumnName("link_rating")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkRel)
                    .IsRequired()
                    .HasColumnName("link_rel")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkRss)
                    .IsRequired()
                    .HasColumnName("link_rss")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkTarget)
                    .IsRequired()
                    .HasColumnName("link_target")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUpdated)
                    .HasColumnName("link_updated")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("link_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkVisible)
                    .IsRequired()
                    .HasColumnName("link_visible")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Y");
            });

            modelBuilder.Entity<WpNewfield>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("wp_newfield", "skistore_se");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("int(9)");
            });

            modelBuilder.Entity<WpOptionTree>(entity =>
            {
                entity.ToTable("wp_option_tree", "skistore_se");

                entity.HasIndex(e => e.ItemId)
                    .HasName("item_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.ItemDesc)
                    .HasColumnName("item_desc")
                    .HasColumnType("longtext");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnName("item_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemOptions)
                    .HasColumnName("item_options")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSort)
                    .HasColumnName("item_sort")
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemTitle)
                    .IsRequired()
                    .HasColumnName("item_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WpOptions>(entity =>
            {
                entity.HasKey(e => e.OptionId);

                entity.ToTable("wp_options", "skistore_se");

                entity.HasIndex(e => e.OptionName)
                    .HasName("option_name")
                    .IsUnique();

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Autoload)
                    .IsRequired()
                    .HasColumnName("autoload")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("yes");

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasColumnName("option_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.OptionValue)
                    .IsRequired()
                    .HasColumnName("option_value")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<WpPostmeta>(entity =>
            {
                entity.HasKey(e => e.MetaId);

                entity.ToTable("wp_postmeta", "skistore_se");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.Property(e => e.MetaId)
                    .HasColumnName("meta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WpPosts>(entity =>
            {
                entity.ToTable("wp_posts", "skistore_se");

                entity.HasIndex(e => e.PostAuthor)
                    .HasName("post_author");

                entity.HasIndex(e => e.PostName)
                    .HasName("post_name");

                entity.HasIndex(e => e.PostParent)
                    .HasName("post_parent");

                entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id })
                    .HasName("type_status_date");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommentCount)
                    .HasColumnName("comment_count")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommentStatus)
                    .IsRequired()
                    .HasColumnName("comment_status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("open");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOrder)
                    .HasColumnName("menu_order")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PingStatus)
                    .IsRequired()
                    .HasColumnName("ping_status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("open");

                entity.Property(e => e.Pinged)
                    .IsRequired()
                    .HasColumnName("pinged")
                    .IsUnicode(false);

                entity.Property(e => e.PostAuthor)
                    .HasColumnName("post_author")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostContent)
                    .IsRequired()
                    .HasColumnName("post_content")
                    .HasColumnType("longtext");

                entity.Property(e => e.PostContentFiltered)
                    .IsRequired()
                    .HasColumnName("post_content_filtered")
                    .HasColumnType("longtext");

                entity.Property(e => e.PostDate)
                    .HasColumnName("post_date")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.PostDateGmt)
                    .HasColumnName("post_date_gmt")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.PostExcerpt)
                    .IsRequired()
                    .HasColumnName("post_excerpt")
                    .IsUnicode(false);

                entity.Property(e => e.PostMimeType)
                    .IsRequired()
                    .HasColumnName("post_mime_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostModified)
                    .HasColumnName("post_modified")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.PostModifiedGmt)
                    .HasColumnName("post_modified_gmt")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.PostName)
                    .IsRequired()
                    .HasColumnName("post_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostParent)
                    .HasColumnName("post_parent")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostPassword)
                    .IsRequired()
                    .HasColumnName("post_password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostStatus)
                    .IsRequired()
                    .HasColumnName("post_status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("publish");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasColumnName("post_title")
                    .IsUnicode(false);

                entity.Property(e => e.PostType)
                    .IsRequired()
                    .HasColumnName("post_type")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("post");

                entity.Property(e => e.ToPing)
                    .IsRequired()
                    .HasColumnName("to_ping")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WpTermRelationships>(entity =>
            {
                entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId });

                entity.ToTable("wp_term_relationships", "skistore_se");

                entity.HasIndex(e => e.TermTaxonomyId)
                    .HasName("term_taxonomy_id");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TermTaxonomyId)
                    .HasColumnName("term_taxonomy_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TermOrder)
                    .HasColumnName("term_order")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WpTermTaxonomy>(entity =>
            {
                entity.HasKey(e => e.TermTaxonomyId);

                entity.ToTable("wp_term_taxonomy", "skistore_se");

                entity.HasIndex(e => e.Taxonomy)
                    .HasName("taxonomy");

                entity.HasIndex(e => new { e.TermId, e.Taxonomy })
                    .HasName("term_id_taxonomy")
                    .IsUnique();

                entity.Property(e => e.TermTaxonomyId)
                    .HasColumnName("term_taxonomy_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("longtext");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Taxonomy)
                    .IsRequired()
                    .HasColumnName("taxonomy")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TermId)
                    .HasColumnName("term_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WpTerms>(entity =>
            {
                entity.HasKey(e => e.TermId);

                entity.ToTable("wp_terms", "skistore_se");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Slug)
                    .HasName("slug")
                    .IsUnique();

                entity.Property(e => e.TermId)
                    .HasColumnName("term_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TermGroup)
                    .HasColumnName("term_group")
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WpUsermeta>(entity =>
            {
                entity.HasKey(e => e.UmetaId);

                entity.ToTable("wp_usermeta", "skistore_se");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.UmetaId)
                    .HasColumnName("umeta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WpUsers>(entity =>
            {
                entity.ToTable("wp_users", "skistore_se");

                entity.HasIndex(e => e.UserLogin)
                    .HasName("user_login_key");

                entity.HasIndex(e => e.UserNicename)
                    .HasName("user_nicename");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("display_name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserActivationKey)
                    .IsRequired()
                    .HasColumnName("user_activation_key")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasColumnName("user_login")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UserNicename)
                    .IsRequired()
                    .HasColumnName("user_nicename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasColumnName("user_pass")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UserRegistered)
                    .HasColumnName("user_registered")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.UserStatus)
                    .HasColumnName("user_status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserUrl)
                    .IsRequired()
                    .HasColumnName("user_url")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WpWpdevCrmCustomers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("wp_wpdev_crm_customers", "skistore_se");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnName("adress")
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDate)
                    .HasColumnName("customer_date")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasColumnName("info")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasColumnName("second_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<WpWpdevCrmOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("wp_wpdev_crm_orders", "skistore_se");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("float(7,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.InternalFilters)
                    .IsRequired()
                    .HasColumnName("internal_filters")
                    .IsUnicode(false);

                entity.Property(e => e.InternalFilters1)
                    .IsRequired()
                    .HasColumnName("internal_filters1")
                    .IsUnicode(false);

                entity.Property(e => e.InternalFilters2)
                    .HasColumnName("internal_filters2")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.InternalFilters3)
                    .HasColumnName("internal_filters3")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.InternalId)
                    .HasColumnName("internal_id")
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.OrderInfo)
                    .IsRequired()
                    .HasColumnName("order_info")
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .IsUnicode(false);

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .IsUnicode(false);
            });
        }
    }
}
