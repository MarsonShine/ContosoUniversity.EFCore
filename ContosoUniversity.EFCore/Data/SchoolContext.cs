﻿using ContosoUniversity.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.EFCore.Data
{
    public class SchoolContext : DbContext
    {
        protected SchoolContext(DbContextOptions<SchoolContext> options):
            base(options)
        {
        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //生成数据表
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
