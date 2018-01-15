namespace MovieDatabase.Entities
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Microsoft.AspNetCore.Identity;

    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {       
        public List<Review> Reviews { get; set; }
    }
}
