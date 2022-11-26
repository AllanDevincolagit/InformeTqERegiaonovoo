﻿// <auto-generated />
using System;
using InformeTqERegiao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InformeTqERegiao.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221126001545_farmacias")]
    partial class farmacias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InformeTqERegiao.Entidades.Camamesabanho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("redessociais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("whatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CAMAMESABANHO");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Cidades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CIDADES");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Construcaoutensilios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("redessociais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("whatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CONSTRUCAOUTENSILIOS");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Farmacias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("redessociais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("whatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FARMACIAS");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Permissoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PERMISSOES");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Problema", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paginaemquestao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("problema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PROBLEMA");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Roupas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("redessociais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("whatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ROUPAS");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Supermercados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("redessociais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("whatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SUPERMERCADOS");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Usuarios_Permissoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissaoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("permissoesId")
                        .HasColumnType("int");

                    b.Property<int?>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("permissoesId");

                    b.HasIndex("usuariosId");

                    b.ToTable("USUARIOS_PERMISSOES");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Variedades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("redessociais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("whatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VARIEDADES");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.estabelecimento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ESTABELECIMENTO");
                });

            modelBuilder.Entity("InformeTqERegiao.Entidades.Usuarios_Permissoes", b =>
                {
                    b.HasOne("InformeTqERegiao.Entidades.Permissoes", "permissoes")
                        .WithMany()
                        .HasForeignKey("permissoesId");

                    b.HasOne("InformeTqERegiao.Entidades.Usuarios", "usuarios")
                        .WithMany()
                        .HasForeignKey("usuariosId");

                    b.Navigation("permissoes");

                    b.Navigation("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
