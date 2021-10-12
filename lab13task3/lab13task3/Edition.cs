using System;
using System.Collections.Generic;
using System.Text;

namespace lab13task3
{
    abstract class Edition
    {
        public string name { get; set; }
        public string author { get; set; }
        public abstract void Info();

    }
}
