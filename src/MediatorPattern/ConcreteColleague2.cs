namespace MediatorPattern
{
    public class ConcreteColleague2: Colleague
    {
        public ConcreteColleague2(IMediator mediator) : base(mediator)
        {
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            System.Console.WriteLine("同事2得到消息：" + message);
        }
    }
}