namespace ToDo_List_Project
{
    partial class frmToDoList
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTaskBox = new System.Windows.Forms.TextBox();
            this.checkedTaskList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPendingTasks = new System.Windows.Forms.Label();
            this.lblCompletedTasks = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCheckAllTasks = new System.Windows.Forms.Button();
            this.btnUncheckAllTasks = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbLeftToRightAlign = new System.Windows.Forms.RadioButton();
            this.rbRightToLeftAlign = new System.Windows.Forms.RadioButton();
            this.btnClearCompletedTasks = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(210, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "To Do List";
            // 
            // txtTaskBox
            // 
            this.txtTaskBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTaskBox.Location = new System.Drawing.Point(138, 177);
            this.txtTaskBox.Name = "txtTaskBox";
            this.txtTaskBox.Size = new System.Drawing.Size(306, 36);
            this.txtTaskBox.TabIndex = 1;
            // 
            // checkedTaskList
            // 
            this.checkedTaskList.Font = new System.Drawing.Font("Tahoma", 12F);
            this.checkedTaskList.FormattingEnabled = true;
            this.checkedTaskList.Location = new System.Drawing.Point(104, 260);
            this.checkedTaskList.Name = "checkedTaskList";
            this.checkedTaskList.Size = new System.Drawing.Size(472, 301);
            this.checkedTaskList.TabIndex = 3;
            this.checkedTaskList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedTaskList_ItemCheck);
            this.checkedTaskList.SelectedIndexChanged += new System.EventHandler(this.checkedTaskList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pending:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Completed:";
            // 
            // lblPendingTasks
            // 
            this.lblPendingTasks.AutoSize = true;
            this.lblPendingTasks.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingTasks.Location = new System.Drawing.Point(257, 633);
            this.lblPendingTasks.Name = "lblPendingTasks";
            this.lblPendingTasks.Size = new System.Drawing.Size(31, 36);
            this.lblPendingTasks.TabIndex = 6;
            this.lblPendingTasks.Text = "0";
            // 
            // lblCompletedTasks
            // 
            this.lblCompletedTasks.AutoSize = true;
            this.lblCompletedTasks.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTasks.Location = new System.Drawing.Point(257, 686);
            this.lblCompletedTasks.Name = "lblCompletedTasks";
            this.lblCompletedTasks.Size = new System.Drawing.Size(31, 36);
            this.lblCompletedTasks.TabIndex = 7;
            this.lblCompletedTasks.Text = "0";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRemoveItem.Location = new System.Drawing.Point(420, 652);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(94, 66);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.Text = "Remove task";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnCheckAllTasks
            // 
            this.btnCheckAllTasks.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCheckAllTasks.Location = new System.Drawing.Point(420, 576);
            this.btnCheckAllTasks.Name = "btnCheckAllTasks";
            this.btnCheckAllTasks.Size = new System.Drawing.Size(94, 66);
            this.btnCheckAllTasks.TabIndex = 9;
            this.btnCheckAllTasks.Text = "Check all tasks";
            this.btnCheckAllTasks.UseVisualStyleBackColor = true;
            this.btnCheckAllTasks.Click += new System.EventHandler(this.btnCheckAllTasks_Click);
            // 
            // btnUncheckAllTasks
            // 
            this.btnUncheckAllTasks.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnUncheckAllTasks.Location = new System.Drawing.Point(531, 576);
            this.btnUncheckAllTasks.Name = "btnUncheckAllTasks";
            this.btnUncheckAllTasks.Size = new System.Drawing.Size(94, 66);
            this.btnUncheckAllTasks.TabIndex = 10;
            this.btnUncheckAllTasks.Text = "Uncheck all tasks";
            this.btnUncheckAllTasks.UseVisualStyleBackColor = true;
            this.btnUncheckAllTasks.Click += new System.EventHandler(this.btnUncheckAllTasks_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClear.Location = new System.Drawing.Point(531, 652);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 66);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear the list";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbLeftToRightAlign
            // 
            this.rbLeftToRightAlign.AutoSize = true;
            this.rbLeftToRightAlign.Checked = true;
            this.rbLeftToRightAlign.Location = new System.Drawing.Point(138, 148);
            this.rbLeftToRightAlign.Name = "rbLeftToRightAlign";
            this.rbLeftToRightAlign.Size = new System.Drawing.Size(86, 23);
            this.rbLeftToRightAlign.TabIndex = 12;
            this.rbLeftToRightAlign.TabStop = true;
            this.rbLeftToRightAlign.Text = "L --> R";
            this.rbLeftToRightAlign.UseVisualStyleBackColor = true;
            this.rbLeftToRightAlign.CheckedChanged += new System.EventHandler(this.rbLeftToRightAlign_CheckedChanged);
            // 
            // rbRightToLeftAlign
            // 
            this.rbRightToLeftAlign.AutoSize = true;
            this.rbRightToLeftAlign.Location = new System.Drawing.Point(358, 148);
            this.rbRightToLeftAlign.Name = "rbRightToLeftAlign";
            this.rbRightToLeftAlign.Size = new System.Drawing.Size(86, 23);
            this.rbRightToLeftAlign.TabIndex = 13;
            this.rbRightToLeftAlign.Text = "L <-- R";
            this.rbRightToLeftAlign.UseVisualStyleBackColor = true;
            this.rbRightToLeftAlign.CheckedChanged += new System.EventHandler(this.rbRightToLeftAlign_CheckedChanged);
            // 
            // btnClearCompletedTasks
            // 
            this.btnClearCompletedTasks.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnClearCompletedTasks.Location = new System.Drawing.Point(420, 728);
            this.btnClearCompletedTasks.Name = "btnClearCompletedTasks";
            this.btnClearCompletedTasks.Size = new System.Drawing.Size(205, 46);
            this.btnClearCompletedTasks.TabIndex = 14;
            this.btnClearCompletedTasks.Text = "Remove completed tasks";
            this.btnClearCompletedTasks.UseVisualStyleBackColor = true;
            this.btnClearCompletedTasks.Click += new System.EventHandler(this.btnClearCompletedTasks_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(28, 158);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(80, 55);
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddTask.Image = global::ToDo_List_Project.Properties.Resources.plus_64_64;
            this.btnAddTask.Location = new System.Drawing.Point(477, 149);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(80, 80);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveList.Image = global::ToDo_List_Project.Properties.Resources.save_icon_32_32;
            this.btnSaveList.Location = new System.Drawing.Point(12, 12);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(40, 40);
            this.btnSaveList.TabIndex = 17;
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Image = global::ToDo_List_Project.Properties.Resources.edit_icon_32_32;
            this.btnEdit.Location = new System.Drawing.Point(594, 508);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmToDoList
            // 
            this.AcceptButton = this.btnAddTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 800);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClearCompletedTasks);
            this.Controls.Add(this.rbRightToLeftAlign);
            this.Controls.Add(this.rbLeftToRightAlign);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUncheckAllTasks);
            this.Controls.Add(this.btnCheckAllTasks);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblCompletedTasks);
            this.Controls.Add(this.lblPendingTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedTaskList);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtTaskBox);
            this.Controls.Add(this.lblTitle);
            this.KeyPreview = true;
            this.Name = "frmToDoList";
            this.Text = "To Do List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmToDoList_FormClosing);
            this.Load += new System.EventHandler(this.frmToDoList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmToDoList_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTaskBox;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.CheckedListBox checkedTaskList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPendingTasks;
        private System.Windows.Forms.Label lblCompletedTasks;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCheckAllTasks;
        private System.Windows.Forms.Button btnUncheckAllTasks;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbLeftToRightAlign;
        private System.Windows.Forms.RadioButton rbRightToLeftAlign;
        private System.Windows.Forms.Button btnClearCompletedTasks;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnSaveList;
    }
}

