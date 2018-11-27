using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTycoon.DataContext
{
    public class GladiatorTycoonDataContext : DbContext
    {
        public GladiatorTycoonDataContext() : base("databaseConnectionString")
        {

        }


    }
}
