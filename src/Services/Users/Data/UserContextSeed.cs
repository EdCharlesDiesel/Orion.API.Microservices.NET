

using Orion.Services.Users.Entities;

namespace Orion.Services.Users.Data
{
    public abstract class UserContextSeed
    {
        // public static void SeedData(IMongoCollection<User> UserCollection)
        // {
        //     bool existUser = UserCollection.Find(p => true).Any();
        //     if (!existUser)
        //     {
        //         UserCollection.InsertManyAsync(GetPreconfiguredUsers());
        //     }
        // }

        private static IEnumerable<User> GetPreconfiguredUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Username = "IPhone X",
                    Bio = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    State = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    Avatar = "User-1.png",
       
                    Email = "Smart Phone"
                },
                new User()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Username = "Samsung 10",
                    Bio = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    State = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    Avatar = "User-2.png",
            
                    Email = "Smart Phone"
                },
                new User()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Username = "Huawei Plus",
                    Bio = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    State = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    Avatar = "User-3.png",
            
                    Email = "White Appliances"
                },
                new User()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Username = "Xiaomi Mi 9",
                    Bio = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    State = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    Avatar = "User-4.png",

                    Email = "White Appliances"
                },
                new User()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Username = "HTC U11+ Plus",
                    Bio = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    State = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    Avatar = "User-5.png",
         
                    Email = "Smart Phone"
                },
                new User()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Username = "LG G7 ThinQ",
                    Bio = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    State = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    Avatar = "User-6.png",
                  
                    Email = "Home Kitchen"
                }
            };
        }
    }
}
