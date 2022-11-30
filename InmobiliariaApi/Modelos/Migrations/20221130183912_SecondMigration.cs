using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelos.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condiciones",
                columns: table => new
                {
                    id_condicion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desc_condicion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condiciones", x => x.id_condicion);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    id_forma_pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desc_forma_pago = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.id_forma_pago);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    id_tipo_inmueble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_tipo_inmueble = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.id_tipo_inmueble);
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    id_inmueble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Inmuebleid_tipo_inmueble = table.Column<int>(type: "int", nullable: false),
                    desc_inmueble = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ubic_inmueble = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    costo_inmueble = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.id_inmueble);
                    table.ForeignKey(
                        name: "FK_Inmuebles_Tipos_Tipo_Inmuebleid_tipo_inmueble",
                        column: x => x.Tipo_Inmuebleid_tipo_inmueble,
                        principalTable: "Tipos",
                        principalColumn: "id_tipo_inmueble",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    id_venta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InmuebleDataid_inmueble = table.Column<int>(type: "int", nullable: false),
                    ClienteDataid_cliente = table.Column<int>(type: "int", nullable: false),
                    CondicionDataid_condicion = table.Column<int>(type: "int", nullable: false),
                    Forma_PagoDataid_forma_pago = table.Column<int>(type: "int", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescVenta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total_iva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total_general = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.id_venta);
                    table.ForeignKey(
                        name: "FK_Ventas_Cliente_ClienteDataid_cliente",
                        column: x => x.ClienteDataid_cliente,
                        principalTable: "Cliente",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Condiciones_CondicionDataid_condicion",
                        column: x => x.CondicionDataid_condicion,
                        principalTable: "Condiciones",
                        principalColumn: "id_condicion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Inmuebles_InmuebleDataid_inmueble",
                        column: x => x.InmuebleDataid_inmueble,
                        principalTable: "Inmuebles",
                        principalColumn: "id_inmueble",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Pagos_Forma_PagoDataid_forma_pago",
                        column: x => x.Forma_PagoDataid_forma_pago,
                        principalTable: "Pagos",
                        principalColumn: "id_forma_pago",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inmuebles_Tipo_Inmuebleid_tipo_inmueble",
                table: "Inmuebles",
                column: "Tipo_Inmuebleid_tipo_inmueble");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteDataid_cliente",
                table: "Ventas",
                column: "ClienteDataid_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_CondicionDataid_condicion",
                table: "Ventas",
                column: "CondicionDataid_condicion");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_Forma_PagoDataid_forma_pago",
                table: "Ventas",
                column: "Forma_PagoDataid_forma_pago");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_InmuebleDataid_inmueble",
                table: "Ventas",
                column: "InmuebleDataid_inmueble");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Condiciones");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Tipos");
        }
    }
}
