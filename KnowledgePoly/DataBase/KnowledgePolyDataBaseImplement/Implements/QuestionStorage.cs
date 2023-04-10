using KnowledgePolyContracts.SearchModels;
using KnowledgePolyContracts.StoragesContract;
using KnowledgePolyContracts.ViewModels;
using KnowledgePolyDataBaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace KnowledgePolyDataBaseImplement.Implements
{
    public class QuestionStorage : IQuestionStorage
    {
        public Tuple<QuestionViewModel,AnswerViewModel[]> GetElement(QuestionSearchModel model)
        {
            if (!model.Id.HasValue)
            {
                return new(null,null);
            }
            using var context = new KnowledgePolyDatabase();
            var question = context.Questions
                          .Include(x => x.Answers)
                          .FirstOrDefault(x => x.Id == model.Id)
                          ?.GetViewModel;
            return new Tuple<QuestionViewModel, AnswerViewModel[]>(question, question.QuestionAnswers.Select(x => (x as Answer).GetViewModel).ToArray());

        }

        public List<QuestionViewModel> GetFilteredList(QuestionSearchModel model)
        {
            return new();
        }

        public List<QuestionViewModel> GetFullList()
        {
            using var context = new KnowledgePolyDatabase();
            return context.Questions
                    .Include(x => x.Answers)
                    .Select(x => x.GetViewModel)
                    .ToList();
        }
    }
}