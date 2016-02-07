using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class AddNewGame
    {
        [Key]
        [Required]
        public Guid GameID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumberOfAnswers { get; set; }
    }

    public class AddNewQuestion
    {
        [Key]
        [Required]
        public Guid QuestionID { get; set; }
        [Required]
        public string CorrectAnswer { get; set; }
        [Required]
        public List<string> InCorrectAnswers { get; set; }
        public string Url { get; set; }
        public string FilePath { get; set; }
        public string QuestionTime { get; set; }
        public string SpotifyLink { get; set; }

    }

    public class ListGames
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumberOfQuestions { get; set; }
        [Required]
        public int TimePerQuestion { get; set; }
    }
}

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
        [Required]
        public int Score { get; set; }
        [Required]
        public List<string> WinnerList { get; set; }
    }

