﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            writeExpression("9");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            writeExpression("8");
        }

        void writeExpression(String value)
        {
            String expression = textbox1.Text;
            expression = expression + value;

            textbox1.Text = expression;
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            String processor;
            processor = textbox1.Text;
            processor = processor.Substring(0, processor.Length - 1);
            textbox1.Text = processor;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textbox1.Text);

                if (a == 8162)
                {
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                    
                }
                else
                {
                    string message = "Do you want to again enter the credentials ?";
                    string title = "Wrong ID";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Retry)
                    {
                        textbox1.Text = "";
                    }
                }
            }
            catch (FormatException ex)
            {
                string title = "Wrong Input";
                string message = "LoginID Field can't be Empty";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
        }
    }
}
