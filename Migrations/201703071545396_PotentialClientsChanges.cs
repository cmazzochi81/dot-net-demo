namespace TheCorridorGroupMd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PotentialClientsChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PotentialClients", "FirstName", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PotentialClients", "FirstName", c => c.String(nullable: false));
        }
    }
}
