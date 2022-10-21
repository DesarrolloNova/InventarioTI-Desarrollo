using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using InventarioTI.Models;

#nullable disable

namespace InventarioTI.Context
{
    public partial class InventarioContext : DbContext
    {
        public InventarioContext()
        {
        }

        public InventarioContext(DbContextOptions<InventarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatDepartamento> CatDepartamentos { get; set; }
        public virtual DbSet<CatPlanta> CatPlanta { get; set; }
        public virtual DbSet<CatPuesto> CatPuestos { get; set; }
        public virtual DbSet<CatRelojChecador> CatRelojChecadors { get; set; }
        public virtual DbSet<FailedJob> FailedJobs { get; set; }
        public virtual DbSet<InvCatEstatusEquipo> InvCatEstatusEquipos { get; set; }
        public virtual DbSet<InvCatRol> InvCatRols { get; set; }
        public virtual DbSet<InvCatSo> InvCatSos { get; set; }
        public virtual DbSet<InvCatTipoEquipo> InvCatTipoEquipos { get; set; }
        public DbSet<InvHisAccionEquipo> InvHisAccionEquipos { get; set; }
        public virtual DbSet<InvHisAsignacionEquipo> InvHisAsignacionEquipos { get; set; }
        public virtual DbSet<InvHisDesarrolloInstalado> InvHisDesarrolloInstalados { get; set; }
        public virtual DbSet<InvHisGrupoUsuario> InvHisGrupoUsuarios { get; set; }
        public virtual DbSet<InvHisPlantillaInstalacion> InvHisPlantillaInstalacions { get; set; }
        public virtual DbSet<InvHisPlantillaMantenimiento> InvHisPlantillaMantenimientos { get; set; }
        public virtual DbSet<InvHisSoporte> InvHisSoportes { get; set; }
        public virtual DbSet<InvRelRolSistema> InvRelRolSistemas { get; set; }
        public virtual DbSet<InvRelUsuarioRol> InvRelUsuarioRols { get; set; }
        public virtual DbSet<InvTabEquipo> InvTabEquipos { get; set; }
        public virtual DbSet<Migration> Migrations { get; set; }
        public virtual DbSet<PasswordReset> PasswordResets { get; set; }
        public virtual DbSet<RelLoginSistemaUsuario> RelLoginSistemaUsuarios { get; set; }
        public virtual DbSet<TabCorreo> TabCorreos { get; set; }
        public virtual DbSet<TabUsuario> TabUsuarios { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<InvCatTipoConexion> InvCatTiposConexion { get; set; }
        public virtual DbSet<UsuarioAsignacion> UsuarioAsignacion { get; set; }
        public virtual DbSet<Licencias> Licencias { get; set; }
        public virtual DbSet<UsuarioLicencias> UsuarioLicencias { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=nova1razure.cloudapp.net;Database=NovDBTest;User=sa2;Password=4aznov-54");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<CatDepartamento>(entity =>
            {
                entity.ToTable("CatDepartamento");

                entity.Property(e => e.Abreviacion)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CatPlanta>(entity =>
            {

            });

            modelBuilder.Entity<CatPuesto>(entity =>
            {
                entity.ToTable("CatPuesto");

                entity.Property(e => e.Puesto).HasMaxLength(100);
            });

            modelBuilder.Entity<CatRelojChecador>(entity =>
            {
                entity.ToTable("CatRelojChecador");

                entity.Property(e => e.Dispositivo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Serial).HasMaxLength(50);
            });

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Connection)
                    .IsRequired()
                    .HasColumnName("connection");

                entity.Property(e => e.Exception)
                    .IsRequired()
                    .HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnName("payload");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnName("queue");
            });

            modelBuilder.Entity<InvCatEstatusEquipo>(entity =>
            {
                entity.ToTable("InvCatEstatusEquipo");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvCatRol>(entity =>
            {
                entity.ToTable("InvCatRol");

                entity.Property(e => e.Rol).HasMaxLength(50);
            });

            modelBuilder.Entity<InvCatSo>(entity =>
            {
                entity.ToTable("InvCatSO");

                entity.Property(e => e.SistemaOperativo).HasMaxLength(100);
            });

            modelBuilder.Entity<InvCatTipoEquipo>(entity =>
            {
                entity.ToTable("InvCatTipoEquipo");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50);
            });


            modelBuilder.Entity<InvHisAsignacionEquipo>(entity =>
            {
                entity.ToTable("InvHisAsignacionEquipo");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.TipoConexion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.InvHisAsignacionEquipos)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvHisAsignacionEquipo_InvTabEquipo");
            });

            modelBuilder.Entity<InvHisDesarrolloInstalado>(entity =>
            {
                entity.ToTable("InvHisDesarrolloInstalado");

                entity.HasOne(d => d.IdAsignacionNavigation)
                    .WithMany(p => p.InvHisDesarrolloInstalados)
                    .HasForeignKey(d => d.IdAsignacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvHisDesarrolloInstalado_InvHisPosesionEquipo");
            });

            modelBuilder.Entity<InvHisGrupoUsuario>(entity =>
            {
                entity.HasOne(d => d.IdAsignacionNavigation)
                    .WithMany(p => p.InvHisGrupoUsuarios)
                    .HasForeignKey(d => d.IdAsignacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvHisGrupoUsuarios_InvHisPosesionEquipo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.InvHisGrupoUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvHisGrupoUsuarios_TabUsuario");
            });

            //modelBuilder.Entity<InvHisPlantillaInstalacion>(entity =>
            //{
            //    entity.ToTable("InvHisPlantillaInstalacion");

            //    entity.Property(e => e.Antivirus)
            //        .IsRequired()
            //        .HasMaxLength(100);

            //    entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

            //    entity.Property(e => e.Observaciones).HasMaxLength(250);

            //    entity.Property(e => e.PaqueteriaOffice)
            //        .IsRequired()
            //        .HasMaxLength(100);

            //    //entity.HasOne(d => d.IdAccionEquipoNavigation)
            //    //    .WithMany(p => p.InvHisPlantillaInstalacions)
            //    //    .HasForeignKey(d => d.IdAccionEquipo)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_InvHisPlantillaInstalacion_InvHisAccionEquipo");
            //});

            modelBuilder.Entity<InvHisPlantillaMantenimiento>(entity =>
            {
                entity.ToTable("InvHisPlantillaMantenimiento");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                //entity.HasOne(d => d.IdAccionEquipoNavigation)
                //    .WithMany(p => p.InvHisPlantillaMantenimientos)
                //    .HasForeignKey(d => d.IdAccionEquipo)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_InvHisPlantillaMantenimiento_InvHisAccionEquipo");
            });

            modelBuilder.Entity<InvHisSoporte>(entity =>
            {
                entity.ToTable("InvHisSoporte");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaResolucion).HasColumnType("datetime");

                entity.Property(e => e.JsonDatosMovil).HasMaxLength(500);

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                entity.Property(e => e.Problema)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.InvHisSoportes)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvHisSoporte_InvTabEquipo");

                entity.HasOne(d => d.IdUsuarioEmisorNavigation)
                    .WithMany(p => p.InvHisSoporteIdUsuarioEmisorNavigations)
                    .HasForeignKey(d => d.IdUsuarioEmisor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvHisSoporte_TabUsuario");

                entity.HasOne(d => d.IdUsuarioResuelveNavigation)
                    .WithMany(p => p.InvHisSoporteIdUsuarioResuelveNavigations)
                    .HasForeignKey(d => d.IdUsuarioResuelve)
                    .HasConstraintName("FK_InvHisSoporte_TabUsuario1");
            });

            modelBuilder.Entity<InvRelRolSistema>(entity =>
            {
                entity.ToTable("InvRelRolSistema");

                entity.Property(e => e.Modulo).HasMaxLength(100);

                entity.Property(e => e.SubModulo).HasMaxLength(100);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.InvRelRolSistemas)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__InvRelRol__IdRol__1A9EF37A");
            });

            modelBuilder.Entity<InvRelUsuarioRol>(entity =>
            {
                entity.ToTable("InvRelUsuarioRol");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.InvRelUsuarioRols)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvRelUsuarioRol_InvCatRol");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.InvRelUsuarioRols)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvRelUsuarioRol_TabUsuario");
            });

