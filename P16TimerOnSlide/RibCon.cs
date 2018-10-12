using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace P16TimerOnSlide
{
    public partial class RibCon
    {
        private void RibCon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonModeTimer_Click(object sender, RibbonControlEventArgs e)
        {
            if (groupStop.Visible == true) groupStop.Visible = false;
            groupTimer.Visible = true;
        }

        private void buttonModeStop_Click(object sender, RibbonControlEventArgs e)
        {
            if (groupTimer.Visible == true) groupTimer.Visible = false;
            groupStop.Visible = true;
        }
    }
}
