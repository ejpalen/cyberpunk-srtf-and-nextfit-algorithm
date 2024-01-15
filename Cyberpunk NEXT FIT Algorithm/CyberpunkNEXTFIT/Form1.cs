using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberpunkNEXTFIT
{
    public partial class CyberpunkNF : Form
    {
        public const int MaxProcesses = 20;
        public int Processes;
        public int Blocks;
        public int a = 0, n, m;
        public int counter1;
        public string[] arr;
        public string[] ProcessName = new string[MaxProcesses];
        public int[] BlockSize = new int[MaxProcesses];
        public int[] ProcessSize = new int[MaxProcesses];
        public int[] allocation;

        int blocklvHeight = 36, lvwProcessHeight= 36;

        string ErrorMessage = "Maximum Number of Process is 10.";
        string ErrorTitle = "Error";

        Boolean processExist = false;

        public CyberpunkNF()
        {
            InitializeComponent();
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
                StartLoadingpnl.Enabled = false;

                Homepnl.Show();

                LoadingStart.Stop();
            }
        }

        private void CyberpunkNF_Load(object sender, EventArgs e)
        {
            //lvw settings
            lvwProcess.View = View.Details;
            lvwProcess.FullRowSelect = true;
            lvwProcess.GridLines = true;

            //Panels
            LoadingStart.Start();
            StartLoadingpnl.Show();

            Homepnl.Hide();
            inputProcesspnl.Hide();
            inputBlockpnl.Hide();

            simulatepnl.Hide();

            blockNumlbl.Hide();
            panel2.Hide();
            addBlockbtn.Hide();
            simulatebtn.Hide();

            //Input Process Objects
            processNumlbl.Hide();
            processpnl.Hide();
            addProcessbtn.Hide();
            nextbtn.Hide();

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Homepnl.Hide();
            Homepnl.Enabled = false;

            inputBlockpnl.Show();
        }

        private void StartLoadingpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputBlockpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numProcessConfirmbtn_Click(object sender, EventArgs e)
        {
            //variable
            Processes = Convert.ToInt32(numProcesstxt.Text);


            ProcessSize = new int[Processes];
            ProcessName = new string[Processes];

            ErrorMessage = "Maximum Number of Process is 10.";
            ErrorTitle = "Error";


            if (Processes > 10)
            {
                MessageBox.Show(ErrorMessage, ErrorTitle);
                numProcesstxt.Clear();
            }
            else
            {
                //Input Process Panel Objects
                processNumlbl.Show();
                processpnl.Show();
                addProcessbtn.Show();

                numProcesstxt.Text = numProcesstxt.Text;
                numProcesstxt.Enabled = false;
                numProcessConfirmbtn.Enabled = false;
                textBox4.Enabled = false;
            }

            counter1 = 02;

        }

        private void numBlocksConfirmbtn_Click(object sender, EventArgs e)
        {


            Blocks = Convert.ToInt32(numBlockstxt.Text);

            ErrorMessage = "Maximum Number of Blocks is 10.";
            ErrorTitle = "Error";


            if (Blocks > 10)
            {
                MessageBox.Show(ErrorMessage, ErrorTitle);
                numBlockstxt.Clear();
            }
            else
            {
                blockNumlbl.Show();
                panel2.Show();
                addBlockbtn.Show();

                numBlockstxt.Text = numBlockstxt.Text;

                numBlockstxt.Enabled = false;
                numBlocksConfirmbtn.Enabled = false;
                textBox6.Enabled = false;
            }
        }

        private void addBlockbtn_Click(object sender, EventArgs e)
        {
            //inputs

            BlockSize[this.a] = Convert.ToInt32(blockSizetxt.Text);

            String[] addRow = { (Convert.ToString(this.a + 1)), (Convert.ToString(BlockSize[this.a])) };

            ListViewItem block = new ListViewItem(addRow);

            blocklview.Items.Add(block);

            int blockctr = 2;

            if (counter1 == 10)
            {
                blockNumlbl.Text = "BLOCK #" + blockctr + ":";
            }
            else
            {
                blockNumlbl.Text = "BLOCK #0" + blockctr + ":";
            }

            this.a++;


            blockSizetxt.Value = 0;
            blockSizetxt.Focus();

            if (counter1 != Blocks)
            {
                counter1++;
                blockctr++;
            }

            if (this.a == Blocks)
            {
                if (Blocks == 10)
                {
                    blockNumlbl.Text = "BLOCK #" + Blocks + ":";
                }
                else
                {
                    blockNumlbl.Text = "BLOCK #0" + Blocks + ":";
                }

                addBlockbtn.Enabled = false;
                blockSizetxt.Value = BlockSize[Blocks - 1];
                blockSizetxt.Enabled = false;
                textBox8.Enabled = false;
                nextbtn.Show();
                a = 0;
            }

        }

        private void addProcessbtn_Click(object sender, EventArgs e)
        {
            String checkProcess = processNametxt.Text;

            for (int i = 0; i < Processes; i++)
            {
                if (checkProcess == ProcessName[i])
                {
                    processExist = true;
                }
            }

            if (processExist)
            {
                ErrorMessage = "Process Name " + checkProcess  +  " Already Exists!";
                ErrorTitle = "Error";

                MessageBox.Show(ErrorMessage, ErrorTitle);

                processNametxt.Text = "";
                processSizetxt.Value = 0;

                processExist = false;

                return;
            }

            //variables and input for processes name, size and block sizes
            //inputs


            ProcessName[this.a] = processNametxt.Text;
            ProcessSize[this.a] = Convert.ToInt32(processSizetxt.Text);

            if (counter1 == 10)
            {
                processNumlbl.Text = "Process #" + counter1 + ":";
            }
            else
            {
                processNumlbl.Text = "Process #0" + counter1 + ":";
            }

            this.a++;

            //default texts

            processNametxt.Clear();
            processSizetxt.Value = 0;

            processNametxt.Focus();
            processSizetxt.Focus();

            if (counter1 != Processes)
            {
                counter1++;
            }


            if (this.a == Processes)
            {
                if (Processes == 10)
                {
                    processNumlbl.Text = "Process #" + Processes + ":";
                }
                else
                {
                    processNumlbl.Text = "Process #0" + Processes + ":";
                }

                addProcessbtn.Enabled = false;
                processNametxt.Enabled = false;
                processSizetxt.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                processNametxt.Text = ProcessName[Processes - 1];
                processSizetxt.Value = ProcessSize[Processes - 1];
                simulatebtn.Show();

            }


        }


        private void nextbtn_Click(object sender, EventArgs e)
        {
            inputProcesspnl.Hide();
            simulatepnl.Show();

            ListViewItem itm;

            //variables and input for processes name, size and block sizes
            string[] arr = new string[3];

            

            int n = Processes;
            int m = Processes;
            // Stores block id of the block allocated to a
            // process
            int[] allocation = new int[n];
            int j = 0, t = m - 1;

            // Initially no block is assigned to any process
            for (int i = 0; i < n; i++)
                allocation[i] = -1;

            // pick each process and find suitable blocks
            // according to its size ad assign to it
            // pick each process and find suitable blocks
            // according to its size ad assign to it
            for (int i = 0; i < n; i++)
            {

                // Do not start from beginning
                while (j < m)
                {
                    if (BlockSize[j] >= ProcessSize[i])
                    {

                        // allocate block j to p[i] process
                        allocation[i] = j;

                        // Reduce available memory in this
                        // block.
                        BlockSize[j] -= ProcessSize[i];

                        // sets a new end point
                        t = (j - 1) % m;
                        break;
                    }
                    if (t == j)
                    {
                        // sets a new end point
                        t = (j - 1) % m;
                        // breaks the loop after going through
                        // all memory block
                        break;
                    }

                    // mod m will help in traversing the
                    // blocks from starting block after
                    // we reach the end.
                    j = (j + 1) % m;
                }
            }
            for (int i = 0; i < n; i++)
            {

                if (allocation[i] != -1)
                {
                    arr[0] = ProcessName[i];
                    arr[1] = Convert.ToString(ProcessSize[i]);
                    arr[2] = "Block " + Convert.ToString(allocation[i] + 1);
                }
                else
                {
                    arr[2] = "Not Allocated";
                }
                itm = new ListViewItem(arr);
                lvwProcess.Items.Add(itm);
            }

            for (int i = 0; i < Processes; i++)
            {

                lvwProcess.Height += lvwProcessHeight;
            }
        }

        private void simulatebtn_Click(object sender, EventArgs e)
        {
            inputBlockpnl.Hide();
            inputProcesspnl.Show();


            for (int i=0; i<Blocks; i++)
            {

                blocklview.Height += blocklvHeight;
            }

            
        }

        private void retrySimbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
