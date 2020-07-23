using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;
using MovieStore.Core.Models.Request;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Purchase()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<ActionResult> purchase(PurchaseRequestModel purchaseRequest)
        {

            await _userService.PurchaseMovie(purchaseRequest);
            return View(purchaseRequest);
        }

        [HttpGet]
        public async Task<ActionResult> purchases()
        {
            var email = User.Identity.Name;
            var currentUser = await _userService.GetUserByEmail(email);
            var currentId = currentUser.Id;
            var moviepurchased = await _userService.GetAllPurchasesForUser(currentId);

            return View(moviepurchased);
        }
        [HttpGet]
        public ActionResult Review()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Review(ReviewRequestModel reviewRequestModel)
        {
            await _userService.AddMovieReview(reviewRequestModel);
            return View(reviewRequestModel);
        }

        [HttpGet]
        public async Task<ActionResult> Reviews()
        {
            var email = User.Identity.Name;
            var currentUser = await _userService.GetUserByEmail(email);
            var currentId = currentUser.Id;
            var allReviews = await _userService.GetAllReviewsByUser(currentId);

            return View(allReviews);
        }

        [HttpPost]
        public async Task<ActionResult> Favorite(FavoriteRequestModel favoriteRequest)
        {
            string url = HttpContext.Request.GetDisplayUrl();
            await _userService.AddFavorite(favoriteRequest);
            return View();
        }
       [HttpPost]
       public async Task<ActionResult> DeleteFavorite(FavoriteRequestModel favoriteRequestModel)
        {
            await _userService.RemoveFavorite(favoriteRequestModel);
            return View();
        }
  
    }
}
