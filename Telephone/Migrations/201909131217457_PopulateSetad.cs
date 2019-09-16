namespace Telephone.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateSetad : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Setads ( Name) VALUES (N'اداره عملیات فناوری')");
            Sql(@"INSERT INTO Setads ( Name) VALUES (N'اداره پشتیبانی')");
            Sql(@"INSERT INTO Setads ( Name) VALUES (N'فنی')");
            Sql(@"INSERT INTO Setads ( Name) VALUES (N'بازرسی')");
            Sql(@"INSERT INTO Setads ( Name) VALUES (N'ساختمان نگین')");

        }

        public override void Down()
        {
        }
    }
}
