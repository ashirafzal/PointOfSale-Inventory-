using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_Inventory_
{
    public partial class CasheirRegister : Form
    {
        public CasheirRegister()
        {
            InitializeComponent();
            dgv_CashierRegister();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void dgv_CashierRegister()
        {
            dgv1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //
            dgv1.RowTemplate.Height = 30;
            dgv1.AllowUserToAddRows = false;

            //This Part of Code is for the styling of the Grid Padding
            Padding newPadding = new Padding(10, 8, 0, 8);
            this.dgv1.ColumnHeadersDefaultCellStyle.Padding = newPadding;

            // For Changing Grid Color
            this.dgv1.GridColor = Color.DimGray;

            //This Part of Code is for the styling of the Grid Columns
            dgv1.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dgv1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Regular);

            //This Part of Code is for the styling of the Visaul Style
            dgv1.EnableHeadersVisualStyles = false;

            // This Part of Code is for the styling of the Grid Border
            this.dgv1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dgv1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dgv1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;


            //This Part of Code is for the styling of the Grid RowsHeader which is on the left side
            this.dgv1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgv1.RowHeadersDefaultCellStyle.BackColor = Color.DimGray;

            //This Part of Code is for the styling of the Grid Rows
            dgv1.RowsDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Regular);
            dgv1.RowsDefaultCellStyle.ForeColor = Color.White;
            dgv1.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv1.RowsDefaultCellStyle.BackColor = Color.Teal;
            dgv1.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray;

            //this Line of Code made the dgv1 Text Middle Center
            dgv1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //this line of code is applying padding to a specific Column of dgv1 which is Product Column
            //dgv1.Columns[2].DefaultCellStyle.Padding = new Padding(2, 2, 2, 2);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDetails.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productDetails.Products);
            MaximizeBox = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        void writeExpression(String value)
        {
            String expression = txtQuantity.Text;
            expression = expression + value;

            txtQuantity.Text = expression;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            writeExpression("9");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            writeExpression("8");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            writeExpression("7");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            writeExpression("6");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            writeExpression("5");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            writeExpression("4");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            writeExpression("3");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            writeExpression("2");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            writeExpression("1");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            writeExpression("0");
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv1.Rows[e.RowIndex];

                comboBox1.Text = row.Cells[0].Value.ToString();
                txtPrice.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = "1";
            }
        }
    }
}
