namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox = new ListBox();
            txt = new TextBox();
            btn_Folder = new Button();
            Btn_Apps = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(39, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(305, 409);
            listBox.TabIndex = 0;
            // 
            // txt
            // 
            txt.Location = new Point(380, 26);
            txt.Name = "txt";
            txt.Size = new Size(393, 23);
            txt.TabIndex = 1;
            txt.TextChanged += textBox1_TextChanged;
            // 
            // btn_Folder
            // 
            btn_Folder.Location = new Point(380, 95);
            btn_Folder.Name = "btn_Folder";
            btn_Folder.Size = new Size(393, 123);
            btn_Folder.TabIndex = 2;
            btn_Folder.Text = "Folders";
            btn_Folder.UseVisualStyleBackColor = true;
            btn_Folder.Click += button1_Click;
            // 
            // Btn_Apps
            // 
            Btn_Apps.Location = new Point(380, 298);
            Btn_Apps.Name = "Btn_Apps";
            Btn_Apps.Size = new Size(393, 123);
            Btn_Apps.TabIndex = 3;
            Btn_Apps.Text = "Apps";
            Btn_Apps.UseVisualStyleBackColor = true;
            Btn_Apps.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Apps);
            Controls.Add(btn_Folder);
            Controls.Add(txt);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private TextBox txt;
        private Button btn_Folder;
        private Button Btn_Apps;
    }
}
