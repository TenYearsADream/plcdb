﻿using plcdb_lib.Models.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plcdb_lib_advancedhmi
{
    public class EthernetIP_SLC : ControllerBase
    {
        public static string Name
        {
            get { return "AB SLC PLC"; }
        }

        public override object Read(plcdb_lib.Models.Model.TagsRow t)
        {
            throw new NotImplementedException();
        }

        public override bool Write(plcdb_lib.Models.Model.TagsRow t, object val)
        {
            throw new NotImplementedException();
        }

        public override plcdb_lib.Models.Model.TagsDataTable BrowseTags()
        {
            throw new NotImplementedException();
        }


        public override bool ValidateTag(string address)
        {
            throw new NotImplementedException();
        }
    }
}
