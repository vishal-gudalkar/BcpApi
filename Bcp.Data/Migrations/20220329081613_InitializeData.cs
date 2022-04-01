using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bcp.Data.Migrations
{
    public partial class InitializeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    oldmatno = table.Column<string>(name: "old mat.no", type: "nvarchar(max)", nullable: true),
                    MaterialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarSegment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabiaClassif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarMarket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionV2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SideV2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompositionV2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthV2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeightV2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextADVEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextADVFR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChg = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Changedby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MTyp = table.Column<string>(type: "varchar(5)", nullable: true),
                    MatlGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customerpartno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUn = table.Column<string>(type: "varchar(5)", nullable: true),
                    GrossWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WUn = table.Column<string>(type: "varchar(5)", nullable: true),
                    NetWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WUn1 = table.Column<string>(type: "varchar(5)", nullable: true),
                    Ms = table.Column<string>(type: "varchar(5)", nullable: true),
                    St = table.Column<string>(type: "varchar(5)", nullable: true),
                    Material1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plnt = table.Column<string>(type: "varchar(5)", nullable: true),
                    Pl = table.Column<string>(type: "varchar(3)", nullable: true),
                    B = table.Column<string>(type: "varchar(3)", nullable: true),
                    Ms1 = table.Column<string>(type: "varchar(5)", nullable: true),
                    PGr = table.Column<string>(type: "varchar(5)", nullable: true),
                    MRPpr = table.Column<string>(type: "varchar(5)", nullable: true),
                    Typ = table.Column<string>(type: "varchar(3)", nullable: true),
                    Mrpc = table.Column<string>(type: "varchar(5)", nullable: true),
                    Pdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pi = table.Column<string>(type: "varchar(3)", nullable: true),
                    Ls = table.Column<string>(type: "varchar(3)", nullable: true),
                    ProcType = table.Column<string>(type: "varchar(3)", nullable: true),
                    Spt = table.Column<string>(type: "varchar(3)", nullable: true),
                    SafetyStock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUn1 = table.Column<string>(type: "varchar(5)", nullable: true),
                    MinLotSze = table.Column<string>(name: "Min.LotSze", type: "nvarchar(max)", nullable: true),
                    BUn2 = table.Column<string>(type: "varchar(5)", nullable: true),
                    ReorderPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUn3 = table.Column<string>(type: "varchar(5)", nullable: true),
                    MaxLotSize = table.Column<string>(name: "Max.LotSize", type: "nvarchar(max)", nullable: true),
                    BUn4 = table.Column<string>(type: "varchar(5)", nullable: true),
                    Fixlotsize = table.Column<string>(name: "Fix.lotsize", type: "nvarchar(max)", nullable: true),
                    BUn5 = table.Column<string>(type: "varchar(5)", nullable: true),
                    Roundingval = table.Column<string>(name: "Roundingval.", type: "nvarchar(max)", nullable: true),
                    BUn6 = table.Column<string>(type: "varchar(5)", nullable: true),
                    B1 = table.Column<string>(type: "varchar(3)", nullable: true),
                    Ipt = table.Column<string>(type: "varchar(3)", nullable: true),
                    Trlt = table.Column<string>(type: "varchar(3)", nullable: true),
                    LGrp = table.Column<string>(type: "varchar(5)", nullable: true),
                    Bmr = table.Column<string>(type: "varchar(3)", nullable: true),
                    Av = table.Column<string>(type: "varchar(3)", nullable: true),
                    Planningtimefence = table.Column<string>(type: "varchar(5)", nullable: true),
                    Consumptionmode = table.Column<string>(type: "varchar(3)", nullable: true),
                    CostingLotSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUn7 = table.Column<string>(type: "varchar(5)", nullable: true),
                    Profl = table.Column<string>(name: "Profl.", type: "varchar(5)", nullable: true),
                    Plnt1 = table.Column<string>(type: "varchar(5)", nullable: true),
                    Material2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPlanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuttingprogram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Layernumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRNorm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Internalplannumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalDocnewproduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportTechnicalDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amendment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lighttransmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Glassmatrix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dangerousproduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Navigability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Militaryproduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PNManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assemblyscrap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmplacementMM = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer = table.Column<int>(type: "int", nullable: true),
                    SOrg = table.Column<string>(type: "varchar(5)", nullable: true),
                    DChl = table.Column<string>(type: "varchar(3)", nullable: true),
                    Dv = table.Column<string>(type: "varchar(3)", nullable: true),
                    Funct = table.Column<string>(type: "varchar(3)", nullable: true),
                    Customer1 = table.Column<int>(type: "int", nullable: true),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncoT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inco2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Curr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SGrp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMailAddress = table.Column<string>(name: "E-MailAddress", type: "nvarchar(max)", nullable: true),
                    CustomerBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerContactEmail1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerContactEmail2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerContactEmail3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmergencyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAdditionalTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLogisticContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTransportWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SGSCustomerServiceReferentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcctAtCust = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipNb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOrg = table.Column<string>(type: "varchar(5)", nullable: true),
                    SalesDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item = table.Column<int>(type: "int", nullable: true),
                    OrderNb = table.Column<int>(type: "int", nullable: true),
                    CustOrderNb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaTy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DChl = table.Column<string>(type: "varchar(3)", nullable: true),
                    Plnt = table.Column<string>(type: "varchar(5)", nullable: true),
                    SoldToPt = table.Column<int>(type: "int", nullable: true),
                    SoldToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipTo = table.Column<int>(type: "int", nullable: true),
                    ShipToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatAvDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OpenQty = table.Column<int>(type: "int", nullable: true),
                    PriceSo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Curr = table.Column<string>(type: "varchar(5)", nullable: true),
                    Division = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipQty = table.Column<int>(type: "int", nullable: true),
                    ShipId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deliveries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "delnbgens",
                columns: table => new
                {
                    DelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delnbgens", x => x.DelId);
                });

            migrationBuilder.CreateTable(
                name: "lblnbgens",
                columns: table => new
                {
                    LblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lblnbgens", x => x.LblId);
                });

            migrationBuilder.CreateTable(
                name: "openorders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SOrg = table.Column<string>(type: "varchar(5)", nullable: true),
                    SalesDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item = table.Column<int>(type: "int", nullable: false),
                    OrderNb = table.Column<int>(type: "int", nullable: false),
                    CustOrderNb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaTy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DChl = table.Column<string>(type: "varchar(3)", nullable: true),
                    Plnt = table.Column<string>(type: "varchar(5)", nullable: true),
                    SoldToPt = table.Column<int>(type: "int", nullable: true),
                    SoldToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipTo = table.Column<int>(type: "int", nullable: true),
                    ShipToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatAvDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OpenQty = table.Column<int>(type: "int", nullable: true),
                    PriceSo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Curr = table.Column<string>(type: "varchar(5)", nullable: true),
                    Division = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipQty = table.Column<int>(type: "int", nullable: false),
                    PlanOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanOrderQty = table.Column<int>(type: "int", nullable: true),
                    Sloc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_openorders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "prodmovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkCenterPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Camp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty_To_Prod = table.Column<int>(type: "int", nullable: true),
                    Work_Center = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Net_Qty = table.Column<int>(type: "int", nullable: true),
                    Scrap = table.Column<int>(type: "int", nullable: true),
                    TmStmp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prodmovements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "routing",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plant = table.Column<string>(type: "varchar(5)", nullable: true),
                    ConsolidatedCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialType = table.Column<string>(type: "varchar(5)", nullable: true),
                    Operation = table.Column<string>(type: "varchar(5)", nullable: true),
                    WorkCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stufe = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_routing", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "saplocmarket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SapLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Market = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saplocmarket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stockmovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TmStmp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plant = table.Column<string>(type: "varchar(5)", nullable: true),
                    SapLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RackType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    ContentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockmovements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stockwms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BinStatus = table.Column<string>(type: "varchar(2)", nullable: true),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentStatus = table.Column<string>(type: "varchar(2)", nullable: true),
                    DryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GlassPos = table.Column<string>(type: "varchar(2)", nullable: true),
                    GlassTyp = table.Column<string>(type: "varchar(5)", nullable: true),
                    LabelNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Market = table.Column<string>(type: "varchar(5)", nullable: true),
                    MatGrp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdDsc2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrNetWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrWeightUnit = table.Column<string>(type: "varchar(5)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    RackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RackTotWgt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RackType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonCodeLong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RtNetWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RtWeightUnit = table.Column<string>(type: "varchar(5)", nullable: true),
                    SapLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusBDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusQDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WareHouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneDsc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plant = table.Column<string>(type: "varchar(5)", nullable: true),
                    Delivery = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockwms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dpt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Werks = table.Column<string>(type: "varchar(5)", nullable: true),
                    Transport = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FailedLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FailedLoginCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "zp36prodorders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkCenterPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "varchar(5)", nullable: true),
                    MasterCamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyToProd = table.Column<int>(type: "int", nullable: true),
                    Operation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdditionalData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NetQty = table.Column<int>(type: "int", nullable: true),
                    Scrap = table.Column<int>(type: "int", nullable: true),
                    TmStmp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RackType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zp36prodorders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ztpmatdiagrams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BisMt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ztpmatdiagrams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classifications");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "deliveries");

            migrationBuilder.DropTable(
                name: "delnbgens");

            migrationBuilder.DropTable(
                name: "lblnbgens");

            migrationBuilder.DropTable(
                name: "openorders");

            migrationBuilder.DropTable(
                name: "prodmovements");

            migrationBuilder.DropTable(
                name: "routing");

            migrationBuilder.DropTable(
                name: "saplocmarket");

            migrationBuilder.DropTable(
                name: "settings");

            migrationBuilder.DropTable(
                name: "stockmovements");

            migrationBuilder.DropTable(
                name: "stockwms");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "zp36prodorders");

            migrationBuilder.DropTable(
                name: "ztpmatdiagrams");
        }
    }
}
