namespace TrainingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForFirstModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.People", new[] { "User_Id" });
            AddColumn("dbo.Entries", "Person_Id", c => c.Int());
            AlterColumn("dbo.People", "Username", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "Sex", c => c.String(maxLength: 1));
            AlterColumn("dbo.People", "User_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Stacks", "StackName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Stacks", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.Supplements", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Entries", "SupplementID");
            CreateIndex("dbo.Entries", "Person_Id");
            CreateIndex("dbo.People", "User_Id");
            AddForeignKey("dbo.Entries", "Person_Id", "dbo.People", "Id");
            AddForeignKey("dbo.Entries", "SupplementID", "dbo.Supplements", "ID", cascadeDelete: true);
            AddForeignKey("dbo.People", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Entries", "SupplementID", "dbo.Supplements");
            DropForeignKey("dbo.Entries", "Person_Id", "dbo.People");
            DropIndex("dbo.People", new[] { "User_Id" });
            DropIndex("dbo.Entries", new[] { "Person_Id" });
            DropIndex("dbo.Entries", new[] { "SupplementID" });
            AlterColumn("dbo.Supplements", "Name", c => c.String());
            AlterColumn("dbo.Stacks", "UserID", c => c.String());
            AlterColumn("dbo.Stacks", "StackName", c => c.String());
            AlterColumn("dbo.People", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.People", "Sex", c => c.String());
            AlterColumn("dbo.People", "Username", c => c.String());
            DropColumn("dbo.Entries", "Person_Id");
            CreateIndex("dbo.People", "User_Id");
            AddForeignKey("dbo.People", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
