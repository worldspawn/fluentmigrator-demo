using FluentMigrator;

namespace Demo.Data.Migrations
{
    [Migration(20120629154502)]
    public class InsertSomeUsers : AutoReversingMigration
    {
        public override void Up()
        {
            base.Insert.IntoTable("User")
                .Row(new {Username = "sam.critchley", Password = "password", Email = "fauxemail@gmail.com"})
                .Row(new {Username = "demo.user", Password = "password", Email = "demo@gmail.com"});
        }
    }
}