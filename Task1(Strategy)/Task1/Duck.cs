using System;
using System.Collections.Generic;
using System.Text;
using Task1.Swim;

namespace Task1
{
    public abstract class Duck
    {
        private protected IFlyBehavior _flyBehavior;
        private protected IQuackBehavior _quackBehavior;
        private protected ISwimable _swimable;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimable swimable)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
            _swimable = swimable;
        }
        public virtual void Display() 
        {
            _flyBehavior.Fly();
            _quackBehavior.Quack();
            _swimable.Swim();
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            _swimable.Swim();
        }

        public void Dead()
        {
                Console.WriteLine("Уточка мертва");
                _flyBehavior = new NoFly();
                _quackBehavior = new NoQuack();
                _swimable = new NotSwimable();
        }
    }
}
