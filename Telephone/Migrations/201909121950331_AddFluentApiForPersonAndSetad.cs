namespace Telephone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFluentApiForPersonAndSetad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "TelDirect", c => c.String(maxLength: 11));
            AlterColumn("dbo.People", "TelInternal", c => c.String(maxLength: 4));
            AlterColumn("dbo.People", "Mobile", c => c.String(maxLength: 11, fixedLength: true));
            AlterColumn("dbo.Setads", "Name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Setads", "Name", c => c.String());
            AlterColumn("dbo.People", "Mobile", c => c.String());
            AlterColumn("dbo.People", "TelInternal", c => c.String());
            AlterColumn("dbo.People", "TelDirect", c => c.String());
            AlterColumn("dbo.People", "Name", c => c.String());
        }
    }
}
