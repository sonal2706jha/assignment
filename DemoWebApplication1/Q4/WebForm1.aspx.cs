using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Load(object sender, EventArgs e)
        {
            Log(" Load page");
        }

        protected void Page_loaded(object sender, EventArgs e)
        {
            Log("Page_PreLoaded");
        }

        protected void CtrlChanged(Object sender, EventArgs e)
        { 
            string ctrlName = ((Control)sender).ID;
            Log(ctrlName + " Changed");
        }
        private void Log(string entry)
        {
            lstEvents.Items.Add(entry); 
            lstEvents.SelectedIndex = lstEvents.Items.Count - 1;
        }
    }
}
