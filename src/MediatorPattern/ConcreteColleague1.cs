namespace MediatorPattern
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator mediator) : base(mediator)
        {
        }
        public void Send(string message)
        {
            mediator.Send(message,this);
        }
        public void Notify(string message)
        {
            System.Console.WriteLine("同事1得到消息："+message);
        }
    }
}