using KnowledgePolyContracts.BusinessLogicsContracts;
using KnowledgePolyContracts.SearchModels;
using KnowledgePolyContracts.StoragesContract;
using KnowledgePolyContracts.ViewModels;

namespace BusinessLogic
{
    public class AnswerLogic : IAnswerLogic
    {
        private readonly IAnswerStorage _answerStorage;
        public AnswerLogic(IAnswerStorage answerStorage)
        {
            _answerStorage = answerStorage;
        }
        public AnswerViewModel? ReadElement(AnswerSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            var element = _answerStorage.GetElement(model);
            if (element == null)
            {
                return null;
            }
            return element;
        }

        public List<AnswerViewModel>? ReadList(AnswerSearchModel? model)
        {
            var list = (model == null) ? _answerStorage.GetFullList() : _answerStorage.GetFilteredList(model);
            if (list == null)
            {
                return null;
            }
            return list;
        }
    }
}