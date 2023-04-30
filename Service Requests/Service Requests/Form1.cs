//program created by Alfred Fagan

using System.Diagnostics.CodeAnalysis;

namespace Service_Requests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //keeps the last datapath as a varible to callback to
        public string lastPath = "";


        
        private void button1_Click(object sender, EventArgs e)
        {
            //continues to program if the text boxes are filled with information
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                //uses a Stream Reader to find the last request number used and adds it by one to create a new number
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Service_Requests\\" + "\\Bin\\" + "\\Newest.txt");
                string newestRequest = sr.ReadToEnd();
                string requestNum = (Int32.Parse(newestRequest) + 1).ToString();
                sr.Close();

                //uses a stream writer to replace the last request number with the one that was just used
                StreamWriter sw2 = new StreamWriter(Application.StartupPath + "\\Service_Requests\\" + "\\Bin\\" + "\\Newest.txt");
                sw2.Write(requestNum);
                sw2.Close();

                //uses a stream writer to create a new file and fill it with the corresponding info, whenever a request is made
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Service_Requests\\" + requestNum + ".txt");
                sw.WriteLine("Request number: " + requestNum);
                sw.WriteLine(label1.Text + " " + dateTimePicker1.Text);
                sw.WriteLine(label2.Text + " " + textBox2.Text);
                sw.WriteLine(label3.Text + " " + textBox3.Text);
                sw.Close();
                textBox2.Text = "";
                textBox3.Text = "";
            }
            //invokes button 2's event handler to refresh the list of requests whenever a new one is made
            button2.PerformClick();
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            //uses directory info to seek all the contents in a folder
            string path = (Application.StartupPath + "\\Service_Requests\\");
            DirectoryInfo dInfo = new DirectoryInfo(path);

            //for every file in the directory if not yet added to the flow panel, create a button for every file to the panel
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
            //makes all previously visible controls invisible and disabled until activated again
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

            //uses senders string to find the name of the filepath so the program can find the correlated file, for the button clicked
            string fileName = sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");
            fileName += ".txt";
            string pathOfFile = (Application.StartupPath + "\\Service_Requests\\" + fileName);

            //uses stream reader to append text to a varible for each line read in the file
            //also checks to see if the Request is complete
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

            //displays the contents of the file in the content box on the far right
            contentBox.Text = content;
            sr.Close();
            
            //if request is complete, dont show the "isComplete" checkbox
            if (isComplete == false)
            {
                completeBox.Enabled = true;
                completeBox.Visible = true;
            }
            lastPath = pathOfFile;
        }

        private void completeBox_CheckedChanged(object sender, EventArgs e)
        {
            //if the checkbox is checked, show the other corresponding controls
            label5.Visible = true;
            notesBox.Visible = true;
            notesBox.Enabled = true;
            submitButton.Enabled = true;
            submitButton.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //once submit button is pressed, it appends the completed status, as well as the notes given to the end of the file
            //then disables the corresponding controls, and clears the content box
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