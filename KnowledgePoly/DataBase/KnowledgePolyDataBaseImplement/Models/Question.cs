using KnowledgePolyContracts.ViewModels;
using KnowledgePolyDataBaseImplement.Models;
using KnowledgePolyDataModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseImplement.Models
{
    public class Question : IQuestionModel
    {
        public int Id { get; private set; }
        [Required]
        public string QuestionText { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
        [ForeignKey("QuestionId")]
        public List<QuestionAnswer> Answers { get; set; } = new();
        public QuestionViewModel GetViewModel => new()
        {
            Id = Id,
            QuestionText = QuestionText,
            Price = Price,
            QuestionAnswers = Answers.Select(x => (IAnswerModel)Answers).ToList(),
        };
    }
}