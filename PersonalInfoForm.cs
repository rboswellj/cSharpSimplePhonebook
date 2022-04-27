using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*  
    Robert Johnson
    CIT 243
    Info 6
 */

namespace PersonalInfoGui
{
    public partial class PersonalInfoForm : Form
    {
        public static string fileName = "infoCollection.txt";
        private static List<Person> readList = Helpers.ReadFile(fileName);
        private static List<Person> people = new List<Person>(readList);
        public PersonalInfoForm()
        {
            InitializeComponent();
            PopulateListBox(people);
            cmbSearch.SelectedIndex = 1;
        }

        private void PopulateListBox(List<Person> list)
        {
            foreach (Person p in list)
            {
                directoryListBox.Items.Add(p.FullName);
            }
        }

        private void Search(List<Person> fullList, string category, string searchString)
        {
            List<Person> resultList = new List<Person>();
            foreach (Person p in fullList) 
            {
                if (category == "Last Name")
                {
                    if (p.Last.ToLower() == searchString.ToLower())
                    {
                        resultList.Add(p);
                    }
                }
                else if (category == "First Name")
                {
                    if (p.First.ToLower() == searchString.ToLower())
                    {
                        resultList.Add(p);
                    }
                }
                else if (category == "Phone Number")
                {
                    if (Helpers.ConvertPhone(p.Phone) == Helpers.ConvertPhone(searchString))
                    {
                        resultList.Add(p);
                    }
                }
                else if (category == "Email")
                {
                    if (p.Email.ToLower() == searchString.ToLower())
                    {
                        resultList.Add(p);
                    }
                }
            }
            if (resultList.Count > 0)
            {
                directoryListBox.Items.Clear();
                PopulateListBox(resultList);
                directoryListBox.ClearSelected();
            } 
            else
            {
                MessageBox.Show("No Results");
                directoryListBox.Items.Clear();
                PopulateListBox(people);
                directoryListBox.ClearSelected();
            }
        }

        private void DirectoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (directoryListBox.SelectedItem != null)
            {
                /*
                When the name is selected in the list box
                The fields in the input form are populated
                with the info from the Person object with
                the same FullName property.

                 */
                Person selected = people.FirstOrDefault(
                    p => p.FullName == directoryListBox.SelectedItem.ToString());
                if (selected != null)
                {
                    firstInBox.Text = selected.First;
                    lastInBox.Text = selected.Last;
                    phoneInBox.Text = selected.Phone;
                    emailInBox.Text = selected.Email;
                    if (selected.Middle != "")
                    {
                        middleInBox.Text = selected.Middle;
                    }
                    else
                    {
                        middleInBox.Text = null;
                    }
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {

            string[] inputFields = { "firstIn", "lastIn", "phoneIn", "emailIn" };
            string convertedPhone = Helpers.ConvertPhone(phoneInBox.Text);
            
            if (NullField(inputFields))
            {
                foreach (string field in inputFields)
                {
                    if (this.Controls[field + "Box"].Text == null)
                    {
                        MarkNull(field);
                    }
                }
            }
            else if (convertedPhone.Length != 10)
            {
                ResetDefaultColors();
                phoneInLabel.Text = "Enter Valid Phone Number";
                MarkNull("phoneIn");
            }
            else if (!Helpers.IsValidEmail(emailInBox.Text))
            {
                ResetDefaultColors();
                emailInLabel.Text = "Enter a valid email";
                MarkNull("emailIn");
            }
            else
            {
                if (directoryListBox.SelectedIndex == -1)
                {
                    ResetDefaultColors();
                    Person toAdd = new Person(
                        firstInBox.Text,
                        lastInBox.Text,
                        convertedPhone,
                        emailInBox.Text,
                        middleInBox.Text);
                    Helpers.WriteToFile(toAdd, fileName);
                    directoryListBox.Items.Add(toAdd.FullName);
                    directoryListBox.ClearSelected();
                }
                else
                {
                    if(directoryListBox.SelectedItem != null)
                    {
                        Person foundPerson = people.FirstOrDefault(
                    p => p.FullName == directoryListBox.SelectedItem.ToString());

                        ResetDefaultColors();
                        if (foundPerson != null)
                        {
                            foundPerson.First = firstInBox.Text;
                            if (middleInBox.Text != "")
                            {
                                foundPerson.Middle = middleInBox.Text;
                            }
                            foundPerson.Last = lastInBox.Text;
                            foundPerson.Phone = convertedPhone;
                            foundPerson.Email = emailInBox.Text;
                            directoryListBox.ClearSelected();
                            Helpers.OverwriteFile(people, fileName);
                            directoryListBox.Items.Clear();
                            PopulateListBox(people);
                        }

                    }
                }
            }
        }

        private bool NullField(string[] arr)
        {
            ResetDefaultColors();
            foreach (string field in arr)
            {
                if (this.Controls[field + "Box"].Text == "")
                {
                    MarkNull(field);
                    return true;
                }
            }
            return false;

        }

        private void MarkNull(string field)
        {
            Control textField = this.Controls[field + "Box"];
            textField.ForeColor = Color.Red;
            Control label = this.Controls[field + "Label"];
            label.ForeColor = Color.Red;
        }

        private void ResetDefaultColors()
        {
            string[] arr = { "firstIn", "lastIn", "phoneIn", "emailIn" };
            foreach (string field in arr)
            {
                this.Controls[field + "Box"].ForeColor = Color.Black;
                this.Controls[field + "Label"].ForeColor = Color.Black;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(directoryListBox.SelectedIndex != -1)
            {
                Person foundPerson = people.FirstOrDefault(
                    p => p.FullName == directoryListBox.SelectedItem.ToString());
                if(foundPerson != null)
                {
                    people.Remove(foundPerson);
                    Helpers.OverwriteFile(people, fileName);
                    directoryListBox.Items.Clear();
                    PopulateListBox(people);
                    directoryListBox.ClearSelected();
                }
            }

        }

        private void ClearSelectionButton_Click(object sender, EventArgs e)
        {
            
            directoryListBox.ClearSelected();
            string[] arr = { "firstIn", "middleIn", "lastIn", "phoneIn", "emailIn" };
            foreach (string field in arr)
            {
                this.Controls[field + "Box"].Text = "";
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string cat = cmbSearch.Text;
            string search = txtSearch.Text;
            Search(people, cat, search);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            directoryListBox.Items.Clear();
            PopulateListBox(people);
            directoryListBox.ClearSelected();
        }
    }
}
