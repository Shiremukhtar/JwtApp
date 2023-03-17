namespace JwtApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>() {
            new UserModel(){Username = "jason_admin", Email = "jason_admin@email.com", Password =
                "Mypass123", GivenName = "Jason", Surname = "Adan", Role = "Adminstrator"},
            new UserModel(){Username = "rage_seller", Email = "rage_seller@mail.com", Password =
                "MyPass_w0rd", GivenName = "Rage", Surname="Diriye", Role = "Seller"},
        };
    }
}
