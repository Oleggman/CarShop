using System;
using System.Collections.Generic;
using CarShop.Data.Interfaces;
using CarShop.Models;

namespace CarShop.Data.Mocks
{
    /*public class MockAdvertisement : IAdvertisement
    {
        private List<Advertisement> _advertisements;
        public IEnumerable<Advertisement> Ads
        {
            get
            {
                return new List<Advertisement>
                {
                    new Advertisement
                    {
                        ActivityStatus = true,
                        Car = new Car
                        {
                            Brand = "Mercedes",
                            Model = "S63 AMG",
                            ReleaseYear = 2017,
                            Run = 5000,
                            Description = "Продам s63 AMG в хорошому стані",
                            Price = 5125000
                        },
                        Owner = new User
                        {
                            FullName = "Ковалець Олег",
                            Age = 19,
                            City = "Київ",
                            Phone = "050 216 42 95"
                        },
                        Img = "/img/s63.jpeg",
                        IsFavourite = false
                    },
                    new Advertisement {
                        ActivityStatus = true,
                        Car = new Car
                        {
                            Brand = "BMW",
                            Model = "528i",
                            ReleaseYear = 2013,
                            Run = 11000,
                            Description = "Продам 528i. Можливість торгів",
                            Price = 750000
                        },
                        Owner = new User
                        {
                            FullName = "Шевчук Артем",
                            Age = 20,
                            City = "Львів",
                            Phone = "096 943 53 90"
                        },
                        Img = "/img/528i.jpeg",
                        IsFavourite = false
                    },
                    new Advertisement {
                        ActivityStatus = true,
                        Car = new Car
                        {
                            Brand = "Audi",
                            Model = "A7",
                            ReleaseYear = 2016,
                            Run = 25000,
                            Description = "Продам А7 по дуже зручній ціні",
                            Price = 785000
                        },
                        Owner = new User
                        {
                            FullName = "Розумняк Роман",
                            Age = 17,
                            City = "Одеса",
                            Phone = "067 234 82 42"
                        },
                        Img = "/img/audia7.jpeg",
                        IsFavourite = false
                    },
                    new Advertisement {
                        ActivityStatus = true,
                        Car = new Car
                        {
                            Brand = "Ford",
                            Model = "Fiesta",
                            ReleaseYear = 2007,
                            Run = 95000,
                            Description = "Продаю Ford Fiesta. Машинка добре давить",
                            Price = 520000
                        },
                        Owner = new User
                        {
                            FullName = "Обозюк Олександр",
                            Age = 21,
                            City = "Суми",
                            Phone = "066 832 15 57"
                        },
                        Img = "/img/fordfiesta.jpeg",
                        IsFavourite = false
                    },
                    new Advertisement {
                        ActivityStatus = true,
                        Car = new Car
                        {
                            Brand = "Chevrolet",
                            Model = "Camaro",
                            ReleaseYear = 2019,
                            Run = 160000,
                            Description = "Продам хорошу машинку Chevrolet Camaro",
                            Price = 2170000
                        },
                        Owner = new User
                        {
                            FullName = "Берковський Данило",
                            Age = 28,
                            City = "Київ",
                            Phone = "095 753 66 72"
                        },
                        Img = "/img/chcamaro.jpeg",
                        IsFavourite = false
                    }
                };
            }
            set
            {
                try
                {
                    _advertisements.Add(new Advertisement { ActivityStatus = true, Car = Auto, Owner = User, Img = Image });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private readonly DBContent dbContent;

        public Car Auto(int carId) { return dbContent.Cars.FirstOrDefault(p => p.Id == carId); }

        public User User(int userId) { return dbContent.Users.FirstOrDefault(p => p.Id == userId); }

        public string Image { get; set; }

        public IEnumerable<Advertisement> FavAds { get; set; }
    }*/
}