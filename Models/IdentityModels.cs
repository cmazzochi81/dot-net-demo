using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TheCorridorGroupMd.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, 
    //please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

        //
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }//class ApplicationUser

    //ApplicationDbContext inherits from IdentityDbContext which inherits from DbContext. 
    //DbContext, will serve as the object layer, you will use to communicate with the database. 
    //By inheriting from IdentityDbContext, it will already give you properties, like, Users, 
    //and Roles, and you can use those to work directly with the user data, in your database. 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            //The string "DefaultConnection", that is passed to the base class constructor, 
            //refers to a connection string in Web.config, that will be used to connect to the database. 
            //Or to create the database, if it doesn't already exist. In the Web.config file, under <connectionStrings>, 
            //you will see a reference to an instance of of SQLServer localDb -- "name='DefaultConnection'", "connectionString='Data Source=LocalDb)'"--
            //The DataDirectory token, between the pipes, represents the App_Data folder of your project, where it will create a database file, 
            //using the file name that comes after the pipes.  And when you eventually do a deployment to a live server, 
            //it will be easy to change these settings, to use the full version of SQLServer, and you can even maintain
            //separate settings, for development and production.  You get this "out of the box", but what you'd like to add
            //to your ApplicationDbContext class is a member, that exposes the checking account data (encapsulation).  
            //You do that by adding a public property, that is a generic DbSet of the PotentialClients object class called 'PotentialClients'.  
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }//End Create() method. 

        //Adding a member that exposes the PotentialClient data(encapsulation).  
        //Accomplished by adding a public property, that is a generic DbSet 
        //of the PotentialClients object class called 'PotentialClients'.  
        //This is going to allow us to work direclty with a checking account table, 
        //This will allow you to work direclty with a PotentialClients table. 
        public DbSet<PotentialClients>PotentialClients { get; set; }

    }//End class ApplicationDbContext

}//End namespace TheCorridorGroupMd.Models