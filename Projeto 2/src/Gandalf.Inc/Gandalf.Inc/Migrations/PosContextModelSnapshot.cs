﻿// <auto-generated />
using System;
using Gandalf.Inc.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gandalf.Inc.Migrations
{
    [DbContext(typeof(PosContext))]
    partial class PosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Gandalf.Inc.Modelo.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cidade")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroIdentificacaoFiscal")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tblClientes");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataModificacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("EnderecoLoja")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tblLojas");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("fldIdPagamento");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LojaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TipoPagamentofldPaymentTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("TEXT");

                    b.Property<int?>("VendaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LojaId");

                    b.HasIndex("TipoPagamentofldPaymentTypeID");

                    b.HasIndex("VendaId");

                    b.ToTable("tblPagamentos");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.PontoDeVenda", b =>
                {
                    b.Property<int>("fldPosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("fldStoreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("fldStoreLocation")
                        .HasColumnType("TEXT");

                    b.HasKey("fldPosID");

                    b.HasIndex("fldStoreId");

                    b.ToTable("tbPos");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.TipoPagamento", b =>
                {
                    b.Property<int>("fldPaymentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("fldPaymentType")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("fldPaymentTypeID");

                    b.ToTable("tblPaymentType");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("fldId");

                    b.Property<string>("Cidade")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT")
                        .HasColumnName("Morada");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT")
                        .HasColumnName("fldNomeUsuario");

                    b.Property<int>("NumeroUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("fldNumeroUsuario");

                    b.Property<string>("Senha")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tblUsuarios");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataModificacao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LojaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NumeroFatura")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroPontoDeVenda")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Pago")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PontoDeVendafldPosID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LojaId");

                    b.HasIndex("PontoDeVendafldPosID");

                    b.HasIndex("UsuarioId");

                    b.ToTable("tblVendas");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.Pagamento", b =>
                {
                    b.HasOne("Gandalf.Inc.Modelo.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaId");

                    b.HasOne("Gandalf.Inc.Modelo.TipoPagamento", "TipoPagamento")
                        .WithMany()
                        .HasForeignKey("TipoPagamentofldPaymentTypeID");

                    b.HasOne("Gandalf.Inc.Modelo.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("VendaId");

                    b.Navigation("Loja");

                    b.Navigation("TipoPagamento");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.PontoDeVenda", b =>
                {
                    b.HasOne("Gandalf.Inc.Modelo.Loja", "fldStore")
                        .WithMany()
                        .HasForeignKey("fldStoreId");

                    b.Navigation("fldStore");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.Venda", b =>
                {
                    b.HasOne("Gandalf.Inc.Modelo.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Gandalf.Inc.Modelo.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaId");

                    b.HasOne("Gandalf.Inc.Modelo.PontoDeVenda", "PontoDeVenda")
                        .WithMany()
                        .HasForeignKey("PontoDeVendafldPosID");

                    b.HasOne("Gandalf.Inc.Modelo.Usuario", "Usuario")
                        .WithMany("Vendas")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Cliente");

                    b.Navigation("Loja");

                    b.Navigation("PontoDeVenda");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.Cliente", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Gandalf.Inc.Modelo.Usuario", b =>
                {
                    b.Navigation("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
