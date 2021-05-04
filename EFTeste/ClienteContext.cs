using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EFTeste
{
    class ClienteContext : DbContext
    {   
        public ClienteContext() : base("ClienteVendedor")
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
