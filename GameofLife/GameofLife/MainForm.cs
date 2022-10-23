
﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Name: Kevin Davis 
// Class : CMPS4143
// Assignment: Program 5
// Date: 10/23/2020
//
// Description :
// To create a library (dll) of critters; to instantiate objects of classes in an inheritance hierarchy and 
// polymorphically output each object’s attributes; to use static variables; to use a labels, text boxes and buttons;
// to use the switch statement; to use exception handling; to use a data structure to hold references to objects.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameofLife
{
    public partial class MainForm : Form
    {
        int flyNum, deadlyNum, majesticNum, gridSizeX, gridSizeY, generations = 0;
        PictureBox[,] grid;
        DataStructure DataStructure = new DataStructure();
        GameLogic Logic = new GameLogic();
        string ManualSelection = "1";
        int Gen = 1;
        bool editForm = false;


        public MainForm() { InitializeComponent(); }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        //*************************************************** Radio Buttons *******************************************
        private void radioButton_Auto_CheckedChanged(object sender, EventArgs e)
        {
            // let game run automatically
            Logic.AutoRun = true;
        }
        private void radioButton_Manual_CheckedChanged(object sender, EventArgs e)
        {
            // game will require button click to iterate
            Logic.AutoRun = false;
        }

        private void radioButton_ManualFly_CheckedChanged(object sender, EventArgs e)
        {
            ManualSelection = "1";
        }

        private void radioButton_ManualMimic_CheckedChanged(object sender, EventArgs e)
        {
            ManualSelection = "2";
        }

        private void radioButton_ManualDeadly_CheckedChanged(object sender, EventArgs e)
        {
            ManualSelection = "3";
        }

        //*************************************************** Normal Buttons *******************************************
        private void button_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void button_Next_Click(object sender, EventArgs e)
        {
            timer_Game.Start();
        }//button_next_click
         //*************************************************** Auto Load Button*******************************************

        private void button_AutoLoad_Click(object sender, EventArgs e)
        {

            button_AutoLoad.Visible = false;
            button_Restart.Visible = true;
            button_ContinueFromManualSelect.Visible = false;
            button_ManualLoad.Visible = false;
            button_Next.Visible = true;
            label_DeadlyNums.Visible = true;
            label_FlyNum.Visible = true;
            label_MajesticNum.Visible = true;
            label_MajesticNum.Visible = true;
            textBox_DeadlyNum.Visible = true;
            textBox_FlyNum.Visible = true;
            textBox_MajesticNum.Visible = true;
            groupBox_manualSelect.Visible = false;
            editForm = false;
            Logic.LoadGameLogic(DataStructure);
            try
            {
                button_Next.Visible = true;
                deadlyNum = int.Parse(textBox_DeadlyNum.Text);
                majesticNum = int.Parse(textBox_MajesticNum.Text);
                flyNum = int.Parse(textBox_FlyNum.Text);