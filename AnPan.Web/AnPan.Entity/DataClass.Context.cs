﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnPan.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CustomsEntities : DbContext
    {
        public CustomsEntities()
            : base("name=CustomsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<UT_AUTO_INFO> UT_AUTO_INFO { get; set; }
        public DbSet<UT_AUTO_PARAMS_INFO> UT_AUTO_PARAMS_INFO { get; set; }
        public DbSet<UT_AUTO_REPORT_BAK> UT_AUTO_REPORT_BAK { get; set; }
        public DbSet<UT_COMPANY_CODE> UT_COMPANY_CODE { get; set; }
        public DbSet<UT_COMPANY_DIRECTORY> UT_COMPANY_DIRECTORY { get; set; }
        public DbSet<UT_COMPANY_RULE> UT_COMPANY_RULE { get; set; }
        public DbSet<UT_CONSIGN_CODE> UT_CONSIGN_CODE { get; set; }
        public DbSet<UT_CONSIGN_DIRECTORY> UT_CONSIGN_DIRECTORY { get; set; }
        public DbSet<UT_CONSIGN_RULE> UT_CONSIGN_RULE { get; set; }
        public DbSet<UT_COUNTRY_CODE> UT_COUNTRY_CODE { get; set; }
        public DbSet<UT_COUNTRY_DIRECTORY> UT_COUNTRY_DIRECTORY { get; set; }
        public DbSet<UT_COUNTRY_RULE> UT_COUNTRY_RULE { get; set; }
        public DbSet<UT_CUST_CODE> UT_CUST_CODE { get; set; }
        public DbSet<UT_CUST_DIRECTORY> UT_CUST_DIRECTORY { get; set; }
        public DbSet<UT_CUST_RULE> UT_CUST_RULE { get; set; }
        public DbSet<UT_DATA_CONTRAST> UT_DATA_CONTRAST { get; set; }
        public DbSet<UT_DATA_CONTRASTPART> UT_DATA_CONTRASTPART { get; set; }
        public DbSet<UT_DATA_FIXED> UT_DATA_FIXED { get; set; }
        public DbSet<UT_DATA_MULTI> UT_DATA_MULTI { get; set; }
        public DbSet<UT_DATA_PRICE> UT_DATA_PRICE { get; set; }
        public DbSet<UT_DATA_TREND> UT_DATA_TREND { get; set; }
        public DbSet<UT_DIRECTORY_SHAREDPOWER> UT_DIRECTORY_SHAREDPOWER { get; set; }
        public DbSet<UT_HS_CODE> UT_HS_CODE { get; set; }
        public DbSet<UT_HS_DIRECTORY> UT_HS_DIRECTORY { get; set; }
        public DbSet<UT_HS_RULE> UT_HS_RULE { get; set; }
        public DbSet<UT_IMPORT_DATE> UT_IMPORT_DATE { get; set; }
        public DbSet<UT_IMPORT_FORMAT> UT_IMPORT_FORMAT { get; set; }
        public DbSet<UT_IMPORT_FORMATDT> UT_IMPORT_FORMATDT { get; set; }
        public DbSet<UT_IMPORTCODE_VIEW> UT_IMPORTCODE_VIEW { get; set; }
        public DbSet<UT_IMPORTDATA_LOG> UT_IMPORTDATA_LOG { get; set; }
        public DbSet<UT_IMPORTDATA_RIGHT> UT_IMPORTDATA_RIGHT { get; set; }
        public DbSet<UT_IMPORTDATA_VIEW_E> UT_IMPORTDATA_VIEW_E { get; set; }
        public DbSet<UT_IMPORTDATA_VIEW_I> UT_IMPORTDATA_VIEW_I { get; set; }
        public DbSet<UT_SEARCH_CONTRAST_DATE> UT_SEARCH_CONTRAST_DATE { get; set; }
        public DbSet<UT_SEARCH_CONTRAST_NODE> UT_SEARCH_CONTRAST_NODE { get; set; }
        public DbSet<UT_SEARCH_CONTRASTPART_DATE> UT_SEARCH_CONTRASTPART_DATE { get; set; }
        public DbSet<UT_SEARCH_CONTRASTPART_NODE> UT_SEARCH_CONTRASTPART_NODE { get; set; }
        public DbSet<UT_SEARCH_DIRECTORY> UT_SEARCH_DIRECTORY { get; set; }
        public DbSet<UT_SEARCH_EXPDIRECTORY> UT_SEARCH_EXPDIRECTORY { get; set; }
        public DbSet<UT_SEARCH_FIXED_DATE> UT_SEARCH_FIXED_DATE { get; set; }
        public DbSet<UT_SEARCH_FIXED_NODE> UT_SEARCH_FIXED_NODE { get; set; }
        public DbSet<UT_SEARCH_MULTIDIM_DATE> UT_SEARCH_MULTIDIM_DATE { get; set; }
        public DbSet<UT_SEARCH_MULTIDIM_NODE> UT_SEARCH_MULTIDIM_NODE { get; set; }
        public DbSet<UT_SEARCH_PRICE_DATE> UT_SEARCH_PRICE_DATE { get; set; }
        public DbSet<UT_SEARCH_PRICE_NODE> UT_SEARCH_PRICE_NODE { get; set; }
        public DbSet<UT_SEARCH_SUITE> UT_SEARCH_SUITE { get; set; }
        public DbSet<UT_SEARCH_SUITE_SELECTED_DATA> UT_SEARCH_SUITE_SELECTED_DATA { get; set; }
        public DbSet<UT_SEARCH_TREND_DATE> UT_SEARCH_TREND_DATE { get; set; }
        public DbSet<UT_SEARCH_TREND_DATEDT> UT_SEARCH_TREND_DATEDT { get; set; }
        public DbSet<UT_SEARCH_TREND_DIRECTORY> UT_SEARCH_TREND_DIRECTORY { get; set; }
        public DbSet<UT_SEARCH_TREND_NODE> UT_SEARCH_TREND_NODE { get; set; }
        public DbSet<UT_SYS_CODE> UT_SYS_CODE { get; set; }
        public DbSet<UT_SYS_CODEGROUP> UT_SYS_CODEGROUP { get; set; }
        public DbSet<UT_SYS_EMPLOYEE> UT_SYS_EMPLOYEE { get; set; }
        public DbSet<UT_SYS_LOG> UT_SYS_LOG { get; set; }
        public DbSet<UT_SYS_LOG4NET> UT_SYS_LOG4NET { get; set; }
        public DbSet<UT_SYS_ORGANIZATION> UT_SYS_ORGANIZATION { get; set; }
        public DbSet<UT_SYS_PERSONALDESKTOP> UT_SYS_PERSONALDESKTOP { get; set; }
        public DbSet<UT_SYS_RIGHT> UT_SYS_RIGHT { get; set; }
        public DbSet<UT_SYS_ROLE> UT_SYS_ROLE { get; set; }
        public DbSet<UT_SYS_ROLERIGHT> UT_SYS_ROLERIGHT { get; set; }
        public DbSet<UT_SYS_SYSTEM> UT_SYS_SYSTEM { get; set; }
        public DbSet<UT_SYS_USER> UT_SYS_USER { get; set; }
        public DbSet<UT_SYS_USERROLE> UT_SYS_USERROLE { get; set; }
        public DbSet<UT_Test> UT_Test { get; set; }
        public DbSet<UT_TRADE_CODE> UT_TRADE_CODE { get; set; }
        public DbSet<UT_TRADE_DIRECTORY> UT_TRADE_DIRECTORY { get; set; }
        public DbSet<UT_TRADE_RULE> UT_TRADE_RULE { get; set; }
        public DbSet<UT_TRANSPORT_CODE> UT_TRANSPORT_CODE { get; set; }
        public DbSet<UT_TRANSPORT_DIRECTORY> UT_TRANSPORT_DIRECTORY { get; set; }
        public DbSet<UT_TRANSPORT_RULE> UT_TRANSPORT_RULE { get; set; }
        public DbSet<DatabaseExtension> DatabaseExtension { get; set; }
        public DbSet<TableDetailExtension> TableDetailExtension { get; set; }
        public DbSet<TableExtension> TableExtension { get; set; }
        public DbSet<UT_CODE_TEMP> UT_CODE_TEMP { get; set; }
        public DbSet<UV_AUTO_INFO> UV_AUTO_INFO { get; set; }
        public DbSet<UV_AUTO_PARAMS_INFO> UV_AUTO_PARAMS_INFO { get; set; }
        public DbSet<UV_SEARCH_GETCHOOSEROOT> UV_SEARCH_GETCHOOSEROOT { get; set; }
        public DbSet<UV_SEARCH_GETCHOOSEROOT_TREND> UV_SEARCH_GETCHOOSEROOT_TREND { get; set; }
        public DbSet<UV_SYS_USER> UV_SYS_USER { get; set; }
        public DbSet<V_SYS_EMPLOYEE> V_SYS_EMPLOYEE { get; set; }
    }
}
