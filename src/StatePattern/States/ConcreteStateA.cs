namespace StatePattern.States
{
    internal class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
