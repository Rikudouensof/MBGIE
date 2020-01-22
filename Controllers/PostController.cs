using MBGIE.Models;
using MBGIE.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MBGIE.Controllers
{

   
    public class PostController : Controller
    {
        // GET: Post
        private ApplicationDbContext _context;
        public Images daImages;


        public PostController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ControlPost()
        {
            NewPostImageViewModel newPostImageViewModel = new NewPostImageViewModel()
            {
                Categories = _context.Categories.ToList(),

                
                
               
              
            };

            try
            {
                newPostImageViewModel.Imagesz = _context.Images.OrderByDescending(m => m.Url).First();
            }
            catch (Exception)
            {

            }
            return View(newPostImageViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddImages(NewPostImageViewModel newPostImageViewModel)
        {
            string filename = Path.GetFileNameWithoutExtension(newPostImageViewModel.Imagesz.ImageFile.FileName);
            string exention = Path.GetExtension(newPostImageViewModel.Imagesz.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmddssffff") + exention;
            newPostImageViewModel.Imagesz.Url = "~/Images/" + filename;
            filename = Path.Combine(Server.MapPath("~/Images/"), filename);
            newPostImageViewModel.Imagesz.Date = DateTime.Now;
            if (_context.Images.Count().Equals(null))
            {
                newPostImageViewModel.Imagesz.Id = 1;
            }
            else
            {
                newPostImageViewModel.Imagesz.Id = _context.Images.Count() + 1;
            }
            newPostImageViewModel.Imagesz.Title = User.Identity.GetUserName().ToString() + DateTime.Now.ToString("yymmddssffff");
            newPostImageViewModel.Imagesz.ImageFile.SaveAs(filename);
            daImages = newPostImageViewModel.Imagesz;
            _context.Images.Add(newPostImageViewModel.Imagesz);
            _context.SaveChanges(); 


            

            NewPostImageViewModel cnewPostImageViewModel = new NewPostImageViewModel()
            {
                Categories = _context.Categories.ToList(),
                Imagesz = newPostImageViewModel.Imagesz


            };
            return View("ControlPost", cnewPostImageViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPost(Post post)
        {

            ////if (!ModelState.IsValid)
            ////{


            ////    NewPostImageViewModel newPostImageViewModel = new NewPostImageViewModel()
            ////    {
            ////        Categories = _context.Categories.ToList(),
            ////        Imagesz = daImages,
            ////        Post = post


            ////    };

            ////    return View("ControlPost", newPostImageViewModel);
            ////}

            ////if (post.Id == 0)

            ////    _context.Posts.Add(post);
            //try
            //{
            //    var PostInDb = _context.Posts.Single(c => c.Id == post.Id);
            //    PostInDb.DateOfMakingPost = DateTime.Now.ToString("dddd/MMMM/YYYY");
            //    PostInDb.CategoriesId = post.CategoriesId;
            //    PostInDb.Content = post.Content;
            //    PostInDb.ImagesId = daImages.Id;
            //    _context.Posts.Add(PostInDb);
            //}
            //catch
            //{
            //    NewPostImageViewModel newPostImageViewModel = new NewPostImageViewModel()
            //    {
            //        Categories = _context.Categories.ToList(),
            //        Imagesz = daImages,
            //        Post = post


            //    };
            //    return View("ControlPost", newPostImageViewModel);
            //}
            int PostID = 0;
            if (_context.Posts.Count().Equals(null))
            {
                PostID = 1;
            }
            else
            {
                PostID = _context.Posts.Count() + 1;
            }
            var PostInDb = new Post();
            PostInDb.Id = PostID;
            PostInDb.DateOfMakingPost = DateTime.Now.ToString("dddd/MMMM/YYYY");
            PostInDb.CategoriesId = post.CategoriesId;
            PostInDb.Content = post.Content;
            PostInDb.ImagesId = _context.Images.OrderByDescending(m => m.Id).Select(md => md.Id).FirstOrDefault();
            _context.Posts.Add(PostInDb);

            _context.SaveChanges();

           

            return RedirectToAction("Index", "Post");







            
        }
    }
}