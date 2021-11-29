
namespace Countdown
{
    partial class Countdow
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.secondsBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.firstTwoDotsBox = new System.Windows.Forms.TextBox();
            this.minutesBox = new System.Windows.Forms.TextBox();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.secondTwoDots = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.lapButton = new System.Windows.Forms.Button();
            this.lapRichBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(110, 136);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 59);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Black;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(199, 139);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(91, 52);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "PAUSE";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // secondsBox
            // 
            this.secondsBox.BackColor = System.Drawing.Color.Black;
            this.secondsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondsBox.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondsBox.ForeColor = System.Drawing.Color.White;
            this.secondsBox.Location = new System.Drawing.Point(284, 12);
            this.secondsBox.MaxLength = 2;
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(105, 128);
            this.secondsBox.TabIndex = 4;
            this.secondsBox.Text = "00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // firstTwoDotsBox
            // 
            this.firstTwoDotsBox.BackColor = System.Drawing.Color.Black;
            this.firstTwoDotsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstTwoDotsBox.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstTwoDotsBox.ForeColor = System.Drawing.Color.White;
            this.firstTwoDotsBox.Location = new System.Drawing.Point(117, 12);
            this.firstTwoDotsBox.Name = "firstTwoDotsBox";
            this.firstTwoDotsBox.Size = new System.Drawing.Size(22, 128);
            this.firstTwoDotsBox.TabIndex = 3;
            this.firstTwoDotsBox.Text = ":";
            // 
            // minutesBox
            // 
            this.minutesBox.BackColor = System.Drawing.Color.Black;
            this.minutesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minutesBox.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minutesBox.ForeColor = System.Drawing.Color.White;
            this.minutesBox.Location = new System.Drawing.Point(145, 12);
            this.minutesBox.MaxLength = 2;
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(105, 128);
            this.minutesBox.TabIndex = 4;
            this.minutesBox.Text = "00";
            // 
            // hoursBox
            // 
            this.hoursBox.BackColor = System.Drawing.Color.Black;
            this.hoursBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hoursBox.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursBox.ForeColor = System.Drawing.Color.White;
            this.hoursBox.Location = new System.Drawing.Point(6, 12);
            this.hoursBox.MaxLength = 2;
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(105, 128);
            this.hoursBox.TabIndex = 4;
            this.hoursBox.Text = "00";
            // 
            // secondTwoDots
            // 
            this.secondTwoDots.BackColor = System.Drawing.Color.Black;
            this.secondTwoDots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondTwoDots.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondTwoDots.ForeColor = System.Drawing.Color.White;
            this.secondTwoDots.Location = new System.Drawing.Point(254, 12);
            this.secondTwoDots.Name = "secondTwoDots";
            this.secondTwoDots.Size = new System.Drawing.Size(24, 128);
            this.secondTwoDots.TabIndex = 6;
            this.secondTwoDots.Text = ":";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(18, 136);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 59);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // lapButton
            // 
            this.lapButton.BackColor = System.Drawing.Color.Black;
            this.lapButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lapButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lapButton.ForeColor = System.Drawing.Color.White;
            this.lapButton.Location = new System.Drawing.Point(296, 136);
            this.lapButton.Name = "lapButton";
            this.lapButton.Size = new System.Drawing.Size(87, 59);
            this.lapButton.TabIndex = 8;
            this.lapButton.Text = "LAP";
            this.lapButton.UseVisualStyleBackColor = false;
            this.lapButton.Click += new System.EventHandler(this.lapButton_Click);
            // 
            // lapRichBox
            // 
            this.lapRichBox.BackColor = System.Drawing.Color.Black;
            this.lapRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lapRichBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lapRichBox.ForeColor = System.Drawing.Color.White;
            this.lapRichBox.Location = new System.Drawing.Point(12, 184);
            this.lapRichBox.Name = "lapRichBox";
            this.lapRichBox.Size = new System.Drawing.Size(371, 96);
            this.lapRichBox.TabIndex = 9;
            this.lapRichBox.Text = "";
            // 
            // Countdow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(395, 292);
            this.Controls.Add(this.lapRichBox);
            this.Controls.Add(this.lapButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.secondTwoDots);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.firstTwoDotsBox);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Countdow";
            this.Text = "Countdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox secondsBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox firstTwoDotsBox;
        private System.Windows.Forms.TextBox minutesBox;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.TextBox secondTwoDots;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button lapButton;
        private System.Windows.Forms.RichTextBox lapRichBox;
    }
}

