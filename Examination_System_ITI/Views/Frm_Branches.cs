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
    public partial class Frm_Branches : Form
    {
        Instructor manager;
        public ComboBox Managers_comBox
        {
            get { return comBox_Manager; }
            set { comBox_Manager = value; }
        }

        public DataGridView Branches_Dgv
        {
            get { return dgvBranches; }
            set { dgvBranches = value; }
        }
        public Frm_Branches()
        {
            InitializeComponent();
            manager = new Instructor();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            int Manager_Id = 0;
            if (comBox_Manager.SelectedValue != null)
                Manager_Id = (int)comBox_Manager.SelectedValue;


            manager = Instructor.GetInstructor(Manager_Id);

            Track.AddTrack(new Track()
            {
                Id = int.Parse(Txt_Id.Text),
                Name = Txt_Name.Text,
                Description = Txt_Desc.Text,
                Instructor = manager,
            },null);

            Branch.GetAllBranches(this);
            if (Track.IsSuccessful)
                MessageBox.Show(Track.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Track.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Frm_Branches_Load(object sender, EventArgs e)
        {
            grBoxBranchInfo.Visible = false;
        }

        private void Frm_Branches_Shown(object sender, EventArgs e)
        {
            Branch.GetAllBranches(this);
        }

        #region Methods
        public void Clear()
        {
            Txt_Name.Text = Txt_Desc.Text = String.Empty;
            comBox_Manager.SelectedIndex = -1;
        }

        #endregion

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grBoxBranchInfo.Visible = false;
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            grBoxBranchInfo.Visible = true;
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Search.Text != String.Empty)
                Branch.GetBranchesByValue(Txt_Search.Text, this);
            else
                Branch.GetAllBranches(this);
        }
    }
}
