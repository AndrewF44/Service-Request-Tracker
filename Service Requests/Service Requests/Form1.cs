using System.Diagnostics.CodeAnalysis;

namespace Service_Requests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string lastPath = "";



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Service_Requests\\" + "\\Bin\\" + "\\Newest.txt");
                string newestRequest = sr.ReadToEnd();
                string requestNum = (Int32.Parse(newestRequest) + 1).ToString();
                sr.Close();
                StreamWriter sw2 = new StreamWriter(Application.StartupPath + "\\Service_Requests\\" + "\\Bin\\" + "\\Newest.txt");
                sw2.Write(requestNum);
                sw2.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Service_Requests\\" + requestNum + ".txt");
                sw.WriteLine("Request number: " + requestNum);
                sw.WriteLine(label1.Text + " " + dateTimePicker1.Text);
                sw.WriteLine(label2.Text + " " + textBox2.Text);
                sw.WriteLine(label3.Text + " " + textBox3.Text);
                sw.Close();
                textBox2.Text = "";
                textBox3.Text = "";
            }
            button2.PerformClick();
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            string path = (Application.StartupPath + "\\Service_Requests\\");
            DirectoryInfo dInfo = new DirectoryInfo(path);
            foreach (var file in dInfo.GetFiles("*.txt"))
            {
                if (flowLayoutPanel1.Controls.ContainsKey((file.Name).Replace(".txt", "")) == false)
                {
                    Button button = new Button();
                    button.Text = (file.Name).Replace(".txt", "");
                    button.Name = (file.Name).Replace(".txt", "");
                    button.Click += new EventHandler(openButton_Click);
                    flowLayoutPanel1.Controls.Add(button);
                }
            }
        }
        protected void openButton_Click(object sender, EventArgs e)
        {
            completeBox.Enabled = false;
            completeBox.Visible = false;
            completeBox.Checked = false;
            notesBox.Text = "";
            label5.Visible = false;
            notesBox.Visible = false;
            notesBox.Enabled = false;
            completeBox.Enabled = false;
            completeBox.Visible = false;
            submitButton.Visible = false;
            submitButton.Enabled = false;
            string fileName = sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");
            fileName += ".txt";
            string pathOfFile = (Application.StartupPath + "\\Service_Requests\\" + fileName);
            StreamReader sr = new StreamReader(pathOfFile);
            string content = "";
            bool isComplete = false;
            foreach (var line in sr.ReadToEnd())
            {
                content += line;
                if (content.Contains("Completed!"))
                {
                    isComplete = true;
                }
            }
            contentBox.Text = content;
            sr.Close();
            if (isComplete == false)
            {
                completeBox.Enabled = true;
                completeBox.Visible = true;
            }
            lastPath = pathOfFile;
        }

        private void completeBox_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            notesBox.Visible = true;
            notesBox.Enabled = true;
            submitButton.Enabled = true;
            submitButton.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(lastPath);
            sw.WriteLine("Completed!");
            sw.WriteLine("Notes:");
            sw.WriteLine(notesBox.Text);
            sw.Close();
            label5.Visible = false;
            notesBox.Visible = false;
            notesBox.Enabled = false;
            completeBox.Enabled = false;
            completeBox.Visible = false;
            submitButton.Visible = false;
            submitButton.Enabled = false;
            contentBox.Text = "";
            
        }
    }
}