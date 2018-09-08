namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes set Name = 'Free' where id = 1");
            Sql("UPDATE MembershipTypes set Name = 'Monthly' where id = 2");
            Sql("UPDATE MembershipTypes set Name = 'Tri-Monthly' where id = 3");
            Sql("UPDATE MembershipTypes set Name = 'Anual' where id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
