using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        public ConcreteColleague1 Colleague1 { set; get; }
        public ConcreteColleague2 Colleague2 { set; get; }
        public void Send(string message, Colleague colleague)
        {
            if(colleague == Colleague1)
            {
                Colleague2.Notify(message);
            }
            else
            {
                Colleague1.Notify(message);
            }
        }
    }
}
