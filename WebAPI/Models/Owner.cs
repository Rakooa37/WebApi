namespace WebAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public Country Country { get; set; }
        public ICollection<SmartPhoneOwner> SmartPhoneOwners { get; set; }
    }
}