            modelBuilder.Entity<InvTabEquipo>(entity =>
            {
                entity.ToTable("InvTabEquipo");

                entity.Property(e => e.DatosAdicionales).HasMaxLength(300);

                entity.Property(e => e.DireccionMac)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCompra).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFinGarantia).HasColumnType("date");

                entity.Property(e => e.FechaInicioGarantia).HasColumnType("date");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NoSerie)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NombreEquipo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Procesador)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UltimaActualizacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasIndex(e => e.Email, "password_resets_email_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<RelLoginSistemaUsuario>(entity =>
            {
                entity.ToTable("RelLoginSistemaUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.RelLoginSistemaUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RelLoginS__IdUsu__21B6055D");
            });

            modelBuilder.Entity<TabCorreo>(entity =>
            {
                entity.ToTable("TabCorreo");

                entity.Property(e => e.Aplicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasenia).HasColumnType("text");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smtp)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabUsuario>(entity =>
            {
                entity.ToTable("TabUsuario");

                entity.Property(e => e.ApellidoMaterno).HasMaxLength(100);

                entity.Property(e => e.ApellidoPaterno).HasMaxLength(100);

                entity.Property(e => e.Correo).HasMaxLength(100);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroExtension).HasMaxLength(10);

                entity.Property(e => e.NumeroTelefonico).HasMaxLength(14);

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.UsuarioWindows).HasMaxLength(100);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.TabUsuarios)
                    .HasForeignKey(d => d.IdDepartamento)
                    .HasConstraintName("FK__TabUsuari__Activ__173876EA");

                entity.HasOne(d => d.IdPlantaNavigation)
                    .WithMany(p => p.TabUsuarios)
                    .HasForeignKey(d => d.IDSitio)
                    .HasConstraintName("FK__TabUsuari__IdPla__182C9B23");

                entity.HasOne(d => d.IdPuestoNavigation)
                    .WithMany(p => p.TabUsuarios)
                    .HasForeignKey(d => d.IdPuesto)
                    .HasConstraintName("FK_TabUsuario_CatPuesto");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email, "users_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("email_verified_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(100)
                    .HasColumnName("remember_token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}