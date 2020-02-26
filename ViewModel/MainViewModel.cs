using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelayLoopGenerator.ViewModel
{
    
    class MainViewModel
    {
        public int Cycles { get; set; }
        public int Time { get; set; }
        public int CycleRate { get; set; }
        public bool CyclesRadioButton { get; set; }
        public bool TimeRadioButton { get; set; }
        public string Text { get; set; }
        public List<string> firstRegistry { get; set; }
        public List<string> secondRegistry { get; set; }
        public List<string> thirdRegistry { get; set; }
        public MainViewModel()
        {
            firstRegistry = new List<string>()
            {
                "R10","R11","R12","R13","R14","R15","R16","R17","R18","R19",
            };
            secondRegistry = new List<string>()
            {
                "R10","R11","R12","R13","R14","R15","R16","R17","R18","R19",
            };
            thirdRegistry = new List<string>()
            {
                "R10","R11","R12","R13","R14","R15","R16","R17","R18","R19",
            };
        }
    }
}
