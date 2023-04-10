using KnowledgePolyDataModels.Models;

namespace KnowledgePolyContracts.ViewModels
{
    public class QuestionViewModel : IQuestionModel
    {
        public int Id { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<IAnswerModel> QuestionAnswers { get; set; } = new();
        public double Price { get; set; }
    }
}