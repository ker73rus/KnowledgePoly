using KnowledgePolyDataModels.Models;

namespace KnowledgePolyContracts.BindingModels
{
    public class QuestionBindingModel : IQuestionModel
    {
        public int Id { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<IAnswerModel> QuestionAnswers { get; set; } = new();

        public double Price { get; set; }
    }
}