using KnowledgePolyDataModels.Models;

namespace KnowledgePolyContracts.BindingModels
{
    public class AnswerBindingModel : IAnswerModel
    {
        public int Id { get; set; }
        public string AnswerText { get; set; } = string.Empty;
        public int QuestionId { get; set; }
        public bool Right { get; set; } = false;
    }
}