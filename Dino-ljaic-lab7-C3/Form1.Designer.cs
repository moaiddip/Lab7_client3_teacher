namespace Dino_ljaic_lab7_C3
{
    partial class Form1
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
            this.studentListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxNativeLang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxLearnLang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberOfQuizesTextBox = new System.Windows.Forms.TextBox();
            this.TeacherTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.createMultipleQuizesButtons = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.createSingleQuizButton = new System.Windows.Forms.Button();
            this.txtboxQword = new System.Windows.Forms.TextBox();
            this.enterWordInNativeLanguageTextBox = new System.Windows.Forms.Label();
            this.operationViewerLabel = new System.Windows.Forms.Label();
            this.TeacherTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentListComboBox
            // 
            this.studentListComboBox.FormattingEnabled = true;
            this.studentListComboBox.Location = new System.Drawing.Point(113, 7);
            this.studentListComboBox.Name = "studentListComboBox";
            this.studentListComboBox.Size = new System.Drawing.Size(467, 21);
            this.studentListComboBox.TabIndex = 0;
            this.studentListComboBox.SelectedIndexChanged += new System.EventHandler(this.studentListComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Student:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Native Language:";
            // 
            // txtboxNativeLang
            // 
            this.txtboxNativeLang.Enabled = false;
            this.txtboxNativeLang.Location = new System.Drawing.Point(113, 56);
            this.txtboxNativeLang.Name = "txtboxNativeLang";
            this.txtboxNativeLang.Size = new System.Drawing.Size(150, 20);
            this.txtboxNativeLang.TabIndex = 3;
            this.txtboxNativeLang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Langauge to learn:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxLearnLang
            // 
            this.txtboxLearnLang.Enabled = false;
            this.txtboxLearnLang.Location = new System.Drawing.Point(408, 56);
            this.txtboxLearnLang.Name = "txtboxLearnLang";
            this.txtboxLearnLang.Size = new System.Drawing.Size(172, 20);
            this.txtboxLearnLang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Quizes:";
            // 
            // numberOfQuizesTextBox
            // 
            this.numberOfQuizesTextBox.Location = new System.Drawing.Point(106, 17);
            this.numberOfQuizesTextBox.Name = "numberOfQuizesTextBox";
            this.numberOfQuizesTextBox.Size = new System.Drawing.Size(147, 22);
            this.numberOfQuizesTextBox.TabIndex = 8;
            // 
            // TeacherTab
            // 
            this.TeacherTab.AccessibleDescription = "";
            this.TeacherTab.AccessibleName = "";
            this.TeacherTab.Controls.Add(this.tabPage1);
            this.TeacherTab.Controls.Add(this.tabPage2);
            this.TeacherTab.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherTab.Location = new System.Drawing.Point(15, 94);
            this.TeacherTab.Name = "TeacherTab";
            this.TeacherTab.SelectedIndex = 0;
            this.TeacherTab.Size = new System.Drawing.Size(589, 89);
            this.TeacherTab.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createMultipleQuizesButtons);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.numberOfQuizesTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 62);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Multiple Random Quizes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // createMultipleQuizesButtons
            // 
            this.createMultipleQuizesButtons.Location = new System.Drawing.Point(290, 15);
            this.createMultipleQuizesButtons.Name = "createMultipleQuizesButtons";
            this.createMultipleQuizesButtons.Size = new System.Drawing.Size(271, 23);
            this.createMultipleQuizesButtons.TabIndex = 9;
            this.createMultipleQuizesButtons.Text = "Create Multiple Quizes";
            this.createMultipleQuizesButtons.UseVisualStyleBackColor = true;
            this.createMultipleQuizesButtons.Click += new System.EventHandler(this.createMultipleQuizesButtons_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.createSingleQuizButton);
            this.tabPage2.Controls.Add(this.txtboxQword);
            this.tabPage2.Controls.Add(this.enterWordInNativeLanguageTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 62);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Single Quiz ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // createSingleQuizButton
            // 
            this.createSingleQuizButton.Location = new System.Drawing.Point(372, 17);
            this.createSingleQuizButton.Name = "createSingleQuizButton";
            this.createSingleQuizButton.Size = new System.Drawing.Size(189, 22);
            this.createSingleQuizButton.TabIndex = 2;
            this.createSingleQuizButton.Text = "Create Single Quiz";
            this.createSingleQuizButton.UseVisualStyleBackColor = true;
            this.createSingleQuizButton.Click += new System.EventHandler(this.createSingleQuizButton_Click);
            // 
            // txtboxQword
            // 
            this.txtboxQword.Location = new System.Drawing.Point(187, 17);
            this.txtboxQword.Name = "txtboxQword";
            this.txtboxQword.Size = new System.Drawing.Size(162, 22);
            this.txtboxQword.TabIndex = 1;
            // 
            // enterWordInNativeLanguageTextBox
            // 
            this.enterWordInNativeLanguageTextBox.AutoSize = true;
            this.enterWordInNativeLanguageTextBox.Location = new System.Drawing.Point(6, 20);
            this.enterWordInNativeLanguageTextBox.Name = "enterWordInNativeLanguageTextBox";
            this.enterWordInNativeLanguageTextBox.Size = new System.Drawing.Size(161, 14);
            this.enterWordInNativeLanguageTextBox.TabIndex = 0;
            this.enterWordInNativeLanguageTextBox.Text = "Enter Word in Native Language:";
            // 
            // operationViewerLabel
            // 
            this.operationViewerLabel.AutoSize = true;
            this.operationViewerLabel.Location = new System.Drawing.Point(12, 186);
            this.operationViewerLabel.Name = "operationViewerLabel";
            this.operationViewerLabel.Size = new System.Drawing.Size(546, 13);
            this.operationViewerLabel.TabIndex = 11;
            this.operationViewerLabel.Text = "Operation Error: XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" +
    "XX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 203);
            this.Controls.Add(this.operationViewerLabel);
            this.Controls.Add(this.TeacherTab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxLearnLang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxNativeLang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentListComboBox);
            this.Name = "Form1";
            this.Text = " MSD Lab 7 Client 3 - Teacher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TeacherTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxNativeLang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxLearnLang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numberOfQuizesTextBox;
        private System.Windows.Forms.TabControl TeacherTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtboxQword;
        private System.Windows.Forms.Label enterWordInNativeLanguageTextBox;
        private System.Windows.Forms.Button createSingleQuizButton;
        private System.Windows.Forms.Label operationViewerLabel;
        private System.Windows.Forms.Button createMultipleQuizesButtons;
    }
}

