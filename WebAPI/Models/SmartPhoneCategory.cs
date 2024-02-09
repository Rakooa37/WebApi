namespace WebAPI.Models
{
    public class SmartPhoneCategory
    {
        public int SmartPhoneId { get; set; }
        public int CategoryId { get; set; } 
        public SmartPhone SmartPhone { get; set; }
        public Category Category { get; set; }
    }
}
