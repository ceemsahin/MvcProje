namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addmessage_class : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "MessageTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "MessageTime");
        }
    }
}
