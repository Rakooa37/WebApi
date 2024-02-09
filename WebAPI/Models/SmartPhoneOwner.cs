namespace WebAPI.Models
{
    public class SmartPhoneOwner
    {
        public int SmartPhoneId { get; set; }
        public int OwnerId { get; set; }
        public SmartPhone SmartPhone { get; set; }
        public Owner Owner { get; set; }

    }
}
