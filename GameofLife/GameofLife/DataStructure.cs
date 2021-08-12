
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
using System.Collections.Generic;
using Organisms;

namespace GameofLife
{
    class DataStructure
    {
        Actor[,] actors;
        Random rand;
        int deadlyCount, flyCount, majesticCount;
        private List<Actor> flies = new List<Actor>();
        ///************************************************* Properties *******************************************
        ///
        public List<Actor> Flies
        {
            get
            {
                return flies;
            }
        }
        public int DeadlyCount
        {
            get { return deadlyCount; }
            set { deadlyCount = value; }
        }
        public int FlyCount
        {