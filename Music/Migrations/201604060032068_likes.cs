namespace Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class likes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Likes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Likes");
        }
    }
}
