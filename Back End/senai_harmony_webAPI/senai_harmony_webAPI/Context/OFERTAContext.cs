using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai_harmony_webAPI.Domains;

#nullable disable

namespace senai_harmony_webAPI.Context
{
    public partial class OFERTAContext : DbContext
    {
        public OFERTAContext()
        {
        }

        public OFERTAContext(DbContextOptions<OFERTAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Finalidade> Finalidades { get; set; }
        public virtual DbSet<Instituicao> Instituicaos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<SituacaoReserva> SituacaoReservas { get; set; }
        public virtual DbSet<TipoProduto> TipoProdutos { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-9F56DG6\\SQLEXPRESS; Initial Catalog=OFERTA; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__D594664217C8D145");

                entity.ToTable("Cliente");

                entity.HasIndex(e => e.Cpf, "UQ__Cliente__C1F89731133BA470")
                    .IsUnique();

                entity.HasIndex(e => e.Nis, "UQ__Cliente__C7DEC3C3D9733396")
                    .IsUnique();

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.Nis)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("NIS");

                entity.Property(e => e.NomeCliente)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Cliente__IdUsuar__32E0915F");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.IdEndereco)
                    .HasName("PK__Endereco__0B7C7F17AFEABCB2");

                entity.ToTable("Endereco");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Logadouro)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Enderecos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Endereco__IdUsua__2B3F6F97");
            });

            modelBuilder.Entity<Finalidade>(entity =>
            {
                entity.HasKey(e => e.IdFinalidade)
                    .HasName("PK__Finalida__36B7CDF7376300E4");

                entity.ToTable("Finalidade");

                entity.HasIndex(e => e.Finalidade1, "UQ__Finalida__F396FAF854775A23")
                    .IsUnique();

                entity.Property(e => e.Finalidade1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Finalidade");
            });

            modelBuilder.Entity<Instituicao>(entity =>
            {
                entity.HasKey(e => e.IdInstituicao)
                    .HasName("PK__Institui__B771C0D8AE44D2A1");

                entity.ToTable("Instituicao");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Instituicaos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Instituic__IdUsu__2E1BDC42");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PK__Produto__2E883C23602D2014");

                entity.ToTable("Produto");

                entity.Property(e => e.DataValidade).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Imagem)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.NomeProduto)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFinalidadeNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdFinalidade)
                    .HasConstraintName("FK__Produto__IdFinal__3D5E1FD2");

                entity.HasOne(d => d.IdTipoProdutoNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdTipoProduto)
                    .HasConstraintName("FK__Produto__IdTipoP__3C69FB99");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Produto__IdUsuar__3B75D760");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__Reserva__0E49C69DAF54784E");

                entity.ToTable("Reserva");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK__Reserva__IdProdu__44FF419A");

                entity.HasOne(d => d.IdSituacaoReservaNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdSituacaoReserva)
                    .HasConstraintName("FK__Reserva__IdSitua__440B1D61");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Reserva__IdUsuar__4316F928");
            });

            modelBuilder.Entity<SituacaoReserva>(entity =>
            {
                entity.HasKey(e => e.IdSituacaoReserva)
                    .HasName("PK__Situacao__CBAF8D4E9B9E97CF");

                entity.ToTable("SituacaoReserva");

                entity.HasIndex(e => e.SituacaoReserva1, "UQ__Situacao__96DD2353048F48AD")
                    .IsUnique();

                entity.Property(e => e.SituacaoReserva1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SituacaoReserva");
            });

            modelBuilder.Entity<TipoProduto>(entity =>
            {
                entity.HasKey(e => e.IdTipoProduto)
                    .HasName("PK__TipoProd__F71CDF61C215265D");

                entity.ToTable("TipoProduto");

                entity.HasIndex(e => e.TipoProduto1, "UQ__TipoProd__46330B65A589C518")
                    .IsUnique();

                entity.Property(e => e.TipoProduto1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TipoProduto");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__CA04062BE25FC224");

                entity.ToTable("TipoUsuario");

                entity.HasIndex(e => e.TipoUsuario1, "UQ__TipoUsua__52F7E3AA719A7EFE")
                    .IsUnique();

                entity.Property(e => e.TipoUsuario1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97AFEC8AF0");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Email, "UQ__Usuario__A9D10534009CBD62")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuario__IdTipoU__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
