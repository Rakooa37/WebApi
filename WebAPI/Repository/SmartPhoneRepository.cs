using WebAPI.Data;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class SmartPhoneRepository : ISmartPhoneRepository
    {   
        private readonly DataContext _context;
        public SmartPhoneRepository(DataContext context)
        {
            this._context = context;
        }

        public SmartPhone GetSmartPhone(int id)
        {
            return _context.SmartPhones.Where(s => s.Id == id).FirstOrDefault();
        }

        public SmartPhone GetSmartPhone(string name)
        {
            return _context.SmartPhones.Where(s => s.Name == name).FirstOrDefault();
        }

        public decimal GetSmartPhoneRating(int id)
        {
            var reviews = _context.Reviews.Where(review => review.SmartPhone.Id == id);
            if(reviews.Count() <= 0)
            {
                return 0;
            }

            return ((decimal)reviews.Sum(r => r.Rating)/reviews.Count());
        }

        public ICollection<SmartPhone> GetSmartPhones()
        {
            return _context.SmartPhones.OrderBy(s => s.Id).ToList() ;
        }

        public bool SmartPhonesExists(int id)
        {
           return _context.SmartPhones.Any(s => s.Id == id);
        }
    }
}
