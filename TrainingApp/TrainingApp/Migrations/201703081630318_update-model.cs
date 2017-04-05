namespace TrainingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Entries", "EntryDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entries", "EntryDate", c => c.DateTime(nullable: false));
        }
    }
}
