using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class UmbracoContext : DbContext
    {
        public UmbracoContext(DbContextOptions<UmbracoContext> options) : base(options) { }
        public DbSet<Submisssion> Submissions { get; set; }
    }
}
