using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFTeste
{
    class VendedorContext : DbContext
    {
        public VendedorContext() : base("ClienteVendedor")
        {

        }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}
