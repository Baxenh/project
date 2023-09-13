using System.ComponentModel.DataAnnotations;

namespace Lession05_Lab5_Account.Models
{
    public class Account
    {
        [Key]
        public string MemberId { get; set; }
       
        public string FullName { get; set; }


        public string Password { get; set; }

       
        public string Email { get; set; }

        public string Phone { get; set; }


     
        public string Address { get; set; }


        public string Avatar { get; set; }


        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        public string Facebook { get; set; }





        public string Website { get; set; }
    }
}
