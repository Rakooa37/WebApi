using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetAllReviewsOfASmartPhone(int smartPhoneId);

        bool ReviewExists(int reviewId);
    }
}
