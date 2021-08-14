
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


using System.Drawing;
using Organisms;

namespace GameofLife
{
    class GameLogic
    {
        bool autoRun;
        DataStructure Data;
        ///************************************************* Properties *******************************************
        public DataStructure DataArr
        {
            get { return Data; }
        }
        public bool AutoRun
        {
            get { return autoRun; }
            set { autoRun = value; }
        }

        ///************************************************* Methods *******************************************
        public GameLogic()
        {
        }//constructor

        public void LoadGameLogic(DataStructure D)
        {
            Data = D;
        }

        ///************************************************* Reset Organism Count *******************************************
        public void ResetOrganismCount()
        {
            //reset all the counts to 0
            DataArr.FlyCount = 0;
            DataArr.MajesticCount = 0;
            DataArr.DeadlyCount = 0;
            //delete every thing in the fly List
            DataArr.Flies.Clear();
        }

        ///************************************************* Update Grid *******************************************
        public Image UpdateGrid(int x, int y, int gridSizeX, int gridSizeY)
        {
            Image ret = null;

            if (DataArr.Actors[x, y] != null)
            {
                //decrement life
                if (DataArr.Actors[x, y].Name != "MajesticPlant")
                {
                    DataArr.Actors[x, y].Life--;
                }
                if (DataArr.Actors[x, y].Life < 0)
                {
                    //if organism is dead remove it from the 2D object array
                    DataArr.Actors[x, y] = null;
                    System.GC.Collect();
                    return null;
                }
                //perform the grow action
                DataArr.Actors[x, y].Grow();

                if (DataArr.Actors[x, y].Name == "MajesticPlant")
                {
                    if (DataArr.Actors[x, y].Size < 1)
                    {
                        ret = GameofLife.Properties.Resources.MajesticPlant1;
                    }
                    else if (DataArr.Actors[x, y].Size < 2)
                    {
                        ret = GameofLife.Properties.Resources.MajesticPlant2;
                    }
                    else
                    {
                        ret = GameofLife.Properties.Resources.MajesticPlant3;
                    }
                    //static count
                    DataArr.MajesticCount = DataArr.Actors[x, y].Count;
                }
                if (DataArr.Actors[x, y].Name == "DeadlyMimic")
                {
                    if (DataArr.Actors[x, y].Size < 1)
                    {
                        ret = GameofLife.Properties.Resources.DeadlyMimic1;
                    }
                    else if (DataArr.Actors[x, y].Size < 2)
                    {
                        ret = GameofLife.Properties.Resources.DeadlyMimic2;
                    }
                    else
                    {
                        ret = GameofLife.Properties.Resources.DeadlyMimic3;
                    }
                    //static count

                    DataArr.DeadlyCount = DataArr.Actors[x, y].Count;
                }
                if (DataArr.Actors[x, y].Name == "Fly")
                {
                    ret = GameofLife.Properties.Resources.Fly1;
                    //add each fly back into the fly List
                    DataArr.Flies.Add(DataArr.Actors[x, y]);
                    //static count

                    DataArr.FlyCount = DataArr.Actors[x, y].Count;