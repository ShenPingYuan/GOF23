using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    class ConcreteObserver : IObserver
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.name = name;
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine($"observer {name}'s new state is {observerState}");
        }
    }
}
