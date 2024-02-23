using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface ISmartPhoneRepository
    {
        ICollection<SmartPhone> GetSmartPhones();
        SmartPhone GetSmartPhone(int id);
        SmartPhone GetSmartPhone(string name);
        decimal GetSmartPhoneRating(int id);
        bool SmartPhonesExists(int id);
    }
}
 