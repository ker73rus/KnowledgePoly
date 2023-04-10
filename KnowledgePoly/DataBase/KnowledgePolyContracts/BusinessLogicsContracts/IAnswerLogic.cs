using KnowledgePolyContracts.SearchModels;
using KnowledgePolyContracts.ViewModels;

namespace KnowledgePolyContracts.BusinessLogicsContracts
{
    public interface IAnswerLogic
    {
        List<AnswerViewModel>? ReadList(AnswerSearchModel? model);
        AnswerViewModel? ReadElement(AnswerSearchModel model);
    }
}