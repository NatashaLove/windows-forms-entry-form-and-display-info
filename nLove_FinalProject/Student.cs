using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_FinalProject
{
    public class Student : Person , ITalkable
    {
        private string _major;
        private string _level;

        private readonly string _studentID;

        //have to have {} - because t's a method and needs body/ definition - even empty
        public Student() : this("student", 0) { }

        //Student constructor- calls the base constructor from Person
        public Student(string name, int age) : base(name, age)
        {

            _studentID = "S" + (_id+ 1000000).ToString();

        }

        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string StudentID
        {
            get { return _studentID; }
            
        }
        public string Talk() {
            // {0,25} - 0 - the position, 25- how many characters
            return String.Format("My name is :{0} , I'm Level: {1}.", Name, Level);
        }
        public override string DisplayInformation()
        {// {0,25} - 0 - the position, 25- how many characters
            return String.Format("Student: {0} | Name:{1} | Age: {2} \n Level : {3} | Major: {4}.", StudentID, Name, Age, Level, Major);
        }
    }
    }
