using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOp.Models
{
    public class dbAkijFoodContext:DbContext
    {
        public dbAkijFoodContext(DbContextOptions<dbAkijFoodContext> options) : base(options)
        {

        }
        public DbSet<ColdDrink> ColdDrinks { get; set; }
    }
}
