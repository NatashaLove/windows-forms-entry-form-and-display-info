using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_FinalProject
{
    class AgeBelowZeroException : Exception
    {
        private static string _msg = "Age cannot be below zero.";
        //AgeBelowZeroWxception - calls constructor of base (Exception)
        public AgeBelowZeroException() : base(_msg) { }

    }
}
