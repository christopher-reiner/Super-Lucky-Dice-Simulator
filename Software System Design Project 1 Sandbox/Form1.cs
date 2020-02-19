//===================================================================================================================================
//Author: Christopher Reiner
//The University of South Florida
//COP4365 Software System Design
//Project #1 - Due 02-17-20
//Objective:
//Write a program to simulate a uniform (meaning every number is equally likely to appear as the next) integer random number.  
//Your program will be a console application which will simulate a 6-faced die. You will “throw” your simulated die N times. 
//The number N should be obtained by prompting the user on “How many rolls?” Also, since you will be using the Random class 
//provide a prompt requesting that the user provide a seed number.The prompt can be as simple as "Please enter a seed:" and 
//a text box. Then use the seed provided by the user to seed the random number generator. This will also help you test your program.
//We will use 6000 times as an example. Show the frequency distribution of your numbers when 6,000 tosses are made and the 
//random number is instantiated to generate numbers between 1 and 6 (inclusive).  In other words, show how many times the 
//numbers 1,2,3,….and 6 have appeared.The output displayed on the screen must use the chart object. 
//Then have another chart to display the histogram obtained when you roll 2 dice and add up the numbers that come up (2 – 12). 
//As in the first part, you will roll the dice N times.
//===================================================================================================================================
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Software_System_Design_Project_1_Sandbox
{
    public partial class Form1 : Form
    {
        //declares global variables
        List<int> rollCounts = new List<int>();
        List<int> rollCounts2 = new List<int>();
        List<int> rollCounts3 = new List<int>();

        public Form1()
        {
            InitializeComponent();

            //message box to prompt the user with instructions
            Interaction.MsgBox("Welcome to the Super Lucky Dice Simulator. This program provides your casino with randomly thrown " +
                                 "die rolls for your customers to game with. The simulator features a \"seed\" feature, which may be " +
                                 "set by you the owner when preparing the simulator to generate die tosses. The program begins by " +
                                 "prompting you to enter a seed, which is then followed by request for you to enter the desired # of " +
                                 "rolls to use in the simulator. Both of these values can be updated at any time during the simulation. " +
                                 "The results for each die throw are shown on the corresponding table, and the distribution of the total " +
                                 "scores can be observed on a third. There are fields for you to enter the seed and the number of rolls. The " +
                                 "\"Populate Charts\" button will start the simulation based on the current parameters. The \"Reset Charts\" " +
                                 "button clears and resets all charts and data. The \"Print Results\" button creates a text file of the data " +
                                 "found in the Test Results field that can be used to verify your system with your potential investors. The " +
                                 "program is ended by clicking the traditional \"close\" box on the top right corner.");

            //input box prompt to set seed value
            string seedInput;
            seedInput = Interaction.InputBox("Please enter a seed value...\n\n" +
                        "Note: You may update this value at any time once the program has launched.", "Initializing Seed Value", "0", -1, -1);

            //local variables and while loop to check for correct seed input
            bool seedValid = false;
            int Number;
            while (seedValid == false)
            {
                if (int.TryParse(seedInput, out Number))
                {
                    seedValid = true;
                }
                else
                {
                    seedInput = Interaction.InputBox("Please enter a seed value...\n\n" +
                        "Note: You may update this value at any time once the program has launched.", "INVALID INPUT - PLEASE ENTER A WHOLE NUMBER", "0", -1, -1);
                }
            }

            //populates seed text box once valid input received
            seedTextBox.Text = seedInput;

            //input box prompt to set number of rolls value
            string numRollsInput;
            numRollsInput = Interaction.InputBox("Please enter the number of rolls to use for the test...\n\n" +
                        "Note: You may update this value at any time once the program has launched.", "Initializing Number Of Rolls", "6000", -1, -1);

            //local variables and while loop to check for correct seed input
            bool numRollsValid = false;
            while (numRollsValid == false)
            {
                if (int.TryParse(numRollsInput, out Number) && (Convert.ToInt32(numRollsInput) > 0))
                {
                    numRollsValid = true;
                }
                else
                {
                    numRollsInput = Interaction.InputBox("\nPlease enter the number of rolls to use for the test...\n\n" +
                        "Note: You may update this value at any time once the program has launched.", "INVALID INPUT - PLEASE ENTER A WHOLE NUMBER > 0", "6000", -1, -1);
                }
            }
            //populates numRolls text box once valid input received
            numTestRollsTextbox.Text = numRollsInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //calls fillChart function so tables are populated with the current parameters
            fillChart();
        }

        //function for reseting and populating table parameter based on current input
        private void fillChart()
        {
            //detects if chart 1 and chart 2 have been previously created and if so resets them
            if (rollCounts.Count() > 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    rollCounts.RemoveAt(0);
                    chart1.Series["Die #1 Rolls"].Points.RemoveAt(0);
                    rollCounts2.RemoveAt(0);
                    chart2.Series["Die #2 Rolls"].Points.RemoveAt(0);
                }
            }

            //detects if chart 3 has been previously created and if so resets it
            if (rollCounts3.Count() > 0)
            {
                for (int i = 0; i < 11; i++)
                {
                    rollCounts3.RemoveAt(0);
                    chart3.Series["Combined Die Rolls"].Points.RemoveAt(0);
                }
            }

            //sets the Y axis depending the anticipated number of rolls
            double yNumber = (Convert.ToInt32(numTestRollsTextbox.Text) / 6) * 1.2;
            if (yNumber < 20) yNumber = 20;

            //populates the # of columns and sets the labels for the individual die tables
            for (int i = 0; i < 6; i++)
            {
                chart1.Series["Die #1 Rolls"].Points.AddXY(Convert.ToString(i + 1) + "pt", "0");
                chart2.Series["Die #2 Rolls"].Points.AddXY(Convert.ToString(i + 1) + "pt", "0");
                rollCounts.Add(0);
                rollCounts2.Add(0);
            }

            //populates the # of columns and sets the labels for the combined die score tables
            for (int i = 0; i < 11; i++)
            {
                chart3.Series["Combined Die Rolls"].Points.AddXY(Convert.ToString(i + 2) + "pt", "0");
                rollCounts3.Add(0);
            }

            //sets additional parameters for the tables
            chart1.ChartAreas[0].AxisY.Maximum = yNumber;
            chart2.ChartAreas[0].AxisY.Maximum = yNumber;
            chart3.ChartAreas[0].AxisY.Maximum = 1.5 * yNumber;
            chart3.ChartAreas[0].AxisX.Interval = 1;
        }

        //function to perform random rolls and populate tables accordingly
        private void populateChartButton_click(object sender, EventArgs e)
        {
            //clears charts for new data
            fillChart();

            //calls an instance of a random class
            Random randomValue = new Random(Convert.ToInt32(seedTextBox.Text));

            //for loop for performing X number of random die throws and populating tables with that data
            for (int i = 0; i < Convert.ToInt32(numTestRollsTextbox.Text); i++)
            {
                //random call for die #1 recorded in List and applied to table
                int roll = randomValue.Next(1, 7);
                rollCounts[roll - 1]++;
                chart1.Series["Die #1 Rolls"].Points[roll - 1].SetValueY(rollCounts[roll - 1]);

                //random call for die #2 recorded in List and applied to table
                int roll2 = randomValue.Next(1, 7);
                rollCounts2[roll2 - 1]++;
                chart2.Series["Die #2 Rolls"].Points[roll2 - 1].SetValueY(rollCounts2[roll2 - 1]);

                //combines die scores and records that result to third List
                rollCounts3[roll + roll2 - 2]++;
                chart3.Series["Combined Die Rolls"].Points[roll + roll2 - 2].SetValueY(rollCounts3[roll + roll2 - 2]);

                //redraws charts based on updated info
                chart1.Refresh();
                chart2.Refresh();
                chart3.Refresh();
            }

            //sets parameters for final results textbox
            finalResultsTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Bold);
            finalResultsTextBox.SelectionColor = System.Drawing.Color.Blue;

            //prints results to test results text box
            finalResultsTextBox.Text += "Seed Value: " + seedTextBox.Text + "\nNumber of Rolls: " + numTestRollsTextbox.Text + "\n\n";
            finalResultsTextBox.Text += "Die #1: \n";
            for (int i = 0; i < 6; i++)
            {
                finalResultsTextBox.Text += Convert.ToString(i + 1) + " was rolled " + Convert.ToString(rollCounts[i]) + " times.\n";
            }
            finalResultsTextBox.Text += "\n";
            finalResultsTextBox.Text += "Die #2: \n";
            for (int i = 0; i < 6; i++)
            {
                finalResultsTextBox.Text += Convert.ToString(i + 1) + " was rolled " + Convert.ToString(rollCounts2[i]) + " times.\n";
            }
            finalResultsTextBox.Text += "\n";
            for (int i = 0; i < 11; i++)
            {
                finalResultsTextBox.Text += "A total score of " + Convert.ToString(i + 2) + " was rolled " + Convert.ToString(rollCounts3[i]) + " times.\n";
            }
        }

        //function that creates a txt. file for record keeping
        private void printResults(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Single Die Results.txt");
            sw.WriteLine(finalResultsTextBox.Text);
            sw.Close();
        }

        //function that resets both the charts and the final results text box
        private void chartResetButton_Click(object sender, EventArgs e)
        {
            fillChart();
            finalResultsTextBox.Clear();
        }
    }
}