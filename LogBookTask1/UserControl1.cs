using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBookTask1
{
    public partial class UserControl1 : UserControl
    {
        Student student = new Student();
        public UserControl1()
        {

            InitializeComponent();

        }
        public int attendance { get; set; }
        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

            CommentRtxtbx.Visible = true;
            SaveCommentBtn.Visible = true;
            CommentBackBtn.Visible = true;
        }

        private void CommentBackBtn_Click(object sender, EventArgs e)
        {
            CommentRtxtbx.Visible = false;
            SaveCommentBtn.Visible = false;
            CommentBackBtn.Visible = false;
            MessageBox.Show("Comment Deleted");
        }

        private void diamondBtn1_Click(object sender, EventArgs e)
        {
            diamondBtn1.Image = Properties.Resources.blueDiamond;
            diamondBtn2.Image = Properties.Resources.whiteTransparentDiamond;
            diamondBtn3.Image = Properties.Resources.whiteTransparentDiamond;
        }

        private void diamondBtn2_Click(object sender, EventArgs e)
        {
            diamondBtn1.Image = Properties.Resources.blueDiamond;
            diamondBtn2.Image = Properties.Resources.blueDiamond;
            diamondBtn3.Image = Properties.Resources.whiteTransparentDiamond;

        }

        private void diamondBtn3_Click(object sender, EventArgs e)
        {
            diamondBtn1.Image = Properties.Resources.blueDiamond;
            diamondBtn2.Image = Properties.Resources.blueDiamond;
            diamondBtn3.Image = Properties.Resources.blueDiamond;

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            diamondBtn1.Image = Properties.Resources.whiteTransparentDiamond;
            diamondBtn2.Image = Properties.Resources.whiteTransparentDiamond;
            diamondBtn3.Image = Properties.Resources.whiteTransparentDiamond;

        }

        private void SaveCommentBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CommentRtxtbx.Text))
            {
                student.Comment = CommentRtxtbx.Text;
            }
            CommentRtxtbx.Visible = false;
            SaveCommentBtn.Visible = false;
            CommentBackBtn.Visible = false;

        }
        private void SetAttendance(Student student, int id)
        {
            student.FullName = StudentFullNameLbl.Text;
            student.LastMyStatSeen = LastSeenLbl.Text;
            if (attendance == 1)
            {
                student.Attendance = "Arrived on time";
            }
            if (attendance == 2)
            {
                student.Attendance = "Late";
            }
            if (attendance == 3)
            {
                student.Attendance = "Absent";
            }
        }

        private void ArrivedOnTimeBtn_CheckedChanged(object sender, EventArgs e)
        {
            attendance = 1;
            SetAttendance(student, attendance);
        }

        private void LateBtn_CheckedChanged(object sender, EventArgs e)
        {
            attendance = 2;
            SetAttendance(student, attendance);
        }

        private void AbsentBtn_CheckedChanged(object sender, EventArgs e)
        {
            attendance = 3;
            SetAttendance(student, attendance);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReviewWorksCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            student.ReviewWork = ReviewWorksCb.SelectedIndex + 1;
            MessageBox.Show(student.ReviewWork.ToString());
        }

        private void ClassWorksCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            student.ClassWork = ClassWorksCb.SelectedIndex + 1;
            MessageBox.Show(student.ClassWork.ToString());
        }

        private void CommentRtxtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
