using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Models
{
    public static class HtmlExtention
    {
        public static MvcHtmlString SubmitButton(this HtmlHelper helper, String buttonText)
        {
            String str = "<input type=\"Submit\" Value=\"" + buttonText + "\" />";
            return new MvcHtmlString(str);
        }

    }
}