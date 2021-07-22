namespace NagpurUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "FName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "MName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "LName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "LName", c => c.String());
            AlterColumn("dbo.Student", "MName", c => c.String());
            AlterColumn("dbo.Student", "FName", c => c.String());
        }
    }
}
