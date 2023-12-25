
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace JwtToken.Models
{
    public class Login
    {
        [Key]
        public int id { get; set; }
        //public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
