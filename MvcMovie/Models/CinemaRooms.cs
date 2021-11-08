using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace MvcMovie.Models
{
    public class CinemaRooms
    {
        public int Id { get; set; }
        [Required]
        public int Chair { get; set; }
        public string ED { get; set; }
        public ICollection<Timetable> Timetables { get; set; }
    }
}
