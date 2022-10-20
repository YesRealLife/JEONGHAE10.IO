
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
