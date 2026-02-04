namespace truth_or_dare_with_best_friend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dare = new Button();
            panel1 = new Panel();
            closed = new Button();
            Truth = new Button();
            panel3 = new Panel();
            Text_thai3 = new Label();
            Text_thai2 = new Label();
            Text_thai1 = new Label();
            button_t_d = new Button();
            panel2 = new Panel();
            Text_Eng5 = new Label();
            Text_Eng4 = new Label();
            Text_Eng3 = new Label();
            Text_Eng2 = new Label();
            Text_Eng1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dare
            // 
            dare.BackColor = Color.Thistle;
            dare.FlatAppearance.BorderColor = Color.Thistle;
            dare.FlatStyle = FlatStyle.Flat;
            dare.Font = new Font("Kristen ITC", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dare.Image = (Image)resources.GetObject("dare.Image");
            dare.ImageAlign = ContentAlignment.TopCenter;
            dare.Location = new Point(90, 9);
            dare.Name = "dare";
            dare.Size = new Size(72, 70);
            dare.TabIndex = 1;
            dare.Text = "dare";
            dare.TextAlign = ContentAlignment.BottomCenter;
            dare.UseVisualStyleBackColor = false;
            dare.Click += dare_Click;
            dare.Leave += dare_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Moccasin;
            panel1.Controls.Add(closed);
            panel1.Controls.Add(Truth);
            panel1.Controls.Add(dare);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 79);
            panel1.TabIndex = 3;
            // 
            // closed
            // 
            closed.BackColor = Color.Moccasin;
            closed.BackgroundImageLayout = ImageLayout.None;
            closed.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            closed.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closed.Location = new Point(333, 3);
            closed.Name = "closed";
            closed.Size = new Size(23, 27);
            closed.TabIndex = 7;
            closed.Text = "X";
            closed.UseVisualStyleBackColor = false;
            closed.Click += closed_Click;
            // 
            // Truth
            // 
            Truth.BackColor = Color.LightPink;
            Truth.FlatAppearance.BorderColor = Color.Thistle;
            Truth.FlatStyle = FlatStyle.Flat;
            Truth.Font = new Font("Kristen ITC", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Truth.Image = (Image)resources.GetObject("Truth.Image");
            Truth.ImageAlign = ContentAlignment.TopCenter;
            Truth.Location = new Point(12, 9);
            Truth.Name = "Truth";
            Truth.Size = new Size(72, 70);
            Truth.TabIndex = 3;
            Truth.Text = "Truth";
            Truth.TextAlign = ContentAlignment.BottomCenter;
            Truth.UseVisualStyleBackColor = false;
            Truth.Click += Truth_Click;
            Truth.Leave += Truth_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(Text_thai3);
            panel3.Controls.Add(Text_thai2);
            panel3.Controls.Add(Text_thai1);
            panel3.Location = new Point(48, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 156);
            panel3.TabIndex = 5;
            // 
            // Text_thai3
            // 
            Text_thai3.AutoSize = true;
            Text_thai3.Font = new Font("Siemens Serif Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_thai3.Location = new Point(15, 95);
            Text_thai3.Name = "Text_thai3";
            Text_thai3.Size = new Size(0, 29);
            Text_thai3.TabIndex = 3;
            // 
            // Text_thai2
            // 
            Text_thai2.AutoSize = true;
            Text_thai2.Font = new Font("Siemens Serif Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_thai2.Location = new Point(15, 63);
            Text_thai2.Name = "Text_thai2";
            Text_thai2.Size = new Size(0, 29);
            Text_thai2.TabIndex = 2;
            // 
            // Text_thai1
            // 
            Text_thai1.AutoSize = true;
            Text_thai1.Font = new Font("Siemens Serif Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_thai1.Location = new Point(15, 31);
            Text_thai1.Name = "Text_thai1";
            Text_thai1.Size = new Size(191, 29);
            Text_thai1.TabIndex = 1;
            Text_thai1.Text = "คุณเคยทำให้ใครอกหักไหม";
            Text_thai1.Click += Text_thai_Click;
            // 
            // button_t_d
            // 
            button_t_d.BackColor = Color.Silver;
            button_t_d.FlatAppearance.BorderColor = Color.Silver;
            button_t_d.FlatStyle = FlatStyle.Flat;
            button_t_d.ForeColor = SystemColors.ControlText;
            button_t_d.Image = (Image)resources.GetObject("button_t_d.Image");
            button_t_d.Location = new Point(48, 524);
            button_t_d.Name = "button_t_d";
            button_t_d.Size = new Size(264, 54);
            button_t_d.TabIndex = 6;
            button_t_d.UseVisualStyleBackColor = false;
            button_t_d.Click += button_t_d_Click;
            button_t_d.Leave += button_t_d_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(Text_Eng5);
            panel2.Controls.Add(Text_Eng4);
            panel2.Controls.Add(Text_Eng3);
            panel2.Controls.Add(Text_Eng2);
            panel2.Controls.Add(Text_Eng1);
            panel2.Location = new Point(48, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 156);
            panel2.TabIndex = 6;
            // 
            // Text_Eng5
            // 
            Text_Eng5.AutoSize = true;
            Text_Eng5.BackColor = Color.LavenderBlush;
            Text_Eng5.Font = new Font("Siemens Serif Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_Eng5.ForeColor = SystemColors.ActiveCaptionText;
            Text_Eng5.Location = new Point(15, 107);
            Text_Eng5.Name = "Text_Eng5";
            Text_Eng5.Size = new Size(0, 23);
            Text_Eng5.TabIndex = 4;
            // 
            // Text_Eng4
            // 
            Text_Eng4.AutoSize = true;
            Text_Eng4.BackColor = Color.LavenderBlush;
            Text_Eng4.Font = new Font("Siemens Serif Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_Eng4.ForeColor = SystemColors.ActiveCaptionText;
            Text_Eng4.Location = new Point(15, 84);
            Text_Eng4.Name = "Text_Eng4";
            Text_Eng4.Size = new Size(0, 23);
            Text_Eng4.TabIndex = 3;
            Text_Eng4.Click += label2_Click;
            // 
            // Text_Eng3
            // 
            Text_Eng3.AutoSize = true;
            Text_Eng3.BackColor = Color.LavenderBlush;
            Text_Eng3.Font = new Font("Siemens Serif Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_Eng3.ForeColor = SystemColors.ActiveCaptionText;
            Text_Eng3.Location = new Point(15, 61);
            Text_Eng3.Name = "Text_Eng3";
            Text_Eng3.Size = new Size(0, 23);
            Text_Eng3.TabIndex = 2;
            // 
            // Text_Eng2
            // 
            Text_Eng2.AutoSize = true;
            Text_Eng2.BackColor = Color.LavenderBlush;
            Text_Eng2.Font = new Font("Siemens Serif Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_Eng2.ForeColor = SystemColors.ActiveCaptionText;
            Text_Eng2.Location = new Point(15, 38);
            Text_Eng2.Name = "Text_Eng2";
            Text_Eng2.Size = new Size(165, 23);
            Text_Eng2.TabIndex = 1;
            Text_Eng2.Text = "someone’s heart";
            // 
            // Text_Eng1
            // 
            Text_Eng1.AutoSize = true;
            Text_Eng1.BackColor = Color.LavenderBlush;
            Text_Eng1.Font = new Font("Siemens Serif Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_Eng1.ForeColor = SystemColors.ActiveCaptionText;
            Text_Eng1.Location = new Point(15, 15);
            Text_Eng1.Name = "Text_Eng1";
            Text_Eng1.Size = new Size(223, 23);
            Text_Eng1.TabIndex = 0;
            Text_Eng1.Text = "Have you ever broken ";
            Text_Eng1.Click += Text_Eng_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(360, 640);
            Controls.Add(panel2);
            Controls.Add(button_t_d);
            Controls.Add(panel3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Truth or dare with beat friend";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button dare;
        private Panel panel1;
        private Button Truth;
        private Panel panel3;
        private Button button_t_d;
        private Panel panel2;
        private Button closed;
        private Label Text_thai1;
        private Label Text_Eng1;
        private Label Text_Eng2;
        private Label Text_Eng4;
        private Label Text_Eng3;
        private Label Text_thai3;
        private Label Text_thai2;
        private Label Text_Eng5;
    }
}
