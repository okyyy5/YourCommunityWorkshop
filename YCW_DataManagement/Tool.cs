using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCW_DataManagement
{
    public class Tool
    {
        public int ToolID { get; set; }
        public string ToolName { get; set; }
        public string ToolBrand { get; set; }
        public string ToolCondition { get; set; }
        public string ToolStatus { get; set; }
        public bool RentStatus { get; set; }
        public string Notes { get; set; }


        public Tool() { }

        // Constructor for dummy data
        public Tool(string toolname, string toolbrand, string toolcondition, string toolstatus, bool rent, string notes)
        {
            ToolName = toolname;
            ToolBrand = toolbrand;
            ToolCondition = toolcondition;
            ToolStatus = toolstatus;
            RentStatus = rent;
            Notes = notes;
        }
    }
}
