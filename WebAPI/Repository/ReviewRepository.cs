using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class ReviewRepository : IReviewRepository
    {   
        private readonly DataContext _context;
        public ReviewRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Review> GetAllReviewsOfASmartPhone(int smartphoneId)
        {
            return _context.Reviews.Where(r => r.SmartPhone.Id == smartphoneId).ToList();
        }

        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r=> r.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.OrderBy(r => r.Id).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r => r.Id == reviewId);
        }
    }
}
