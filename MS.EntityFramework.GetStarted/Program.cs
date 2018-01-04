using System;
using System.Collections.Generic;

namespace MS.EntityFramework.GetStarted
{
    public class Program
    {
        private static readonly MyContext _context;

        static Program()
        {
            _context = new MyContext();
        }

        public static void Main(string[] args)
        {
            //
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            //var myBlog = new Blog();
            //_context.Entry(myBlog).Property("LastUpdated").CurrentValue = DateTime.Now;

            #region Demo3
            //Car car = new Car
            //{
            //    LicensePlate = "湘A58R34",
            //    Make = "中国",
            //    Model = "上海大众",
            //    State = "SHDZ-RT-2.0"
            //};

            //var recordOfSale = new RecordOfSale
            //{
            //    Price = 350000,
            //    DateSold = new DateTime(2018, 5, 20)
            //};
            //car.SaleHistory = new System.Collections.Generic.List<RecordOfSale> { recordOfSale };
            //_context.Add<Car>(car);
            //_context.SaveChanges(); 
            #endregion

            #region Demo4
            //添加多对多关联数据
            //var post = new Post
            //{
            //    Content = "文章1",
            //    Title = "标题1"
            //};
            //var posts = new List<Post>();
            //var tags = new List<Tag>();
            //Array.ForEach(new int[] { 1, 2, 3, 4, 5 }, i => posts.Add(new Post { Content = "文章" + i, Title = "标题" + i }));
            //Array.ForEach(new int[] { 1, 2, 3, 4, 5 }, i => tags.Add(new Tag()));
            //var postTags = new List<PostTag>();
            //for (var i = 0; i < posts.Count; i++)
            //{
            //    postTags.Add(new PostTag
            //    {
            //        Post = posts[i],
            //        Tag = tags[i]
            //    });
            //}
            //_context.AddRange(postTags); 
            #endregion
            //_context.AddRange(tags);
            //_context.SaveChanges();
            Console.WriteLine("初始化DB成功！");
            var k = Console.ReadKey();
            //if (k.Key == ConsoleKey.Enter)
            //{
            //    Main(null);
            //}
        }


        private void EnsuraDatabaseCreateOrDelete()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }
    }
}
