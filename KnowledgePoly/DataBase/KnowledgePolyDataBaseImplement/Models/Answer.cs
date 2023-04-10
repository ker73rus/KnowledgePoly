using KnowledgePolyContracts.ViewModels;
using KnowledgePolyDataModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgePolyDataBaseImplement.Models
{
    public class Answer : IAnswerModel
    {
        public int Id { get; private set; }
        [Required]
        public string AnswerText { get; set; } = string.Empty;
        [Required]
        public bool Right { get; set; }
        [ForeignKey("AnswerId")]
        public virtual List<QuestionAnswer> QuestionAnswers { get; set; } = new();
        public AnswerViewModel GetViewModel => new()
        {
            Id = Id,
            AnswerText = AnswerText,
            Right = Right
        };

    }
}