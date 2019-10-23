using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

// This Class allows this to connect with the database
namespace COMP229_Assignment_01_F2019_300613283.Models
{
    public class ApplicationDBContext : DbContext
    {
        // Constructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        // Dataset of Recipes, get the recipes from database.
        public DbSet<Recipe> Recipes { get; set; }
    }
}
