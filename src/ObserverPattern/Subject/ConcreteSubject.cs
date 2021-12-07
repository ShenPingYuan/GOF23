using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    public class ConcreteSubject:AbstractSubject
    {
        private string subjectState;
        //The state of the observed
        public string SubjectState {
            get=>subjectState;
            set
            {
                subjectState = value;
                this.Notify();
            }
        }

    }
}
