using System.ComponentModel.DataAnnotations;

namespace uPhoriaClientAPI.DTOs.PostDTO
{
    public class CreatePostDTO
    {       
        [Required]
        public string text { get; set; }

        [Required]
        public string username { get; set; }
    }
}
