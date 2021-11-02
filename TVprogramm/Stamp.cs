using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVprogramm
{
    public class Stamp
    { public  string print()
        {
            return this.start_time + this.id + this.end_time;
        }

        public Stamp(
         string id,
         string data,
         string start_time,
         string end_time,
         string TV,
         string TV_show
        
    ) {
            this.id = id;
            this.data = data;
            this.start_time = start_time;
            this.end_time = end_time;
            this.TV = TV;
            this.TV_show = TV_show;
            
        }

        public string id = "";
        public string data = "";
        public string start_time = "";
        public string end_time = "";
        public string TV = "";
        public string TV_show = "";
    }
    }

