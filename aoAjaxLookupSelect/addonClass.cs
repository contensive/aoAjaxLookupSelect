using System;
using System.Collections.Generic;
using System.Text;
using Contensive.BaseClasses;

namespace aoAjaxLookupSelect
{
    //
    // 1) Change the namespace to the collection name
    // 2) Change this class name to the addon name
    // 3) Create a Contensive Addon record with the namespace apCollectionName
    // 3) add reference to CPBase.DLL, typically installed in c:\program files\kma\contensive\
    //
    public class lookupSelectClass : Contensive.BaseClasses.AddonBaseClass
    {
        //
        // execute method is the only public
        //
        public override object Execute(Contensive.BaseClasses.CPBaseClass cp)
        {
            return "Hello World";
        }
    }
}
