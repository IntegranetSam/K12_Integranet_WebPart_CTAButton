using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.ContactManagement;
using CMS.FormEngine;
using CMS.FormEngine.Web.UI;
using CMS.Helpers;
using CMS.Membership;
using CMS.OnlineForms;
using CMS.PortalEngine.Web.UI;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSApp.Integranet.WebParts
{
    public partial class ITG_CTAButton : CMSAbstractWebPart
    {
        #region WebPart Properties
        public string StylePreset
        {
            get
            {
                return GetStringValue("StylePreset", "");
            }

            set
            {
                SetValue("StylePreset", value);
            }
        }

        public string CustomText
        {
            get
            {
                return GetStringValue("CustomText", "");
            }

            set
            {
                SetValue("CustomText", value);
            }
        }

        public string PresetText
        {
            get
            {
                return GetStringValue("PresetText", "");
            }
            set
            {
                SetValue("PresetText", "");
            }
        }

        public string ButtonLink
        {
            get
            {
                return GetStringValue("ButtonLink", "");
            }
            set
            {
                SetValue("ButtonLink", "");
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            // Set the text of CTAButton to the Custom text if user selects, else make button text Preset Text choice. 
            if (PresetText == "Custom")
            {
                CTAButton.Text = CustomText;
            }
            else
            {
                CTAButton.Text = DataHelper.GetNotEmpty(GetValue("PresetText"), "Default");
            }


            // Set button style from selected preset style

            CTAButton.CssClass = "cta-button " + DataHelper.GetNotEmpty(GetValue("StylePreset"), "");

            // Set button to link to Button Link field input

            CTAButton.NavigateUrl = DataHelper.GetNotEmpty(GetValue("ButtonLink"), "#");
        }
    }
}