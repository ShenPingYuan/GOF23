using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";
            originator.Show();//On

            Caretaker caretaker = new Caretaker();
            caretaker.memento = originator.CreateMemento();

            originator.State = "Off";
            originator.Show();//Off

            originator.SetMemento(caretaker.memento);
            originator.Show();//On
        }
    }
}
