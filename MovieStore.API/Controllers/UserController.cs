using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;
using MovieStore.Core.Models.Request;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //[Authorize]
        [HttpPost("purchase")]
        public async Task<ActionResult> CreatePurchase([FromBody] PurchaseRequestModel purchaseRequest)
        {
            await _userService.PurchaseMovie(purchaseRequest);
            return Ok();
        }
        [Authorize]
        [HttpGet("purchases/{id}")]
        public async Task<ActionResult> AllPurchase(int id)
        {
            var purchases = await _userService.GetAllPurchasesForUser(id);
            return Ok(purchases);
        }
        //[Authorize]
        [HttpPost("favorite")]
        public async Task<ActionResult> CreateFavorite([FromBody] FavoriteRequestModel favoriteRequest)
        {
            await _userService.AddFavorite(favoriteRequest);
            return Ok();
        }
        //[Authorize]
        [HttpPost("unfavorite")]
        public async Task<ActionResult> DeleteFavorite([FromBody] FavoriteRequestModel favoriteRequest)
        {
            await _userService.RemoveFavorite(favoriteRequest);
            return Ok();
        }
        //[Authorize]
        [HttpGet("{id:int}/movie/{movieId}/favorite")]
        public async Task<ActionResult> IsFavoriteExists(int id, int movieId)
        {
            var favoriteExists = await _userService.IsMovieFavorited(id, movieId);
            return Ok(new { isFavorited = favoriteExists });
        }
       //[Authorize]
        [HttpPost("review")]
        public async Task<ActionResult> CreateReview([FromBody] ReviewRequestModel reviewRequest)
        {
            await _userService.AddMovieReview(reviewRequest);
            return Ok();
        }
       // [Authorize]
        [HttpGet("{id:int}/movie/{movieId}/review")]
        public async Task<ActionResult> IsReviewExists(int id, int movieId)
        {
            var reviewExists = await _userService.IsMovieReviewed(id, movieId);
            return Ok(new { isReviewed = reviewExists });
        }
       // [Authorize]
        [HttpGet("reviews/{id}")]
        public async Task<ActionResult> AllReviews(int id)
        {
            var reviews = await _userService.GetAllReviewsByUser(id);
            return Ok(reviews);
        }
    }
}
