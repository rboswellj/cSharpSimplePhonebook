using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalInfoGui
{
    class Person
    {
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person(string firstName, string lastName, string phoneNum, string emailAddress, string middleName = null)
        {
            First = firstName;
            Middle = middleName;
            Last = lastName;
            Phone = phoneNum;
            Email = emailAddress;
        }
        public Person() 
        {
        }

        public string FullName
        {
            get 
            { 
                if (Middle != null)
                {
                    return First + " " + Middle + " " + Last;
                }
                return First + " " + Last; 
            }
        }

    }
}
