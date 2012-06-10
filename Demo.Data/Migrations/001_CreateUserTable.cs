using FluentMigrator;

namespace Demo.Data.Migrations
{
    [Migration(20120610175418)]
    public class CreateUserTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("User")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("Version").AsInt32().NotNullable();
        }
    }
}
