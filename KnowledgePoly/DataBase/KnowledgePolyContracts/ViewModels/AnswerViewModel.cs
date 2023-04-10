using KnowledgePolyDataModels.Models;

namespace KnowledgePolyContracts.ViewModels
{
    public class AnswerViewModel : IAnswerModel
    {
        public int Id { get; set; }
        public string AnswerText { get; set; } = string.Empty;
        public bool Right { get; set; } = false;
    }
}