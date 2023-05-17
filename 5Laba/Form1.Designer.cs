namespace _5Laba
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
            panel1 = new Panel();
            pause_button = new Button();
            continue_button = new Button();
            stop_button = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(53, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 470);
            panel1.TabIndex = 0;
            // 
            // pause_button
            // 
            pause_button.Location = new Point(53, 25);
            pause_button.Name = "pause_button";
            pause_button.Size = new Size(94, 29);
            pause_button.TabIndex = 1;
            pause_button.Text = "pause";
            pause_button.UseVisualStyleBackColor = true;
            pause_button.Click += button1_Click;
            // 
            // continue_button
            // 
            continue_button.Location = new Point(187, 25);
            continue_button.Name = "continue_button";
            continue_button.Size = new Size(94, 29);
            continue_button.TabIndex = 2;
            continue_button.Text = "continue";
            continue_button.UseVisualStyleBackColor = true;
            continue_button.Click += continue_button_Click;
            // 
            // stop_button
            // 
            stop_button.Location = new Point(323, 25);
            stop_button.Name = "stop_button";
            stop_button.Size = new Size(94, 29);
            stop_button.TabIndex = 3;
            stop_button.Text = "stop";
            stop_button.UseVisualStyleBackColor = true;
            stop_button.Click += stop_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 664);
            Controls.Add(stop_button);
            Controls.Add(continue_button);
            Controls.Add(pause_button);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button pause_button;
        private Button continue_button;
        private Button stop_button;
    }
}