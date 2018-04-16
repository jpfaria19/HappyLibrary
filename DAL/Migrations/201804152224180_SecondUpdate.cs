namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Isbn", c => c.String(nullable: false, maxLength: 17));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Isbn", c => c.String(nullable: false, maxLength: 13));
        }
    }
}
