namespace CPA
{
    partial class Main
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
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.tasksButton = new System.Windows.Forms.Button();
            this.alarmsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Location = new System.Drawing.Point(23, 13);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(184, 140);
            this.buttonCalendar.TabIndex = 0;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            // 
            // tasksButton
            // 
            this.tasksButton.Location = new System.Drawing.Point(23, 182);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(85, 62);
            this.tasksButton.TabIndex = 1;
            this.tasksButton.Text = "Tasks";
            this.tasksButton.UseVisualStyleBackColor = true;
            // 
            // alarmsButton
            // 
            this.alarmsButton.Location = new System.Drawing.Point(123, 182);
            this.alarmsButton.Name = "alarmsButton";
            this.alarmsButton.Size = new System.Drawing.Size(84, 62);
            this.alarmsButton.TabIndex = 2;
            this.alarmsButton.Text = "Alarms";
            this.alarmsButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.alarmsButton);
            this.panel1.Controls.Add(this.tasksButton);
            this.panel1.Controls.Add(this.buttonCalendar);
            this.panel1.Location = new System.Drawing.Point(15, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 270);
            this.panel1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 304);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Button alarmsButton;
        private System.Windows.Forms.Panel panel1;
    }
}

