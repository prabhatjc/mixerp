﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MixERP.Net.WebControls.ScrudFactory;

namespace MixERP.Net.FrontEnd.CRM.Setup
{
    public partial class LeadStatuses : MixERP.Net.BusinessLayer.MixERPWebPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ScrudForm scrud = new ScrudForm())
            {
                scrud.KeyColumn = "lead_status_id";

                scrud.TableSchema = "crm";
                scrud.Table = "lead_statuses";
                scrud.ViewSchema = "crm";
                scrud.View = "lead_statuses";
                scrud.Text = Resources.Titles.LeadStatuses;

                ScriptManager1.NamingContainer.Controls.Add(scrud);
            }
        }
    }
}