using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RiftMacroTranslator.Models
{
    public class Translation1DB
    {
        public int Id { get; set; }
        public string en { get; set; }
        public string fr { get; set; }
        public string de { get; set; }
    }

    public class Translation1DBContext : DbContext
    {
        public DbSet<Translation1DB> Translations { get; set; }
    }
}