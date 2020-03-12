using System;
using System.Collections.Generic;

namespace DatingApp.API.Dtos
{
    public class PhotosForDetailedDTO
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public ICollection<TagForDetailedDTO> Tags { get; set; }
    }
}