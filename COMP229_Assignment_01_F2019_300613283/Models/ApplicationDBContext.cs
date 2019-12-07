using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace COMP229_Assignment_01_F2019_300613283.Models
{
    // This is the Database Class to be used by the Repository Class
    public class ApplicationDBContext : DbContext
    {
        // Constructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        // Dataset of Recipes, get the recipes from database.
        public DbSet<Recipe> Recipes { get; set; }
    }
}
