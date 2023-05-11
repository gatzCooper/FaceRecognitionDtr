namespace faceRecognitionDtr
{
    partial class userTimeIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userTimeIn));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label_time = new Label();
            label_date1 = new Label();
            button_timeIn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label_userName = new Label();
            label_greetings = new Label();
            label_date = new Label();
            label_realTime = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 109);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = FaceRecognitionDtr.Properties.Resources._3dgifmaker46096;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(166, -39);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(275, 24);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(542, 61);
            label1.TabIndex = 0;
            label1.Text = "NC Face Recognition DTR";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label_time);
            panel2.Controls.Add(label_date1);
            panel2.Location = new Point(2, 620);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 60);
            panel2.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(134, 23);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(5, 23);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(469, 21);
            label4.TabIndex = 20;
            label4.Text = "Group 1- BSCS4B  💜  Angeles, Cruz, De Leon, Gatacelo, San Pedro";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_time.ForeColor = Color.White;
            label_time.Location = new Point(824, 9);
            label_time.Margin = new Padding(5, 0, 5, 0);
            label_time.Name = "label_time";
            label_time.Size = new Size(70, 21);
            label_time.TabIndex = 19;
            label_time.Text = "4:30 PM";
            // 
            // label_date1
            // 
            label_date1.AutoSize = true;
            label_date1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_date1.ForeColor = Color.White;
            label_date1.Location = new Point(770, 29);
            label_date1.Margin = new Padding(5, 0, 5, 0);
            label_date1.Name = "label_date1";
            label_date1.Size = new Size(178, 21);
            label_date1.TabIndex = 18;
            label_date1.Text = "Thursday, May 11, 2023";
            // 
            // button_timeIn
            // 
            button_timeIn.BackColor = SystemColors.HotTrack;
            button_timeIn.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_timeIn.ForeColor = Color.White;
            button_timeIn.Location = new Point(583, 436);
            button_timeIn.Margin = new Padding(5, 4, 5, 4);
            button_timeIn.Name = "button_timeIn";
            button_timeIn.Size = new Size(243, 63);
            button_timeIn.TabIndex = 25;
            button_timeIn.Text = "TIME IN";
            button_timeIn.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.ForeColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(583, 151);
            flowLayoutPanel1.Margin = new Padding(5, 4, 5, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(243, 259);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // label_userName
            // 
            label_userName.AutoSize = true;
            label_userName.BackColor = Color.Transparent;
            label_userName.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_userName.ForeColor = SystemColors.HotTrack;
            label_userName.Location = new Point(136, 357);
            label_userName.Margin = new Padding(5, 0, 5, 0);
            label_userName.Name = "label_userName";
            label_userName.Size = new Size(272, 37);
            label_userName.TabIndex = 22;
            label_userName.Text = "Gatacelo, Jacqueline";
            // 
            // label_greetings
            // 
            label_greetings.AutoSize = true;
            label_greetings.BackColor = Color.Transparent;
            label_greetings.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_greetings.ForeColor = SystemColors.HotTrack;
            label_greetings.ImageAlign = ContentAlignment.MiddleRight;
            label_greetings.Location = new Point(136, 320);
            label_greetings.Margin = new Padding(5, 0, 5, 0);
            label_greetings.Name = "label_greetings";
            label_greetings.Size = new Size(274, 37);
            label_greetings.TabIndex = 21;
            label_greetings.Text = "Good day, Welcome!";
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Font = new Font("Calibri", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_date.Location = new Point(158, 260);
            label_date.Margin = new Padding(5, 0, 5, 0);
            label_date.Name = "label_date";
            label_date.Size = new Size(226, 27);
            label_date.TabIndex = 20;
            label_date.Text = "Thursday, May 11, 2023";
            // 
            // label_realTime
            // 
            label_realTime.AutoSize = true;
            label_realTime.Font = new Font("Calibri", 50.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_realTime.Location = new Point(122, 151);
            label_realTime.Margin = new Padding(5, 0, 5, 0);
            label_realTime.Name = "label_realTime";
            label_realTime.Size = new Size(333, 103);
            label_realTime.TabIndex = 19;
            label_realTime.Text = "4:30 PM";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(646, 517);
            pictureBox3.Margin = new Padding(5, 4, 5, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // userTimeIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 681);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button_timeIn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label_userName);
            Controls.Add(label_greetings);
            Controls.Add(label_date);
            Controls.Add(label_realTime);
            Name = "userTimeIn";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label_time;
        private Label label_date1;
        private Button button_timeIn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label_userName;
        private Label label_greetings;
        private Label label_date;
        private Label label_realTime;
        private PictureBox pictureBox3;
    }
}