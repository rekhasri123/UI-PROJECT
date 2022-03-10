namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.clearResults = new System.Windows.Forms.Button();
            this.runTest = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectSection = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Section1 = new System.Windows.Forms.Button();
            this.Section3 = new System.Windows.Forms.Button();
            this.Section2 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.clearResults);
            this.panel1.Controls.Add(this.runTest);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 551);
            this.panel1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(802, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(255, 444);
            this.listBox2.TabIndex = 7;
            // 
            // clearResults
            // 
            this.clearResults.BackColor = System.Drawing.Color.Yellow;
            this.clearResults.Location = new System.Drawing.Point(802, 473);
            this.clearResults.Name = "clearResults";
            this.clearResults.Size = new System.Drawing.Size(207, 48);
            this.clearResults.TabIndex = 6;
            this.clearResults.Text = "CLEAR RESULTS";
            this.clearResults.UseVisualStyleBackColor = false;
            this.clearResults.Click += new System.EventHandler(this.button3_Click);
            // 
            // runTest
            // 
            this.runTest.BackColor = System.Drawing.Color.LawnGreen;
            this.runTest.Location = new System.Drawing.Point(549, 473);
            this.runTest.Name = "runTest";
            this.runTest.Size = new System.Drawing.Size(184, 48);
            this.runTest.TabIndex = 5;
            this.runTest.Text = "RUN TEST";
            this.runTest.UseVisualStyleBackColor = false;
            this.runTest.Click += new System.EventHandler(this.runTest_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.Location = new System.Drawing.Point(291, 473);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(161, 48);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "CANCEL";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(255, 453);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(802, 84);
            this.listBox3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Controls.Add(this.listBox1);
            this.panel5.Location = new System.Drawing.Point(255, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(547, 455);
            this.panel5.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(538, 225);
            this.dataGridView1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(173, 208);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(8, 8);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(547, 444);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SelectSection);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.listBox4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 536);
            this.panel2.TabIndex = 0;
            // 
            // SelectSection
            // 
            this.SelectSection.BackColor = System.Drawing.Color.Peru;
            this.SelectSection.Location = new System.Drawing.Point(50, 51);
            this.SelectSection.Name = "SelectSection";
            this.SelectSection.Size = new System.Drawing.Size(155, 44);
            this.SelectSection.TabIndex = 4;
            this.SelectSection.Text = "Select Section";
            this.SelectSection.UseVisualStyleBackColor = false;
            this.SelectSection.Click += new System.EventHandler(this.SelectSection_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Section1);
            this.panel4.Controls.Add(this.Section3);
            this.panel4.Controls.Add(this.Section2);
            this.panel4.Location = new System.Drawing.Point(50, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 125);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // Section1
            // 
            this.Section1.BackColor = System.Drawing.Color.LightCoral;
            this.Section1.Location = new System.Drawing.Point(0, 0);
            this.Section1.Name = "Section1";
            this.Section1.Size = new System.Drawing.Size(155, 44);
            this.Section1.TabIndex = 5;
            this.Section1.Text = "Section 1";
            this.Section1.UseVisualStyleBackColor = false;
            this.Section1.Click += new System.EventHandler(this.Section1_Click);
            // 
            // Section3
            // 
            this.Section3.BackColor = System.Drawing.Color.Brown;
            this.Section3.Location = new System.Drawing.Point(0, 80);
            this.Section3.Name = "Section3";
            this.Section3.Size = new System.Drawing.Size(155, 44);
            this.Section3.TabIndex = 3;
            this.Section3.Text = "Section 3";
            this.Section3.UseVisualStyleBackColor = false;
            this.Section3.Click += new System.EventHandler(this.Section3_Click);
            // 
            // Section2
            // 
            this.Section2.BackColor = System.Drawing.Color.IndianRed;
            this.Section2.Location = new System.Drawing.Point(0, 39);
            this.Section2.Name = "Section2";
            this.Section2.Size = new System.Drawing.Size(155, 44);
            this.Section2.TabIndex = 2;
            this.Section2.Text = "Section 2";
            this.Section2.UseVisualStyleBackColor = false;
            this.Section2.Click += new System.EventHandler(this.Section2_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(-4, 3);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(253, 544);
            this.listBox4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(252, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 445);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1073, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button clearResults;
        private System.Windows.Forms.Button runTest;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SelectSection;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Section1;
        private System.Windows.Forms.Button Section3;
        private System.Windows.Forms.Button Section2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

