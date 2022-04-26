using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bcp.Data.Migrations
{
    public partial class RemovedunnecessarycolumnsfromstockWmstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BinStatus",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "CarBrand",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "GlassPos",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "GlassTyp",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "LabelStatus",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "LotNr",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "PackNr",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "RackTotWgt",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "ReasonCodeLong",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "RtNetWeight",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "RtWeightUnit",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "StatusBDate",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "StatusQDate",
                table: "stockwms");

            migrationBuilder.DropColumn(
                name: "ZoneDsc",
                table: "stockwms");

            migrationBuilder.AlterColumn<string>(
                name: "RackType",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RackId",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "stockwms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Plant",
                table: "stockwms",
                type: "varchar(5)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bin",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RackType",
                table: "stockmovements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RackId",
                table: "stockmovements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "stockmovements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Plant",
                table: "stockmovements",
                type: "varchar(5)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Delivery",
                table: "stockmovements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContentStatus",
                table: "stockmovements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RackType",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RackId",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "stockwms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Plant",
                table: "stockwms",
                type: "varchar(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5)");

            migrationBuilder.AlterColumn<string>(
                name: "Bin",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "BinStatus",
                table: "stockwms",
                type: "varchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarBrand",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GlassPos",
                table: "stockwms",
                type: "varchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GlassTyp",
                table: "stockwms",
                type: "varchar(5)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelStatus",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LotNr",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackNr",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RackTotWgt",
                table: "stockwms",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReasonCodeLong",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RtNetWeight",
                table: "stockwms",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RtWeightUnit",
                table: "stockwms",
                type: "varchar(5)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusBDate",
                table: "stockwms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusQDate",
                table: "stockwms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZoneDsc",
                table: "stockwms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RackType",
                table: "stockmovements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RackId",
                table: "stockmovements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "stockmovements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Plant",
                table: "stockmovements",
                type: "varchar(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5)");

            migrationBuilder.AlterColumn<string>(
                name: "Delivery",
                table: "stockmovements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContentStatus",
                table: "stockmovements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
