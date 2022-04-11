using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bcp.Data.Migrations
{
    public partial class altertableClassificationandProdMovementscolumnnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Work_Center",
                table: "prodmovements",
                newName: "WorkCenter");

            migrationBuilder.RenameColumn(
                name: "Qty_To_Prod",
                table: "prodmovements",
                newName: "QtyToProd");

            migrationBuilder.RenameColumn(
                name: "Net_Qty",
                table: "prodmovements",
                newName: "NetQty");

            migrationBuilder.RenameColumn(
                name: "Master_Camp",
                table: "prodmovements",
                newName: "MasterCamp");

            migrationBuilder.RenameColumn(
                name: "old mat.no",
                table: "classifications",
                newName: "OldMatNo");

            migrationBuilder.RenameColumn(
                name: "Roundingval.",
                table: "classifications",
                newName: "RoundingVal");

            migrationBuilder.RenameColumn(
                name: "Profl.",
                table: "classifications",
                newName: "Profl");

            migrationBuilder.RenameColumn(
                name: "Min.LotSze",
                table: "classifications",
                newName: "MinLotSze");

            migrationBuilder.RenameColumn(
                name: "Max.LotSize",
                table: "classifications",
                newName: "MaxLotSize");

            migrationBuilder.RenameColumn(
                name: "Fix.lotsize",
                table: "classifications",
                newName: "FixLotSize");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkCenter",
                table: "prodmovements",
                newName: "Work_Center");

            migrationBuilder.RenameColumn(
                name: "QtyToProd",
                table: "prodmovements",
                newName: "Qty_To_Prod");

            migrationBuilder.RenameColumn(
                name: "NetQty",
                table: "prodmovements",
                newName: "Net_Qty");

            migrationBuilder.RenameColumn(
                name: "MasterCamp",
                table: "prodmovements",
                newName: "Master_Camp");

            migrationBuilder.RenameColumn(
                name: "RoundingVal",
                table: "classifications",
                newName: "Roundingval.");

            migrationBuilder.RenameColumn(
                name: "Profl",
                table: "classifications",
                newName: "Profl.");

            migrationBuilder.RenameColumn(
                name: "OldMatNo",
                table: "classifications",
                newName: "old mat.no");

            migrationBuilder.RenameColumn(
                name: "MinLotSze",
                table: "classifications",
                newName: "Min.LotSze");

            migrationBuilder.RenameColumn(
                name: "MaxLotSize",
                table: "classifications",
                newName: "Max.LotSize");

            migrationBuilder.RenameColumn(
                name: "FixLotSize",
                table: "classifications",
                newName: "Fix.lotsize");
        }
    }
}
