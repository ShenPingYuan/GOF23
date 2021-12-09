using StatePattern.States;
using System;

namespace StatePattern
{
    public class Context
    {
        private IState state;
        public IState State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine($"当前状态：{state.GetType().Name}");
            }
        }
        public Context(IState state)
        {
            this.state = state;
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}
