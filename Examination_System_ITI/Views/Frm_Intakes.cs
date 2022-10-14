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
    public partial class Frm_Intakes : Form
    {
        Intake intake;
        IList<Intake> Intakes;
        public Frm_Intakes()
        {
            InitializeComponent();
            intake = new Intake();
            Intakes = new List<Intake>();
        }

        private void Frm_Intakes_Load(object sender, EventArgs e)
        {
            grBoxIntakeInfo.Visible = false;
            dateTimePicker_SDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString().ToString());
            dateTimePicker_EndDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString().ToString());
            var list = Track.GetAllTracks().ToList();
            foreach (var item in list)
            {
                tracksList.Items.Add(item);
            }
            tracksList.DisplayMember = "Name";
            tracksList.ValueMember = "Id";
            listBox_AddedTracksList.Items.Clear();
            listBox_AddedTracksList.DisplayMember = "Name";
            listBox_AddedTracksList.ValueMember = "Id";
        }

        private void btn_AddTrack_Click(object sender, EventArgs e)
        {
            AddRemoveTracks(tracksList, listBox_AddedTracksList);
        }

        private void btn_RemoveTrack_Click(object sender, EventArgs e)
        {
            AddRemoveTracks(listBox_AddedTracksList, tracksList);
        }

        #region Methods

        public void AddRemoveTracks(ListBox from, ListBox to)
        {
            var selectedTrack = from.SelectedItem;
            if (selectedTrack is null)
                return;

            int index = from.SelectedIndex;
            from.Items.RemoveAt(index);
            to.Items.Add(selectedTrack);
            if (index >= from.Items.Count) index--;
            from.SelectedIndex = index;
        }

        public void clear()
        {
            Txt_Id.Text = Txt_Name.Text = String.Empty;
            comBox_Branch.SelectedIndex = -1;
            dateTimePicker_SDate.Value = Convert.ToDateTime( DateTime.Now.ToLongDateString().ToString());
            dateTimePicker_EndDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString().ToString());
        }

        public void FillDataGridView()
        {
            foreach (var intake in Intakes)
            {
                dgvIntakes.Rows.Add(
                                new object[]
                                {
                                    intake.Id,
                                    intake.Name,
                                    intake.Branch.Name,
                                    intake.Start_Date,
                                    intake.End_Date,
                                });
            }
        }
        #endregion

        private void btnAddIntake_Click(object sender, EventArgs e)
        {
            grBoxIntakeInfo.Visible = true;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            intake.Name = Txt_Name.Text;
            intake.Start_Date = dateTimePicker_SDate.Value;
            intake.End_Date = dateTimePicker_EndDate.Value;
            intake.Id = Convert.ToInt32(Txt_Id.Text);
            intake.Branch = (Branch)comBox_Branch.SelectedItem;
            foreach (var item in listBox_AddedTracksList.Items)
                intake.Tracks.Add(item as Track);
            Intake.AddIntake(intake);
            Intakes.Clear();
            Intakes = Intake.GetAllInataks();
            FillDataGridView();
            dgvIntakes.Refresh();
            if (Intake.IsSuccessful)
                MessageBox.Show(Intake.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Intake.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grBoxIntakeInfo.Visible = false;
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            if(Txt_Search.Text != string.Empty)
            {
                Intakes.Clear();
                Intakes = Intake.GetIntakesByValue(Txt_Search.Text);
                FillDataGridView();
                dgvIntakes.Refresh();
            }
            else
            {
                Intakes.Clear();
                Intakes = Intake.GetAllInataks();
                FillDataGridView();
                dgvIntakes.Refresh();
            }
        }

        private void Frm_Intakes_Shown(object sender, EventArgs e)
        {
            Intakes.Clear();
            Intakes = Intake.GetAllInataks();
            FillDataGridView();
            dgvIntakes.Refresh();
        }
    }
}
