using KnowledgePolyContracts.SearchModels;
using KnowledgePolyContracts.StoragesContract;
using KnowledgePolyContracts.ViewModels;

namespace KnowledgePolyDataBaseImplement.Implements
{
    public class AnswerStorage : IAnswerStorage
    {
        public AnswerViewModel? GetElement(AnswerSearchModel model)
        {
            if (!model.QuestionId.HasValue)
            {
                return null;
            }
            using var context = new KnowledgePolyDatabase();
            return context.Answers
                .FirstOrDefault(x => model.Id.HasValue && x.Id == model.Id)
                ?.GetViewModel;
        }

        public List<AnswerViewModel> GetFilteredList(AnswerSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<AnswerViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }
    }
}
