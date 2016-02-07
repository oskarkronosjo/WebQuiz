using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class GameModel
    {
        [Key]
        [Required]
        public Guid GameID { get; set; }
        [Required]
        public int NumberOfQuestions { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int TimePerQuestion { get; set; }
    }
}
