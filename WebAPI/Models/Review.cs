namespace WebAPI.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public float Rating { get; set; }
        public Reviewer Reviewer { get; set; }
        public SmartPhone SmartPhone { get; set; }
    }
}
