Imports System
Imports System.Linq
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Public Class StudentDb
    Inherits DbContext

    Public Sub New()
        MyBase.New()
    End Sub
    Public Overridable Property Rooms() As DbSet(Of Room)
    Public Overridable Property Students() As DbSet(Of Student)

    Protected Overrides Sub OnConfiguring(ByVal options As DbContextOptionsBuilder)
        If Not options.IsConfigured Then
            Dim config = Configuration.ConfigurationManager.ConnectionStrings("StudentDb")
            Dim connStr As String = "data source=(LocalDb)\MSSQLLocalDB;initial catalog=StudentAccommondation;integrated security=True"
            If Not IsNothing(config) Then
                connStr = config.ConnectionString
            End If
            options.UseSqlServer(connStr)
        End If
    End Sub

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)

        modelBuilder.Entity(Sub(entity As EntityTypeBuilder(Of Room))
                                entity.HasKey(Function(e) e.Id)
                                entity.[Property](Function(e) e.Id).ValueGeneratedOnAdd()
                                entity.[Property](Function(e) e.Number).IsRequired().IsUnicode().HasMaxLength(10)
                                entity.[Property](Function(e) e.Name).IsRequired().IsUnicode().HasMaxLength(16)
                                entity.[Property](Function(e) e.BuildingNo).IsUnicode().HasMaxLength(8)
                                entity.[Property](Function(e) e.FloorNo).IsUnicode().HasMaxLength(8)
                                entity.[Property](Function(e) e.Capacity).HasDefaultValue(4)
                            End Sub)

        modelBuilder.Entity(Sub(Entity As EntityTypeBuilder(Of Student))
                                Entity.HasKey(Function(e) e.Id)
                                Entity.[Property](Function(e) e.Id).ValueGeneratedOnAdd()
                                Entity.[Property](Function(e) e.Number).IsRequired().IsUnicode().HasMaxLength(10)
                                Entity.[Property](Function(e) e.Name).IsRequired().IsUnicode().HasMaxLength(16)
                                Entity.[Property](Function(e) e.Major).IsUnicode().HasMaxLength(20)
                                'Entity.[Property](Function(e) e.AdmissionDate).IsRequired()
                                'Entity.[Property](Function(e) e.Birthday).IsRequired()
                                Entity.[Property](Function(e) e.CreateTime).IsRequired().HasDefaultValueSql("getdate()")
                                Entity.HasOne(Function(d) d.Room).WithMany(Function(r) r.Students)
                            End Sub)
    End Sub


End Class
