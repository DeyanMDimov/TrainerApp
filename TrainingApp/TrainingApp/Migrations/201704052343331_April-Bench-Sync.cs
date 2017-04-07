namespace TrainingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AprilBenchSync : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entries", "Supplement_ID", "dbo.Supplements");
            DropIndex("dbo.Entries", new[] { "Supplement_ID" });
            RenameColumn(table: "dbo.Entries", name: "Supplement_ID", newName: "SupplementID");
            AddColumn("dbo.Entries", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Entries", "SupplementID", c => c.Int(nullable: false));
            CreateIndex("dbo.Entries", "SupplementID");
            AddForeignKey("dbo.Entries", "SupplementID", "dbo.Supplements", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "SupplementID", "dbo.Supplements");
            DropIndex("dbo.Entries", new[] { "SupplementID" });
            AlterColumn("dbo.Entries", "SupplementID", c => c.Int());
            DropColumn("dbo.Entries", "UserId");
            RenameColumn(table: "dbo.Entries", name: "SupplementID", newName: "Supplement_ID");
            CreateIndex("dbo.Entries", "Supplement_ID");
            AddForeignKey("dbo.Entries", "Supplement_ID", "dbo.Supplements", "ID");
        }
    }
}
