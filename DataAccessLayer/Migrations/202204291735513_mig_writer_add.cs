namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 50));
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Contents", "HeadingID", c => c.Int(nullable: false));
            AlterColumn("dbo.Contents", "WriterID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contents", "WriterID", c => c.Int());
            AlterColumn("dbo.Contents", "HeadingID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            DropColumn("dbo.Writers", "WriterTitle");
        }
    }
}
