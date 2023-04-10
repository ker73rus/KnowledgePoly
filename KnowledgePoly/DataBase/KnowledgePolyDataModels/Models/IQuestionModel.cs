namespace KnowledgePolyDataModels.Models
{
    public interface IQuestionModel : IId
    {
        string QuestionText { get;}
        double Price { get; }
    }
}