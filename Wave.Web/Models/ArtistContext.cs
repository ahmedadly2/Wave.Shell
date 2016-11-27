using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Wave.Web.Models
{
    public class ArtistsContext : DbContext
    {
        public virtual DbSet<Artist> Artists { get; set; }
    }
}