using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Save
    {
        //property
        public string Name { get; private set; }
        public string Summary { get; private set; }
        public string Actor { get; private set; }
        public string Assumption { get; private set; }
        public string Discription { get; private set; }
        public string Implementation { get; private set; }
        public string Result { get; set; }

        //Constructors
        public Save(string name, string summary, string actor, string assumption, string discription, string implementation, string result)
        {
            Name = name;
            Summary = summary;
            Actor = actor;
            Assumption = assumption;
            Discription = discription;
            Implementation = implementation;
            Result = result;
        }
    }
}
