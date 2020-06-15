using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuOptionsForTester
    {
        public class CountCaptials : IDoable
        {
            public void Do()
            {
                System.Console.WriteLine(string.Format("Number of Capital Letters is: {0}", getSentenceAndCountCaptials()));
            }

            private int getSentenceAndCountCaptials()
            {
                string UserSentence;
                int count = 0;

                Console.WriteLine("Please write a sentence: ");
                UserSentence = Console.ReadLine();

                for (int i = 0; i < UserSentence.Length; i++)
                {
                    if (char.IsUpper(UserSentence[i]))
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public class ShowVersion : IDoable
        {
            public void Do()
            {
                System.Console.WriteLine("Version: 20.2.4.30620");
            }
        }

        public class ShowCurrTime : IDoable
        {
            public void Do()
            {
                System.Console.WriteLine(DateTime.Now.TimeOfDay.ToString());
            }
        }

        public class ShowCurrDate : IDoable
        {
            public void Do()
            {
                System.Console.WriteLine(DateTime.Now.Date.ToString());
            }
        }
    }
}
