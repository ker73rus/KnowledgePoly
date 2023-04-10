using KnowledgePolyContracts.SearchModels;
using KnowledgePolyContracts.ViewModels;

namespace KnowledgePolyContracts.StoragesContract
{
    public interface IAnswerStorage
    {
        List<AnswerViewModel> GetFullList();
        List<AnswerViewModel> GetFilteredList(AnswerSearchModel model);
        AnswerViewModel? GetElement(AnswerSearchModel model);
    }
}