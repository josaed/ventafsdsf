using System;

namespace Wikipedia.Patterns.Strategy
{
    // MainApp Test para aplicacion
    class MainApp
    {
        static void Main()
        {
            Context context;

            // Tres contextos con diferentes estrategias
            context = new Context(new ConcreteStrategyA());
            context.Execute();

            context = new Context(new ConcreteStrategyB());
            context.Execute();

            context = new Context(new ConcreteStrategyC());
            context.Execute();

        }
    }

    interface IStrategy
    {
        void Execute();
    }

    // Implementa el algoritmo usando el patron estrategia
    class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyA.Execute()");
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyB.Execute()");
        }
    }

    class ConcreteStrategyC : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyC.Execute()");
        }
    }

    // Contiene un objeto ConcreteStrategy y mantiene una referencia a un objeto Strategy
    class Context
    {
        IStrategy strategy;

        // Constructor
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Execute()
        {
            strategy.Execute();
        }
    }
}