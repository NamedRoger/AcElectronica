﻿// <auto-generated />
using System;
using DatabasaeManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabasaeManager.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210407225904_add prov")]
    partial class addprov
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("AplicacionUsuario", b =>
                {
                    b.Property<int>("AplicacionesId")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("AplicacionesId", "UsuariosId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("AplicacionUsuario");
                });

            modelBuilder.Entity("DatabasaeManager.Entidades.Aplicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Aplicaciones");
                });

            modelBuilder.Entity("DatabasaeManager.Entidades.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApodoProveedor")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Banco")
                        .HasColumnType("text");

                    b.Property<string>("Banco2")
                        .HasColumnType("text");

                    b.Property<string>("Banco3")
                        .HasColumnType("text");

                    b.Property<string>("Celular")
                        .HasColumnType("text");

                    b.Property<string>("Ciudad")
                        .HasColumnType("text");

                    b.Property<string>("ClaveBancaria")
                        .HasColumnType("text");

                    b.Property<string>("ClaveBancaria2")
                        .HasColumnType("text");

                    b.Property<string>("ClaveBancaria3")
                        .HasColumnType("text");

                    b.Property<string>("Cp")
                        .HasColumnType("text");

                    b.Property<string>("CuentaBancaria")
                        .HasColumnType("text");

                    b.Property<string>("CuentaBancaria2")
                        .HasColumnType("text");

                    b.Property<string>("CuentaBancaria3")
                        .HasColumnType("text");

                    b.Property<string>("Domicilio")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime");

                    b.Property<string>("Notas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pais")
                        .HasColumnType("text");

                    b.Property<string>("Paqueteria")
                        .HasColumnType("text");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Representante")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RepresentanteCelular")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RepresentanteCiudad")
                        .HasColumnType("text");

                    b.Property<string>("RepresentanteDomicilio")
                        .HasColumnType("text");

                    b.Property<string>("RepresentanteEmail")
                        .HasColumnType("text");

                    b.Property<string>("RepresentanteEstado")
                        .HasColumnType("text");

                    b.Property<string>("RepresentantePais")
                        .HasColumnType("text");

                    b.Property<string>("RepresentanteTelefeono")
                        .HasColumnType("text");

                    b.Property<string>("RepresentatneCp")
                        .HasColumnType("text");

                    b.Property<string>("Rfc")
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UltimaCompra")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ApodoProveedor")
                        .IsUnique();

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("DatabasaeManager.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Activo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Celular")
                        .HasColumnType("text");

                    b.Property<string>("Curp")
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("Foto")
                        .HasColumnType("text");

                    b.Property<string>("Nss")
                        .HasColumnType("text");

                    b.Property<string>("NumeroInfonavit")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AplicacionUsuario", b =>
                {
                    b.HasOne("DatabasaeManager.Entidades.Aplicacion", null)
                        .WithMany()
                        .HasForeignKey("AplicacionesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabasaeManager.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}