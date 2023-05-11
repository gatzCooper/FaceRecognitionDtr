namespace faceRecognitionDtr
{
    partial class faceRegistration
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            userId = new Button();
            name = new Button();
            registerFace = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 109);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FaceRecognitionDtr.Properties.Resources._3dgifmaker46096;
            pictureBox1.Location = new Point(145, 0);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(258, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(542, 61);
            label1.TabIndex = 0;
            label1.Text = "NC Face Recognition DTR";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(115, 47);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 29);
            label2.TabIndex = 1;
            label2.Text = "Please have your face";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 104);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 579);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.LightGray;
            flowLayoutPanel2.ForeColor = SystemColors.ControlDark;
            flowLayoutPanel2.Location = new Point(57, 141);
            flowLayoutPanel2.Margin = new Padding(5, 4, 5, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(331, 321);
            flowLayoutPanel2.TabIndex = 4;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(145, 76);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 29);
            label3.TabIndex = 3;
            label3.Text = "registered here";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.ForeColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(571, 151);
            flowLayoutPanel1.Margin = new Padding(5, 4, 5, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(275, 253);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // userId
            // 
            userId.BackColor = SystemColors.HotTrack;
            userId.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            userId.ForeColor = Color.White;
            userId.Location = new Point(571, 422);
            userId.Margin = new Padding(5, 4, 5, 4);
            userId.Name = "userId";
            userId.Size = new Size(275, 63);
            userId.TabIndex = 4;
            userId.Text = "User ID";
            userId.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            name.BackColor = SystemColors.HotTrack;
            name.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            name.ForeColor = Color.White;
            name.Location = new Point(571, 503);
            name.Margin = new Padding(5, 4, 5, 4);
            name.Name = "name";
            name.Size = new Size(275, 63);
            name.TabIndex = 5;
            name.Text = "Name";
            name.UseVisualStyleBackColor = false;
            // 
            // registerFace
            // 
            registerFace.BackColor = SystemColors.HotTrack;
            registerFace.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            registerFace.ForeColor = Color.White;
            registerFace.Location = new Point(571, 584);
            registerFace.Margin = new Padding(5, 4, 5, 4);
            registerFace.Name = "registerFace";
            registerFace.Size = new Size(275, 63);
            registerFace.TabIndex = 6;
            registerFace.Text = "Register Face";
            registerFace.UseVisualStyleBackColor = false;
            // 
            // faceRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 681);
            Controls.Add(registerFace);
            Controls.Add(name);
            Controls.Add(userId);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(5, 3, 5, 3);
            Name = "faceRegistration";
            Text = "Face Registration";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button userId;
        private Button name;
        private Button registerFace;
    }
}