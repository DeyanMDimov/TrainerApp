namespace TrainingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingdatamodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entries", "SupplementID", "dbo.Supplements");
            DropIndex("dbo.Entries", new[] { "SupplementID" });
            RenameColumn(table: "dbo.Entries", name: "SupplementID", newName: "Supplement_ID");
            AddColumn("dbo.Supplements", "Stack_StackID", c => c.Int());
            AlterColumn("dbo.Entries", "Supplement_ID", c => c.Int());
            CreateIndex("dbo.Entries", "Supplement_ID");
            CreateIndex("dbo.Supplements", "Stack_StackID");
            AddForeignKey("dbo.Supplements", "Stack_StackID", "dbo.Stacks", "StackID");
            AddForeignKey("dbo.Entries", "Supplement_ID", "dbo.Supplements", "ID");
            DropColumn("dbo.Entries", "SupplementName");
            DropColumn("dbo.Entries", "UserID");
            DropColumn("dbo.Entries", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entries", "UserName", c => c.String());
            AddColumn("dbo.Entries", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Entries", "SupplementName", c => c.Int(nullable: false));
            DropForeignKey("dbo.Entries", "Supplement_ID", "dbo.Supplements");
            DropForeignKey("dbo.Supplements", "Stack_StackID", "dbo.Stacks");
            DropIndex("dbo.Supplements", new[] { "Stack_StackID" });
            DropIndex("dbo.Entries", new[] { "Supplement_ID" });
            AlterColumn("dbo.Entries", "Supplement_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Supplements", "Stack_StackID");
            RenameColumn(table: "dbo.Entries", name: "Supplement_ID", newName: "SupplementID");
            CreateIndex("dbo.Entries", "SupplementID");
            AddForeignKey("dbo.Entries", "SupplementID", "dbo.Supplements", "ID", cascadeDelete: true);
        }
    }
}
