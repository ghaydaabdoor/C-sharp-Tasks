using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task2
{
    public partial class Task2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(TextBox1.Text);
            int Num2=Convert.ToInt32(TextBox2.Text);
            int Multiply=Num1*Num2;
            ResultBox.Text = Multiply.ToString();
        }

        protected void Subtract_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(TextBox1.Text);
            int Num2 = Convert.ToInt32(TextBox2.Text);
            int Subtract = Num1 - Num2;
            ResultBox.Text = Subtract.ToString();
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(TextBox1.Text);
            int Num2 = Convert.ToInt32(TextBox2.Text);
            int Add = Num1 + Num2;
            ResultBox.Text = Add.ToString();
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(TextBox1.Text);
            int Num2 = Convert.ToInt32(TextBox2.Text);
            int Divide = Num1 / Num2;
            ResultBox.Text = Divide.ToString();
        }
    }
}