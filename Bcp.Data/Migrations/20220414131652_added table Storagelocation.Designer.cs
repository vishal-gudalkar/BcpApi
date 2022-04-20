﻿// <auto-generated />
using System;
using Bcp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bcp.Data.Migrations
{
    [DbContext(typeof(BcpContext))]
    [Migration("20220414131652_added table Storagelocation")]
    partial class addedtableStoragelocation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bcp.Domain.Models.Classification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Amendment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assemblyscrap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Av")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("B")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("B1")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("BUn")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("BUn1")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("BUn2")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("BUn3")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("BUn4")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("BUn5")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("BUn6")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("BUn7")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Bmr")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("CRNorm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarMarket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarSegment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Changedby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompositionV2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Consumptionmode")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("CostingLotSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerPlanNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customerpartno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cuttingprogram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dangerousproduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmplacementMM")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("FixLotSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Glassmatrix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrossWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeightV2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Internalplannumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ipt")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("LGrp")
                        .HasColumnType("varchar(5)");

                    b.Property<DateTime?>("LastChg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Layernumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lighttransmission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ls")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("MRPpr")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("MTyp")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatlGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxLotSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Militaryproduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinLotSze")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mrpc")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Ms")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Ms1")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Navigability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldMatNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PGr")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PNManufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pi")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Pl")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Planningtimefence")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Plnt")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Plnt1")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PositionV2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcType")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Profl")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("ReorderPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roundingval")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RoundingVal");

                    b.Property<string>("SafetyStock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SideV2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spt")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("St")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SupportTechnicalDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TabiaClassif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechnicalDocnewproduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextADVEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextADVFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trlt")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Typ")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("WUn")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("WUn1")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("WidthV2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("classifications");
                });

            modelBuilder.Entity("Bcp.Domain.Models.customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AcctAtCust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Curr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Customer")
                        .HasColumnType("int");

                    b.Property<int?>("Customer1")
                        .HasColumnType("int");

                    b.Property<string>("CustomerAdditionalTelephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerContactEmail1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerContactEmail2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerContactEmail3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmergencyEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLogisticContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerTransportWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DChl")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Dv")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("EMailAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-MailAddress");

                    b.Property<string>("FaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Funct")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("IdLogin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inco2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncoT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGSCustomerServiceReferentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGrp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SOrg")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SiteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNumber1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Bcp.Domain.Models.Deliveries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Curr")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("CustMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustOrderNb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DChl")
                        .HasColumnType("varchar(3)");

                    b.Property<int?>("Division")
                        .HasColumnType("int");

                    b.Property<int?>("Item")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MatAvDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OpenQty")
                        .HasColumnType("int");

                    b.Property<int?>("OrderNb")
                        .HasColumnType("int");

                    b.Property<string>("Plnt")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("PriceSo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SOrg")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SaTy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipNb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShipQty")
                        .HasColumnType("int");

                    b.Property<int?>("ShipTo")
                        .HasColumnType("int");

                    b.Property<string>("ShipToName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoldToName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SoldToPt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("deliveries");
                });

            modelBuilder.Entity("Bcp.Domain.Models.Delnbgen", b =>
                {
                    b.Property<int>("DelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DelId"), 1L, 1);

                    b.HasKey("DelId");

                    b.ToTable("delnbgens");
                });

            modelBuilder.Entity("Bcp.Domain.Models.Lblnbgen", b =>
                {
                    b.Property<int>("LblId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LblId"), 1L, 1);

                    b.HasKey("LblId");

                    b.ToTable("lblnbgens");
                });

            modelBuilder.Entity("Bcp.Domain.Models.OpenOrders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("Curr")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("CustMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustOrderNb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DChl")
                        .HasColumnType("varchar(3)");

                    b.Property<int?>("Division")
                        .HasColumnType("int");

                    b.Property<int>("Item")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MatAvDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OpenQty")
                        .HasColumnType("int");

                    b.Property<int>("OrderNb")
                        .HasColumnType("int");

                    b.Property<string>("PlanOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlanOrderQty")
                        .HasColumnType("int");

                    b.Property<string>("Plnt")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("PriceSo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SOrg")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SaTy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipQty")
                        .HasColumnType("int");

                    b.Property<int?>("ShipTo")
                        .HasColumnType("int");

                    b.Property<string>("ShipToName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sloc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoldToName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SoldToPt")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("openorders");
                });

            modelBuilder.Entity("Bcp.Domain.Models.ProdMovements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterCamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NetQty")
                        .HasColumnType("int");

                    b.Property<string>("OrderNb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QtyToProd")
                        .HasColumnType("int");

                    b.Property<int?>("Scrap")
                        .HasColumnType("int");

                    b.Property<string>("TmStmp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCenterPlan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("prodmovements");
                });

            modelBuilder.Entity("Bcp.Domain.Models.RackTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("RackType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("racktypes");
                });

            modelBuilder.Entity("Bcp.Domain.Models.Routing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ConsolidatedCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialType")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Operation")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Plant")
                        .HasColumnType("varchar(5)");

                    b.Property<int?>("Stufe")
                        .HasColumnType("int");

                    b.Property<string>("WorkCenter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("routing");
                });

            modelBuilder.Entity("Bcp.Domain.Models.SapLocMarket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Market")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SapLoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("saplocmarket");
                });

            modelBuilder.Entity("Bcp.Domain.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("OptionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("settings");
                });

            modelBuilder.Entity("Bcp.Domain.Models.StockMovements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BatchNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Delivery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabelNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plant")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("RackId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RackType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapLoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TmStmp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("stockmovements");
                });

            modelBuilder.Entity("Bcp.Domain.Models.StockWms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BatchNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BinStatus")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("CarBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentStatus")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Delivery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GlassPos")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("GlassTyp")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("LabelNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabelStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LotNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Market")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("MatGrp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plant")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("PrNetWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PrWeightUnit")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("ProdAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProdDsc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("RackId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RackTotWgt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RackType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonCodeLong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RtNetWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RtWeightUnit")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SapLoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StatusBDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StatusQDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WareHouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZoneDsc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("stockwms");
                });

            modelBuilder.Entity("Bcp.Domain.Models.StorageLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Storagelocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("storagelocation");
                });

            modelBuilder.Entity("Bcp.Domain.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Dpt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FailedLogin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FailedLoginCount")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Transport")
                        .HasColumnType("int");

                    b.Property<string>("Wc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Werks")
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Bcp.Domain.Models.Zp36ProdOrders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdditionalData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MasterCamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NetQty")
                        .HasColumnType("int");

                    b.Property<string>("Operation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QtyToProd")
                        .HasColumnType("int");

                    b.Property<string>("RackType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Scrap")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TmStmp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("WorkCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCenterPlan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("zp36prodorders");
                });

            modelBuilder.Entity("Bcp.Domain.Models.ZtpMatDiagram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BisMt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatNr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ztpmatdiagrams");
                });
#pragma warning restore 612, 618
        }
    }
}
