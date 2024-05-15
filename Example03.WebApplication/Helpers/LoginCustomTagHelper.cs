﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Example03.WebApplication.Helpers
{
    [HtmlTargetElement("login-form")]
    public class LoginCustomTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; //dışarıya bir tag oluşturuyoruz ve dışarıya böyle bir tag çıkartıyor.
            output.TagMode = TagMode.StartTagAndEndTag; //bitiş ve açılış tagı

            string loginForm = "<form action='/Home/Login' method='post'>";

            loginForm += "<input type='text' name='username'/>";
            loginForm += "<input type='password' name='password'/>";
            loginForm += "<input type='submit' value='Giriş'/>";

            loginForm += "</form>";

            output.PreContent.SetHtmlContent(loginForm);


        }
    }
}
