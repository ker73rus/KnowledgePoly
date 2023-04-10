using KnowledgePolyContracts;
using KnowledgePolyContracts.SearchModels;
using KnowledgePolyContracts.StoragesContract;
using KnowledgePolyContracts.ViewModels;

namespace BusinessLogic
{
    public class QuestionLogic : IQuestionLogic
    {
        private readonly IQuestionStorage _questionStorage;
        public QuestionLogic(IQuestionStorage questionStorage)
        {
            _questionStorage = questionStorage;
        }
        public Tuple<QuestionViewModel, AnswerViewModel[]> ReadElement(QuestionSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            var element = _questionStorage.GetElement(model);
            if (element == null)
            {
                return null;
            }
            return element;
        }

        public List<QuestionViewModel>? ReadList(QuestionSearchModel? model)
        {
            var list = (model == null) ? _questionStorage.GetFullList() : _questionStorage.GetFilteredList(model);
            if (list == null)
            {
                return null;
            }
            return list;
        }
    }
}