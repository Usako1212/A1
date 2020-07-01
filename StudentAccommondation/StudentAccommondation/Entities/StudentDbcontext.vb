Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class StudentDbcontext
    Inherits DbContext

    '您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
    '使用“StudentDbcontext”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
    '“StudentAccommondation.StudentDbcontext”数据库。
    ' 
    '如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“StudentDbcontext”
    '连接字符串。
    Public Sub New()
        MyBase.New("name=StudentDbcontext")
    End Sub

    '为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
    '的详细信息，请参阅 http:'go.microsoft.com/fwlink/?LinkId=390109。

    Public Overridable Property Rooms As DbSet(Of Room)
    Public Overridable Property Students As DbSet(Of Student)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.Properties() _
                    .Where(Function(p) p.Name = "Id") _
                    .Configure(Function(p) p.IsKey().HasDatabaseGeneratedOption(ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity))
        modelBuilder.Properties().Where(Function(p) p.Name = "Name") _
            .Configure(Function(p) p.HasMaxLength(16).IsUnicode().IsRequired())
        modelBuilder.Properties().Where(Function(p) p.Name = "Number") _
            .Configure(Function(p) p.HasMaxLength(10).IsUnicode().IsRequired())
        modelBuilder.Entity(Of Room).Property(Function(p) p.BuildingNo).HasMaxLength(8)
        modelBuilder.Entity(Of Room).Property(Function(p) p.FloorNo).HasMaxLength(8)

        modelBuilder.Entity(Of Student).Property(Function(p) p.Major).HasMaxLength(20)

    End Sub

End Class

