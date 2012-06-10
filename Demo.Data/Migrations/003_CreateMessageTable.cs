using System;
using FluentMigrator;

namespace Demo.Data.Migrations
{
    [Migration(20120610180755)]
    public class CreateMessageTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Message")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("Version").AsInt32().NotNullable()
                .WithColumn("FromUserId").AsGuid().NotNullable().ForeignKey("FK_Message_User", "User", "Id");
        }
    }
}
