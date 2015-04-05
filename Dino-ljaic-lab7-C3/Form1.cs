using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino_ljaic_lab7_C3
{
    public partial class Form1 : Form
    {
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //          AUTHORS: Michal, Dino, Sepideh            !!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        String natLang;
        String learnLang;
        String student;
        ArrayList students;
        //net.azurewebsites.lab7dms.WebServicesMultiplatform ws;
        net.azurewebsites.lab7mds.WebServicesMultiplatform webs;

        public Form1()
        {
            natLang = null;
            learnLang = null;
            student = null;
            students = null;
            InitializeComponent();

            txtboxNativeLang.Text = natLang;
            txtboxLearnLang.Text = learnLang;
            //ws = new net.azurewebsites.lab7dms.WebServicesMultiplatform();
            webs = new net.azurewebsites.lab7mds.WebServicesMultiplatform();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TESTING CODE
            //students = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{
            //    students.Add("Option " + i+", surname, name # id "+i);
            //}
            try
            {
                String test = webs.debugTest();
                students = new ArrayList(webs.GetAllUsers());
                students.Sort();
                studentListComboBox.DataSource = students;
                studentListComboBox.SelectedItem = null;
                setOperationSuccessViewerLabel(test);
            }
            catch (Exception ex)
            {
                setErrorOperationViewerLabel("Error occured: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createMultipleQuizesButton_Click(object sender, EventArgs e)
        {

        }

        private void setErrorOperationViewerLabel(string errorMessage)
        {
            operationViewerLabel.Text = "Operation Error " + errorMessage;
            operationViewerLabel.ForeColor = System.Drawing.Color.Red;
        }

        private void setOperationSuccessViewerLabel(string operationMessage)
        {
            operationViewerLabel.Text = "Operation Successfull " + operationMessage;
            operationViewerLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void createSingleQuizButton_Click(object sender, EventArgs e)
        {
            setOperationSuccessViewerLabel("Create Single Quiz Button Has Been Pressed");
            String Qword = txtboxQword.Text;
            if (student != null)
            {
                try
                {
                    ArrayList words = new ArrayList(webs.GetAllWords(natLang));
                    if (words.Contains(Qword))
                    {
                        webs.createOneQuiz(student, Qword);
                        setOperationSuccessViewerLabel("Single Quiz created");
                    }
                    else
                    {
                        setErrorOperationViewerLabel("Error. Requested word: " + Qword + " is not in the database.");
                    }

                }
                catch (Exception ex)
                {
                    setErrorOperationViewerLabel("Error occured: " + ex.Message);
                }
            }
            else
            {
                setErrorOperationViewerLabel("Error occured. Possibly student is not selected");
            }

        }

        private void createMultipleQuizesButtons_Click(object sender, EventArgs e)
        {
            setOperationSuccessViewerLabel("Create Multiple Quizes Button Has Been Pressed");
            int nbr = 0;
            if (stringValueIsNumeric(numberOfQuizesTextBox.Text) == true)
            {
                nbr = Convert.ToInt32(numberOfQuizesTextBox.Text);
                if (student != null)
                {
                    try
                    {
                        webs.createMultipleRandomQuizes(nbr, natLang, student);
                        setOperationSuccessViewerLabel(nbr+" quiz(es) has been created");
                    }
                    catch (Exception ex)
                    {
                        setErrorOperationViewerLabel("Error occured: " + ex.Message);
                    }
                }
                else
                {
                    setErrorOperationViewerLabel("Error occured. Possibly student is not selected");
                }

            }

        }

        private Boolean stringValueIsNumeric(string numericValue)
        {
            int nbr = 0;
            if (int.TryParse(numericValue, out nbr) == true)
            {
                return true;
            }
            else
            {
                setErrorOperationViewerLabel("The value you entered is NOT a number");
                return false;
            }
        }

        private void studentListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)studentListComboBox;

            String selectedStudent = (String)combobox.SelectedItem;
            if (selectedStudent != null)
            {
                //student = string.Concat(selectedStudent.TakeWhile((c) => c != ','));
                //student = string.Concat(selectedStudent.SkipWhile((c) => c != '#'));
                student = string.Concat(selectedStudent.SkipWhile((c) => c != '#'));
                this.student = student.Substring(1, student.Length - 1);
                setOperationSuccessViewerLabel(student);

                try
                {
                    natLang = webs.getNativeLanguage(student);
                    learnLang = webs.getLearningLanguage(student);
                    txtboxNativeLang.Text = natLang;
                    txtboxLearnLang.Text = learnLang;
                }
                catch (Exception ex)
                {
                    setErrorOperationViewerLabel("Error occured: " + ex.Message);
                }
            }
        }
    }
}
