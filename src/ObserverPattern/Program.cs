using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            new ConcreteObserver(subject, "X");
            new ConcreteObserver(subject, "Y");
            new ConcreteObserver(subject, "Z");
            subject.SubjectState = "ABC";
            subject.SubjectState = "hello";
        }
    }

}
