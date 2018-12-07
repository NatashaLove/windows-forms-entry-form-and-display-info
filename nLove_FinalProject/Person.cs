using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_FinalProject
{
   public abstract class Person
    {
        private string _name;
        private int _age;

        protected static int _id = 0;

        //this- calls the custom constructor from this class and sends info into empty constructor (in case it is called)
        public Person() : this("", 0) { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            _id++;
        }

        // public properties are with Capital letter
        public string Name
        {
            get { return _name; }
            // set { _name = value; }

                //setter throws an exception(custom-created) - if the value="".
            set {
                if (value=="")
                {
                    _name = "";
                    EmptyNameException ex = new EmptyNameException();
                    throw (ex);
                }
                else
                {
                    _name = value;
               
                }
            }
        }

  //VALUE is taken from the setter

        public int Age
        {
            get { return _age; }
            // set { _age = (value >= 0) ? value : 0; }

            set
            {
                if (value < 0)
                {
                    _age = 0;
                    AgeBelowZeroException ex = new AgeBelowZeroException();
                    throw (ex);
                }
                else
                {
                    _age = value;

                }
            }

        }
        
        // in abstract methods (has to be in abstract class) - no definition in the parent abstract class
        public abstract string DisplayInformation();

    }
}
