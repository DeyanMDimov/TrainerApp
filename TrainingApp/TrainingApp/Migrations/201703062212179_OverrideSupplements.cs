namespace TrainingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideSupplements : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Supplements", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Supplements", "MethodOfAdmin", c => c.String(maxLength: 10));
            AlterColumn("dbo.Supplements", "MeasuringUnit", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Supplements", "MeasuringUnit", c => c.String());
            AlterColumn("dbo.Supplements", "MethodOfAdmin", c => c.String());
            AlterColumn("dbo.Supplements", "Name", c => c.String(nullable: false));
        }
    }
}
