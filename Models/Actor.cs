using System.ComponentModel.DataAnnotations;

namespace cine.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string ProfilePictureUrl { get; set; }
        [Required(ErrorMessage = "Full Name is Required")]

        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Full name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //relationships
        public List<Actor_Movie>? Actors_Movies { get; set;}
    }
}
