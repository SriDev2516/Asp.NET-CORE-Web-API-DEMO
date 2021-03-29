using Microsoft.EntityFrameworkCore;
using Parky.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parky.API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }

        public DbSet<NationalPark> NationalParks { get; set; }
    }
}
