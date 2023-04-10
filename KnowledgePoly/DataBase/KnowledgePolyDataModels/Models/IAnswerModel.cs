namespace KnowledgePolyDataModels.Models
{
    public interface IAnswerModel : IId
    {
        string AnswerText { get; }
        bool Right { get; }
    }
}