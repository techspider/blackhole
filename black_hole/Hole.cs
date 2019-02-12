using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace black_hole
{
    public class Hole
    {
        public List<string> ExcludedPaths { get; set; } = new List<string>();
        public Timer HoleTimer { get; set; } = new Timer();
        public string Name { get; set; } = "Untitled Hole";
        public int HoleScanInterval { get; set; } = 100;
        public string Target { get; set; } = "(null)";
        public HoleType Type { get; set; } = HoleType.Folder;

        public Hole() { }

        public Hole(string name, string target, int holeScanInt = 100)
        {
            Target = target;
            if (!Directory.Exists(target))
                Directory.CreateDirectory(target);
            Name = name;
            HoleScanInterval = holeScanInt;
        }

        public void Start()
        {
            switch(Type)
            {
                case HoleType.Folder:
                    HoleTimer.Interval = HoleScanInterval;
                    HoleTimer.Tick += HoleTimer_Tick;
                    HoleTimer.Start();
                    break;
                case HoleType.FUSE:

                    break;
            }
        }

        public void Cleanup(bool detachTarget = true)
        {
            Directory.Delete(Target, true);
            if(detachTarget) Target = "(null)";
        }

        private void HoleTimer_Tick(object sender, EventArgs e)
        {
            if (Target == "(null)") return;
            try
            {
                foreach(var directory in Directory.GetDirectories(Target))
                {
                    try
                    {
                        Directory.Delete(directory, true);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                foreach(var file in Directory.GetFiles(Target))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {
                //TODO add error logging
            }
        }
    }
}
