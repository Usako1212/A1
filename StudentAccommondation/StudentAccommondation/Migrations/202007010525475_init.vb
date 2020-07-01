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
                        .Name = c.String(),
                        .Number = c.String(),
                        .BuildingNo = c.String(),
                        .FloorNo = c.String(),
                        .Capacity = c.Short(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Students",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Number = c.String(),
                        .Name = c.String(),
                        .Major = c.String(),
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
