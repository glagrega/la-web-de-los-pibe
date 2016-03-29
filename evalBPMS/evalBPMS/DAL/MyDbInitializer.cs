
using evalBPMS.Models;
using System;
using System.Data.Entity;

namespace evalBPMS.DAL
{
    public class MyDbInitializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            base.Seed(context);
        }
    }
}