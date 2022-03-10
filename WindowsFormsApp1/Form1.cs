using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Cancel_Click(object sender, EventArgs e)
        {

            listBox2.Items.Add("press CANCEL button");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void SelectSection_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            GridAddCoForm1mponent_Load(sender, e);


        }



        private void Section1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("press SECTION 1 button");
            GridAddCoForm1mponent_Load(sender, e);

        }

        private void Section2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("press SECTION 2 button");
            GridAddCoForm1mponent_Load(sender, e);
        }

        private void Section3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("press SECTION 3 button");
            GridAddCoForm1mponent_Load(sender, e);
        }

        private void runTest_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("press RUN TEST button");

        }

        private void GridAddCoForm1mponent_Load(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Section 1", typeof(string));
            dt.Columns.Add("Actual Results", typeof(string));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
       
            if (btn.Text == "Section 1")
            {
                dt.Rows.Add("Section 1", "Completed", "Send message:OK" +
                    "Receive Ack:OK" +
                    "Receieve message:OK" +
                    "All mandatory fields:OK" +
                    "Validating fields:OK"
                    );
                dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Green;

            }
            else if (btn.Text == "Section 2")
            {
                dt.Rows.Add("Section 2", "Not Executed");
                dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            }
            else if (btn.Text == "Section 3")
            {
                dt.Rows.Add("Section 3", "Failed", "Send message: OK" +
    "Receive Ack: OK" +
    "Receive message: OK" +
    "All mandatory fields: Missing 2 fields" +
    "Validating fields:" +
    "Field ID 1 contains invalid info." +
    "Field ID 2 is missing." +
    "Field ID 5 is missing.");
                dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
            }
            else
            {
                dt.Rows.Add("", "", "");
            }
            dataGridView1.DataSource = dt;
        }
       
    }
}
