using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

#region Custom Methods

        private int Subtract(int firstnumber, int secondnumber)
        {
            int answer;
            answer = firstnumber - secondnumber;
            return answer;
        }

        private int Addition(int firstnumber, int secondnumber)
        {
            int answer;
            answer = firstnumber + secondnumber;
            return answer;
        }

        private int Multiply(int firstnumber, int secondnumber)
        {
            int answer;
            answer = firstnumber * secondnumber;
            return answer;
        }

        private int Divide(int firstnumber, int secondnumber)
        {
            int answer;
            answer = firstnumber / secondnumber;
            return answer;
        }

#endregion
        private void subBTN_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            returnValue = Subtract(number1, number2);
            textBox3.Text = Convert.ToString(returnValue);
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            returnValue = Addition(number1, number2);
            textBox3.Text = Convert.ToString(returnValue);

        }

        private void mulBTN_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            returnValue = Multiply(number1, number2);
            textBox3.Text = Convert.ToString(returnValue);
        }

        private void divBTN_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            returnValue = Divide(number1, number2);
            textBox3.Text = Convert.ToString(returnValue);
        }
        
    }
}
