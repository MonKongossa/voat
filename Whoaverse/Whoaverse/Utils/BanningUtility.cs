﻿/*
This source file is subject to version 3 of the GPL license, 
that is bundled with this package in the file LICENSE, and is 
available online at http://www.gnu.org/licenses/gpl.txt; 
you may not use this file except in compliance with the License. 

Software distributed under the License is distributed on an "AS IS" basis,
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
the specific language governing rights and limitations under the License.

All portions of the code written by Whoaverse are Copyright (c) 2014 Whoaverse
All Rights Reserved.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Voat.Models;

namespace Voat.Utils
{
    public class BanningUtility
    {

        public static bool IsHostnameBanned(string hostname)
        {
            using (whoaverseEntities db = new whoaverseEntities())
            {
                var bannedHostname = db.Banneddomains
                            .Where(r => r.Hostname.Equals(hostname, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

                return bannedHostname != null;
            }
        }

    }
}