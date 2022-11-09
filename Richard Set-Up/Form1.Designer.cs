
namespace Richard_Set_Up
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Youtube = new System.Windows.Forms.Button();
            this.Network = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Disk = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Splite = new System.Windows.Forms.Button();
            this.Formeren = new System.Windows.Forms.Button();
            this.formeren_L = new System.Windows.Forms.Panel();
            this.F_Disk_Start = new System.Windows.Forms.Button();
            this.F_Disk_Checklist = new System.Windows.Forms.CheckedListBox();
            this.F_Disk_Letter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Disk_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.formeren_L.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Youtube);
            this.panel1.Controls.Add(this.Network);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.Disk);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Name = "panel1";
            // 
            // Youtube
            // 
            resources.ApplyResources(this.Youtube, "Youtube");
            this.Youtube.Name = "Youtube";
            this.Youtube.UseVisualStyleBackColor = true;
            this.Youtube.Click += new System.EventHandler(this.Youtube_Click);
            // 
            // Network
            // 
            resources.ApplyResources(this.Network, "Network");
            this.Network.Name = "Network";
            this.Network.UseVisualStyleBackColor = true;
            this.Network.Click += new System.EventHandler(this.Network_Click);
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Disk
            // 
            this.Disk.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Disk, "Disk");
            this.Disk.Name = "Disk";
            this.Disk.UseVisualStyleBackColor = false;
            this.Disk.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Home
            // 
            this.Home.AutoEllipsis = true;
            resources.ApplyResources(this.Home, "Home");
            this.Home.Name = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Splite);
            this.panel2.Controls.Add(this.Formeren);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Splite
            // 
            resources.ApplyResources(this.Splite, "Splite");
            this.Splite.Name = "Splite";
            this.Splite.UseVisualStyleBackColor = true;
            this.Splite.Click += new System.EventHandler(this.Splite_Click);
            // 
            // Formeren
            // 
            resources.ApplyResources(this.Formeren, "Formeren");
            this.Formeren.Name = "Formeren";
            this.Formeren.UseVisualStyleBackColor = true;
            this.Formeren.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // formeren_L
            // 
            resources.ApplyResources(this.formeren_L, "formeren_L");
            this.formeren_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.formeren_L.Controls.Add(this.F_Disk_Start);
            this.formeren_L.Controls.Add(this.F_Disk_Checklist);
            this.formeren_L.Controls.Add(this.F_Disk_Letter);
            this.formeren_L.Controls.Add(this.label2);
            this.formeren_L.Controls.Add(this.F_Disk_Name);
            this.formeren_L.Controls.Add(this.label1);
            this.formeren_L.Name = "formeren_L";
            this.formeren_L.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // F_Disk_Start
            // 
            this.F_Disk_Start.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.F_Disk_Start, "F_Disk_Start");
            this.F_Disk_Start.Name = "F_Disk_Start";
            this.F_Disk_Start.UseVisualStyleBackColor = false;
            this.F_Disk_Start.Click += new System.EventHandler(this.F_Disk_Start_Click);
            // 
            // F_Disk_Checklist
            // 
            this.F_Disk_Checklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.F_Disk_Checklist.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.F_Disk_Checklist, "F_Disk_Checklist");
            this.F_Disk_Checklist.ForeColor = System.Drawing.Color.Indigo;
            this.F_Disk_Checklist.FormattingEnabled = true;
            this.F_Disk_Checklist.Name = "F_Disk_Checklist";
            this.F_Disk_Checklist.SelectedIndexChanged += new System.EventHandler(this.F_Disk_Checklist_SelectedIndexChanged);
            // 
            // F_Disk_Letter
            // 
            resources.ApplyResources(this.F_Disk_Letter, "F_Disk_Letter");
            this.F_Disk_Letter.Name = "F_Disk_Letter";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // F_Disk_Name
            // 
            resources.ApplyResources(this.F_Disk_Name, "F_Disk_Name");
            this.F_Disk_Name.Name = "F_Disk_Name";
            this.F_Disk_Name.TextChanged += new System.EventHandler(this.F_Disk_Name_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.formeren_L);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.formeren_L.ResumeLayout(false);
            this.formeren_L.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Disk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Formeren;
        private System.Windows.Forms.Button Splite;
        private System.Windows.Forms.Button Youtube;
        private System.Windows.Forms.Button Network;
        private System.Windows.Forms.Panel formeren_L;
        private System.Windows.Forms.TextBox F_Disk_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox F_Disk_Checklist;
        private System.Windows.Forms.TextBox F_Disk_Letter;
        private System.Windows.Forms.Button F_Disk_Start;
    }
}

