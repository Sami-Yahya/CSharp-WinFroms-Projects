using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List_Project
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        private void frmToDoList_Load(object sender, EventArgs e)
        {
            LoadTasksFromFile();
            UpdateTaskStatus();
        }

        private void frmToDoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasksInFile();
        }

        private void CompletedTasks()
        {
            int NumberOfCheckedItems = checkedTaskList.CheckedItems.Count;

            lblCompletedTasks.Text = NumberOfCheckedItems.ToString();
        }

        private void PendingTasks()
        {
            int NumberOfUncheckedItems = checkedTaskList.Items.Count - checkedTaskList.CheckedItems.Count;

            lblPendingTasks.Text = NumberOfUncheckedItems.ToString();
        }

        private void UpdateTaskStatus()
        {
            PendingTasks();
            CompletedTasks();
        }

        private void SaveTasksInFile()
        {
            string FilePath = Path.Combine(Application.StartupPath, "Tasks.txt");

            List<string> lines = new List<string>();

            for (int i = 0; i < checkedTaskList.Items.Count; i++)
            {
                string task = checkedTaskList.Items[i].ToString();
                bool isDone = checkedTaskList.GetItemChecked(i);

                lines.Add(task + "#//#" + isDone);
            }

            File.WriteAllLines(FilePath, lines);
        }

        private void LoadTasksFromFile()
        {
            string FilePath = Path.Combine(Application.StartupPath, "Tasks.txt");

            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);

                foreach (var line in lines)
                {
                    var parts = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    if (parts.Length == 2)
                    {
                        string task = parts[0];
                        bool isDone = bool.Parse(parts[1]);

                        checkedTaskList.Items.Add(task, isDone);
                    }
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTaskBox.Text)) 
            {
                checkedTaskList.Items.Add(txtTaskBox.Text);
                txtTaskBox.Clear();

                UpdateTaskStatus();
            }

            txtTaskBox.Focus();
        }

        private void btnCheckAllTasks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedTaskList.Items.Count; i++)
            {
                checkedTaskList.SetItemChecked(i, true);
            }

            UpdateTaskStatus();
        }

        private void btnUncheckAllTasks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedTaskList.Items.Count; i++)
            {
                checkedTaskList.SetItemChecked(i, false);
            }

            UpdateTaskStatus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the list?", "Comfirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                checkedTaskList.Items.Clear();

                lblPendingTasks.Text = "0";
                lblCompletedTasks.Text = "0";
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
             //for (int i = 0; i < checkedTaskList.SelectedItems.Count; i++)
             //{
             //   checkedTaskList.Items.Remove(checkedTaskList.SelectedItems[i]);

             //   UpdateTaskStatus();
             //}

             if (checkedTaskList.SelectedIndex != -1)
             {
                checkedTaskList.Items.RemoveAt(checkedTaskList.SelectedIndex);
                UpdateTaskStatus();
             }
        }

        private void checkedTaskList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)UpdateTaskStatus);
        }

        private void rbLeftToRightAlign_CheckedChanged(object sender, EventArgs e)
        {
            txtTaskBox.TextAlign = HorizontalAlignment.Left;
            txtTaskBox.Focus();
        }

        private void rbRightToLeftAlign_CheckedChanged(object sender, EventArgs e)
        {
            txtTaskBox.TextAlign = HorizontalAlignment.Right;
            txtTaskBox.Focus();
        }

        private void btnClearCompletedTasks_Click(object sender, EventArgs e)
        {
            for (int i = checkedTaskList.Items.Count - 1; i >= 0; i--)
            {
                if (checkedTaskList.GetItemChecked(i))
                {
                    checkedTaskList.Items.RemoveAt(i);
                    UpdateTaskStatus();
                }
            }
            
        }

        private void checkedTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedTaskList.SelectedIndex != -1)
            {
                txtTaskBox.Clear();
                btnSaveChanges.Visible = false;
                this.AcceptButton = btnAddTask;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkedTaskList.SelectedIndex != -1)
            {
                btnSaveChanges.Visible = true;
                txtTaskBox.Text = checkedTaskList.SelectedItem.ToString();
                txtTaskBox.Focus();
                this.AcceptButton = btnSaveChanges;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            int index = checkedTaskList.SelectedIndex;

            if (index != -1 && !string.IsNullOrWhiteSpace(txtTaskBox.Text))
            {
                checkedTaskList.Items[index] = txtTaskBox.Text;
               // SaveTasksInFile();

                txtTaskBox.Clear();
                checkedTaskList.ClearSelected();
            }

            btnSaveChanges.Visible = false;
            this.AcceptButton = btnAddTask;
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            SaveTasksInFile();
        }

        private void frmToDoList_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl+S to Save
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSaveList.PerformClick();
            }
        }
        
    }
}
