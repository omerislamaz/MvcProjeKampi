﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_writer_addStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WritingStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WritingStatus");
        }
    }
}
