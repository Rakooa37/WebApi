using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int id);

        ICollection<Review> GetAllReviewesByReviewer(int reviewerId);
        bool ReviewerExits(int id);
    }
}
