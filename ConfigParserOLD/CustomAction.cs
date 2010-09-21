﻿/*
 * ################################################################
 *
 * ProActive: The Java(TM) library for Parallel, Distributed,
 *            Concurrent computing with Security and Mobility
 *
 * Copyright (C) 1997-2010 INRIA/University of 
 *                                 Nice-Sophia Antipolis/ActiveEon
 * Contact: proactive@ow2.org or contact@activeeon.com
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; version 3 of
 * the License.
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
 * If needed, contact us to obtain a release under GPL Version 2 
 * or a different license than the GPL.
 *
 *  Initial developer(s):               The ActiveEon Team
 *                        http://www.activeeon.com/
 *  Contributor(s):
 *
 * ################################################################
 * $$ACTIVEEON_INITIAL_DEV$$
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConfigParserOLD
{
    public class CustomAction : Action
    {
        /** The string description of this action **/
        public const string DESCRIPTION = "Custom";
        /// <summary>
        /// The java class that corresponds to this action.</summary>
        public const string DEFAULT_JAVA_STARTER_CLASS = "user.Starter";
        /// <summary>
        /// The arguments used for this custom conenction.</summary>
        private string[] myArgs;

        public CustomAction()
        {
            base.javaStarterClass = DEFAULT_JAVA_STARTER_CLASS;
            this.args = new string[0];
        }

        [XmlArray("args", IsNullable = false)]
        [XmlArrayItem("arg", IsNullable = true)]
        public String[] args
        {
            get
            {
                return this.myArgs;
            }
            set
            {
                this.myArgs = value;
            }
        }

        public override string[] getArgs()
        {
            return this.myArgs;
        }
    }
}