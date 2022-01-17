using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using GuideTouristiqueApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MovieApp.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant d'autres propriétés à votre classe ApplicationUser. Pour en savoir plus, consultez https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Notez qu'authenticationType doit correspondre à l'élément défini dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Ajouter les revendications personnalisées de l’utilisateur ici
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Membershiptype> membershiptypes { get; set; }
        public DbSet<SiteTouristique> sites { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Restaurant> restaurants { get; set; }
        public DbSet<Transport> transports { get; set; }
        public DbSet<Activite> activites { get; set; }
        public DbSet<Internaute> personnes { get; set; }
        public DbSet<Bus> buses { get; set; }
        public DbSet<Offre> offres { get; set; }
        public DbSet<Chambre> chambres { get; set; }
        public DbSet<Localisation> localisations { get; set; }
        public DbSet<ServiceTouristique> services { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}