namespace WebAPI.Models
{
    public class SmartPhone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<SmartPhoneOwner> SmartPhoneOwners { get; set; }
        public ICollection<SmartPhoneCategory> SmartPhoneCategories { get; set; }

    }
}
