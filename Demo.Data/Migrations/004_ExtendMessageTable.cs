using FluentMigrator;

namespace Demo.Data.Migrations
{
    [Migration(20120629154244)]
    public class ExtendMessageTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Column("Text").OnTable("Message").AsString(int.MaxValue).NotNullable();
        }
    }
}