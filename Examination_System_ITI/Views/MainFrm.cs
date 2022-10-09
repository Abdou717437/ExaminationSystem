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
    public partial class MainFrm : Form
    {
        private Button currentBtn;
        public MainFrm()
        {
            InitializeComponent();
            ActivateButton(dashboardBtn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        #region Methods For Manipulating Navigation Buttons

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(14, 15, 18);
                    currentBtn.ForeColor = Color.FromArgb(50, 86, 120);
                    currentBtn.Font = new Font("Verdana", 11.8F, System.Drawing.FontStyle.Regular);
                    translatePanel.Height = currentBtn.Height;
                    translatePanel.Top = currentBtn.Top;
                    translatePanel.Left = currentBtn.Left;
                    pageTitleLbl.Text = currentBtn.Text;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control prevButton in navigationPanel.Controls)
            {
                if (prevButton.GetType() == typeof(Button))
                {
                    prevButton.BackColor = Color.Transparent;
                    prevButton.ForeColor = Color.White;
                    prevButton.Font = new Font("Verdana", 11.8F, System.Drawing.FontStyle.Bold);
                }
            }
        }
        #endregion
    }
}
