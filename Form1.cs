// A5508
// Program 2
// Due: March 9, 2017
// CIS 199-01
// Description: This program contains the use of radio buttons to make a registration schedule.  The 4 radio buttons include:
// freshman, sophomore, junior, and senior.  The "Show Registration" button displays the date and the time that you regitser  
// classes for depending on what your class standing is and the first letter of your last name.





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //holds dates of possible registration dates
            const string date1 = "Wednesday, March 29th"; 
            const string date2 = "Thursday, March 30th";
            const string date3 = "Friday, March 31st";
            const string date4 = "Monday, April 3rd";
            const string date5 = "Tuesday, April 4th";
            const string date6 = "Wednesday, April 5th";

            //holds times for the registration dates
            const string time1 = "8:30 A.M.";
            const string time2 = "10:00 A.M.";
            const string time3 = "11:30 A.M.";
            const string time4 = "2:00 P.M.";
            const string time5 = "4:00 P.M.";

            string lastName = lastNameTextBox.Text; // lets last name textbox hold last name string
            char letter; // contains variable for first letter of last name
            string dateOfReg; // contains registration date


            if ((lastNameTextBox.TextLength > 0) && char.IsLetter(lastName[0]))
            {
                letter = lastName[0]; // reserved the first letter of the last name for variable 
                letter = char.ToUpper(letter); // first letter of last name is uppercase

                
                if (seniorRadioButton.Checked || juniorRadioButton.Checked)// If user selects senior or junior radio button
                {
                    if (seniorRadioButton.Checked)
                    {
                                            // use first date if senior radio button is clicked
                        dateOfReg = date1;
                    }
                    else
                    {
                                            // use second date if junior radio button is clicked
                        dateOfReg = date2;
                    }

                                            // If last name is between A-D, show registration date and time
                    if (letter <= 'D')
                    {
                        MessageBox.Show(dateOfReg + " at " + time3);
                    }

                                            // If last name is between E-I, show registration date and time
                    else if (letter <= 'I')
                    {
                        MessageBox.Show(dateOfReg + " at " + time4);
                    }

                                            // If last name is between F-O, show registration date and time
                    else if (letter <= 'O')
                    {
                        MessageBox.Show(dateOfReg + " at " + time5);
                    }

                                            // If last name is between P-S, show registration date and time
                    else if (letter <= 'S')
                    {
                        MessageBox.Show(dateOfReg + " at " + time1);
                    }

                                            // If last name is between T-Z, show registration date and time
                    else
                    {
                        MessageBox.Show(dateOfReg + " at " + time2);
                    }
                }


                
                if (sophomoreRadioButton.Checked || freshmanRadioButton.Checked)// If user selects sophomore or freshman radio button
                {
                    if (sophomoreRadioButton.Checked && (letter > 'B') && (letter <= 'O'))
                    {
                                            // if sophomore last name letter is greater than B and less than or equal to O,
                                            // use fourth date
                        dateOfReg = date4;
                    }
                    else if (sophomoreRadioButton.Checked)
                    {
                                            // use third date for all other sophomores
                        dateOfReg = date3;
                    }
                    else if (freshmanRadioButton.Checked && (letter > 'B') && (letter <= 'O'))
                    {
                                            // if freshman last name letter is greater than B and less than or equal to O,
                                            // use sixth date
                        dateOfReg = date6;
                    }
                    else
                    {
                                            
                        dateOfReg = date5;// use fifth date for all other freshman
                    }

                    if (letter <= 'B')
                    {
                                            
                        MessageBox.Show(dateOfReg + " at " + time5);  // display registration date for last names A-B
                    }
                    else if (letter <= 'D')
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time1);  // display registration date for last names C-D
                    }
                    else if (letter <= 'F')
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time2);  // display registration date for last names E-F
                    }
                    else if (letter <= 'I')
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time3);  // display registration date for last names G-I
                    }
                    else if (letter <= 'L')
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time4);  // display registration date for last names J-L
                    }
                    else if (letter <= 'O')
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time5);  // display registration date for last names M-O
                    }
                    else if (letter <= 'Q')
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time1);  // display registration date for last names P-Q
                    }
                    else if (letter <= 'S')
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time2);  // display registration date for last names R-S
                    }
                    else if (letter <= 'V')
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time3);  // display registration date for last names T-V
                    }
                    else
                    {
                        
                        MessageBox.Show(dateOfReg + " at " + time4);  // display registration date for last names W-Z
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid last name.");  // Enter valid last name 
            }
        }
            }

            


            
        }
    

