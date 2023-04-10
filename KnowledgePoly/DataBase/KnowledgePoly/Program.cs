using BusinessLogic;
using KnowledgePolyContracts;
using KnowledgePolyContracts.BusinessLogicsContracts;
using KnowledgePolyContracts.StoragesContract;
using KnowledgePolyDataBaseImplement.Implements;
using Microsoft.Extensions.DependencyInjection;

namespace KnowledgePoly
{
    internal static class Program
    {
        private static ServiceProvider? _serviceProvider;
        public static ServiceProvider? ServiceProvider => _serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();

            Application.Run(_serviceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<IQuestionStorage, QuestionStorage>();
            services.AddTransient<IAnswerStorage, AnswerStorage>();

            services.AddTransient<IAnswerLogic, AnswerLogic>();
            services.AddTransient<IQuestionLogic, QuestionLogic>();
            services.AddTransient<Form1>();
        }
    }
}