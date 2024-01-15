using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberpunkSRTF
{

    public partial class CyberpunkForm : Form
    {

        private int Processes;
        private int a;
        private int counter1;

        string[] ProcessNameNum;

        string[] ProcessName;
        int[] arrivalTime;
        int[] burstTime;
        string[] shortestTimeArr;
        int idcount = 0;

        int numP;
        public string itm;
        public string[] arr;

        int[] waitingTime;
        int[] remainingTime;

        int counter = 0;

        int complete = 0, t = 0, minimum = int.MaxValue;
        int shortestTime = 0, finish_time;
        bool check = false;

        int lvHeight = 38;

        int X =0;
        int gcX = 70;
        int gcY = 70;

        int statusX = 0;
        int statusY = 0;

        Boolean processExist = false;


        Font font = new Font("Conthrax Regular", 16);
        Font SmallFont = new Font("Conthrax Regular", 16);

        string ErrorMessage = "Maximum Number of Process is 10.";
        string ErrorTitle = "Error";

        List<Process> Process_List = new List<Process>();
        List<Process> ganttChart = new List<Process>();


        public CyberpunkForm()
        {
            InitializeComponent();
        }


        public class Process
        {
            public int burst_time, priorty, arrival_time, Pwaiting_time, PturnAround_time, status, compeletion_time;
            public String P_id;
            readonly static Random rand = new Random();
            public Color process_color = new Color();

            public Process(String id, int b_time, int a_time)
            {

                P_id = id;
                burst_time = b_time;
                arrival_time = a_time;
                status = 0;
                PturnAround_time = 0;
                Pwaiting_time = 0;
                compeletion_time = 0;
                process_color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }
        }

       

        private void CyberpunkForm_Load(object sender, EventArgs e)
        {
            //Panels
            LoadingStart.Start();
            StartLoadingpnl.Show();
            
            Homepnl.Hide();
            Inputpnl.Hide();
            simLoadpnl.Hide();
            simulatepnl.Hide();

            //Input Panel Page Objects
            processNumlbl.Hide();
            processpnl.Hide();
            addProcessbtn.Hide();
            simulatebtn.Hide();


        }

        private void LoadingStart_Tick(object sender, EventArgs e)
        {


            if (progressBarStart.Value < 100)
            {
                progressBarStart.ForeColor = Color.Red;
                progressBarStart.BackColor = Color.Red;
                progressBarStart.Value += 5;

                progressBarStartlbl.Text = progressBarStart.Value.ToString() + "%";
            }
            else
            {
                StartLoadingpnl.Hide();

                Homepnl.Show();

                LoadingStart.Stop();
            }
        }


        private void Startbtn_Click(object sender, EventArgs e)
        {
            Homepnl.Hide();

            panel2.Hide();
            simulatepnl.Show();
            Inputpnl.Show();

            

        }

        private void numProcessConfirmbtn_Click(object sender, EventArgs e)
        {
            //variable
            Processes = Convert.ToInt32(numProcesstxt.Text);

            numP = Processes;

            ProcessNameNum = new String[numP];

            waitingTime = new int[numP];
            remainingTime = new int[numP];

            ProcessName = new string[Processes];
            arrivalTime = new int[Processes];
            burstTime = new int[Processes];

            ErrorMessage = "Maximum Number of Process is 10.";
            ErrorTitle = "Error";


            if (Processes > 10)
            {
                MessageBox.Show(ErrorMessage, ErrorTitle);
                numProcesstxt.Clear();
            }
            else
            {
                //Input Panel Page Objects
                processNumlbl.Show();
                processpnl.Show();
                addProcessbtn.Show();
                //simulatebtn.Show();

                numProcesstxt.Text = numProcesstxt.Text;
                numProcesstxt.Enabled = false;
                numProcessConfirmbtn.Enabled = false;
            }

            a = 0;
            counter1 = 02;
        }

        private void addRow(String pName, int pAt, int pBt, int pWt, int pTat)
        {
            String[] addRow = { pName, (Convert.ToString(pAt)), (Convert.ToString(pBt)), (Convert.ToString(pWt)), (Convert.ToString(pTat)) };

            ListViewItem itm = new ListViewItem(addRow);

            processlview.Items.Add(itm);
        }

        private void addProcessbtn_Click(object sender, EventArgs e)
        {
            String checkProcess = processNametxt.Text;
            

            for (int i = 0; i < numP; i++)
            {
                if(checkProcess == ProcessName[i])
                {
                    processExist = true;
                }
            }

            if(processExist)
            {
                ErrorMessage = "Process Name " + checkProcess + " Already Exists!";
                ErrorTitle = "Error";

                MessageBox.Show(ErrorMessage, ErrorTitle);

                processNametxt.Text = "";
                arrivalTimetxt.Value = 0;
                burstTimetxt.Value = 0;
                
                processExist = false;

                return;
            }
            ProcessName[a] = processNametxt.Text;
            arrivalTime[a] = Convert.ToInt32(arrivalTimetxt.Value);
            burstTime[a] = Convert.ToInt32(burstTimetxt.Value);

            String temp = processNametxt.Text;

            ProcessNameNum[a] = Convert.ToString(Array.IndexOf(ProcessName, temp) +1);

            Process_List.Add(new Process(ProcessNameNum[a], burstTime[a], arrivalTime[a]));


            if (counter1 == 10)
            {
                processNumlbl.Text = "Process #" + counter1 + ":";
            }
            else
            {
                processNumlbl.Text = "Process #0" + counter1 + ":";
            }

            a++;

            processNametxt.Text = "";
            arrivalTimetxt.Value = 0;
            burstTimetxt.Value = 0;

            if (counter1 != Processes)
            {
                counter1++;
            }
            if (a >= Processes)
            {
                processNametxt.Text = ProcessName[a - 1];
                arrivalTimetxt.Text = Convert.ToString(arrivalTime[a - 1]);
                burstTimetxt.Text = Convert.ToString(burstTime[a - 1]);
                processNametxt.Enabled = false;
                arrivalTimetxt.Enabled = false;
                burstTimetxt.Enabled = false;
                addProcessbtn.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;

                simulatebtn.Show();
            }



        }

        private void simLoadtmr_Tick(object sender, EventArgs e)
        {
            if (progressBarSimLoad.Value < 100)
            {
                progressBarSimLoad.ForeColor = Color.Red;
                progressBarSimLoad.BackColor = Color.Red;
                progressBarSimLoad.Value += 1;
            }
            else
            {
                simulatepnl.Show();
                simLoadpnl.Hide();
                simLoadtmr.Stop();

            }
        }

        private void simulatebtn_Click(object sender, EventArgs e)
        {
            Inputpnl.Hide();

            simLoadtmr.Start();
            simLoadpnl.Show();

            shortestTimeArr = new String[100];

            
            //find waiting time
            // Copy the burst time into rt[]
            for (int i = 0; i < numP; i++)
            {
                remainingTime[i] = burstTime[i];
            }

            // Process until all processes gets
            // completed
            while (complete != numP)
            {

                // Find process with minimum
                // remaining time among the
                // processes that arrives till the
                // current time`
                for (int j = 0; j < numP; j++)
                {
                    if ((arrivalTime[j] <= t) &&
                    (remainingTime[j] < minimum) && remainingTime[j] > 0)
                    {
                        minimum = remainingTime[j];
                        shortestTime = j;
                        check = true;

                        
                    }
                    
                }

                if (check == false)
                {
                    t++;
                }

                shortestTimeArr[idcount] = (Process_List[shortestTime].P_id);


                ganttChart.Add(Process_List[shortestTime]);

                // Reduce remaining time by one
                remainingTime[shortestTime]--;

                Label label1 = new Label();
                gcPane.Controls.Add(label1);
                label1.Size = new Size(gcY, gcX);
                label1.Text = "P" + Convert.ToString(Process_List[shortestTime].P_id);
                label1.Location = new Point(X, 0);
                label1.BackColor = Process_List[shortestTime].process_color;
                label1.Name = "gcIdlbl";
                X += label1.Width;
                label1.BorderStyle = BorderStyle.FixedSingle;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Font = font;

                idcount += 1;


                // Update minimum
                minimum = remainingTime[shortestTime];

                // If a process gets completely
                // executed
                if (remainingTime[shortestTime] == 0)
                {
                    minimum = int.MaxValue;

                    // Increment complete
                    complete++;
                    check = false;

                    // Find finish time of current
                    // process
                    finish_time = t + 1;

                    // Calculate waiting time
                    waitingTime[shortestTime] = finish_time -
                                burstTime[shortestTime] -
                                arrivalTime[shortestTime];

                    if (waitingTime[shortestTime] < 0)
                        waitingTime[shortestTime] = 0;
                }


                //Process Execution Status
                    Label proclbl = new Label();
                    statuspnl.Controls.Add(proclbl);
                    proclbl.Size = new Size(810, 40);
                    proclbl.Text = "Executing Process " + Convert.ToString(Process_List[shortestTime].P_id) + " ...";
                    proclbl.Location = new Point(statusX, statusY);
                    proclbl.BackColor = Color.Transparent;
                    proclbl.Name = "procIdlbl";
                    proclbl.BorderStyle = BorderStyle.None;
                    proclbl.TextAlign = ContentAlignment.MiddleLeft;
                    proclbl.Font = font;

                    statusY += 60;

                    //System.Threading.Thread.Sleep(1000);

                    proclbl.ForeColor = Color.White;



                // Increment time
                t++;


            }

            statusY += 60;

            for (int a = 0; a < numP; a++)
                {
                    Label proclbld = new Label();
                    statuspnl.Controls.Add(proclbld);
                    proclbld.Size = new Size(810, 40);
                    proclbld.Location = new Point(statusX, statusY);
                    proclbld.BackColor = Color.Transparent;
                    proclbld.Name = "procIdlbl";
                    proclbld.BorderStyle = BorderStyle.None;
                    proclbld.TextAlign = ContentAlignment.MiddleLeft;
                    proclbld.Font = font;
                    proclbld.ForeColor = Color.Cyan;
                    proclbld.Text = "Process " + ProcessName[a] + ": [DONE]";

                    statusY += 60;
            }


            panel2.Show();

            PrintGanttChart(ganttChart, new TextBox(), new TextBox(), new TextBox());

            //find turn around time
            int[] tat = new int[numP];
            int total_wt = 0, total_tat = 0;

            //Display processes in List View
            for (int i = 0; i < numP; i++)
            {
                tat[i] = burstTime[i] + waitingTime[i];

                addRow("[P" + (i + 1) + "] " + ProcessName[i], arrivalTime[i], burstTime[i], waitingTime[i], tat[i]);

                lvHeight += 36;

                processlview.Size = new Size(1283, lvHeight);
                hidepnl.Size = new Size(59, lvHeight);
            }

            //Display average wt and TaT

            for (int i = 0; i < numP; i++)
            {
                total_wt = total_wt + waitingTime[i];
                total_tat = total_tat + tat[i];
            }

            float aveWT = (float)total_wt / (float)numP;
            float aveTaT = (float)total_tat / (float)numP;

            aveWaitingTimelbl.Text = Convert.ToString("Average Waiting Time: " + Math.Round((float)aveWT, 2));
            aveTaTimelbl.Text = Convert.ToString("Average Turnaround Time: " + Math.Round((float)aveTaT, 2));

        }

        public void PrintGanttChart(List<Process> ganttChart, TextBox textBox7, TextBox textBox5, TextBox textBox1)
        {
            int num = 0;
            X = 0;

            for (; num < ganttChart.Count; num++)
            {
                Label label2 = new Label();
                gcPane.Controls.Add(label2);
                label2.Size = new Size(gcY, gcX);
                label2.Text = num.ToString();
                label2.Location = new Point(X, 70);
                label2.BackColor = Color.Transparent;
                label2.Name = "gcCountlbl";
                X += label2.Width;
                label2.BorderStyle = BorderStyle.FixedSingle;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label2.Font = font;
            }
        }

        private void rerunSimbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
