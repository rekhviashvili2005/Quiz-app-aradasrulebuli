using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_app_2
{
    public abstract class BaseClass
    {
        private static int _idCounter = 0;

        public int Id { get; private set; }

        protected BaseClass()
        {
            Id = +_idCounter++;
        }
    }

}
