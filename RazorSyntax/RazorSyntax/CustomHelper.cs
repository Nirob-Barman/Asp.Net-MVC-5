using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorSyntax
{
    public static class CustomHelper
    {
        public static IHtmlString Image(string src, string alt, int width, int height)
        {
            //return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'></img>", src, alt));
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}' width='{2}' height='{3}'></img>", src, alt, width, height));
        }

        public static IHtmlString Img(this HtmlHelper helper, string src, string alt, int width, int height)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}' width='{2}' height='{3}'></img>", src, alt, width, height));
        }

        public static IHtmlString ImgTag(this HtmlHelper helper, string src, string alt, int width, int height)
        {
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src", src);
            tag.Attributes.Add("alt", alt);
            tag.Attributes.Add("width", width.ToString());
            tag.Attributes.Add("height", height.ToString());
            return new MvcHtmlString(tag.ToString());
        }
    }
}