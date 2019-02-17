using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebApplication2.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication2.Startup))]
namespace WebApplication2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            InitializeRoles();
        }

        private void InitializeRoles()
        {
            using (var context = new ApplicationDbContext())
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!roleManager.RoleExists("Admin"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Admin"
                    };

                    roleManager.Create(role);
                }

                if (!roleManager.RoleExists("Enquiry"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Enquiry"
                    };

                    roleManager.Create(role);
                }

                if (!roleManager.RoleExists("Funds Transfer"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Funds Transfer"
                    };

                    roleManager.Create(role);
                }

                if (!roleManager.RoleExists("Deposit"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Deposit"
                    };

                    roleManager.Create(role);
                }

                if (!roleManager.RoleExists("Loans"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Loans"
                    };

                    roleManager.Create(role);
                }

                if (!roleManager.RoleExists("Grievance"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Grievance"
                    };

                    roleManager.Create(role);
                }

                if (!roleManager.RoleExists("New Account"))
                {
                    var role = new IdentityRole
                    {
                        Name = "New Account"
                    };

                    roleManager.Create(role);
                }
            }
        }
    }
}
