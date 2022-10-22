using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System_ITI.Views
{
    public partial class QuestionsFrmcs : Form
    {
        enum QuestionType { Choose = 0, True_False = 1, Text = 2}
        enum TrueFalse  { True = 0, False = 1}
        Context _context;
        Question_Bank _bank;
        Course course;
        public QuestionsFrmcs()
        {
            InitializeComponent();
            _context = new Context();
            _bank = new Question_Bank();
            course = new Course();
        }

        private void QuestionsFrmcs_Load(object sender, EventArgs e)
        {
            pnlCorrectTxt.Visible = false;
            pnl_Options.Visible = false;
            Txt_Id.Enabled = false;
            comBox_Courses.DataSource = _context.Courses.Where(C => C.Instructor.Id == User.CurrentUser.Id).ToList();
            comBox_Type.DataSource = Enum.GetValues(typeof(QuestionType));
            comBox_Courses.DisplayMember = "Name";
            comBox_Courses.ValueMember = "Id";
        }

        private void comBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionType questionType = (QuestionType)comBox_Type.SelectedItem;
            if(questionType == QuestionType.Choose)
            {
                pnl_Options.Visible = true;
                pnlCorrectTxt.Visible= false;
                pnl_CorrectCoose.Visible = true;
            }
            else if(questionType == QuestionType.True_False)
            {
                pnl_Options.Visible = false;
                pnl_CorrectCoose.Visible = true;
                comBox_CorrectOption.DataSource = Enum.GetValues(typeof(TrueFalse));
            }
            else
            {
                pnl_CorrectCoose.Visible = false;
                pnl_Options.Visible=false;
                pnlCorrectTxt.Visible = true;
            }
        }

        private void btnSaveOptions_Click(object sender, EventArgs e)
        {
            comBox_CorrectOption.Items.Clear();
            comBox_CorrectOption.Items.Add(txt_OptionA.Text);
            comBox_CorrectOption.Items.Add(txt_optionB.Text);
            comBox_CorrectOption.Items.Add(txt_OptionC.Text);
            comBox_CorrectOption.Items.Add(txt_optionD.Text);
            comBox_CorrectOption.Refresh();
        }

        private void btnUpdateLast_Click(object sender, EventArgs e)
        {
            txt_OptionA.Text = comBox_CorrectOption.Items[0].ToString();
            txt_optionB.Text = comBox_CorrectOption.Items[1].ToString();
            txt_OptionC.Text = comBox_CorrectOption.Items[2].ToString();
            txt_optionD.Text = comBox_CorrectOption.Items[3].ToString();
            comBox_CorrectOption.Items.Clear();
        }

        private void Btn_RefreshOptions_Click(object sender, EventArgs e)
        {
            txt_OptionA.Text = txt_optionB.Text = txt_OptionC.Text = txt_optionD.Text = String.Empty;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            int courseId = (int)comBox_Courses.SelectedValue;
            course = _context.Courses.FirstOrDefault(C => C.Id == courseId);
            MessageBox.Show(course.Description);
            if((QuestionType)comBox_Type.SelectedItem == QuestionType.Choose)
            {
                _bank.Id =int.Parse(Txt_Id.Text);
                _bank.Body = Txt_Body.Text;
                _bank.Course = course;
                _bank.Type = (int)comBox_Type.SelectedItem;
                _bank.Correct_Answer = comBox_CorrectOption.SelectedItem.ToString();
                _bank.Question_Option = new Question_Option 
                                            { 
                                                Op_1 = txt_OptionA.Text, Op_2 = txt_optionB.Text,
                                                Op_3 = txt_OptionC.Text, Op_4 = txt_optionD.Text 
                                            };
                try
                {
                    if (_bank.Body is null)
                        MessageBox.Show("Question Body Is Required!");
                    else if (_bank.Type == -1)
                        MessageBox.Show("Please Select Question Type!");
                    else if (_bank.Course is null)
                        MessageBox.Show("Please Select a Course!");
                    else if (_bank.Question_Option.Op_1 is null || _bank.Question_Option.Op_2 is null
                             || _bank.Question_Option.Op_3 is null || _bank.Question_Option.Op_4 is null)
                        MessageBox.Show("Options Cant't Be Empty!");
                    else
                    {
                        _context.Questions.Add(_bank);
                        _context.SaveChanges();
                        MessageBox.Show("Added Successfuly!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if ((QuestionType)comBox_Type.SelectedItem == QuestionType.True_False)
            {
                _bank.Id = int.Parse(Txt_Id.Text);
                _bank.Body = Txt_Body.Text;
                _bank.Course = course;
                _bank.Type = (int)comBox_Type.SelectedItem;
                _bank.Correct_Answer = comBox_CorrectOption.SelectedItem.ToString();
                try
                {
                    if (_bank.Body is null)
                        MessageBox.Show("Question Body Is Required!");
                    else if (_bank.Type == -1)
                        MessageBox.Show("Please Select Question Type!");
                    else if (_bank.Course is null)
                        MessageBox.Show("Please Select a Course!");
                    else
                    {
                        _context.Questions.Add(_bank);
                        _context.SaveChanges();
                        MessageBox.Show("Added Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                _bank.Body = Txt_Body.Text;
                _bank.Type = (int)comBox_Type.SelectedItem;
                _bank.Correct_Answer = txt_correctTxt.Text.Trim();
                _bank.Course = course;
                try
                {
                    if (_bank.Body is null)
                        MessageBox.Show("Question Body Is Required!");
                    else if (_bank.Type == -1)
                        MessageBox.Show("Please Select Question Type!");
                    else if (_bank.Course is null)
                        MessageBox.Show("Please Select a Course!");
                    else
                    {
                        _context.Questions.Add(_bank);
                        _context.SaveChanges();
                        MessageBox.Show("Added Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {

        }
    }
}
