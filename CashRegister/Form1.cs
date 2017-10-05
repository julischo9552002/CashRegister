using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //Globals
        const double BURGER_PRICE = 2.49;
        const double FRIES_PRICE = 1.89;
        const double DRINK_PRICE = 0.99;
        const double TAX_RATE = 0.13;

        int totalBurger, totalFries, totalDrinks;

        double subTotalCost, totalTax, totalCost, tendered, changeDue;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //conversions
            totalBurger = Convert.ToInt16(burgerInput.Text);
            totalFries = Convert.ToInt16(friesInput.Text);
            totalDrinks = Convert.ToInt16(drinksInput.Text);
            
            //calculations
            subTotalCost = BURGER_PRICE * totalBurger + FRIES_PRICE * totalFries + DRINK_PRICE * totalDrinks;
            totalTax = subTotalCost * TAX_RATE;
            totalCost = totalTax + subTotalCost;

            //Output Messages
            subTotalOutput.Text = subTotalCost.ToString("C");
            TaxOutput.Text = totalTax.ToString("C");
            totalOutput.Text = totalCost.ToString("C");
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            //conversions
            //tendered = Convert.ToInt16(tenderedInput); 

            //calculations
            changeDue = tendered - totalCost;

            //Output Messages
            changeOutput.Text = changeDue.ToString("C");
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            
            //Square
            Pen linePen = new Pen(Color.Black, 3);

            fg.DrawLine(linePen, 280,90, 550, 90);
            fg.DrawLine(linePen, 280, 90, 280, 550);
            fg.DrawLine(linePen, 280, 550, 550, 550);
            fg.DrawLine(linePen, 550, 550, 550, 90);
            Thread.Sleep(500);

            //writing
            Font bFont = new Font("Consolas", 10, FontStyle.Regular);
            SolidBrush bBrush = new SolidBrush(Color.Black);

            Font yFont = new Font("Consolas", 10, FontStyle.Regular);
            SolidBrush yBrush = new SolidBrush(Color.Gold);
            
            fg.DrawString("McDonalds", bFont, bBrush, 380, 530);
            Thread.Sleep(500);
            fg.DrawString("McDonalds", yFont, yBrush, 380, 530);







        }

        public Form1()
        {
            InitializeComponent();
        }
            
    }
}

