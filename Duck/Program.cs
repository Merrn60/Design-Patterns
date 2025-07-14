using System;

namespace StrategyPattern
{
    // Behavior Interfaces
    public interface IFlyBehavior
    {
        void Fly();
    }

    public interface IQuackBehavior
    {
        void Quack();
    }

    // Fly Behaviors
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }

    // Quack Behaviors
    public class DefaultQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    // Base Duck Class
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior newFlyBehavior)
        {
            flyBehavior = newFlyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior newQuackBehavior)
        {
            quackBehavior = newQuackBehavior;
        }

        public abstract void Display();
    }

    // Specific Duck Type
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay(); // Initially, the duck can't fly.
            quackBehavior = new DefaultQuack(); // Default quacking behavior.
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }

    // Simulator Class
    public class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
            Duck modelDuck = new ModelDuck();

            modelDuck.Display();
            modelDuck.PerformFly(); // Output: I can't fly.
            modelDuck.PerformQuack(); // Output: Quack!

            // Change behavior at runtime
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly(); // Output: I'm flying with a rocket!

            Console.ReadLine(); // Keeps the console window open.
        }
    }
}
