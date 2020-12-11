
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

namespace Organisms
{
    public class Fly : Actor, IInsect
    {
        int life, positionX, positionY;
        string name;
        static int count = 0;
        /// ******************************************** Properties *********************************
        public override int Count
        {
            get { return count; }
        }