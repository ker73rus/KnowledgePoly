using KnowledgePolyContracts.SearchModels;
using KnowledgePolyContracts.ViewModels;

namespace KnowledgePolyContracts
{
    public interface IQuestionLogic
    {
        List<QuestionViewModel>? ReadList(QuestionSearchModel? model);
        Tuple<QuestionViewModel, AnswerViewModel[]> ReadElement(QuestionSearchModel model);
    }
}