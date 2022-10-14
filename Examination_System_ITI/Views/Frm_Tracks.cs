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
    public partial class Frm_Tracks : Form
    {
        Track track;
        IList<Track> Tracks;
        public static ComboBox Instructors_ComBox
        {
            get { return Instructors_ComBox; }
            set { Instructors_ComBox = value; }
        }
        public Frm_Tracks()
        {
            InitializeComponent();
            track = new Track();
            Tracks = new List<Track>();
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            grBoxTrackInfo.Visible = true;
            
        }

        private void Frm_Tracks_Load(object sender, EventArgs e)
        {
            grBoxTrackInfo.Visible=false;
            var list = Course.GetAllCourses().ToList();
            foreach (var item in list)
            {
                coursesList.Items.Add(item);
            }
            comBox_Manager.Items.Clear();
            //Instructor.GetAllInstructors(this);
            comBox_Manager.DisplayMember = "User_Name";
            comBox_Manager.ValueMember = "Id";
            coursesList.DisplayMember = "Name";
            coursesList.ValueMember = "Id";
            listBox_AddedCoursesList.Items.Clear();
            listBox_AddedCoursesList.DisplayMember = "Name";
            listBox_AddedCoursesList.ValueMember  = "Id";
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            track.Name = Txt_Name.Text;
            track.Description= Txt_Desc.Text;
            track.IsActive = toggleBtnActivateTrack.Checked;
            track.Instructor = (Instructor)comBox_Manager.SelectedItem;
            track.Courses = listBox_AddedCoursesList.Items as IList<Course>;
            Track.AddTrack(track);
            Tracks.Clear();
            Tracks = Track.GetAllTracks();
            FillDataGridView();
            dgvTracks.Refresh();
            if (Track.IsSuccessful)
                MessageBox.Show(Track.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Track.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region Methods
        public void FillDataGridView()
        {
            foreach (var track in Tracks)
            {
                dgvTracks.Rows.Add(
                                new object[]
                                {
                                    track.Id,
                                    track.Name,
                                    track.Description,
                                    track.IsActive,
                                    track.Instructor.F_Name + " "+track.Instructor.L_Name,
                                });
            }
        }

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
                Tracks.Clear();
                Tracks = Track.GetTracksByValue(Txt_Search.Text);
                FillDataGridView();
                dgvTracks.Refresh();
            }
            else
            {
                Tracks.Clear();
                Tracks = Track.GetAllTracks();
                FillDataGridView();
                dgvTracks.Refresh();
            }
        }

        private void Frm_Tracks_Shown(object sender, EventArgs e)
        {
            Tracks.Clear();
            Tracks = Track.GetAllTracks();
            FillDataGridView();
            dgvTracks.Refresh();
        }
    }
}
