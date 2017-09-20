namespace CodeFirstDemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentNameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(maxLength: 250));
        }
    }
}
