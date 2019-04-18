namespace MigrationDZ_18._04._2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TimeOfJoin = c.DateTime(nullable: false),
                        TimeOfLeave = c.DateTime(nullable: false),
                        Name = c.String(),
                        IDCardNumber = c.String(),
                        PointOfVisit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visits");
        }
    }
}
