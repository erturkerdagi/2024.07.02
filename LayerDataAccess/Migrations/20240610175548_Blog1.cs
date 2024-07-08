using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LayerDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Blog1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hakkinda",
                columns: table => new
                {
                    HakkindaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkindaDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkindaDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkinda", x => x.HakkindaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriAciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Mesaj",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesajKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajKullaniciEposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajIcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesaj", x => x.MesajID);
                });

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarAciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarResmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarEposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "Yazi",
                columns: table => new
                {
                    YaziID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KucukResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyukResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaziDurumu = table.Column<bool>(type: "bit", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazi", x => x.YaziID);
                    table.ForeignKey(
                        name: "FK_Yazi_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yazi_Yazar_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazar",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumBasligi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumIcerigi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumDurumu = table.Column<bool>(type: "bit", nullable: false),
                    YaziID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorum_Yazi_YaziID",
                        column: x => x.YaziID,
                        principalTable: "Yazi",
                        principalColumn: "YaziID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yazi_KategoriID",
                table: "Yazi",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Yazi_YazarID",
                table: "Yazi",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_YaziID",
                table: "Yorum",
                column: "YaziID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hakkinda");

            migrationBuilder.DropTable(
                name: "Mesaj");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "Yazi");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Yazar");
        }
    }
}
