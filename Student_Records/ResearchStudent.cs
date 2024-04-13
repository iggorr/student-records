using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_40125689
{
    /* ResearchStudent.cs
    * This class is used to store and manipulate data about Research students. It inherits from the Student class.
    *
    * Written by Igors Ahmetovs 22/10/15
    */
    class ResearchStudent : Student
    {
        // additional private properties
        private string topic;
        private string supervisor;


        public ResearchStudent()  // default construct that takes no arguments and sets the Course value to "PhD"
        {
            Course = "PhD";
        }

        public string Topic  // property for manipulating topic. Validating that the string passed is not empty
        {
            get { return topic; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Topic field is blank!");
                }
                topic = value;
            }
        }

        public string Supervisor  // property for manipulating supervisor. Validating that the string passed is not empty
        {
            get { return supervisor; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Supervisor field is blank!");
                }
                supervisor = value;
            }
        }

        public string Award()  // the method determines the award of the student, returning a string
        {
            string award = "";

            if (Level == 4)
            {
                award = "Doctor of Philosophy";
            }
            return award;
        }

    }
}
