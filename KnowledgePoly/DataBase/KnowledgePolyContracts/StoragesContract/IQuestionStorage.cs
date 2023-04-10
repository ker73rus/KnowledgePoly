using KnowledgePolyContracts.SearchModels;
using KnowledgePolyContracts.ViewModels;

namespace KnowledgePolyContracts.StoragesContract
{
    public interface IQuestionStorage
    {
        List<QuestionViewModel> GetFullList();
        List<QuestionViewModel> GetFilteredList(QuestionSearchModel model);
        Tuple<QuestionViewModel, AnswerViewModel[]> GetElement(QuestionSearchModel model);
    }
}