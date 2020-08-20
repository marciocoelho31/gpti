﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gpti.Context;

namespace gpti.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200820022249_CriacaoInicialBanco")]
    partial class CriacaoInicialBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("gpti.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContExt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ContInt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Hora")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Local")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Minutos")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("Resolvido_Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Resolvido_Hora")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TelCont")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TempoDesloc")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("gpti.Models.Cab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DadosContato")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Empresa")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Cab");
                });

            modelBuilder.Entity("gpti.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Autorizado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BancoCobr")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CGC")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Cep")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Cobranca")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CodMem")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Contato")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("CorrecaoDiariaAtraso")
                        .HasColumnType("double");

                    b.Property<string>("Corresp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CritMensalid")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("Custo")
                        .HasColumnType("double");

                    b.Property<DateTime?>("DataTravaSistema")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataUltBkp")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("DescFat")
                        .HasColumnType("double");

                    b.Property<int?>("DiaSemanaBkp")
                        .HasColumnType("int");

                    b.Property<int?>("DiasARenovar")
                        .HasColumnType("int");

                    b.Property<double?>("Dolar")
                        .HasColumnType("double");

                    b.Property<DateTime?>("DtAudVal")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DtEmiBol")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DtInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DtRescisao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DtUltAcesso")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("E_mail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("E_mail2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("E_mail3")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FormaPg")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Homepage")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HoraUltBkp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HrEmiBol")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("IniContrat")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("IniManut")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Inscricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Login")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LoginEmiBol")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mensagem")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mensagem_No_Site")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MesAtraso")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("MostraAnuncios")
                        .HasColumnType("int");

                    b.Property<double?>("Multa")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomeEmissorBol")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NumBoleto")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Obs")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Opcao_NO")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("Parcelas")
                        .HasColumnType("double");

                    b.Property<string>("PastaClient")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PastaServer")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("PercDesconto")
                        .HasColumnType("double");

                    b.Property<double>("PercSalAdMaq")
                        .HasColumnType("double");

                    b.Property<double?>("PercSobreSalario")
                        .HasColumnType("double");

                    b.Property<int?>("QtMaq")
                        .HasColumnType("int");

                    b.Property<int?>("QtMaqDesktop")
                        .HasColumnType("int");

                    b.Property<int?>("QtMaqMovel")
                        .HasColumnType("int");

                    b.Property<int?>("QtMaquinasReg")
                        .HasColumnType("int");

                    b.Property<int?>("QtUsuariosMob")
                        .HasColumnType("int");

                    b.Property<string>("Razao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("Receita")
                        .HasColumnType("double");

                    b.Property<string>("Salario")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("Senha_A")
                        .HasColumnType("int");

                    b.Property<string>("Sistema")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("Tempo")
                        .HasColumnType("double");

                    b.Property<double?>("UltBol")
                        .HasColumnType("double");

                    b.Property<double>("ValMensMob")
                        .HasColumnType("double");

                    b.Property<double>("ValMensSiteOnl")
                        .HasColumnType("double");

                    b.Property<double?>("ValPar")
                        .HasColumnType("double");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.Property<double>("ValorAnterior")
                        .HasColumnType("double");

                    b.Property<double?>("ValorTotal")
                        .HasColumnType("double");

                    b.Property<DateTime?>("Vencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("VendaAlugu")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Versao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("mysql_ip")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("mysql_nomebd")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("mysql_pwd")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("mysql_user")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("gpti.Models.Pendencias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cliente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ComentInt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("DataPos")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataSolic")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DescricaoOrig")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("DtLanc")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FormaSolic")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HoraPos")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Minutos")
                        .HasColumnType("int");

                    b.Property<string>("NaWeb")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("NovoItem")
                        .HasColumnType("int");

                    b.Property<string>("Posicao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("Previsao")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Prior")
                        .HasColumnType("int");

                    b.Property<string>("Prog")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Projeto")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("QtdDias")
                        .HasColumnType("int");

                    b.Property<string>("QuemSolic")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sistema")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Urgente")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Pendencias");
                });

            modelBuilder.Entity("gpti.Models.RCP", b =>
                {
                    b.Property<double>("Id")
                        .HasColumnType("double");

                    b.Property<string>("ContExt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ContInt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Ct")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Hora")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Local")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Origem")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Posicao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TelCont")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("RCP");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
