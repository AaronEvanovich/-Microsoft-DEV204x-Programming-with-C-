﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private string _city;

        public string FirstName 
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        { 
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
    }
}
