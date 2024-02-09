using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI
{
    public class DataSeeder
    {
        private readonly DataContext dataContext;
        public DataSeeder(DataContext context)
        {
            this.dataContext = context;
        }
        public void Seed()
        {
            if (!dataContext.SmartPhoneOwners.Any())
            {
                var smartPhoneOwners = new List<SmartPhoneOwner>()
                {
                    new SmartPhoneOwner()
                    {
                        SmartPhone = new SmartPhone()
                        {
                            Name = "Samsung Galaxy S3",
                            ReleaseDate = new DateTime(2005,1,1),
                            SmartPhoneCategories = new List<SmartPhoneCategory>()
                            {
                                new SmartPhoneCategory { Category = new Category() { Name = "First Releases"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Best Phone",Text = "S3 is the best SmartPhone, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Awesome Phone", Text = "Samsung is the best company", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Trash",Text = "Nokia is better", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "London",
                            Description = "Brocks Description",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new SmartPhoneOwner()
                    {
                        SmartPhone = new SmartPhone()
                        {
                            Name = "Motorola v15",
                            ReleaseDate = new DateTime(2005,1,1),
                            SmartPhoneCategories = new List<SmartPhoneCategory>()
                            {
                                new SmartPhoneCategory { Category = new Category() { Name = "Old gems"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Motorola v15 rocks", Text = "Motorola v15 is the best SmartPhone, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title= "Weird phone",Text = "Motorola is very underrated", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title= "Not worthed", Text = "apple is the best", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Harry",
                            LastName = "Potter",
                            Description = "Mistys Description",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                                    new SmartPhoneOwner()
                    {
                        SmartPhone = new SmartPhone()
                        {
                            Name = "Blackberry I20",
                            ReleaseDate = new DateTime(1903,1,1),
                            SmartPhoneCategories = new List<SmartPhoneCategory>()
                            {
                                new SmartPhoneCategory { Category = new Category() { Name = "Best phones "}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Blackberry I20 best",Text = "Blackberry I20 best is the best SmartPhone, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Blackberry I20 wow",Text = "Blackberry is the best company", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Trash",Text = "Huawei does it better", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Ash",
                            LastName = "Ketchum",
                            Description = "Ashs Description",
                            Country = new Country()
                            {
                                Name = "Millet Town"
                            }
                        }
                    }
                };
                dataContext.SmartPhoneOwners.AddRange(smartPhoneOwners);
                dataContext.SaveChanges();
            }
        }
    }
}
