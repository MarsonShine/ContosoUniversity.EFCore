using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;
using System.Text;

namespace MS.EntityFramework.GetStarted
{
    #region Demo1
    //public class MyContext : DbContext
    //{
    //    public DbSet<Blog> Blogs { get; set; }

    //    public DbSet<Car> Cars { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=DELL-PC;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        //Fluent API
    //        modelBuilder.Entity<AuditEntry>();
    //        //抽象类方式
    //        //modelBuilder.ApplyConfiguration(new MyContextConfiguation());

    //        //符合主键
    //        modelBuilder.Entity<Car>()
    //            .HasKey(c => new { c.LicensePlate, c.State });
    //        modelBuilder.Entity<Blog>()
    //            .Property(p => p.Timestamp)
    //            .IsRowVersion();

    //        //阴影属性
    //        modelBuilder.Entity<Blog>()
    //            .Property<DateTime>("LastUpdated");
    //    }

    //    public class MyContextConfiguation : IEntityTypeConfiguration<Blog>
    //    {
    //        public void Configure(EntityTypeBuilder<Blog> builder)
    //        {
    //            //builder
    //        }
    //    }
    //}


    //#region Including & Excluding Types

    //public class Blog
    //{
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int BlogId { get; set; }
    //    public string Url { get; set; }

    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public DateTime Inserted { get; set; }
    //    public byte[] Timestamp { get; set; }

    //    public List<Post> Posts { get; set; }
    //}

    //public class Post
    //{
    //    public int PostId { get; set; }
    //    public string Title { get; set; }
    //    public string Content { get; set; }

    //    public Blog Blog { get; set; }
    //}
    ////[NotMapped]
    //public class AuditEntry
    //{
    //    public int AuditEntryId { get; set; }
    //    public string Username { get; set; }
    //    public string Action { get; set; }
    //}
    //#endregion


    //#region Keys
    //public class Car
    //{
    //    public string State { get; set; }
    //    public string LicensePlate { get; set; }

    //    public string Make { get; set; }
    //    public string Model { get; set; }
    //}
    //#endregion 
    #endregion

    #region Demo2
    //public class MyContext : DbContext
    //{
    //    public DbSet<Blog> Blogs { get; set; }
    //    //public DbSet<Post> Posts { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=DELL-PC;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Blog>()
    //        .Property<DateTime>("LastUpdated");
    //    }
    //}

    //public class Blog
    //{
    //    public int BlogId { get; set; }
    //    public string Url { get; set; }

    //    //public List<Post> Posts { get; set; }
    //}

    //public class Post
    //{
    //    public int PostId { get; set; }
    //    public string Title { get; set; }
    //    public string Content { get; set; }

    //    public Blog Blog { get; set; }
    //}
    //public class AuditEntry
    //{
    //    public int AuditEntryId { get; set; }
    //    public string Username { get; set; }
    //    public string Action { get; set; }
    //}

    //public class Car
    //{
    //    public string State { get; set; }
    //    public string LicensePlate { get; set; }

    //    public string Make { get; set; }
    //    public string Model { get; set; }
    //} 
    #endregion


    #region Demo3
    //public class MyContext : DbContext
    //{
    //    public DbSet<Post> Blogs { get; set; }
    //    public DbSet<User> Posts { get; set; }
    //    public DbSet<Car> Cars { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=DELL-PC;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        //modelBuilder.Entity<Blog>()
    //        //.Property<DateTime>("LastUpdated");
    //        modelBuilder.Entity<RecordOfSale>()
    //            .HasOne(s => s.Car)
    //            .WithMany(p => p.SaleHistory)
    //            .HasForeignKey(s => new { s.CarState, s.CarLicensePlate })
    //            .HasPrincipalKey(p => new { p.State, p.LicensePlate });
    //    }
    //}
    //public class Post
    //{
    //    public int PostId { get; set; }
    //    public string Title { get; set; }
    //    public string Content { get; set; }

    //    //public int AuthorUserId { get; set; }
    //    public User Author { get; set; }

    //    //public int ContributorUserId { get; set; }
    //    public User Contributor { get; set; }
    //}

    //public class User
    //{
    //    public string UserId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    [InverseProperty("Author")]
    //    public List<Post> AuthoredPosts { get; set; }

    //    [InverseProperty("Contributor")]
    //    public List<Post> ContributedToPosts { get; set; }
    //}

    //public class Car
    //{
    //    public int CarId { get; set; }
    //    public string State { get; set; }
    //    public string LicensePlate { get; set; }
    //    public string Make { get; set; }
    //    public string Model { get; set; }

    //    public List<RecordOfSale> SaleHistory { get; set; }
    //}

    //public class RecordOfSale
    //{
    //    public int RecordOfSaleId { get; set; }
    //    public DateTime DateSold { get; set; }
    //    public decimal Price { get; set; }

    //    public string CarState { get; set; }
    //    public string CarLicensePlate { get; set; }
    //    public Car Car { get; set; }
    //} 
    #endregion

    #region Demo4
    //public class MyContext : DbContext
    //{
    //    public DbSet<Post> Posts { get; set; }
    //    public DbSet<Tag> Tags { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=DELL-PC;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<PostTag>()
    //            .HasKey(t => new { t.PostId, t.TagId });

    //        modelBuilder.Entity<PostTag>()
    //            .HasOne(pt => pt.Post)
    //            .WithMany(p => p.PostTags)
    //            .HasForeignKey(pt => pt.PostId);

    //        modelBuilder.Entity<PostTag>()
    //            .HasOne(pt => pt.Tag)
    //            .WithMany(t => t.PostTags)
    //            .HasForeignKey(pt => pt.TagId);
    //    }
    //}


    //public class Post
    //{
    //    public int PostId { get; set; }
    //    public string Title { get; set; }
    //    public string Content { get; set; }

    //    public List<PostTag> PostTags { get; set; }
    //}

    //public class Tag
    //{
    //    public string TagId { get; set; }

    //    public List<PostTag> PostTags { get; set; }
    //}

    //public class PostTag
    //{
    //    public int PostId { get; set; }
    //    public Post Post { get; set; }

    //    public string TagId { get; set; }
    //    public Tag Tag { get; set; }
    //} 
    #endregion

    #region Demo5
    //class MyContext : DbContext
    //{
    //    public DbSet<Blog> Blogs { get; set; }
    //    //public DbSet<RssBlog> RssBlogs { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=DELL-PC;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<RssBlog>().HasBaseType<Blog>();
    //    }

    //}

    //public class Blog
    //{
    //    public int BlogId { get; set; }
    //    public string Url { get; set; }
    //}

    //public class RssBlog : Blog
    //{
    //    public string RssUrl { get; set; }
    //} 
    #endregion

    class MyContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        //public DbSet<RssBlog> RssBlogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DELL-PC;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(p => p.Url);
                //.HasField("_validatedUrl")
                //.UsePropertyAccessMode(PropertyAccessMode.Field);
        }

    }
    public class Blog
    {
        private string _url;

        public int BlogId { get; set; }

        public string Url
        {
            get { return _url; }
        }

        public void SetUrl(string url)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
            }

            _url = url;
        }
    }
}
