﻿using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsPage432 {
    public partial class Form1 : Form {
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        public Form1() {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }
        private void UpdateForm(bool changed) {
            if (!changed) {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath)) {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }
                this.Text = "Excuse Manager";
            }
            else {
                this.Text = "Excuse Manager*";
            }
            this.formChanged = changed;
        }

        private void folderButton_Click(object sender, EventArgs e) {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                saveButton.Enabled = true;
                openButton.Enabled = true;
                randomButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text)) {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Excuse files (*.excuse)|*.excuse";
            saveFileDialog1.FileName = description.Text + ".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void openButton_Click(object sender, EventArgs e) {
            if (CheckChanged()) {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Excuse files (*.excuse)|*.excuse| All files (*.*)|*.*";
                openFileDialog1.FileName = description.Text + ".excuse";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK) {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void randomButton_Click(object sender, EventArgs e) {
            if (Directory.GetFiles(selectedFolder).Length == 0)
                MessageBox.Show("There are no excuse files in the selected folder.");
            else if (CheckChanged()) {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChanged() {
            if (formChanged) {
                DialogResult result = MessageBox.Show(
                "The current excuse has not been saved. Continue?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void description_TextChanged(object sender, EventArgs e) {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e) {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e) {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }
    }
}
