using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhaleDemo01.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AracDetay_Arac_AracID",
                table: "AracDetay");

            migrationBuilder.DropIndex(
                name: "IX_AracDetay_AracID",
                table: "AracDetay");

            migrationBuilder.DropColumn(
                name: "AracID",
                table: "AracDetay");

            migrationBuilder.DropColumn(
                name: "AracMarka",
                table: "AracDetay");

            migrationBuilder.DropColumn(
                name: "AracModel",
                table: "AracDetay");

            migrationBuilder.DropColumn(
                name: "GovdeTipi",
                table: "AracDetay");

            migrationBuilder.DropColumn(
                name: "Renk",
                table: "AracDetay");

            migrationBuilder.DropColumn(
                name: "Versiyon",
                table: "AracDetay");

            migrationBuilder.DropColumn(
                name: "Yil",
                table: "AracDetay");

            migrationBuilder.RenameColumn(
                name: "YakitTipi",
                table: "AracDetay",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "VitesTipi",
                table: "AracDetay",
                newName: "GrupAdi");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaAdi",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaBilgisi",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GovdeTipi",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MarkaId",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RenkId",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Versiyon",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VitesTipi",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YakitTipi",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YilId",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "FirmaAdi",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "FirmaBilgisi",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "GovdeTipi",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "MarkaId",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "RenkId",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "Versiyon",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "VitesTipi",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "YakitTipi",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "YilId",
                table: "Arac");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "AracDetay",
                newName: "YakitTipi");

            migrationBuilder.RenameColumn(
                name: "GrupAdi",
                table: "AracDetay",
                newName: "VitesTipi");

            migrationBuilder.AddColumn<int>(
                name: "AracID",
                table: "AracDetay",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracMarka",
                table: "AracDetay",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracModel",
                table: "AracDetay",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GovdeTipi",
                table: "AracDetay",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Renk",
                table: "AracDetay",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Versiyon",
                table: "AracDetay",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Yil",
                table: "AracDetay",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_AracDetay_AracID",
                table: "AracDetay",
                column: "AracID");

            migrationBuilder.AddForeignKey(
                name: "FK_AracDetay_Arac_AracID",
                table: "AracDetay",
                column: "AracID",
                principalTable: "Arac",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
