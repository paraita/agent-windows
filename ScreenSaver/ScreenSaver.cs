/*
* ################################################################
*
* ProActive: The Java(TM) library for Parallel, Distributed,
*            Concurrent computing with Security and Mobility
*
* Copyright (C) 1997-2009 INRIA/University of Nice-Sophia Antipolis
* Contact: proactive@ow2.org
*
* This library is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version
* 2 of the License, or any later version.
*
* This library is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
* General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this library; if not, write to the Free Software
* Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307
* USA
*
*  Initial developer(s):               The ProActive Team
*                        http://proactive.inria.fr/team_members.htm
*  Contributor(s): ActiveEon Team - http://www.activeeon.com
*
* ################################################################
* $$ACTIVEEON_CONTRIBUTOR$$
*/
using System;
using System.Windows.Forms;

/**
 * Main screensaver class conforming to screen saver requirements as for command line parameters
 */

namespace ScreenSaver
{
    public class DotNETScreenSaver
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                // we don't have configuration dialog
                if (args[0].ToLower().Trim().Substring(0, 2) == "/c")
                {
                    MessageBox.Show("This Screen Saver has no options you can set.", "ProActive Agent Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (args[0].ToLower() == "/s")
                {
                    System.Windows.Forms.Application.Run(new ScreenSaverForm());
                }
            }
            else
            {
                System.Windows.Forms.Application.Run(new ScreenSaverForm());
            }
        }
    }
}
