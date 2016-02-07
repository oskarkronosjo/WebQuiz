using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class QuestionModel
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
}
