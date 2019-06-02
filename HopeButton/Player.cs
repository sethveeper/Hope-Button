using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeButton
{
    class Player
    {
        private string name;
        private int indexStory;
        private int indexHope;
        private long totalHope;
        private long totalDays;

        public string Name { get => name; set => name = value; }
        public int IndexStory { get => indexStory; set => indexStory = value; }
        public int IndexHope { get => indexHope; set => indexHope = value; }
        public long TotalHope { get => totalHope; set => totalHope = value; }
        public long TotalDays { get => totalDays; set => totalDays = value; }

        public Player()
        {
            name = "Player 1";
            indexStory = 0;
            indexHope = 0;
            totalHope = 0;
            totalDays = 0;
        }
        public Player(string inName)
        {
            name = inName;
            indexStory = 0;
            indexHope = 0;
            totalHope = 0;
            totalDays = 0;
        }
    }
}
