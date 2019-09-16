namespace Telephone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePersonToIndividual : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Individuals");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Individuals", newName: "People");
        }
    }
}
