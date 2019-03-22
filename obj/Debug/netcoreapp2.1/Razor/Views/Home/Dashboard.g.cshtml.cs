#pragma checksum "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6da0a4b2e0a4ec7ef0188b2d558157fa722126fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/_ViewImports.cshtml"
using Activity_Center;

#line default
#line hidden
#line 7 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
using Activity_Center.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da0a4b2e0a4ec7ef0188b2d558157fa722126fb", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9dc1ae3f4d8758441d6639d51eefa587562847", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 41, true);
            WriteLiteral("<h2>Dojo Activity Center</h2> \n<p>Wecome ");
            EndContext();
            BeginContext(42, 17, false);
#line 2 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
     Write(ViewBag.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(59, 175, true);
            WriteLiteral("!<p>\n\n<a href=\"New\"><button type=\"button\" class=\"btn btn-primary\">New Activity</button></a>\n<a href=\"Logout\"><button type=\"button\" class=\"btn btn-danger\">Logout</button></a>\n\n");
            EndContext();
            BeginContext(283, 353, true);
            WriteLiteral(@"
<table class=""table table-striped mt-4"">
    <thead>
      <tr>
        <th scope=""col"">Activity</th>
        <th scope=""col"">Date and Time</th>
        <th scope=""col"">Duration</th>
        <th scope=""col"">Event Coordinator</th>
        <th scope=""col""># of Participants</th>
        <th scope=""col"">Action</th>
      </tr>
    </thead>
      <tbody>
");
            EndContext();
#line 22 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
         foreach(var E in @Model)
        {

#line default
#line hidden
            BeginContext(680, 60, true);
            WriteLiteral("        <tr>\n            <td scope=\"row\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 740, "\"", 767, 2);
            WriteAttributeValue("", 747, "/Activity/", 747, 10, true);
#line 26 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 757, E.EventId, 757, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(768, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(770, 7, false);
#line 26 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                                          Write(E.Title);

#line default
#line hidden
            EndContext();
            BeginContext(777, 57, true);
            WriteLiteral("</a> \n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(835, 45, false);
#line 29 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
           Write(E.StartTime.ToString("MM/dd/yyyy @ hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(880, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(933, 10, false);
#line 32 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
           Write(E.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(943, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(945, 10, false);
#line 32 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                       Write(E.TimeType);

#line default
#line hidden
            EndContext();
            BeginContext(955, 36, true);
            WriteLiteral("\n            </td>\n            <td>\n");
            EndContext();
#line 35 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                foreach(var user in @ViewBag.users){
                   if(@user.UserId == @E.UserId){
                       

#line default
#line hidden
            BeginContext(1118, 14, false);
#line 37 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                  Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 15, true);
            WriteLiteral("<span> </span> ");
            EndContext();
            BeginContext(1148, 13, false);
#line 37 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                                                Write(user.LastName);

#line default
#line hidden
            EndContext();
#line 37 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                                                                   
                   }
               }

#line default
#line hidden
            BeginContext(1200, 51, true);
            WriteLiteral("            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1252, 20, false);
#line 42 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
           Write(E.Participants.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1324, 2708, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03697d12b75d4f1e930cfac6993231b4", async() => {
                BeginContext(1410, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 46 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                      
                    int flag = 0;
                    List<int> goodEventId = new List<int>();
                    

#line default
#line hidden
#line 49 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     foreach (var JoinedEvent in @ViewBag.UserJoinedEvents)
                    {
                        foreach (var NotJoinedEvent in @ViewBag.UserNotJoinedEvents)
                        {
                            if(JoinedEvent == null)
                            {
                                goodEventId.Add(NotJoinedEvent.EventId);
                            }
                            if(JoinedEvent.EndTime<NotJoinedEvent.StartTime)
                            {
                                goodEventId.Add(NotJoinedEvent.EventId);
                            }
                            if(JoinedEvent.StartTime>NotJoinedEvent.EndTime)
                            {
                                goodEventId.Add(NotJoinedEvent.EventId);
                            }
                        }
                    }

#line default
#line hidden
#line 67 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     foreach (var id in goodEventId)
                    {
                        if(E.EventId == id){
                            flag = 0;
                        }
                        else 
                        {
                            flag = 2;
                        }
                    }

#line default
#line hidden
#line 76 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     
                    Console.WriteLine(flag);
                    

#line default
#line hidden
#line 78 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     foreach (var JoinedEvent in @ViewBag.UserJoinedEvents)
                    {
                        if(E.EventId == JoinedEvent.EventId)
                        {
                            flag = 1;
                        }
                    }

#line default
#line hidden
#line 84 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     
                    Console.WriteLine(flag);
                    

#line default
#line hidden
#line 86 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     foreach (var guest in @E.Participants) {
                        if (@guest.UserId == @ViewBag.LoginUser) {
                            flag = 1;
                        }
                    }

#line default
#line hidden
#line 90 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     
                    Console.WriteLine(flag);
                    Console.WriteLine("//////////////////");
                    

#line default
#line hidden
#line 93 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     if(flag == 1)
                    {

#line default
#line hidden
                BeginContext(3456, 26, true);
                WriteLiteral("                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3482, "\"", 3507, 2);
                WriteAttributeValue("", 3489, "Un-RSVP/", 3489, 8, true);
#line 95 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3497, E.EventId, 3497, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3508, 71, true);
                WriteLiteral("><button type=\"button\" class=\"btn-sm btn-secondary\">Leave</button></a>\n");
                EndContext();
#line 96 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                    }

#line default
#line hidden
#line 97 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     if(flag == 0)
                    {

#line default
#line hidden
                BeginContext(3660, 87, true);
                WriteLiteral("                        <button type=\"submit\" class=\"btn-sm btn-success\">Join</button>\n");
                EndContext();
#line 100 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                    }

#line default
#line hidden
#line 101 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                     if(@E.UserId == @ViewBag.LoginUser)
                    {

#line default
#line hidden
                BeginContext(3848, 26, true);
                WriteLiteral("                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3874, "\"", 3899, 2);
                WriteAttributeValue("", 3881, "/delete/", 3881, 8, true);
#line 103 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3889, E.EventId, 3889, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3900, 69, true);
                WriteLiteral("><button type=\"button\" class=\"btn-sm btn-danger\">Delete</button></a>\n");
                EndContext();
#line 104 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                    }

#line default
#line hidden
                BeginContext(4009, 16, true);
                WriteLiteral("                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
                                          WriteLiteral(E.EventId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4032, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 109 "/Users/Andy/Documents/coding_dojo/c#_stack/Entity_Framework/Activity_Center/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(4075, 25, true);
            WriteLiteral("      </tbody>\n  </table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591