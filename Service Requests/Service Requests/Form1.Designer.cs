namespace Service_Requests
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            contentBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            completeBox = new CheckBox();
            notesBox = new TextBox();
            label5 = new Label();
            submitButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(18, 437);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 0;
            button1.Text = "Create Service Request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Date requested:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 83);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Technician assigned:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 146);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 3;
            label3.Text = "Request description:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(156, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(18, 173);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 195);
            textBox3.TabIndex = 6;
            // 
            // contentBox
            // 
            contentBox.BorderStyle = BorderStyle.FixedSingle;
            contentBox.Location = new Point(670, 19);
            contentBox.Multiline = true;
            contentBox.Name = "contentBox";
            contentBox.ReadOnly = true;
            contentBox.Size = new Size(444, 470);
            contentBox.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(343, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(105, 439);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(305, 50);
            button2.Name = "button2";
            button2.Size = new Size(32, 32);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 22);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 10;
            label4.Text = "Request Number:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(156, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // completeBox
            // 
            completeBox.AutoSize = true;
            completeBox.Enabled = false;
            completeBox.Location = new Point(510, 125);
            completeBox.Name = "completeBox";
            completeBox.Size = new Size(101, 19);
            completeBox.TabIndex = 12;
            completeBox.Text = "Is Completed?";
            completeBox.UseVisualStyleBackColor = true;
            completeBox.Visible = false;
            completeBox.CheckedChanged += completeBox_CheckedChanged;
            // 
            // notesBox
            // 
            notesBox.BorderStyle = BorderStyle.FixedSingle;
            notesBox.Enabled = false;
            notesBox.Location = new Point(476, 173);
            notesBox.Multiline = true;
            notesBox.Name = "notesBox";
            notesBox.Size = new Size(168, 206);
            notesBox.TabIndex = 13;
            notesBox.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(541, 155);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 14;
            label5.Text = "Notes:";
            label5.Visible = false;
            // 
            // submitButton
            // 
            submitButton.Enabled = false;
            submitButton.Location = new Point(521, 385);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 15;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Visible = false;
            submitButton.Click += submitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(1126, 511);
            Controls.Add(submitButton);
            Controls.Add(label5);
            Controls.Add(notesBox);
            Controls.Add(completeBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(contentBox);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Service Requests";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox contentBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private CheckBox completeBox;
        private TextBox notesBox;
        private Label label5;
        private Button submitButton;
    }
}