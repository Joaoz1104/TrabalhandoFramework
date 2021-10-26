using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhandoFramework.Model;

namespace TrabalhandoFramework.ConfigDB
{
    class MyEventosDBContext: DbContext
    {
        DbSet<Evento> Eventos { get; set; }
        DbSet<Status> Statuses { get; set; }
    }
}
