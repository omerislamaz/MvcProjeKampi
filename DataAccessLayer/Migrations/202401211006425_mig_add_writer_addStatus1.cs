namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_writer_addStatus1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Writers", "WritingStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WritingStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Writers", "WriterStatus");
        }
    }
}
