using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBookTask1
{
    public partial class Form1 : Form
    {
        Lesson lesson = new Lesson();
        Student Lale = new Student
        {
            FullName = "Muradova Lale Asif",
            LastMyStatSeen = "01.08.2021",
        };
        Student Rafael = new Student
        {
            FullName = "Xelilzade Rafael Ilham",
            LastMyStatSeen = "01.08.2021"
        };
        Student Ruslan = new Student
        {
            FullName = "Mustafayev Ruslan Aydin",
            LastMyStatSeen = "01.08.2021"
        };
        Student Kamran = new Student
        {
            FullName = "Eliyev Kamran Yusif",
            LastMyStatSeen = "01.08.2021"
        };
        Student Huseyn = new Student
        {
            FullName = "Rustamli Huseyn Senan",
            LastMyStatSeen = "01.08.2021"
        };
        Student Teymur = new Student
        {
            FullName = "Novruzov Teymur Rasim",
            LastMyStatSeen = "01.08.2021",
        };
        Student Samir = new Student
        {
            FullName = "Memmedov Samir Fuzuli",
            LastMyStatSeen = "01.08.2021",
        };
        Student Kenan = new Student
        {
            FullName = "Nebizade Kenan Namiq",
            LastMyStatSeen = "01.08.2021"
        };
        public Form1()
        {
            InitializeComponent();
            LaleUc.StudentFullNameLbl.Text = Lale.FullName;
            LaleUc.LastSeenLbl.Text = Lale.LastMyStatSeen;
            RafaelUc.StudentFullNameLbl.Text = Rafael.FullName;
            RafaelUc.LastSeenLbl.Text = Rafael.LastMyStatSeen;
            RuslanUc.StudentFullNameLbl.Text = Ruslan.FullName;
            RuslanUc.LastSeenLbl.Text = Ruslan.LastMyStatSeen;
            KamranUc.StudentFullNameLbl.Text = Kamran.FullName;
            KamranUc.LastSeenLbl.Text = Kamran.LastMyStatSeen;
            HuseynUC.StudentFullNameLbl.Text = Huseyn.FullName;
            HuseynUC.LastSeenLbl.Text = Huseyn.LastMyStatSeen;
            TeymurUC.StudentFullNameLbl.Text = Teymur.FullName;
            TeymurUC.LastSeenLbl.Text = Teymur.LastMyStatSeen;
            SamirUc.StudentFullNameLbl.Text = Samir.FullName;
            SamirUc.LastSeenLbl.Text = Samir.LastMyStatSeen;
            KenanUc.StudentFullNameLbl.Text = Kenan.FullName;
            KenanUc.LastSeenLbl.Text = Kenan.LastMyStatSeen;
          
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void guna2ImageButton1_Click_2(object sender, EventArgs e)
        {
            SubjectRtxtbx.Visible = true;
            SaveSubjectBtn.Visible = true;
            DeleteSubjectBtn.Visible = true;
        }
        private void DeleteSubjectBtn_Click(object sender, EventArgs e)
        {
            SubjectRtxtbx.Text = "";
            SubjectRtxtbx.Visible = false;
            SaveSubjectBtn.Visible = false;
            DeleteSubjectBtn.Visible = false;
            MessageBox.Show("Description not stored");
        }
        private void SaveSubjectBtn_Click(object sender, EventArgs e)
        {
            lesson.Subject = SubjectRtxtbx.Text;
            MessageBox.Show("Description has created sucsessfully");
            SubjectRtxtbx.Visible = false;
            SaveSubjectBtn.Visible = false;
            DeleteSubjectBtn.Visible = false;
        }
        private void AlternateTutorRbtn_CheckedChanged(object sender, EventArgs e)
        {
            lesson.Tutor = AlternateTutorLbl.Text;
        }

        private void MainTutorRbtn_CheckedChanged(object sender, EventArgs e)
        {
            lesson.Tutor = MainTutorLbl.Text;

        }

        private void saveAllChangesBtn_Click(object sender, EventArgs e)
        {
            //json
        }

        private void ElgunUc_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Lale.Attendance = "Arrived On Time";
            Rafael.Attendance = "Arrived On Time";
            Ruslan.Attendance = "Arrived On Time";
            Kamran.Attendance = "Arrived On Time";
            Huseyn.Attendance = "Arrived On Time";
            Teymur.Attendance = "Arrived On Time";
            Samir.Attendance = "Arrived On Time";
            Kenan.Attendance = "Arrived On Time";

        }
        //int scroll = 0;
        //private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    if (scroll == vScrollBar1.Value)
        //    {

        //        guna2GradientPanel2.Location = new Point(guna2GradientPanel2.Location.X, guna2GradientPanel2.Location.Y + 4);
        //    }
        //    else if (scroll < vScrollBar1.Value)
        //    {
        //        guna2GradientPanel2.Location = new Point(guna2GradientPanel2.Location.X, guna2GradientPanel2.Location.Y - 4);
        //    }
        //    else if (scroll > vScrollBar1.Value)
        //    {
        //        guna2GradientPanel2.Location = new Point(guna2GradientPanel2.Location.X, guna2GradientPanel2.Location.Y + 4);
        //    }
        //    scroll = vScrollBar1.Value;
        //}
    }
}
