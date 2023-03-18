using CarShop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarShop.Data
{
    public class DBObjects
    {
        public static void Initial(DBContent content)
        {
            if (!content.Ads.Any())
                content.Ads.AddRange(Advertisements.Select(c => c));

            content.SaveChanges();
        }

        private static List<Advertisement> _advertisements;

        public static List<Advertisement> Advertisements 
        {
            get
            {
                if (_advertisements == null) 
                {
                    List<User> Owners = new List<User> 
                    {
                        new User
                        {
                             FullName = "Ковалець Олег",
                             Age = 19,
                             City = "Київ",
                             Phone = "050 216 42 95",
                             UserToken = 223124,
                             Login = "olegBaza112@ukr.net",
                             Password = "chinaSauntrez22"
                        },
                        new User
                        {
                             FullName = "Шевчук Артем",
                             Age = 20,
                             City = "Львів",
                             Phone = "096 943 53 90",
                             UserToken = 331472,
                             Login = "ashev@gmail.com",
                             Password = "skyrim227"
                        },
                        new User
                        {
                             FullName = "Обозюк Олександр",
                             Age = 21,
                             City = "Суми",
                             Phone = "066 832 15 57",
                             UserToken = 532678,
                             Login = "obozlo.ya@gmail.com",
                             Password = "gymnChiza90"
                        },
                        new User
                        {
                             FullName = "Розумняк Роман",
                             Age = 17,
                             City = "Одеса",
                             Phone = "067 234 82 42",
                             UserToken = 852462,
                             Login = "romanrozumda@gmail.com",
                             Password = "fartumasti.brs"
                        },
                        new User
                        {
                             FullName = "Берковський Данило",
                             Age = 28,
                             City = "Київ",
                             Phone = "095 753 66 72",
                             UserToken = 485512,
                             Login = "berkovichstudio@gmail.com",
                             Password = "berkolandpictures2016"
                        }
                    };

                    var list = new Advertisement[]
                    {
                        new Advertisement
                        {
                            ActivityStatus = true,
                            Brand = "Mercedes",
                            Model = "S63 AMG",
                            ReleaseYear = 2017,
                            Run = 5000,
                            Description = "Продам s63 AMG в хорошому стані",
                            Price = 5125000,
                            UserToken = Owners[0].UserToken,
                            FullName = Owners[0].FullName,
                            Phone = Owners[0].Phone,
                            Img = "/img/s63.jpeg",
                            IsFavourite = false
                        },
                        new Advertisement
                        {
                            ActivityStatus = true,
                            Brand = "Volkswagen",
                            Model = "Jetta",
                            ReleaseYear = 2014,
                            Run = 110000,
                            Description = "Авто перевирене часом. Міцне авто",
                            Price = 510000,
                            UserToken = Owners[3].UserToken,
                            FullName = Owners[3].FullName,
                            Phone = Owners[3].Phone,
                            Img = "/img/jetta.jpeg",
                            IsFavourite = false
                        },
                        new Advertisement {
                            ActivityStatus = true,
                            Brand = "BMW",
                            Model = "528i",
                            ReleaseYear = 2013,
                            Run = 11000,
                            Description = "Продам 528i. Можливість торгів",
                            Price = 750000,
                            UserToken= Owners[2].UserToken,
                            FullName = Owners[2].FullName,
                            Phone = Owners[2].Phone,
                            Img = "/img/528i.jpeg",
                            IsFavourite = false
                        },
                        new Advertisement {
                            ActivityStatus = true,
                            Brand = "Hyundai",
                            Model = "Sonata",
                            ReleaseYear = 2015,
                            Run = 63000,
                            Description = "Зручна та компактна. Ціна пристойна",
                            Price = 400000,
                            UserToken= Owners[3].UserToken,
                            FullName = Owners[3].FullName,
                            Phone = Owners[3].Phone,
                            Img = "/img/sonata.jpeg",
                            IsFavourite = true
                        },
                        new Advertisement {
                            ActivityStatus = true,
                            Brand = "Ford",
                            Model = "Fiesta",
                            ReleaseYear = 2007,
                            Run = 95000,
                            Description = "Продаю Ford Fiesta. Машинка добре давить",
                            Price = 520000,
                            UserToken= Owners[1].UserToken,
                            FullName = Owners[1].FullName,
                            Phone = Owners[1].Phone,
                            Img = "/img/fordfiesta.jpeg",
                            IsFavourite = false
                        },
                        new Advertisement {
                            ActivityStatus = true,
                            Brand = "Audi",
                            Model = "A7",
                            ReleaseYear = 2016,
                            Run = 25000,
                            Description = "Продам А7 по дуже зручній ціні",
                            Price = 785000,
                            UserToken = Owners[0].UserToken,
                            FullName = Owners[0].FullName,
                            Phone = Owners[0].Phone,
                            Img = "/img/audia7.jpeg",
                            IsFavourite = true
                        },
                        new Advertisement {
                            ActivityStatus = true,
                            Brand = "Kia",
                            Model = "Sportage",
                            ReleaseYear = 2018,
                            Run = 420000,
                            Description = "Комфортне та велике авто. Торги",
                            Price = 730000,
                            UserToken = Owners[4].UserToken,
                            FullName = Owners[4].FullName,
                            Phone = Owners[4].Phone,
                            Img = "/img/sportage.jpeg",
                            IsFavourite = false
                        },
                        new Advertisement {
                            ActivityStatus = true,
                            Brand = "Toyota",
                            Model = "Corolla",
                            ReleaseYear = 2015,
                            Run = 87000,
                            Description = "Гарна машинка. Продам терміново",
                            Price = 670000,
                            UserToken = Owners[2].UserToken,
                            FullName = Owners[2].FullName,
                            Phone = Owners[2].Phone,
                            Img = "/img/toyotacorolla.jpeg",
                            IsFavourite = false
                        },
                        new Advertisement {
                            ActivityStatus = true,
                            Brand = "Ford",
                            Model = "Focus",
                            ReleaseYear = 2012,
                            Run = 10000,
                            Description = "Mашинка майже нова. Повна комплектація",
                            Price = 380000,
                            UserToken = Owners[4].UserToken,
                            FullName = Owners[4].FullName,
                            Phone = Owners[4].Phone,
                            Img = "/img/fordfocus.jpeg",
                            IsFavourite = true
                        },
                        new Advertisement {
                            ActivityStatus = true,
                            Brand = "Chevrolet",
                            Model = "Camaro",
                            ReleaseYear = 2019,
                            Run = 160000,
                            Description = "Продам хорошу машинку Chevrolet Camaro",
                            Price = 2170000,
                            UserToken = Owners[1].UserToken,
                            FullName = Owners[1].FullName,
                            Phone = Owners[1].Phone,
                            Img = "/img/chcamaro.jpeg",
                            IsFavourite = false
                        }
                    };

                    _advertisements = new List<Advertisement>();

                    foreach (Advertisement ad in list)
                        _advertisements.Add(ad);
                }

                return _advertisements;
            }
        }
    }
}
