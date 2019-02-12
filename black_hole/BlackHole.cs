using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace black_hole
{
    public static class BlackHole
    {
        public static List<Hole> Holes { get; set; } = new List<Hole>();

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BlackHoleUIMain());
        }
    }
}
