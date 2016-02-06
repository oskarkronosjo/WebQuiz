using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class AddNewGame
    { }

    public class AddNewQuestion
    { }

    public class QuestionViewModel
    {
        [Key]
        [Required]
        public Guid QuestionID { get; set; }
        [Required]
        public List<string> AnswerList { get; set; }
        [Required]
        public string CorrectAnswer { get; set; }
        public string QuestionUrl { get; set; }
        public string  QuestionFilePath { get; set; }
        public string SpotifyLink { get; set; }
        public DateTime QuestionTime { get; set; }
    }

    public class WinnersViewModel
    {
        public int Score { get; set; }
        public List<string> WinnerList { get; set; }
    }
}
