using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyShopping
{
    class Inventory
    {
        private static int gold;
        private static int silver;
        private static int copper;
        private static int rations;

        public int getGold()
        {
            return gold;
        }
        public void setGold(int nGold)
        {
            gold = nGold;
        }
        public int getSilver()
        {
            return silver;
        }
        public void setSilver(int nSilver)
        {
            silver = nSilver;
        }
        public int getCopper()
        {
            return copper;
        }
        public void setCopper(int nCopper)
        {
            copper = nCopper;
        }
    }
}
