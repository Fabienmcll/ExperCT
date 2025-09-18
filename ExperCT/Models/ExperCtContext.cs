using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExperCT.Models;

public partial class ExperCtContext : DbContext
{
    public ExperCtContext()
    {
    }

    public ExperCtContext(DbContextOptions<ExperCtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CarteGrise> CarteGrises { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ContrôleTechnique> ContrôleTechniques { get; set; }

    public virtual DbSet<Criticite> Criticites { get; set; }

    public virtual DbSet<Defaillance> Defaillances { get; set; }

    public virtual DbSet<PointControle> PointControles { get; set; }

    public virtual DbSet<Technicien> Techniciens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("SERVER=2a03:5840:111:1024:508f:fc67:4795:f4d3; User ID=sa;Password=erty64%;Database=ExperCT; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarteGrise>(entity =>
        {
            entity.HasKey(e => e.IdCarteGrise).HasName("PK__CarteGri__4DBAD6926DE6FC6C");

            entity.ToTable("CarteGrise");

            entity.HasIndex(e => e.CodeVin, "UQ__CarteGri__9C0140D3695A4049").IsUnique();

            entity.HasIndex(e => e.NumeroImmatriculation, "UQ__CarteGri__F551C8FDA0007139").IsUnique();

            entity.Property(e => e.IdCarteGrise)
                .ValueGeneratedNever()
                .HasColumnName("idCarteGrise");
            entity.Property(e => e.CodeVin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codeVin");
            entity.Property(e => e.DateMiseCirculation).HasColumnName("dateMiseCirculation");
            entity.Property(e => e.IdClient).HasColumnName("idClient");
            entity.Property(e => e.Marque)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marque");
            entity.Property(e => e.Modele)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modele");
            entity.Property(e => e.Motorisation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("motorisation");
            entity.Property(e => e.NumeroImmatriculation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numeroImmatriculation");
            entity.Property(e => e.Puissance).HasColumnName("puissance");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.CarteGrises)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarteGris__idCli__2B3F6F97");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClient).HasName("PK__Client__A6A610D43196FD0A");

            entity.ToTable("Client");

            entity.HasIndex(e => e.Mail, "UQ__Client__7A212904753CD7CA").IsUnique();

            entity.Property(e => e.IdClient).HasColumnName("idClient");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Mdp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mdp");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");
        });

        modelBuilder.Entity<ContrôleTechnique>(entity =>
        {
            entity.HasKey(e => e.IdControleTechnique).HasName("PK__Contrôle__753CE0F29E115C7D");

            entity.ToTable("ContrôleTechnique");

            entity.HasIndex(e => e.NumReference, "UQ__Contrôle__7E796537B515AC36").IsUnique();

            entity.Property(e => e.IdControleTechnique).HasColumnName("idControleTechnique");
            entity.Property(e => e.DatePassage).HasColumnName("datePassage");
            entity.Property(e => e.IdCarteGrise).HasColumnName("idCarteGrise");
            entity.Property(e => e.IdTechnicien).HasColumnName("idTechnicien");
            entity.Property(e => e.NumReference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numReference");

            entity.HasOne(d => d.IdCarteGriseNavigation).WithMany(p => p.ContrôleTechniques)
                .HasForeignKey(d => d.IdCarteGrise)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContrôleT__idCar__3A81B327");

            entity.HasOne(d => d.IdDefaillanceNavigation).WithMany(p => p.ContrôleTechniques)
                .HasForeignKey(d => d.IdDefaillance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContrôleT__IdDef__398D8EEE");

            entity.HasOne(d => d.IdTechnicienNavigation).WithMany(p => p.ContrôleTechniques)
                .HasForeignKey(d => d.IdTechnicien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContrôleT__idTec__3B75D760");
        });

        modelBuilder.Entity<Criticite>(entity =>
        {
            entity.HasKey(e => e.IdCriticite).HasName("PK__Criticit__722529B99EBFF953");

            entity.ToTable("Criticite");

            entity.HasIndex(e => e.Nom, "UQ__Criticit__DF90DC2CBED82B8B").IsUnique();

            entity.Property(e => e.IdCriticite).HasColumnName("idCriticite");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Defaillance>(entity =>
        {
            entity.HasKey(e => e.IdDefaillance).HasName("PK__Defailla__4AA0D61CE4C4A8BE");

            entity.ToTable("Defaillance");

            entity.HasIndex(e => e.Nom, "UQ__Defailla__DF90DC2C3FA9FA42").IsUnique();

            entity.Property(e => e.IdCriticite).HasColumnName("idCriticite");
            entity.Property(e => e.IdPointControle).HasColumnName("idPointControle");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");

            entity.HasOne(d => d.IdCriticiteNavigation).WithMany(p => p.Defaillances)
                .HasForeignKey(d => d.IdCriticite)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Defaillan__idCri__35BCFE0A");

            entity.HasOne(d => d.IdPointControleNavigation).WithMany(p => p.Defaillances)
                .HasForeignKey(d => d.IdPointControle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Defaillan__idPoi__34C8D9D1");
        });

        modelBuilder.Entity<PointControle>(entity =>
        {
            entity.HasKey(e => e.IdPointControle).HasName("PK__PointCon__F40D9E54FB37DC0B");

            entity.ToTable("PointControle");

            entity.HasIndex(e => e.Nom, "UQ__PointCon__DF90DC2C4147C9FD").IsUnique();

            entity.Property(e => e.IdPointControle).HasColumnName("idPointControle");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Technicien>(entity =>
        {
            entity.HasKey(e => e.IdTechnicien).HasName("PK__Technici__EDBE613FF19CDEAA");

            entity.ToTable("Technicien");

            entity.Property(e => e.IdTechnicien).HasColumnName("idTechnicien");
            entity.Property(e => e.Mdp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mdp");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
