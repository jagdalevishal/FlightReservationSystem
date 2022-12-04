using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FRS.Models
{
    [Table("TblAdminLogin")]
    public class AdminLogin
    {
        [Key]
        public int AdminId { get; set; }
        [Required(ErrorMessage ="User Name Required")]
        [Display(Name ="User Name")]
        [MinLength(3,ErrorMessage ="Min 3 Char Req"),MaxLength(10,ErrorMessage ="Max 10 Char Allow")]
        public string AName { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Min 5 Char Req"),MaxLength(10, ErrorMessage = "Max 10 Char Allow")]
       

        public string Password { get; set; }
    }
    [Table("TblUserAccount")]
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Req")]
        [MinLength(5, ErrorMessage = "Min 5 Char Req"), MaxLength(40, ErrorMessage = "Max 40 Char Allow")]

        public int FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Req")]
        [MinLength(5, ErrorMessage = "Min 5 Char Req"), MaxLength(40, ErrorMessage = "Max 40 Char Allow")]

        public int LastName { get; set; }
        [Display(Name = "Email Id")]
        [Required(ErrorMessage = "Email Id Req")]
        [MinLength(5, ErrorMessage = "Min 5 Char Req"), MaxLength(30, ErrorMessage = "Max 30 Char Allow")]
        [DataType(DataType.EmailAddress)]
        public int EmailId { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password Req")]
        [MinLength(5, ErrorMessage = "Min 5 Char Req"), MaxLength(20, ErrorMessage = "Max 20 Char Allow")]

        public int Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Password not match")]
        [MinLength(5, ErrorMessage = "Min 5 Char Req"), MaxLength(20, ErrorMessage = "Max 20 Char Allow")]

        public int CPassword { get; set; }
        [Required(ErrorMessage ="Age Req")]
        [Range(18,120,ErrorMessage ="Min 18 Years has book the flight")]
        public int Age { get; set; }

        [Display(Name = "Phone No")]
        [Required(ErrorMessage = "Phone No Req"),RegularExpression(@"^([0-9]{11})$",ErrorMessage ="Phone no is not valid")]
        [StringLength(11)]

        public string Phoneno{ get; set; }

        [Display(Name = "NIC No")]
        [Required(ErrorMessage = "NIC No Req"), RegularExpression(@"^([0-9]{13})$", ErrorMessage = "Invalid NIC no")]
        [StringLength(13)]

        public string NIC { get; set; }
    }
    public class AiroPlaneInfo
    {
        [Key]
        public int Planeid { get; set; }
        [Display(Name = "Aitoplane Name")]
        [Required(ErrorMessage = "Airoplane Name Req")]
        [MinLength(3, ErrorMessage = "Min 3 Char Req"), MaxLength(30, ErrorMessage = "Max 30 Char Allow")]

        public int APlaneName { get; set; }
        [Required(ErrorMessage ="Capacity Required")]
        [Display(Name ="Seating Capacity")]
        public int SeatingCapacity { get; set; }

        [Required(ErrorMessage = "Price Required")]
       
        public int Price { get; set; }
        
    }
    [Table("TblFlightBook")]
    public class FlightBooking
    {
        [Key]
        public int bid { get; set; }

        [Required(ErrorMessage ="From City Req")]
        [Display(Name ="From City")]
        [StringLength(40,ErrorMessage ="Max 40 char allowed")]
        public string From{ get; set; }

        [Required(ErrorMessage = "To City Req")]
        [Display(Name = "To City")]
        [StringLength(40, ErrorMessage = "Max 40 char allowed")]
        public string To{ get; set; }

        [Display(Name ="Departture date")]
        [DataType(DataType.Date)]
        public DateTime DDate { get; set; }

        [Display(Name = "Departture Time")]
        [StringLength(15)]
        public DateTime DTime { get; set; }

        public int Planeid { get; set; }
        //forign key
        public virtual AiroPlaneInfo PlaneInfo { get; set; }

        

        [Display(Name ="Seat Type")]
        [StringLength(25)]
        public string SeatType { get; set; }



    }
}

