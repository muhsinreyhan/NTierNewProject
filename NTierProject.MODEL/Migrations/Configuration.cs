namespace NTierProject.MODEL.Migrations
{
    using Bogus.DataSets;
    using NTierProject.MODEL.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NTierProject.MODEL.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NTierProject.MODEL.Context.ProjectContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                AppUser user = new AppUser();
                user.UserName = new Internet("tr").UserName();
                user.Password = new Internet("tr").Password();
                user.Name = new Name("tr").FirstName();
                user.SurName = new Name("tr").LastName();
                user.EMail = new Internet("tr").Email();
                user.Address = new Address("tr").StreetAddress();
                user.PhoneNumber = new PhoneNumbers("tr").PhoneNumber();

                context.Users.Add(user);
            }
        }
    }
}
