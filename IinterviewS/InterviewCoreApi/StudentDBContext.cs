using InterviewCoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewCoreApi
{
    public class StudentDbContext : DbContext
    {
        StudentDbContext()
        {

        }
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Post> Post { get; set; }

    }
}
