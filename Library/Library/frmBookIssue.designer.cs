﻿namespace Library
{
    partial class frmBookIssue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.lblBurrowerName = new IncLibrary.IncLabel();
            this.btnNew = new IncLibrary.IncButton();
            this.txtBookCopies = new System.Windows.Forms.TextBox();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.colBurrowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblBurrowerID = new IncLibrary.IncLabel();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.txtBookIDSearch = new System.Windows.Forms.TextBox();
            this.lblBurrowerCbo = new IncLibrary.IncLabel();
            this.incLabel3 = new IncLibrary.IncLabel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.chkBurrower = new System.Windows.Forms.CheckBox();
            this.pnlISBN = new System.Windows.Forms.Panel();
            this.dgvISBNList = new System.Windows.Forms.DataGridView();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picMember = new System.Windows.Forms.PictureBox();
            this.lblBurrowerNameImg = new IncLibrary.IncLabel();
            this.incButton1 = new IncLibrary.IncButton();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowedBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWhichInfo = new IncLibrary.IncLabel();
            this.btnClear = new IncLibrary.IncButton();
            this._CloseButton = new Library.ButtonZ();
            this.lblRemoveBook = new IncLibrary.IncLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.pnlBook.SuspendLayout();
            this.pnlStudentInfo.SuspendLayout();
            this.pnlISBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvISBNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClose.Controls.Add(this._CloseButton);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClose.Location = new System.Drawing.Point(0, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(1361, 26);
            this.pnlClose.TabIndex = 2;
            // 
            // lblBurrowerName
            // 
            this.lblBurrowerName.AutoSize = true;
            this.lblBurrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBurrowerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerName.Location = new System.Drawing.Point(44, 7);
            this.lblBurrowerName.Name = "lblBurrowerName";
            this.lblBurrowerName.Readonly = false;
            this.lblBurrowerName.Size = new System.Drawing.Size(98, 17);
            this.lblBurrowerName.TabIndex = 45;
            this.lblBurrowerName.Text = "Student Name";
            this.lblBurrowerName.ValueByOrchestrator = "Student Name";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNew.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnNew.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNew.Location = new System.Drawing.Point(1083, 513);
            this.btnNew.Name = "btnNew";
            this.btnNew.NextControl = null;
            this.btnNew.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnNew.PreviousControl = null;
            this.btnNew.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnNew.Size = new System.Drawing.Size(92, 42);
            this.btnNew.TabIndex = 46;
            this.btnNew.Text = "Return";
            // 
            // txtBookCopies
            // 
            this.txtBookCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCopies.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBookCopies.Location = new System.Drawing.Point(28, 29);
            this.txtBookCopies.MaxLength = 500;
            this.txtBookCopies.Name = "txtBookCopies";
            this.txtBookCopies.Size = new System.Drawing.Size(131, 23);
            this.txtBookCopies.TabIndex = 43;
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.AllowUserToAddRows = false;
            this.dgvStudentInfo.AllowUserToDeleteRows = false;
            this.dgvStudentInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBurrowerID,
            this.colBurrowerName,
            this.colClass,
            this.colDepartment,
            this.colDeparmentID,
            this.colBookIssued,
            this.colClassID,
            this.colFine});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentInfo.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvStudentInfo.EnableHeadersVisualStyles = false;
            this.dgvStudentInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvStudentInfo.Location = new System.Drawing.Point(2, -2);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvStudentInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvStudentInfo.Size = new System.Drawing.Size(557, 456);
            this.dgvStudentInfo.TabIndex = 49;
            // 
            // colBurrowerID
            // 
            this.colBurrowerID.HeaderText = "Burrower ID";
            this.colBurrowerID.Name = "colBurrowerID";
            this.colBurrowerID.ReadOnly = true;
            this.colBurrowerID.Width = 110;
            // 
            // colBurrowerName
            // 
            this.colBurrowerName.HeaderText = "Name";
            this.colBurrowerName.Name = "colBurrowerName";
            this.colBurrowerName.ReadOnly = true;
            this.colBurrowerName.Width = 140;
            // 
            // colClass
            // 
            this.colClass.HeaderText = "Class";
            this.colClass.Name = "colClass";
            this.colClass.ReadOnly = true;
            this.colClass.Visible = false;
            // 
            // colDepartment
            // 
            this.colDepartment.HeaderText = "Deparment";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            this.colDepartment.Visible = false;
            // 
            // colDeparmentID
            // 
            this.colDeparmentID.HeaderText = "Department ID";
            this.colDeparmentID.Name = "colDeparmentID";
            this.colDeparmentID.ReadOnly = true;
            this.colDeparmentID.Visible = false;
            // 
            // colBookIssued
            // 
            this.colBookIssued.HeaderText = "BookIssued";
            this.colBookIssued.Name = "colBookIssued";
            this.colBookIssued.ReadOnly = true;
            // 
            // colClassID
            // 
            this.colClassID.HeaderText = "Class ID";
            this.colClassID.Name = "colClassID";
            this.colClassID.ReadOnly = true;
            this.colClassID.Visible = false;
            // 
            // colFine
            // 
            this.colFine.HeaderText = "Fine";
            this.colFine.Name = "colFine";
            this.colFine.ReadOnly = true;
            this.colFine.Width = 80;
            // 
            // pnlBook
            // 
            this.pnlBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlBook.Controls.Add(this.cboDepartment);
            this.pnlBook.Controls.Add(this.lblBurrowerID);
            this.pnlBook.Controls.Add(this.cboClass);
            this.pnlBook.Controls.Add(this.txtBookIDSearch);
            this.pnlBook.Controls.Add(this.lblBurrowerCbo);
            this.pnlBook.Controls.Add(this.lblBurrowerName);
            this.pnlBook.Controls.Add(this.txtBookCopies);
            this.pnlBook.Location = new System.Drawing.Point(12, 75);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(566, 59);
            this.pnlBook.TabIndex = 50;
            // 
            // cboDepartment
            // 
            this.cboDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboDepartment.ForeColor = System.Drawing.SystemColors.Window;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(211, 28);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(148, 24);
            this.cboDepartment.TabIndex = 59;
            // 
            // lblBurrowerID
            // 
            this.lblBurrowerID.AutoSize = true;
            this.lblBurrowerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBurrowerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerID.Location = new System.Drawing.Point(411, 7);
            this.lblBurrowerID.Name = "lblBurrowerID";
            this.lblBurrowerID.Readonly = false;
            this.lblBurrowerID.Size = new System.Drawing.Size(74, 17);
            this.lblBurrowerID.TabIndex = 27;
            this.lblBurrowerID.Text = "Student ID";
            this.lblBurrowerID.ValueByOrchestrator = "Student ID";
            // 
            // cboClass
            // 
            this.cboClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboClass.ForeColor = System.Drawing.SystemColors.Window;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(211, 28);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(148, 24);
            this.cboClass.TabIndex = 1;
            // 
            // txtBookIDSearch
            // 
            this.txtBookIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBookIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBookIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtBookIDSearch.Location = new System.Drawing.Point(383, 29);
            this.txtBookIDSearch.MaxLength = 500;
            this.txtBookIDSearch.Name = "txtBookIDSearch";
            this.txtBookIDSearch.Size = new System.Drawing.Size(131, 23);
            this.txtBookIDSearch.TabIndex = 26;
            // 
            // lblBurrowerCbo
            // 
            this.lblBurrowerCbo.AutoSize = true;
            this.lblBurrowerCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBurrowerCbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerCbo.Location = new System.Drawing.Point(258, 7);
            this.lblBurrowerCbo.Name = "lblBurrowerCbo";
            this.lblBurrowerCbo.Readonly = false;
            this.lblBurrowerCbo.Size = new System.Drawing.Size(42, 17);
            this.lblBurrowerCbo.TabIndex = 25;
            this.lblBurrowerCbo.Text = "Class";
            this.lblBurrowerCbo.ValueByOrchestrator = "Class";
            // 
            // incLabel3
            // 
            this.incLabel3.AutoSize = true;
            this.incLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.incLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incLabel3.Location = new System.Drawing.Point(587, 254);
            this.incLabel3.Name = "incLabel3";
            this.incLabel3.Readonly = false;
            this.incLabel3.Size = new System.Drawing.Size(48, 16);
            this.incLabel3.TabIndex = 23;
            this.incLabel3.Text = "I.S.B.N";
            this.incLabel3.ValueByOrchestrator = "I.S.B.N";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtISBN.ForeColor = System.Drawing.SystemColors.Window;
            this.txtISBN.Location = new System.Drawing.Point(638, 249);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(216, 24);
            this.txtISBN.TabIndex = 0;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // pnlStudentInfo
            // 
            this.pnlStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStudentInfo.Controls.Add(this.dgvStudentInfo);
            this.pnlStudentInfo.Location = new System.Drawing.Point(13, 135);
            this.pnlStudentInfo.Name = "pnlStudentInfo";
            this.pnlStudentInfo.Size = new System.Drawing.Size(566, 460);
            this.pnlStudentInfo.TabIndex = 51;
            // 
            // chkBurrower
            // 
            this.chkBurrower.AutoSize = true;
            this.chkBurrower.BackColor = System.Drawing.Color.Red;
            this.chkBurrower.Checked = true;
            this.chkBurrower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBurrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBurrower.ForeColor = System.Drawing.Color.White;
            this.chkBurrower.Location = new System.Drawing.Point(12, 47);
            this.chkBurrower.Name = "chkBurrower";
            this.chkBurrower.Size = new System.Drawing.Size(92, 22);
            this.chkBurrower.TabIndex = 52;
            this.chkBurrower.Text = "Is Student";
            this.chkBurrower.UseVisualStyleBackColor = true;
            this.chkBurrower.CheckedChanged += new System.EventHandler(this.chkBurrower_CheckedChanged);
            // 
            // pnlISBN
            // 
            this.pnlISBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlISBN.Controls.Add(this.dgvISBNList);
            this.pnlISBN.Location = new System.Drawing.Point(638, 274);
            this.pnlISBN.Name = "pnlISBN";
            this.pnlISBN.Size = new System.Drawing.Size(216, 317);
            this.pnlISBN.TabIndex = 53;
            // 
            // dgvISBNList
            // 
            this.dgvISBNList.AllowUserToDeleteRows = false;
            this.dgvISBNList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvISBNList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvISBNList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvISBNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvISBNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colISBN});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvISBNList.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvISBNList.EnableHeadersVisualStyles = false;
            this.dgvISBNList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvISBNList.Location = new System.Drawing.Point(-1, -1);
            this.dgvISBNList.Name = "dgvISBNList";
            this.dgvISBNList.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvISBNList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvISBNList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvISBNList.Size = new System.Drawing.Size(216, 312);
            this.dgvISBNList.TabIndex = 56;
            // 
            // colSN
            // 
            this.colSN.HeaderText = "SN";
            this.colSN.Name = "colSN";
            this.colSN.ReadOnly = true;
            this.colSN.Width = 30;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Width = 172;
            // 
            // picMember
            // 
            this.picMember.Location = new System.Drawing.Point(669, 75);
            this.picMember.Name = "picMember";
            this.picMember.Size = new System.Drawing.Size(131, 126);
            this.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMember.TabIndex = 54;
            this.picMember.TabStop = false;
            // 
            // lblBurrowerNameImg
            // 
            this.lblBurrowerNameImg.AutoSize = true;
            this.lblBurrowerNameImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBurrowerNameImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBurrowerNameImg.Location = new System.Drawing.Point(685, 204);
            this.lblBurrowerNameImg.Name = "lblBurrowerNameImg";
            this.lblBurrowerNameImg.Readonly = false;
            this.lblBurrowerNameImg.Size = new System.Drawing.Size(98, 17);
            this.lblBurrowerNameImg.TabIndex = 55;
            this.lblBurrowerNameImg.Text = "Student Name";
            this.lblBurrowerNameImg.ValueByOrchestrator = "Student Name";
            // 
            // incButton1
            // 
            this.incButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.incButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.incButton1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.incButton1.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.incButton1.Location = new System.Drawing.Point(1237, 513);
            this.incButton1.Name = "incButton1";
            this.incButton1.NextControl = null;
            this.incButton1.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incButton1.PreviousControl = null;
            this.incButton1.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.incButton1.Size = new System.Drawing.Size(92, 42);
            this.incButton1.TabIndex = 46;
            this.incButton1.Text = "Issue";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colBurrowedBook,
            this.colBurrowedDate});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfo.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvInfo.EnableHeadersVisualStyles = false;
            this.dgvInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvInfo.Size = new System.Drawing.Size(395, 422);
            this.dgvInfo.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // colBurrowedBook
            // 
            this.colBurrowedBook.HeaderText = "Book Name";
            this.colBurrowedBook.Name = "colBurrowedBook";
            this.colBurrowedBook.ReadOnly = true;
            this.colBurrowedBook.Visible = false;
            // 
            // colBurrowedDate
            // 
            this.colBurrowedDate.HeaderText = "Burrowed Date";
            this.colBurrowedDate.Name = "colBurrowedDate";
            this.colBurrowedDate.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvInfo);
            this.panel1.Location = new System.Drawing.Point(927, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 432);
            this.panel1.TabIndex = 58;
            // 
            // lblWhichInfo
            // 
            this.lblWhichInfo.AutoSize = true;
            this.lblWhichInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblWhichInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblWhichInfo.Location = new System.Drawing.Point(1116, 52);
            this.lblWhichInfo.Name = "lblWhichInfo";
            this.lblWhichInfo.Readonly = false;
            this.lblWhichInfo.Size = new System.Drawing.Size(31, 17);
            this.lblWhichInfo.TabIndex = 58;
            this.lblWhichInfo.Text = "Info";
            this.lblWhichInfo.ValueByOrchestrator = "Info";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnClear.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClear.Location = new System.Drawing.Point(929, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.NextControl = null;
            this.btnClear.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.PreviousControl = null;
            this.btnClear.ShineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClear.Size = new System.Drawing.Size(92, 42);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Clear";
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(1331, 0);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(22, 21);
            this._CloseButton.TabIndex = 1;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // lblRemoveBook
            // 
            this.lblRemoveBook.BackColor = System.Drawing.Color.Red;
            this.lblRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblRemoveBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRemoveBook.Location = new System.Drawing.Point(1, 1);
            this.lblRemoveBook.Name = "lblRemoveBook";
            this.lblRemoveBook.Readonly = false;
            this.lblRemoveBook.Size = new System.Drawing.Size(31, 42);
            this.lblRemoveBook.TabIndex = 59;
            this.lblRemoveBook.Text = "-";
            this.lblRemoveBook.ValueByOrchestrator = "-";
            this.lblRemoveBook.Click += new System.EventHandler(this.lblRemoveBook_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblRemoveBook);
            this.panel2.Location = new System.Drawing.Point(641, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 45);
            this.panel2.TabIndex = 58;
            // 
            // frmBookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1361, 609);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWhichInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBurrowerNameImg);
            this.Controls.Add(this.picMember);
            this.Controls.Add(this.pnlISBN);
            this.Controls.Add(this.chkBurrower);
            this.Controls.Add(this.pnlStudentInfo);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.incLabel3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.incButton1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlISBN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvISBNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonZ _CloseButton;
        private System.Windows.Forms.Panel pnlClose;
        private IncLibrary.IncLabel lblBurrowerName;
        private IncLibrary.IncButton btnNew;
        private System.Windows.Forms.TextBox txtBookCopies;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.Panel pnlBook;
        private IncLibrary.IncLabel lblBurrowerID;
        private IncLibrary.IncLabel incLabel3;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.TextBox txtBookIDSearch;
        private IncLibrary.IncLabel lblBurrowerCbo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.CheckBox chkBurrower;
        private System.Windows.Forms.Panel pnlISBN;
        private System.Windows.Forms.PictureBox picMember;
        private IncLibrary.IncLabel lblBurrowerNameImg;
        private IncLibrary.IncButton incButton1;
        private System.Windows.Forms.DataGridView dgvISBNList;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowedBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurrowedDate;
        private IncLibrary.IncLabel lblWhichInfo;
        private IncLibrary.IncButton btnClear;
        private IncLibrary.IncLabel lblRemoveBook;
        private System.Windows.Forms.Panel panel2;
    }
}

