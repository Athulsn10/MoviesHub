using System.ComponentModel.DataAnnotations;
namespace MoviesHub.Models;

public class User  
    {  
        [Key]  
        public int UserId { get; set; }  
        public bool IsAdmin { get; set; }
  
        [Required(ErrorMessage ="Please Enter Username..")]  
        [Display(Name = "UserName")]  
        public string Username { get; set; }  
  
        [Required(ErrorMessage ="Please Enter Password...")]  
        [DataType(DataType.Password)]  
        [Display(Name ="Password")]  
        public string Pwd { get; set; }  
  
        [Required(ErrorMessage = "Please Enter the Confirm Password...")]  
        [DataType(DataType.Password)]  
        [Display(Name = "Confirm Password")]  
        [Compare("Pwd")]  
        public string Confirmpwd { get; set; }  
  
        [Required(ErrorMessage = "Please Enter Email...")]  
        [Display(Name = "Email")]  
        public string Email { get; set; }  
  
        [Required(ErrorMessage = "Select the Gender...")]  
        [Display(Name = "Gender")]  
        public string Gender { get; set; }  
  
        [Required(ErrorMessage = "Select the Marital Status...")]  
        [Display(Name = "Marital Status")]  
        public string MaritalStatus { get; set; }  
   
    }
    