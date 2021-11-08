using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Timetable
    {
        public int MovieId { get; set; }
        public int RoomId { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Realise { get; set; }
    }
}
