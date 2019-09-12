namespace Telephone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonAndSetadClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Boolean(nullable: false),
                        TelDirect = c.String(),
                        TelInternal = c.String(),
                        Mobile = c.String(),
                        WorkPlace = c.String(),
                        FieldOfActivity = c.String(),
                        SetadId = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Setads", t => t.SetadId)
                .Index(t => t.SetadId);
            
            CreateTable(
                "dbo.Setads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "SetadId", "dbo.Setads");
            DropIndex("dbo.People", new[] { "SetadId" });
            DropTable("dbo.Setads");
            DropTable("dbo.People");
        }
    }
}
