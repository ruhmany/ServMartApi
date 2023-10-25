using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Helpers
{
    public static class JWT
    {
        public static string Key { get=> "Q5Pe3cStYk0NWFAaFmYW0uuPy/mMMSwIFsqoL86bOhs="; }
        public static string Issuer { get => "ServMartApplication"; }
        public static string Audience { get => "ServMartApplicationUser"; }
        public static double DurationInDays { get => 30; }
    }
}
