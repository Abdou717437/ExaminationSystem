using Models;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System_ITI.Views
{
    public partial class Frm_Tracks : Form
    {
        Instructor manager;
        IList<Course> SelectedCourses;
        Context context;
        public DataGridView Tracks_Dgv
        {
            get { return dgvTracks; }
            set { dgvTracks = value; }
        }

        public ComboBox Manager_Combox
        {
            get { return comBox_Manager; }
            set { comBox_Manager = value; }
        }
        public static ComboBox Instructors_ComBox
        {
            get { return Instructors_ComBox; }
            set { Instructors_ComBox = value; }
        }
        public Frm_Tracks()
        {
            InitializeComponent();
            manager = new Instructor();
            SelectedCourses = new List<Course>();
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            grBoxTrackInfo.Visible = true;
            
        }

        private void Frm_Tracks_Load(object sender, EventArgs e)
        {
            grBoxTrackInfo.Visible=false;
            //var list = Course.GetAllCourses().ToList();
            //foreach (var item in list)
            //{
            //    coursesList.Items.Add(item);
            //}
            coursesList.DisplayMember = "Name";
            coursesList.ValueMember = "Id";
            listBox_AddedCoursesList.Items.Clear();
            listBox_AddedCoursesList.DisplayMember = "Name";
            listBox_AddedCoursesList.ValueMember  = "Id";
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            int Manager_Id = 0;
            if (comBox_Manager.SelectedValue != null)
                Manager_Id = (int)comBox_Manager.SelectedValue;
            try
            {
                using (var context = new Context())
                {
                    
                    context.Instructors.Find(Manager_Id);
                    Track track = new Track()
                    {
                        Name = Txt_Name.Text,
                        Description = Txt_Desc.Text,
                        IsActive = toggleBtnActivateTrack.Checked,
                        Instructor = manager,
                    };

                    if (listBox_AddedCoursesList.Items.Count > 0)
                    {
                        
                        foreach (Course C in listBox_AddedCoursesList.Items)
                        {
                            var c = context.Courses.Find(C.Id);
                            c.Tracks.Add(track);

                            context.Courses.Attach(C);
                        }
                        context.Tracks.Add(track);
                        
                    }
                    else
                    {
                        MessageBox.Show("Select Some Courses For Track");
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Methods
       

        public void Clear()
        {
            Txt_Id.Text = Txt_Name.Text = Txt_Desc.Text = string.Empty;
            comBox_Manager.SelectedIndex = -1;
        }

        public void AddRemoveCourses(ListBox from, ListBox to)
        {
            var selectedCourse = from.SelectedItem;
            if (selectedCourse is null)
                return;

            int index = from.SelectedIndex;
            from.Items.RemoveAt(index);
            to.Items.Add(selectedCourse);
            if (index >= from.Items.Count) index--;
                from.SelectedIndex = index;
        }
        #endregion

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            AddRemoveCourses(coursesList, listBox_AddedCoursesList);
        }

        private void btn_RemoveCourse_Click(object sender, EventArgs e)
        {
            AddRemoveCourses(listBox_AddedCoursesList, coursesList);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grBoxTrackInfo.Visible = false;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Search.Text != string.Empty)
            {   
                Track.GetTracksByValue(Txt_Search.Text,this);
            }
            else
            {
                 Track.GetAllTracks(this);
            }
        }

        private void Frm_Tracks_Shown(object sender, EventArgs e)
        {
            Track.GetAllTracks(this);
            Track.GetTracksManagers(this);
        }
    }
}
