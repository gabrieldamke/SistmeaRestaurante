﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(RestauranteDbContext))]
    partial class RestauranteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Domain.Entities.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GarcomId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GarcomId1")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("HoraAbertura")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HoraFechamento")
                        .HasColumnType("TEXT");

                    b.Property<int>("MesaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MesaId1")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GarcomId");

                    b.HasIndex("GarcomId1");

                    b.HasIndex("MesaId");

                    b.HasIndex("MesaId1");

                    b.ToTable("Atendimentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GarcomId = 1,
                            HoraAbertura = new DateTime(2023, 5, 7, 16, 5, 35, 618, DateTimeKind.Local).AddTicks(2983),
                            HoraFechamento = new DateTime(2023, 5, 7, 17, 5, 35, 618, DateTimeKind.Local).AddTicks(2998),
                            MesaId = 1
                        },
                        new
                        {
                            Id = 2,
                            GarcomId = 2,
                            HoraAbertura = new DateTime(2023, 5, 7, 16, 5, 35, 618, DateTimeKind.Local).AddTicks(3006),
                            HoraFechamento = new DateTime(2023, 5, 7, 17, 5, 35, 618, DateTimeKind.Local).AddTicks(3007),
                            MesaId = 2
                        },
                        new
                        {
                            Id = 3,
                            GarcomId = 3,
                            HoraAbertura = new DateTime(2023, 5, 7, 16, 5, 35, 618, DateTimeKind.Local).AddTicks(3008),
                            HoraFechamento = new DateTime(2023, 5, 7, 17, 5, 35, 618, DateTimeKind.Local).AddTicks(3009),
                            MesaId = 3
                        },
                        new
                        {
                            Id = 4,
                            GarcomId = 4,
                            HoraAbertura = new DateTime(2023, 5, 7, 16, 5, 35, 618, DateTimeKind.Local).AddTicks(3010),
                            HoraFechamento = new DateTime(2023, 5, 7, 17, 5, 35, 618, DateTimeKind.Local).AddTicks(3011),
                            MesaId = 4
                        },
                        new
                        {
                            Id = 5,
                            GarcomId = 5,
                            HoraAbertura = new DateTime(2023, 5, 7, 16, 5, 35, 618, DateTimeKind.Local).AddTicks(3012),
                            HoraFechamento = new DateTime(2023, 5, 7, 17, 5, 35, 618, DateTimeKind.Local).AddTicks(3013),
                            MesaId = 5
                        });
                });

            modelBuilder.Entity("Domain.Entities.AtendimentoProduto", b =>
                {
                    b.Property<int>("AtendimentoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("AtendimentoId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("AtendimentoProdutos");

                    b.HasData(
                        new
                        {
                            AtendimentoId = 1,
                            ProdutoId = 1,
                            Id = 1,
                            Preco = 24.9m,
                            Quantidade = 1
                        },
                        new
                        {
                            AtendimentoId = 1,
                            ProdutoId = 2,
                            Id = 2,
                            Preco = 39.9m,
                            Quantidade = 2
                        },
                        new
                        {
                            AtendimentoId = 1,
                            ProdutoId = 3,
                            Id = 3,
                            Preco = 40m,
                            Quantidade = 1
                        },
                        new
                        {
                            AtendimentoId = 1,
                            ProdutoId = 4,
                            Id = 4,
                            Preco = 9.9m,
                            Quantidade = 3
                        },
                        new
                        {
                            AtendimentoId = 1,
                            ProdutoId = 5,
                            Id = 5,
                            Preco = 14.9m,
                            Quantidade = 5
                        },
                        new
                        {
                            AtendimentoId = 2,
                            ProdutoId = 1,
                            Id = 6,
                            Preco = 25.9m,
                            Quantidade = 3
                        },
                        new
                        {
                            AtendimentoId = 2,
                            ProdutoId = 2,
                            Id = 7,
                            Preco = 37.5m,
                            Quantidade = 4
                        },
                        new
                        {
                            AtendimentoId = 2,
                            ProdutoId = 3,
                            Id = 8,
                            Preco = 39.9m,
                            Quantidade = 3
                        },
                        new
                        {
                            AtendimentoId = 2,
                            ProdutoId = 4,
                            Id = 9,
                            Preco = 17.9m,
                            Quantidade = 2
                        },
                        new
                        {
                            AtendimentoId = 2,
                            ProdutoId = 5,
                            Id = 10,
                            Preco = 15.9m,
                            Quantidade = 5
                        },
                        new
                        {
                            AtendimentoId = 2,
                            ProdutoId = 6,
                            Id = 11,
                            Preco = 69.9m,
                            Quantidade = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Opções de entrada para abrir o apetite",
                            Nome = "Entradas"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Pratos principais com carnes, peixes e vegetarianos",
                            Nome = "Pratos Principais"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Acompanhamentos para os pratos principais",
                            Nome = "Acompanhamentos"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Sobremesas deliciosas para fechar a refeição",
                            Nome = "Sobremesas"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Diversas opções de bebidas para acompanhar a refeição",
                            Nome = "Bebidas"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Garcom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroTelefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Garcons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "André",
                            NumeroTelefone = "45999999991",
                            Sobrenome = "Soares"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Fernanda",
                            NumeroTelefone = "45999999992",
                            Sobrenome = "Silva"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Henrique",
                            NumeroTelefone = "45999999993",
                            Sobrenome = "Souza"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Juliano",
                            NumeroTelefone = "45999999994",
                            Sobrenome = "Santos"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Sabrina",
                            NumeroTelefone = "45999999995",
                            Sobrenome = "Moreira"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("HoraAbertura")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Mesas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Numero = 1,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Numero = 2,
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            Numero = 3,
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            Numero = 4,
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            Numero = 5,
                            Status = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Descricao = "Carpaccio de carne com rúcula, parmesão e molho de mostarda",
                            Nome = "Carpaccio de Carne",
                            Preco = 25.90m
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 2,
                            Descricao = "Risoto com cogumelos frescos, parmesão e azeite trufado",
                            Nome = "Risoto de Funghi",
                            Preco = 39.90m
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 2,
                            Descricao = "Arroz com pato, linguiça, ervilhas e azeitonas",
                            Nome = "Arroz de Pato",
                            Preco = 44.90m
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 3,
                            Descricao = "Purê de batatas com alho e cebolinha",
                            Nome = "Purê de Batatas",
                            Preco = 9.90m
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 4,
                            Descricao = "Mousse de chocolate com chantilly e raspas de chocolate",
                            Nome = "Mousse de Chocolate",
                            Preco = 15.90m
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 5,
                            Descricao = "Vinho tinto chileno de uva cabernet sauvignon",
                            Nome = "Vinho Tinto Chileno",
                            Preco = 69.90m
                        });
                });

            modelBuilder.Entity("Domain.Entities.Atendimento", b =>
                {
                    b.HasOne("Domain.Entities.Garcom", "Garcom")
                        .WithMany()
                        .HasForeignKey("GarcomId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Garcom", null)
                        .WithMany("Atendimentos")
                        .HasForeignKey("GarcomId1");

                    b.HasOne("Domain.Entities.Mesa", "Mesa")
                        .WithMany()
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Mesa", null)
                        .WithMany("Atendimentos")
                        .HasForeignKey("MesaId1");

                    b.Navigation("Garcom");

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("Domain.Entities.AtendimentoProduto", b =>
                {
                    b.HasOne("Domain.Entities.Atendimento", "Atendimento")
                        .WithMany()
                        .HasForeignKey("AtendimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atendimento");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Domain.Entities.Produto", b =>
                {
                    b.HasOne("Domain.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Domain.Entities.Garcom", b =>
                {
                    b.Navigation("Atendimentos");
                });

            modelBuilder.Entity("Domain.Entities.Mesa", b =>
                {
                    b.Navigation("Atendimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
