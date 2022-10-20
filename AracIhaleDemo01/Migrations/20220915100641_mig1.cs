using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhaleDemo01.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AracStatu",
                columns: table => new
                {
                    AracStatuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracStatuAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracStatu", x => x.AracStatuID);
                });

            migrationBuilder.CreateTable(
                name: "EkspertizStatu",
                columns: table => new
                {
                    EkspertizStatuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EkspertizStatuAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkspertizStatu", x => x.EkspertizStatuID);
                });

            migrationBuilder.CreateTable(
                name: "IhaleStatu",
                columns: table => new
                {
                    IhaleStatuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IhaleStatuAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IhaleStatu", x => x.IhaleStatuID);
                });

            migrationBuilder.CreateTable(
                name: "Ilan",
                columns: table => new
                {
                    IlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilan", x => x.IlanID);
                });

            migrationBuilder.CreateTable(
                name: "KayitTip",
                columns: table => new
                {
                    KayitTipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KayitTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KayitTip", x => x.KayitTipID);
                });

            migrationBuilder.CreateTable(
                name: "Paket",
                columns: table => new
                {
                    PaketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaketAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paket", x => x.PaketID);
                });

            migrationBuilder.CreateTable(
                name: "Rols",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rols", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "TramerCesit",
                columns: table => new
                {
                    TramerCesitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramerCesiti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramerCesit", x => x.TramerCesitID);
                });

            migrationBuilder.CreateTable(
                name: "Yetki",
                columns: table => new
                {
                    YetkiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetki", x => x.YetkiID);
                });

            migrationBuilder.CreateTable(
                name: "EkspertizSurec",
                columns: table => new
                {
                    EkspertizSurecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EkspertizStatuID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkspertizSurec", x => x.EkspertizSurecID);
                    table.ForeignKey(
                        name: "FK_EkspertizSurec_EkspertizStatu_EkspertizStatuID",
                        column: x => x.EkspertizStatuID,
                        principalTable: "EkspertizStatu",
                        principalColumn: "EkspertizStatuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arac",
                columns: table => new
                {
                    AracID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KayitTipID = table.Column<int>(type: "int", nullable: false),
                    SirketAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracStatuID = table.Column<int>(type: "int", nullable: false),
                    AracFiyat = table.Column<int>(type: "int", nullable: false),
                    KMBilgisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Donanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arac", x => x.AracID);
                    table.ForeignKey(
                        name: "FK_Arac_AracStatu_AracStatuID",
                        column: x => x.AracStatuID,
                        principalTable: "AracStatu",
                        principalColumn: "AracStatuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arac_KayitTip_KayitTipID",
                        column: x => x.KayitTipID,
                        principalTable: "KayitTip",
                        principalColumn: "KayitTipID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ihale",
                columns: table => new
                {
                    IhaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IhaleAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTipID = table.Column<int>(type: "int", nullable: false),
                    SirketAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IhaleStatuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ihale", x => x.IhaleID);
                    table.ForeignKey(
                        name: "FK_Ihale_IhaleStatu_IhaleStatuID",
                        column: x => x.IhaleStatuID,
                        principalTable: "IhaleStatu",
                        principalColumn: "IhaleStatuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ihale_KayitTip_KayitTipID",
                        column: x => x.KayitTipID,
                        principalTable: "KayitTip",
                        principalColumn: "KayitTipID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanici_Rols_RolID",
                        column: x => x.RolID,
                        principalTable: "Rols",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tramer",
                columns: table => new
                {
                    TramerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramerTutari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TramerCesitID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tramer", x => x.TramerID);
                    table.ForeignKey(
                        name: "FK_Tramer_TramerCesit_TramerCesitID",
                        column: x => x.TramerCesitID,
                        principalTable: "TramerCesit",
                        principalColumn: "TramerCesitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolYetkiIliski",
                columns: table => new
                {
                    RolYetkiIliskiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolID = table.Column<int>(type: "int", nullable: false),
                    YetkiID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolYetkiIliski", x => x.RolYetkiIliskiID);
                    table.ForeignKey(
                        name: "FK_RolYetkiIliski_Rols_RolID",
                        column: x => x.RolID,
                        principalTable: "Rols",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolYetkiIliski_Yetki_YetkiID",
                        column: x => x.YetkiID,
                        principalTable: "Yetki",
                        principalColumn: "YetkiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AracDetay",
                columns: table => new
                {
                    AracDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracMarka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovdeTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YakitTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitesTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Versiyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracID = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracDetay", x => x.AracDetayID);
                    table.ForeignKey(
                        name: "FK_AracDetay_Arac_AracID",
                        column: x => x.AracID,
                        principalTable: "Arac",
                        principalColumn: "AracID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IhaleFiyat",
                columns: table => new
                {
                    IhaleFiyatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracID = table.Column<int>(type: "int", nullable: false),
                    IhaleBaslangicFiyat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumAlımFiyat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IhaleFiyat", x => x.IhaleFiyatID);
                    table.ForeignKey(
                        name: "FK_IhaleFiyat_Arac_AracID",
                        column: x => x.AracID,
                        principalTable: "Arac",
                        principalColumn: "AracID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arac_AracStatuID",
                table: "Arac",
                column: "AracStatuID");

            migrationBuilder.CreateIndex(
                name: "IX_Arac_KayitTipID",
                table: "Arac",
                column: "KayitTipID");

            migrationBuilder.CreateIndex(
                name: "IX_AracDetay_AracID",
                table: "AracDetay",
                column: "AracID");

            migrationBuilder.CreateIndex(
                name: "IX_EkspertizSurec_EkspertizStatuID",
                table: "EkspertizSurec",
                column: "EkspertizStatuID");

            migrationBuilder.CreateIndex(
                name: "IX_Ihale_IhaleStatuID",
                table: "Ihale",
                column: "IhaleStatuID");

            migrationBuilder.CreateIndex(
                name: "IX_Ihale_KayitTipID",
                table: "Ihale",
                column: "KayitTipID");

            migrationBuilder.CreateIndex(
                name: "IX_IhaleFiyat_AracID",
                table: "IhaleFiyat",
                column: "AracID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_RolID",
                table: "Kullanici",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_RolYetkiIliski_RolID",
                table: "RolYetkiIliski",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_RolYetkiIliski_YetkiID",
                table: "RolYetkiIliski",
                column: "YetkiID");

            migrationBuilder.CreateIndex(
                name: "IX_Tramer_TramerCesitID",
                table: "Tramer",
                column: "TramerCesitID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AracDetay");

            migrationBuilder.DropTable(
                name: "EkspertizSurec");

            migrationBuilder.DropTable(
                name: "Ihale");

            migrationBuilder.DropTable(
                name: "IhaleFiyat");

            migrationBuilder.DropTable(
                name: "Ilan");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Paket");

            migrationBuilder.DropTable(
                name: "RolYetkiIliski");

            migrationBuilder.DropTable(
                name: "Tramer");

            migrationBuilder.DropTable(
                name: "EkspertizStatu");

            migrationBuilder.DropTable(
                name: "IhaleStatu");

            migrationBuilder.DropTable(
                name: "Arac");

            migrationBuilder.DropTable(
                name: "Rols");

            migrationBuilder.DropTable(
                name: "Yetki");

            migrationBuilder.DropTable(
                name: "TramerCesit");

            migrationBuilder.DropTable(
                name: "AracStatu");

            migrationBuilder.DropTable(
                name: "KayitTip");
        }
    }
}
