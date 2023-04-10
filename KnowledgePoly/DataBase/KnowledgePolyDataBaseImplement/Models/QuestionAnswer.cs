using DataBaseImplement.Models;
using System.ComponentModel.DataAnnotations;

namespace KnowledgePolyDataBaseImplement.Models
{
    public class QuestionAnswer
    {
        public int Id { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [Required]
        public int AnswerId { get; set; }
        public virtual Answer Answer { get; set; } = new();
        public virtual Question Question { get; set; } = new();
    }
}