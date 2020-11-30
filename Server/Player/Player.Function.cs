using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace Server.Player
{
    public class PlayerFunctions
    {
        public static int GetRandom(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }
        /*public static int GetPhoneNumber()
        {
            using (Database.Database db = new Database.Database())
            {
                while (true)
                {
                    int number = GetRandom(111111, 999999);
                    if (!db.Items.Any(t => t.Type == ItemType.Phone && t.Value1 == number)) return number;
                }
            }
        }*/
    }
}