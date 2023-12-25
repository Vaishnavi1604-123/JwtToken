using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace JwtToken.Models
{
    public class Employee
    {
        [Key]
        public int userid { get; set; }
        public string username { get; set; }
        public string department { get; set; }
        public string gender { get; set; }
        public decimal salary { get; set; }
    }

}
