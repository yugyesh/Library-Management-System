﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace Library
{
    public partial class frmMain : BlackForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            frmAddMember addMemberForm = new frmAddMember();
            addMemberForm.MdiParent = this;
            addMemberForm.Show();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            frmAddBooks addBooksForm = new frmAddBooks();
            addBooksForm.MdiParent = this;
            addBooksForm.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            frmBookIssue bookIssueForm = new frmBookIssue();
            bookIssueForm.MdiParent = this;
            bookIssueForm.Show();
        }

        private void toolLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Logout", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (check==DialogResult.OK)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
        }

        BALFine balFine = new BALFine();
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (statRoleID.Text!="1")
            {
                toolAddBooks.Enabled = false;
                toolAddMember.Enabled = false;
                masterToolStripMenuItem.Enabled = false;
            }
            DataTable dt = new DataTable();
            dt = balFine.GetFineDetails(txtStudentName.Text);
            if (dt != null && dt.Rows.Count > 0)
            {
                LoadGridFine(dt);
            }
        }

        private void LoadGridFine(DataTable dt)
        {
            dgvFineDetail.Columns["colDays"].DefaultCellStyle.BackColor = Color.Red;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvFineDetail.Rows.Add();
                dgvFineDetail.Rows[i].Cells["colSNF"].Value = i;
                dgvFineDetail.Rows[i].Cells["colDays"].Value = dt.Rows[i]["DaysExceed"].ToString();
                dgvFineDetail.Rows[i].Cells["colFineAmount"].Value = Convert.ToInt32(dt.Rows[i]["DaysExceed"].ToString()) * 5;
                dgvFineDetail.Rows[i].Cells["colStudentID"].Value = dt.Rows[i]["BurrowerID"].ToString();
                dgvFineDetail.Rows[i].Cells["colSection"].Value = dt.Rows[i]["SectionName"].ToString();
                dgvFineDetail.Rows[i].Cells["colClassF"].Value = dt.Rows[i]["ClassName"].ToString();
                dgvFineDetail.Rows[i].Cells["colStudentName"].Value = dt.Rows[i]["StudentName"].ToString();
                dgvFineDetail.Rows[i].Cells["colBookTitleF"].Value = dt.Rows[i]["BookTitle"].ToString();
                dgvFineDetail.Rows[i].Cells["colAuthorF"].Value = dt.Rows[i]["Author"].ToString();
                dgvFineDetail.Rows[i].Cells["colBurrowedDate"].Value = dt.Rows[i]["BurrowedDate"].ToString();
                dgvFineDetail.Rows[i].Cells["colISBN"].Value = dt.Rows[i]["ISBN"].ToString();
            }
        }

        private void toolAddMember_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            Form activeChild = this.ActiveMdiChild;
            frmAddMember addMemberForm = new frmAddMember();
            if (activeChild == null)
            {
                addMemberForm.Show();
                addMemberForm.MdiParent = this;
            }
            else
            {
                addMemberForm.Show();
                addMemberForm.MdiParent = this;
                activeChild.Close();
            }
        }

        private void toolAddBooks_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            Form activeChild = this.ActiveMdiChild;
            frmAddBooks bookAddForm = new frmAddBooks();
            if (activeChild == null)
            {
                bookAddForm.Show();
                bookAddForm.MdiParent = this;
            }
            else
            {
                activeChild.Close();
                bookAddForm.Show();
                bookAddForm.MdiParent = this;
            }
        }

        private void toolBookIssue_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            Form activeChild = this.ActiveMdiChild;
            frmBookIssue bookIssueForm = new frmBookIssue();
            if (activeChild == null)
            {
                bookIssueForm.Show();
                bookIssueForm.MdiParent = this;
            }
            else
            {
                activeChild.Close();
                bookIssueForm.Show();
                bookIssueForm.MdiParent = this;
            }
            bookIssueForm.lblIssueorReturn.Checked = true;
        }

        private void toolBookReturn_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            Form activeChild = this.ActiveMdiChild;
            frmBookIssue bookIssueForm = new frmBookIssue();
            if (activeChild == null)
            {
                bookIssueForm.Show();
                bookIssueForm.MdiParent = this;
            }
            else
            {
                activeChild.Close();
                bookIssueForm.Show();
                bookIssueForm.MdiParent = this;
            }
            bookIssueForm.lblIssueorReturn.Checked = false;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            frmChangePassword changePasswordForm = new frmChangePassword();
            changePasswordForm.ShowDialog();
            changePasswordForm.MdiParent = this;
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            frmAddClass addClassForm = new frmAddClass();
            addClassForm.ShowDialog();
            addClassForm.MdiParent = this;
        }

        private void addStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            frmAddStatus addStatusForm = new frmAddStatus();
            addStatusForm.ShowDialog();
            addStatusForm.MdiParent = this;
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            frmAddDepartment addDepartmentForm = new frmAddDepartment();
            addDepartmentForm.ShowDialog();
            addDepartmentForm.MdiParent = this;
        }

        private void addTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            frmAddTag addTag = new frmAddTag();
            addTag.ShowDialog();
            addTag.MdiParent = this;
        }
    }
}
