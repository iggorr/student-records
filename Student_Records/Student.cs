using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_40125689
{
    /* Student.cs
    * This class stores the data entered by the user and contains methods to manipulate the data. 
    * The properties of the class are validated through exceptions.
    *
    * Written by Igors Ahmetovs 17/10/15
    * exceptions added 18/10/15
    * Advance() method added 18/10/15
    * Award() method added 19/10/15
    */
    class Student
    {
        //private properties
        private int matriculationNumber;
        private string firstName;
        private string secondName;
        private DateTime dateOfBirth;
        private string course;
        private int level;
        private int credits;

        public Student() // default constructor that takes no arguments
        {

        }

        public int MatriculationNumber  // property for manipulating matriculation number. Validating that the value is within the range
        {
            get { return matriculationNumber; }
            set
            {

                if (value<40000 || value>60000)
                {
                    throw new ArgumentException("Please enter a valid matriculation number ( between 40000 and 60000 )!");
                }
                matriculationNumber = value;
            }          
        }
        
        public string FirstName  // property for manipulating first name. Validating that the string passed is not empty
        {
            get { return firstName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name field is blank!");
                }
                firstName = value;
            }
        }

        public string SecondName  // property for manipulating second name. Validating that the string passed is not empty
        {
            get { return secondName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Second Name field is blank!");
                }
                secondName = value;
            }
        }

        public DateTime DateOfBirth  // property for manipulating date of birth. 
                                     // Validating whether the string is in the correct format to be converted to DateTime variable
        {
            get { return dateOfBirth.Date; }
            set { dateOfBirth = value; }
        }

        public string Course  // property for manipulating course. Validating that the string passed is not empty
        {
            get { return course; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course field is blank!");
                }
                course = value;
            }
        }

        public int Level  // property for manipulating level. Validating that the value is within the range
        {
            get { return level; }
            set
            {

                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("Please enter a valid level ( in the range 1 - 4 )!");
                }
                level = value;
            }
        }

        public int Credits  // property for manipulating credits. Validating that the value is within the range
        {
            get { return credits; }
            set
            {

                if (value < 0 || value > 480)
                {
                    throw new ArgumentException("Please enter a valid amount of credits ( in the range 0 - 480 )!");
                }
                credits = value;
            }
        }

        public void Advance()  // the method advances the student by 1 level, also checks whether there are sufficient credits
        {

            if (level == 1 && credits < 120)
            {
                throw new ArgumentException("Insufficient credits ( need at least 120 to advance to level 2 )!");
            }
            if (level == 2 && credits < 240)
            {
                throw new ArgumentException("Insufficient credits ( need at least 240 to advance to level 3 )!");
            }
            if (level == 3 && credits < 360)
            {
                throw new ArgumentException("Insufficient credits ( need at least 360 to advance to level 4 )!");
            }
            if (level == 4)
            {
                throw new ArgumentException("Student is already in the 4th year!");
            }
            level++;
        }

        public string Award()  // the method determines the award of the student, returning a string
        {
            string award = "";

            if (credits < 360)
            {
                award = "Certificate of Higher Education";
            }
            if (credits >=360 && credits <480)
            {
                award = "Degree";
            }
            if (credits == 480)
            {
                award = "Honours degree";
            }
            return award;
        }

    }
}
