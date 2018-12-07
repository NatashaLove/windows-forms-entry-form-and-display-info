using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_FinalProject
{
    class EmptyNameException : Exception
    {
        private static string _msg = "Name cannot be empty.";
        //EmptyName.. - calls constructor of base (Exception)
        public EmptyNameException() : base(_msg) { }
    }
}
