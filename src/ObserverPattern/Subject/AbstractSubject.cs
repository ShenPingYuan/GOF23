using ObserverPattern.Observer;
using System.Collections.Generic;

namespace ObserverPattern.Subject
{
    public abstract class AbstractSubject
    {
        private IList<IObserver> observers = new List<IObserver>();

        //add observer
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        //remove observer
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }
        //notify
        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
