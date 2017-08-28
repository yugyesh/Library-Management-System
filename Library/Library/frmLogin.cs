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
    public partial class frmLogin : Form
    {
        public frmLogin ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        BALUser balUser = new BALUser();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            erpGeneral.Clear();
            if (!ValidateFields())
            {
                if (balUser.CheckUser(txtUserName.Text, txtPassword.Text, Convert.ToInt32(cboUserType.SelectedValue.ToString())))
                {
                    MessageBox.Show("Login Successful", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain mainForm = new frmMain();
                    mainForm.statUserName.Text = txtUserName.Text;
                    mainForm.statRoleID.Text = cboUserType.SelectedValue.ToString();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password Mismatch", "Login Falure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool ValidateFields()
        {
            if (this.txtUserName.Text.Trim()==string.Empty)
            {
                txtUserName.Focus();
                erpGeneral.SetError(txtUserName, "Please Provide UserName");
                return true;
            }
            else if (this.txtPassword.Text.Trim()==string.Empty)
            {
                txtPassword.Focus();
                erpGeneral.SetError(txtPassword, "Please Enter Password");
                return true;
            }
            else if (cboUserType.SelectedIndex==0)
            {
                cboUserType.Focus();
                erpGeneral.SetError(cboUserType, "Please Select User Type");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = balUser.GetUserType();
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["RoleName"] = "-- Please Select --";
                dt.Rows.InsertAt(dr, 0);
                cboUserType.DataSource = dt;
                cboUserType.ValueMember = "RoleID";
                cboUserType.DisplayMember = "RoleName";
            }
        }
    }
}
