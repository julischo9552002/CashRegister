﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
    //Julia Scholz, 16 th october 2017, cash register for McDonald's in Germany
{
    public partial class Form1 : Form
    {
        //Globals
        const double BURGER_PRICE = 2.58;
        const double FRIES_PRICE = 1.98;
        const double DRINK_PRICE = 0.98;
        const double TAX_RATE = 0.19;

        int totalBurger, totalFries, totalDrinks;
        
        double totalBP, totalFP, totalDP, subTotalCost, totalTax, totalCost, tendered, changeDue;
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false; 

                //conversions
                totalBurger = Convert.ToInt16(burgerInput.Text);
                totalFries = Convert.ToInt16(friesInput.Text);
                totalDrinks = Convert.ToInt16(drinksInput.Text);

                //calculations
                totalBP = BURGER_PRICE * totalBurger;
                totalFP = FRIES_PRICE * totalFries;
                totalDP = DRINK_PRICE * totalDrinks;

                subTotalCost = totalBP + totalFP + totalDP;
                totalTax = subTotalCost * TAX_RATE;
                totalCost = totalTax + subTotalCost;
                
                //Output Messages
                subTotalOutput.Text = subTotalCost.ToString("0.00" + " €");
                TaxOutput.Text = totalTax.ToString("0.00") + " €";
                totalOutput.Text = totalCost.ToString("0.00") + " €";
            }
            catch
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Bitte geben Sie eine korrekte Nummer ein!";
            }
         }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel2.Visible = false;

                //conversions
                tendered = Convert.ToInt16(tenderedInput.Text); 

                //calculations
                changeDue = tendered - totalCost;

                //Output Messages
                changeOutput.Text = changeDue.ToString("0.00") + " €";
            }
            catch
            {
                errorLabel2.Visible = true;
                errorLabel2.Text = "Bitte geben Sie eine korrekte Nummer ein!";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //Sound
            SoundPlayer receipt = new SoundPlayer(Properties.Resources.kitchen_ticket_printer_sound);

            //sleep variable
            var time = 310;

            Graphics fg = this.CreateGraphics();

            //calculations
            totalBP = BURGER_PRICE * totalBurger;
            totalFP = FRIES_PRICE * totalFries;
            totalDP = DRINK_PRICE * totalDrinks;
            
            //writingPens
            Font bFont = new Font("Consolas", 10, FontStyle.Regular);
            SolidBrush bBrush = new SolidBrush(Color.Black);

            Font tiFont = new Font("Consolas", 12, FontStyle.Regular);
            SolidBrush tiBrush = new SolidBrush(Color.Black);

            //SquarePens
            Pen linePen = new Pen(Color.Black, 4);
            SolidBrush gBrush = new SolidBrush(Color.Gray);
            SolidBrush wBrush = new SolidBrush(Color.White);
            
            //Square
            fg.FillRectangle(gBrush, 280, 90, 270, 390);
            fg.DrawRectangle(linePen, 280, 90, 270, 390);
            Thread.Sleep(500);

            //sound
            receipt.Play();

            //receipt
            fg.FillRectangle(wBrush, 282, 92, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 107, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 122, 266, 15);

            fg.DrawString("McDonald's", tiFont, tiBrush, 300, 122);
            fg.DrawString("ich liebe es", tiFont, tiBrush, 412, 122);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 137, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 152, 266, 15);

            fg.DrawString("Bestellnummer: 420", bFont, bBrush, 300, 152);
            Thread.Sleep(400);

            fg.FillRectangle(wBrush, 282, 167, 266, 15);

            fg.DrawString("31.Oktober.2017", bFont, bBrush, 300, 167);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 182, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 197, 266, 15);
            
            fg.DrawString("Frühstücksburger", bFont, bBrush, 300, 197);
            fg.DrawString("x " + totalBurger, bFont, bBrush, 430, 197);
            fg.DrawString(totalBP.ToString("0.00") + " €", bFont, bBrush, 475, 197);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 212, 266, 15);

            fg.DrawString("Gitterkartoffeln", bFont, bBrush, 300, 212);
            fg.DrawString("x " + totalFries, bFont, bBrush, 430, 212);
            fg.DrawString(totalFP.ToString("0.00") + " €", bFont, bBrush, 475, 212);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 227, 266, 15);

            fg.DrawString("Getränke", bFont, bBrush, 300, 227);
            fg.DrawString("x " + totalDrinks, bFont, bBrush, 430, 227);
            fg.DrawString(totalDP.ToString("0.00") + " €", bFont, bBrush, 475, 227);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 242, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 257, 266, 15);

            fg.DrawString("Netto", bFont, bBrush, 300, 257);
            fg.DrawString(subTotalCost.ToString("0.00") + " €", bFont, bBrush, 475, 257);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 272, 266, 15);

            fg.DrawString("Mehrwertsteuer", bFont, bBrush, 300, 272);
            fg.DrawString(totalTax.ToString("0.00") + " €", bFont, bBrush, 475, 272);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 287, 266, 15);

            fg.DrawString("Brutto", bFont, bBrush, 300, 287);
            fg.DrawString(totalCost.ToString("0.00") + " €", bFont, bBrush, 475, 287);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 302, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 317, 266, 15);

            fg.DrawString("Bar", bFont, bBrush, 300, 317);
            fg.DrawString(tendered.ToString("0.00") + " €", bFont, bBrush, 475, 317);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 332, 266, 15);

            fg.DrawString("Wechselgeld", bFont, bBrush, 300, 332);
            fg.DrawString(changeDue.ToString("0.00") + " €", bFont, bBrush, 475, 332);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 347, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 362, 266, 15);

            fg.DrawString("Vielen Dank für ihren Besuch!", bFont, bBrush, 310, 362);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 377, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 392, 266, 15);

            fg.DrawString("McDonald's Restaurant", bFont, bBrush, 340, 392);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 407, 266, 15);

            fg.DrawString("Itterstraße 99, D-40589 Düsseldorf", bFont, bBrush, 285, 407);
            Thread.Sleep(time);
            fg.FillRectangle(wBrush, 282, 422, 266, 15);

            fg.DrawString("------------------------------", bFont, bBrush, 305, 422);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 437, 266, 15);

            fg.DrawString("Telefonnummer: 0211/7453020", bFont, bBrush, 315, 437);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 452, 266, 15);
            Thread.Sleep(time);

            fg.FillRectangle(wBrush, 282, 463, 266, 15);
            Thread.Sleep(time);
        }

        private void newordnerButton_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();

            //empty receipt
            Pen goPen = new Pen(Color.Gold, 4);
            SolidBrush goBrush = new SolidBrush(Color.Gold);

            fg.FillRectangle(goBrush, 280, 90, 270, 390);
            fg.DrawRectangle(goPen, 280, 90, 270, 390);

            //empty textboxs
            burgerInput.Text = String.Empty;
            friesInput.Text = String.Empty;
            drinksInput.Text = String.Empty;
            tenderedInput.Text = String.Empty;

            //empty Lables
            subTotalOutput.Text = String.Empty;
            TaxOutput.Text = String.Empty;
            totalOutput.Text = String.Empty;
            changeOutput.Text = String.Empty;
        }
        public Form1()
        {
            InitializeComponent();
        }
            
    }
}

