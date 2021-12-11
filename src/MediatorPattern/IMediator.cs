using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IMediator
    {
        void Send(string message,Colleague colleague);
    }
}
