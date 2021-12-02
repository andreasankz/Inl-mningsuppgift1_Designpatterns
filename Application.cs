using Design_Patterns_Assignment.Decorator.DecoratorApp;
using Design_Patterns_Assignment.Observer.Program;
using Design_Patterns_Assignment.Repository.RepositoryData;
using Design_Patterns_Assignment.Strategy.StrategyApp;
using System;

namespace Design_Patterns_Assignment
{
    public class Application : IApplication
    {
        private readonly IObserverApp ObserverApp;
        private readonly IRepositoryApp RepositoryApp;
        private readonly IStrategyApplication StrategyApp;
        private readonly IDecoratorApplication DecoratorApp;

        public Application(IObserverApp observerApp, IRepositoryApp repositoryApp, IStrategyApplication strategyApp, IDecoratorApplication decoratorApp)
        {
            ObserverApp = observerApp;
            RepositoryApp = repositoryApp;
            StrategyApp = strategyApp;
            DecoratorApp = decoratorApp;
        }

        public void Run()
        {
            // Here is all the programs



            //ObserverApp.ObserverApplication();
            //RepositoryApp.RepositoryApplication();
            //StrategyApp.StrategyProgram();
            DecoratorApp.DecoratorProgram();
        }
    }
}