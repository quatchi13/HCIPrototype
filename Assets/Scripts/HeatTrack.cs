using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

///You do not need to attach this script to anything
///It contains static classes that we will call from actual monobehaviours
namespace MapTests
{
    //delete this struct i made it for testing
    //replace all references to this type with "Vector2" (a unity struct)
 


    public static class HeatTrack
    {
        //you are going to change "v2" to unity's Vector2
        private static Queue<Vector2> positionTracker = new Queue<Vector2>();
        
        

        private static string FormatPos(Vector2 pos)//see comment on the queue, you want it to take in a Vector2
        {
            return(pos.x.ToString() + ", " + pos.y.ToString());
        }
        private static string FormatTimeToFilePath()
        {
            string time = System.DateTime.Now.Hour.ToString();
            time += ("_" + System.DateTime.Now.Minute.ToString());
            time += ("_" + System.DateTime.Now.Second.ToString());
            
            return (time + ".txt");
        }


        //shabingus shareplace with Vector2
        public static void TrackPos(Vector2 pos)
        {
            positionTracker.Enqueue(pos);
        }

        public static void PrintToFile()
        {
            Console.WriteLine(FormatTimeToFilePath());
            string prefix = Application.persistentDataPath;//we want to do Application.PersistentDataPath() or something like that in the Unity version
            string fPath =  prefix + FormatTimeToFilePath();
            using (StreamWriter writer = new StreamWriter(fPath))
            {
                while(positionTracker.Count > 0)
                {
                    writer.WriteLine(FormatPos(positionTracker.Dequeue()));
                }
                writer.Close();
            }
            
        }

    }
}
