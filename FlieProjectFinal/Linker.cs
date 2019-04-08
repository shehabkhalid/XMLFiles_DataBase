using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FlieProjectFinal
{


    public class pair
    {
        public string a, b;

    }

    public class info
    {



        public List<pair> Row = new List<pair>();

    }

    public static class Linker
    {
        public static Dictionary<string, info> allData = new Dictionary<string, info>();

        public static Dictionary<string, string> Rule = new Dictionary<string, string>();



    }
}
