using FluentMigrator;

namespace Demo.Data.Migrations
{
    [Migration(20120610175940)]
    public class AddFieldToUser : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Column("Username").OnTable("User").AsString(255).NotNullable().Unique();
            Create.Column("Password").OnTable("User").AsString(64).NotNullable();
            Create.Column("Email").OnTable("User").AsString(255).NotNullable().Unique();
        }
    }
}