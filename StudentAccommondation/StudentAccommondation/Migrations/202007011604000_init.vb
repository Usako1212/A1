Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class init
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Rooms",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String(nullable := False, maxLength := 16),
                        .Number = c.String(nullable := False, maxLength := 10),
                        .BuildingNo = c.String(maxLength := 8),
                        .FloorNo = c.String(maxLength := 8),
                        .Capacity = c.Short(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Students",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Number = c.String(nullable := False, maxLength := 10),
                        .Name = c.String(nullable := False, maxLength := 16),
                        .Major = c.String(maxLength := 20),
                        .AdmissionDate = c.DateTime(nullable := False),
                        .Birthday = c.DateTime(nullable := False),
                        .CreateTime = c.DateTime(nullable := False),
                        .Room_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Rooms", Function(t) t.Room_Id) _
                .Index(Function(t) t.Room_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Students", "Room_Id", "dbo.Rooms")
            DropIndex("dbo.Students", New String() { "Room_Id" })
            DropTable("dbo.Students")
            DropTable("dbo.Rooms")
        End Sub
    End Class
End Namespace
