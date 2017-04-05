namespace TrainingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstModels1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        EntryID = c.Int(nullable: false, identity: true),
                        EntryDate = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        dateAdded = c.DateTime(nullable: false),
                        SupplementID = c.Int(nullable: false),
                        SupplementName = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(),
                        TimeIngested = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EntryID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Sex = c.String(),
                        Weight = c.Int(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Stacks",
                c => new
                    {
                        StackID = c.Int(nullable: false, identity: true),
                        StackName = c.String(),
                        UserID = c.String(),
                        dateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StackID);
            
            CreateTable(
                "dbo.Supplements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MethodOfAdmin = c.String(),
                        Dose = c.Int(nullable: false),
                        MeasuringUnit = c.String(),
                        dateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.People", new[] { "User_Id" });
            DropTable("dbo.Supplements");
            DropTable("dbo.Stacks");
            DropTable("dbo.People");
            DropTable("dbo.Entries");
        }
    }
}
