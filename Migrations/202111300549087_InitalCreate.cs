namespace FixtureProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fixtures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SerialNo = c.String(nullable: false, maxLength: 128, unicode: false),
                        FixtureName = c.String(unicode: false),
                        UseCount = c.Int(),
                        CycleCount = c.Int(),
                        CeilingCount = c.Int(),
                        InvestmentDate = c.DateTime(),
                        ExpirationDate = c.DateTime(),
                        UserId = c.String(unicode: false),
                        UserName = c.String(unicode: false),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Id, t.SerialNo });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fixtures");
        }
    }
}
