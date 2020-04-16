using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceViewer
{
    class Person
    {
        private string _Name;
        private string _Age;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public Person(string iName, string iAge)
        {
            this._Name = iName;
            this._Age = iAge;
        }
    }
}
