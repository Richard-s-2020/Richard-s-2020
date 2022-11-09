using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text;
using System.IO;

namespace Richard_Set_Up
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Disk Visible flase
            panel2.Visible = false;
            formeren_L.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Disk Visible flase
            formeren_L.Visible = false;
            panel2.Visible = true;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\my folder"))
            {
                string[] drives = Directory.GetLogicalDrives();
                foreach (string Disk in drives)
                {
                    if (Disk == @"C:\")
                    {
                        F_Disk_Checklist.Items.Add(@"C:\", CheckState.Unchecked);

                    }
                    else
                    {
                        F_Disk_Checklist.Items.Add(Disk);
                    };


                }
            }
            else {
                Directory.CreateDirectory(@"C:\my folder");
            }            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Disk Visible flase
            panel2.Visible = false;
            formeren_L.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            formeren_L.Visible = true;
            panel2.Visible = false;
        
        }

        private void Network_Click(object sender, EventArgs e)
        {
           
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
      
        }

        private void Splite_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void F_Disk_Checklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void F_Disk_Start_Click(object sender, EventArgs e)
        {
            foreach (var Check in F_Disk_Checklist.CheckedItems)
            {
                if (Check.ToString() != "")
                {
                    
                    if (F_Disk_Name.Text != "")
                    {
                        if (F_Disk_Letter.Text != "")
                        {
                            string[] lines = { "sel disk " + 1, "clean", "create par primary", "format fs = ntfs label=" + F_Disk_Name.Text + " quick ", "assign letter= " + F_Disk_Letter.Text};
                            using StreamWriter file = new StreamWriter(@"C:\my folder\formeter.bat");

                            foreach (string line in lines)
                            {
                            
                            
                              file.WriteLineAsync(line);
                            
                            };
                        }
                        else
                        {

                            MessageBox.Show("write a leter in de textbox.");
                        }
                    }
                    else
                    {

                        DialogResult dialogResult = MessageBox.Show("Are you sure you don't whant a cusstom name?", "Some Title", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (F_Disk_Letter.Text != "")
                            {
                                System.Diagnostics.Process process = new System.Diagnostics.Process();
                                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                                startInfo.FileName = "cmd.exe";
                                string tets1 = Check.ToString();
                                string Disk = "/C FORMAT " + tets1.Remove(2) + " /Y /FS:NTFS /V:Drivers /Q";
                                startInfo.Arguments = Disk;
                                process.StartInfo = startInfo;
                                process.Start();

                            }
                            else
                            {

                                MessageBox.Show("write a leter in de textbox.");
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            break;
                        }
                        

                    }
                }
                else {

                    Console.WriteLine("No name");
                
                } 
            }
        }

        private void F_Disk_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
