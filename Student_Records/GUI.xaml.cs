using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cw_40125689
{
    /* GUI.xaml.cs
    * This is the main window of the application. 
    * Allows the user to create an instance of the Student class, 
    * view and modify the properties of the instance, 
    * and call out the methods of the Student class.
    *
    * Written by Igors Ahmetovs 17/10/15
    * exceptions added 18/10/15
    * functionality of btnAdvance added 18/10/15
    * functionality of btnAward added 19/10/15
    * CheckIfEntered() method added 19/10/15
    * CheckIfResearch() method added 22/10/15
    * Form modified 22/10/15
    */
    public partial class MainWindow : Window
    {
        Student theStudent;  // creating an object reference of class Student
        ResearchStudent rStudent;  // creating an object reference of class ResearchStudent
        bool lastRecordResearch;  // declaring a bool type variable that will show whether the last entered object was a Student or a Research Student

        public MainWindow()
        {
            InitializeComponent();
            theStudent = new Student();  // creating a new object of class Student
            rStudent = new ResearchStudent();  // creating a new object of class ResearchStudent
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)  // takes the values in the text boxes to update 
                                                                     // the corresponding Student or ResearchStudent class properties, 
                                                                     // converting the strings from the text boxes to the same type as class properties:
                                                                     // int or DateTime, if required
        {
            if (CheckIfResearch())  // checking whether the user inputs data for Student or ResearchStudent. If yes, the following code is executed:
            {
                // using exceptions to validate the data entered by the user

                // setting the FirstName property of the ResearchStudent object
                try
                {
                    rStudent.FirstName = txtFirstName.Text;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

                // setting the MatriculationNumber property of the ResearchStudent object. Checking that the text field is not empty
                if (!String.IsNullOrWhiteSpace(txtMatricNumber.Text))
                {
                    try
                    {
                        rStudent.MatriculationNumber = Convert.ToInt32(txtMatricNumber.Text);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Matric Number field is blank!");
                }

                // setting the SecondName property of the ResearchStudent object
                try
                {
                    rStudent.SecondName = txtSecondName.Text;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

                // setting the DateOfBirth property of the ResearchStudent object. Checking that the text field is not empty
                if (!String.IsNullOrWhiteSpace(txtDateOfBirth.Text))
                {
                    try
                    {
                        rStudent.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Date of Birth field is blank!");
                }

                // setting the Level property of the ResearchStudent object. Checking that the text field is not empty
                if (!String.IsNullOrWhiteSpace(txtLevel.Text))
                {
                    try
                    {
                        rStudent.Level = Convert.ToInt32(txtLevel.Text);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Level field is blank!");
                }

                // setting the Credits property of the ResearchStudent object. Checking that the text field is not empty
                if (!String.IsNullOrWhiteSpace(txtCredits.Text))
                {
                    try
                    {
                        rStudent.Credits = Convert.ToInt32(txtCredits.Text);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Credits field is blank!");
                }

                // setting the Topic property of the ResearchStudent object
                try
                {
                    rStudent.Topic = txtTopic.Text;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

                // setting the Supervisor property of the ResearchStudent object
                try
                {
                    rStudent.Supervisor = txtSupervisor.Text;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

            }

            else  // if the user has input data for Student object:
            {

                // using exceptions to validate the data entered by the user

                // setting the FirstName property of the Student object
                try
                {
                    theStudent.FirstName = txtFirstName.Text;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

                // setting the MatriculationNumber property of the Student object. Checking that the text field is not empty
                if (!String.IsNullOrWhiteSpace(txtMatricNumber.Text))
                {
                    try
                    {
                        theStudent.MatriculationNumber = Convert.ToInt32(txtMatricNumber.Text);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Matric Number field is blank!");
                }

                // setting the SecondName property of the Student object
                try
                {
                    theStudent.SecondName = txtSecondName.Text;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

                // setting the DateOfBirth property of the Student object. Checking that the text field is not empty
                if (!String.IsNullOrWhiteSpace(txtDateOfBirth.Text))
                {
                    try
                    {
                        theStudent.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Date of Birth field is blank!");
                }

                // setting the Course property of the Student object
                try
                {
                    theStudent.Course = txtCourse.Text;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

                // setting the Level property of the Student object. Checking that the text field is not empty
                if (!String.IsNullOrWhiteSpace(txtLevel.Text))
                {
                    try
                    {
                        theStudent.Level = Convert.ToInt32(txtLevel.Text);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Level field is blank!");
                }

                // setting the Credits property of the Student object. Checking that the text field is not empty
                if (!String.IsNullOrWhiteSpace(txtCredits.Text))
                {
                    try
                    {
                        theStudent.Credits = Convert.ToInt32(txtCredits.Text);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Credits field is blank!");
                }
            }


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)  // removes the contents of the text boxes
        {
            txtFirstName.Text = String.Empty;
            txtSecondName.Text = String.Empty;
            txtDateOfBirth.Text = String.Empty;
            txtCourse.Text = String.Empty;
            txtMatricNumber.Text = String.Empty;
            txtLevel.Text = String.Empty;
            txtCredits.Text = String.Empty;
            txtTopic.Text = String.Empty;
            txtSupervisor.Text = String.Empty;
        }

        private void btnGet_Click(object sender, RoutedEventArgs e) // updates the text boxes according to the Student or ResearchStudent instance values,
                                                                    // changing the type to string, if required
        {
            if (CheckIfEntered())  // checking if there have been any student record at all
            {
                if (lastRecordResearch)  // the code is executed only when confirmed that the last entered data was for a ResearchStudent object
                {
                    txtFirstName.Text = rStudent.FirstName;
                    txtSecondName.Text = rStudent.SecondName;
                    txtDateOfBirth.Text = Convert.ToString(rStudent.DateOfBirth.ToShortDateString()); // using the ToShortDateString() method to hide the 
                                                                                                      // time value of a DateTime type variable
                    txtCourse.Text = rStudent.Course;
                    txtMatricNumber.Text = Convert.ToString(rStudent.MatriculationNumber);
                    txtLevel.Text = Convert.ToString(rStudent.Level);
                    txtCredits.Text = Convert.ToString(rStudent.Credits);
                    txtTopic.Text = rStudent.Topic;
                    txtSupervisor.Text = rStudent.Supervisor;
                }

                else  // if the data was for a Student object:
                {
                    txtFirstName.Text = theStudent.FirstName;
                    txtSecondName.Text = theStudent.SecondName;
                    txtDateOfBirth.Text = Convert.ToString(theStudent.DateOfBirth.ToShortDateString()); // using the ToShortDateString() method to hide the 
                                                                                                        // time value of a DateTime type variable
                    txtCourse.Text = theStudent.Course;
                    txtMatricNumber.Text = Convert.ToString(theStudent.MatriculationNumber);
                    txtLevel.Text = Convert.ToString(theStudent.Level);
                    txtCredits.Text = Convert.ToString(theStudent.Credits);
                }
            }

        }

        private void btnAdvance_Click(object sender, RoutedEventArgs e) // calling the Advance() method
        {
            if (CheckIfEntered())
            {
                if (lastRecordResearch)  // checking if the last entry was for a Research student
                {
                    try
                    {
                        rStudent.Advance();
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                    txtLevel.Text = Convert.ToString(rStudent.Level);
                }
                else  // if not, executing the Advance() method for Student object
                {
                    try
                    {
                        theStudent.Advance();
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                    txtLevel.Text = Convert.ToString(theStudent.Level);
                }
            }
        }

        private void btnAward_Click(object sender, RoutedEventArgs e) // calling the Award() method, checking if the award is possible for the student.
                                                                      // The window will be displayed modally
        {
            if (CheckIfEntered())
            {
                if (lastRecordResearch)  // if the current entry is a ResearchStudent object
                {
                    if (!String.IsNullOrWhiteSpace(rStudent.Award()))  // checking if the award is possible for the ResearchStudent
                    {
                        // passing the ResearchStudent instance values to the new Award window

                        string matricN = Convert.ToString(rStudent.MatriculationNumber);
                        string secondN = rStudent.SecondName;
                        string firstN = rStudent.FirstName;
                        string course = rStudent.Course;
                        string level = Convert.ToString(rStudent.Level);
                        string award = rStudent.Award();

                        Award newWin = new Award(matricN, secondN, firstN, course, level, award);
                        newWin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Award is not possible, student must be at level 4!");
                    }
                }

                else
                {
                    if (!String.IsNullOrWhiteSpace(theStudent.Award()))  // checking if the award is possible for the Student
                    {
                        // passing the Student instance values to the new Award window

                        string matricN = Convert.ToString(theStudent.MatriculationNumber);
                        string secondN = theStudent.SecondName;
                        string firstN = theStudent.FirstName;
                        string course = theStudent.Course;
                        string level = Convert.ToString(theStudent.Level);
                        string award = theStudent.Award();

                        Award newWin = new Award(matricN, secondN, firstN, course, level, award);
                        newWin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Award is not possible!");
                    }
                }
            }
        }

        private bool CheckIfEntered()  // the method checks whether the name value of the Student or ResearchStudent object is blank to determine 
                                       // if the user has entered
                                       // the data before trying to obtain / manipulate it
        {
            bool result = true;
            if (String.IsNullOrWhiteSpace(theStudent.FirstName) && String.IsNullOrWhiteSpace(rStudent.FirstName))                                                                       
            {
                MessageBox.Show("No student record yet!");
                result = false;
            }
            return result;
        }

        private bool CheckIfResearch()  // the method checks whether one of the ResearchStudent specific fields were filled in by the user
        {
            bool result = true;
            lastRecordResearch = true;
            if (String.IsNullOrWhiteSpace(txtTopic.Text) && String.IsNullOrWhiteSpace(txtSupervisor.Text))
            {
                result = false;
                lastRecordResearch = false;
            }
            return result;
        }
    }
}
