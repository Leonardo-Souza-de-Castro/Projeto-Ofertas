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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=NOTE0113F4\\SQLEXPRESS; Initial Catalog=OFERTA; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__D5946642001F8577");

                entity.ToTable("Cliente");

                entity.HasIndex(e => e.Cpf, "UQ__Cliente__C1F8973137592112")
                    .IsUnique();

                entity.HasIndex(e => e.Nis, "UQ__Cliente__C7DEC3C3051A62A9")
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
                    .HasName("PK__Endereco__0B7C7F1710296920");

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
                    .HasName("PK__Finalida__36B7CDF7B7308889");

                entity.ToTable("Finalidade");

                entity.HasIndex(e => e.Finalidade1, "UQ__Finalida__F396FAF8B061606C")
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
                    .HasName("PK__Institui__B771C0D846218CB4");

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
                    .HasName("PK__Produto__2E883C2374E790BE");

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
                    .HasName("PK__Reserva__0E49C69D881F695F");

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
                    .HasName("PK__Situacao__CBAF8D4E11F7B86D");

                entity.ToTable("SituacaoReserva");

                entity.HasIndex(e => e.SituacaoReserva1, "UQ__Situacao__96DD23535AF42EF4")
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
                    .HasName("PK__TipoProd__F71CDF6149CC196E");

                entity.ToTable("TipoProduto");

                entity.HasIndex(e => e.TipoProduto1, "UQ__TipoProd__46330B6561EADA12")
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
                    .HasName("PK__TipoUsua__CA04062B4BA3E1A6");

                entity.ToTable("TipoUsuario");

                entity.HasIndex(e => e.TipoUsuario1, "UQ__TipoUsua__52F7E3AAE1110924")
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
                    .HasName("PK__Usuario__5B65BF97123A70BE");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Email, "UQ__Usuario__A9D105342E030D4A")
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
