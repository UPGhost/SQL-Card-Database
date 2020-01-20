using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterApp
{
    public static class VersionInfo
    {
        public static string ApplicationName { get; }
        public static string CreatorName { get; }
        public static string VersionNumber { get; }

        static VersionInfo()
        {
            ApplicationName = "LoR Card Database";
            CreatorName = "Conor Wood";
            VersionNumber = "1.0.0";
        }
    }
}
