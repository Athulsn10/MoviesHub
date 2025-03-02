using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
namespace MoviesHub.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }

    // [Required(ErrorMessage ="Please Upload An Image")]
    [Display(Name = "Image")]
    public string? ImageUrl { get; set; }
    
    [NotMapped]
    [Display(Name = "Upload Image")]
    [Required(ErrorMessage = "Please select an image file")]
    public IFormFile ImageFile { get; set; }
    public decimal Price { get; set; }
}