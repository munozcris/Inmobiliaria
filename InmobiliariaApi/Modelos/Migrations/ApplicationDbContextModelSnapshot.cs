﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelos.DataAccess.Context;

#nullable disable

namespace Modelos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Modelos.Models.ClienteData", b =>
                {
                    b.Property<int>("id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_cliente"), 1L, 1);

                    b.Property<string>("CorreoCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DireccionCliente")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TelefonoCliente")
                        .HasColumnType("int");

                    b.HasKey("id_cliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Modelos.Models.CondicionData", b =>
                {
                    b.Property<int>("id_condicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_condicion"), 1L, 1);

                    b.Property<string>("desc_condicion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_condicion");

                    b.ToTable("Condiciones");
                });

            modelBuilder.Entity("Modelos.Models.FormaPagoData", b =>
                {
                    b.Property<int>("id_forma_pago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_forma_pago"), 1L, 1);

                    b.Property<string>("desc_forma_pago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_forma_pago");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Modelos.Models.InmuebleData", b =>
                {
                    b.Property<int>("id_inmueble")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_inmueble"), 1L, 1);

                    b.Property<int>("Tipo_Inmuebleid_tipo_inmueble")
                        .HasColumnType("int");

                    b.Property<decimal>("costo_inmueble")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("desc_inmueble")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ubic_inmueble")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_inmueble");

                    b.HasIndex("Tipo_Inmuebleid_tipo_inmueble");

                    b.ToTable("Inmuebles");
                });

            modelBuilder.Entity("Modelos.Models.TipoInmuebleData", b =>
                {
                    b.Property<int>("id_tipo_inmueble")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_tipo_inmueble"), 1L, 1);

                    b.Property<string>("Desc_tipo_inmueble")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_tipo_inmueble");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("Modelos.Models.VentaData", b =>
                {
                    b.Property<int>("id_venta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_venta"), 1L, 1);

                    b.Property<int>("ClienteDataid_cliente")
                        .HasColumnType("int");

                    b.Property<int>("CondicionDataid_condicion")
                        .HasColumnType("int");

                    b.Property<string>("DescVenta")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<int>("Forma_PagoDataid_forma_pago")
                        .HasColumnType("int");

                    b.Property<int>("InmuebleDataid_inmueble")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalVenta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total_general")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total_iva")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id_venta");

                    b.HasIndex("ClienteDataid_cliente");

                    b.HasIndex("CondicionDataid_condicion");

                    b.HasIndex("Forma_PagoDataid_forma_pago");

                    b.HasIndex("InmuebleDataid_inmueble");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Modelos.Models.InmuebleData", b =>
                {
                    b.HasOne("Modelos.Models.TipoInmuebleData", "Tipo_Inmueble")
                        .WithMany("Inmuebles")
                        .HasForeignKey("Tipo_Inmuebleid_tipo_inmueble")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_Inmueble");
                });

            modelBuilder.Entity("Modelos.Models.VentaData", b =>
                {
                    b.HasOne("Modelos.Models.ClienteData", "ClienteData")
                        .WithMany()
                        .HasForeignKey("ClienteDataid_cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelos.Models.CondicionData", "CondicionData")
                        .WithMany("Ventas")
                        .HasForeignKey("CondicionDataid_condicion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelos.Models.FormaPagoData", "Forma_PagoData")
                        .WithMany("Ventas")
                        .HasForeignKey("Forma_PagoDataid_forma_pago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelos.Models.InmuebleData", "InmuebleData")
                        .WithMany()
                        .HasForeignKey("InmuebleDataid_inmueble")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteData");

                    b.Navigation("CondicionData");

                    b.Navigation("Forma_PagoData");

                    b.Navigation("InmuebleData");
                });

            modelBuilder.Entity("Modelos.Models.CondicionData", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Modelos.Models.FormaPagoData", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Modelos.Models.TipoInmuebleData", b =>
                {
                    b.Navigation("Inmuebles");
                });
#pragma warning restore 612, 618
        }
    }
}
