#pragma checksum "\\Mac\Home\Documents\PROJECTS\DOTNETPROJECTS\ComplierWeb\Views\Shared\Partial\NotificationPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbaf827373489e92f68d8404eae97fa930b15302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_NotificationPartialView), @"mvc.1.0.view", @"/Views/Shared/Partial/NotificationPartialView.cshtml")]
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
#nullable restore
#line 1 "\\Mac\Home\Documents\PROJECTS\DOTNETPROJECTS\ComplierWeb\Views\_ViewImports.cshtml"
using ComplierWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Documents\PROJECTS\DOTNETPROJECTS\ComplierWeb\Views\_ViewImports.cshtml"
using ComplierWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "\\Mac\Home\Documents\PROJECTS\DOTNETPROJECTS\ComplierWeb\Views\Shared\Partial\NotificationPartialView.cshtml"
using ComplierWeb.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbaf827373489e92f68d8404eae97fa930b15302", @"/Views/Shared/Partial/NotificationPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d957295ce4475a859fb6d48dbd91d0c8c513ddb1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Partial_NotificationPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotificationViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/users/avatar-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("me-3 rounded-circle avatar-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/users/avatar-8.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/users/avatar-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/users/avatar-6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/svg/bell.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""dropdown topbar-head-dropdown ms-1 header-item"">
                        <button type=""button"" class=""btn btn-icon btn-topbar btn-ghost-secondary rounded-circle"" id=""page-header-notifications-dropdown"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class='bx bx-bell fs-22'></i>
                            <span class=""position-absolute topbar-badge fs-10 translate-middle badge rounded-pill bg-danger"">3<span class=""visually-hidden"">unread messages</span></span>
                        </button>
                        <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-end p-0"" aria-labelledby=""page-header-notifications-dropdown"">
    
                            <div class=""dropdown-head bg-primary bg-pattern rounded-top"">
                                <div class=""p-3"">
                                    <div class=""row align-items-center"">
                                        <div class=""col"">
                                      ");
            WriteLiteral(@"      <h6 class=""m-0 fs-16 fw-semibold text-white""> Notifications </h6>
                                        </div>
                                        <div class=""col-auto dropdown-tabs"">
                                            <span class=""badge badge-soft-light fs-13"">");
#nullable restore
#line 18 "\\Mac\Home\Documents\PROJECTS\DOTNETPROJECTS\ComplierWeb\Views\Shared\Partial\NotificationPartialView.cshtml"
                                                                                  Write(Model.NewMessages);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" New</span>
                                        </div>
                                    </div>
                                </div>
    
                                <div class=""px-2 pt-2"">
                                    <ul class=""nav nav-tabs dropdown-tabs nav-tabs-custom"" data-dropdown-tabs=""true"" id=""notificationItemsTab"" role=""tablist"">
                                        <li class=""nav-item waves-effect waves-light"">
                                            <a class=""nav-link active"" data-bs-toggle=""tab"" href=""#all-noti-tab"" role=""tab"" aria-selected=""true"">
                                                All (");
#nullable restore
#line 27 "\\Mac\Home\Documents\PROJECTS\DOTNETPROJECTS\ComplierWeb\Views\Shared\Partial\NotificationPartialView.cshtml"
                                                Write(Model.NewMessages);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")
                                            </a>
                                        </li>
                                        <li class=""nav-item waves-effect waves-light"">
                                            <a class=""nav-link"" data-bs-toggle=""tab"" href=""#messages-tab"" role=""tab"" aria-selected=""false"">
                                                Messages
                                            </a>
                                        </li>
                                        <li class=""nav-item waves-effect waves-light"">
                                            <a class=""nav-link"" data-bs-toggle=""tab"" href=""#alerts-tab"" role=""tab"" aria-selected=""false"">
                                                Alerts
                                            </a>
                                        </li>
                                    </ul>
                                </div>
    
                            </div>
    
                            <div class=""tab-con");
            WriteLiteral(@"tent"" id=""notificationItemsTabContent"">
                                <div class=""tab-pane fade show active py-2 ps-2"" id=""all-noti-tab"" role=""tabpanel"">
                                    <div data-simplebar style=""max-height: 300px;"" class=""pe-2"">
                                        <div class=""text-reset notification-item d-block dropdown-item position-relative"">
                                            <div class=""d-flex"">
                                                <div class=""avatar-xs me-3"">
                                                    <span class=""avatar-title bg-soft-info text-info rounded-circle fs-16"">
                                                        <i class=""bx bx-badge-check""></i>
                                                    </span>
                                                </div>
                                                <div class=""flex-1"">
                                                    <a href=""#!"" class=""stretched-link"">
                   ");
            WriteLiteral(@"                                     <h6 class=""mt-0 mb-2 lh-base"">Your <b>Elite</b> author Graphic
                                                            Optimization <span class=""text-secondary"">reward</span> is
                                                            ready!
                                                        </h6>
                                                    </a>
                                                    <p class=""mb-0 fs-11 fw-medium text-uppercase text-muted"">
                                                        <span><i class=""mdi mdi-clock-outline""></i> Just 30 sec ago</span>
                                                    </p>
                                                </div>
                                                <div class=""px-2 fs-15"">
                                                    <div class=""form-check notification-check"">
                                                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5127, "\"", 5135, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""all-notification-check01"">
                                                        <label class=""form-check-label"" for=""all-notification-check01""></label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
    
                                        <div class=""text-reset notification-item d-block dropdown-item position-relative active"">
                                            <div class=""d-flex"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbaf827373489e92f68d8404eae97fa930b1530213055", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <div class=""flex-1"">
                                                    <a href=""#!"" class=""stretched-link"">
                                                        <h6 class=""mt-0 mb-1 fs-13 fw-semibold"">Angela Bernier</h6>
                                                    </a>
                                                    <div class=""fs-13 text-muted"">
                                                        <p class=""mb-1"">Answered to your comment on the cash flow forecast's
                                                            graph ????.</p>
                                                    </div>
                                                    <p class=""mb-0 fs-11 fw-medium text-uppercase text-muted"">
                                                        <span><i class=""mdi mdi-clock-outline""></i> 48 min ago</span>
                                                    </p>
                                                </div>
          ");
            WriteLiteral(@"                                      <div class=""px-2 fs-15"">
                                                    <div class=""form-check notification-check"">
                                                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 7134, "\"", 7142, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""all-notification-check02"" checked>
                                                        <label class=""form-check-label"" for=""all-notification-check02""></label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
    
                                        <div class=""text-reset notification-item d-block dropdown-item position-relative"">
                                            <div class=""d-flex"">
                                                <div class=""avatar-xs me-3"">
                                                    <span class=""avatar-title bg-soft-danger text-danger rounded-circle fs-16"">
                                                        <i class='bx bx-message-square-dots'></i>
                                                    </span>
                                                </div>
                                 ");
            WriteLiteral(@"               <div class=""flex-1"">
                                                    <a href=""#!"" class=""stretched-link"">
                                                        <h6 class=""mt-0 mb-2 fs-13 lh-base"">You have received <b class=""text-success"">20</b> new messages in the conversation
                                                        </h6>
                                                    </a>
                                                    <p class=""mb-0 fs-11 fw-medium text-uppercase text-muted"">
                                                        <span><i class=""mdi mdi-clock-outline""></i> 2 hrs ago</span>
                                                    </p>
                                                </div>
                                                <div class=""px-2 fs-15"">
                                                    <div class=""form-check notification-check"">
                                                        <input class=""form-check-input"" type=""che");
            WriteLiteral("ckbox\"");
            BeginWriteAttribute("value", " value=\"", 9197, "\"", 9205, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""all-notification-check03"">
                                                        <label class=""form-check-label"" for=""all-notification-check03""></label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
    
                                        <div class=""text-reset notification-item d-block dropdown-item position-relative"">
                                            <div class=""d-flex"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbaf827373489e92f68d8404eae97fa930b1530218654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <div class=""flex-1"">
                                                    <a href=""#!"" class=""stretched-link"">
                                                        <h6 class=""mt-0 mb-1 fs-13 fw-semibold"">Maureen Gibson</h6>
                                                    </a>
                                                    <div class=""fs-13 text-muted"">
                                                        <p class=""mb-1"">We talked about a project on linkedin.</p>
                                                    </div>
                                                    <p class=""mb-0 fs-11 fw-medium text-uppercase text-muted"">
                                                        <span><i class=""mdi mdi-clock-outline""></i> 4 hrs ago</span>
                                                    </p>
                                                </div>
                                                <div class=""px-2 fs-15"">
                      ");
            WriteLiteral("                              <div class=\"form-check notification-check\">\n                                                        <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 11112, "\"", 11120, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""all-notification-check04"">
                                                        <label class=""form-check-label"" for=""all-notification-check04""></label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
    
                                        <div class=""my-3 text-center"">
                                            <button type=""button"" class=""btn btn-soft-success waves-effect waves-light"">View
                                                All Notifications <i class=""ri-arrow-right-line align-middle""></i></button>
                                        </div>
                                    </div>
    
                                </div>
    
                                <div class=""tab-pane fade py-2 ps-2"" id=""messages-tab"" role=""tabpanel"" aria-labelledby=""messages-tab"">
                                    <div data-simpleb");
            WriteLiteral(@"ar style=""max-height: 300px;"" class=""pe-2"">
                                        <div class=""text-reset notification-item d-block dropdown-item"">
                                            <div class=""d-flex"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbaf827373489e92f68d8404eae97fa930b1530222599", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <div class=""flex-1"">
                                                    <a href=""#!"" class=""stretched-link"">
                                                        <h6 class=""mt-0 mb-1 fs-13 fw-semibold"">James Lemire</h6>
                                                    </a>
                                                    <div class=""fs-13 text-muted"">
                                                        <p class=""mb-1"">We talked about a project on linkedin.</p>
                                                    </div>
                                                    <p class=""mb-0 fs-11 fw-medium text-uppercase text-muted"">
                                                        <span><i class=""mdi mdi-clock-outline""></i> 30 min ago</span>
                                                    </p>
                                                </div>
                                                <div class=""px-2 fs-15"">
                       ");
            WriteLiteral("                             <div class=\"form-check notification-check\">\n                                                        <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 13699, "\"", 13707, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""messages-notification-check01"">
                                                        <label class=""form-check-label"" for=""messages-notification-check01""></label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
    
                                        <div class=""text-reset notification-item d-block dropdown-item"">
                                            <div class=""d-flex"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbaf827373489e92f68d8404eae97fa930b1530225810", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <div class=""flex-1"">
                                                    <a href=""#!"" class=""stretched-link"">
                                                        <h6 class=""mt-0 mb-1 fs-13 fw-semibold"">Angela Bernier</h6>
                                                    </a>
                                                    <div class=""fs-13 text-muted"">
                                                        <p class=""mb-1"">Answered to your comment on the cash flow forecast's
                                                            graph ????.</p>
                                                    </div>
                                                    <p class=""mb-0 fs-11 fw-medium text-uppercase text-muted"">
                                                        <span><i class=""mdi mdi-clock-outline""></i> 2 hrs ago</span>
                                                    </p>
                                                </div>
           ");
            WriteLiteral(@"                                     <div class=""px-2 fs-15"">
                                                    <div class=""form-check notification-check"">
                                                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 15690, "\"", 15698, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""messages-notification-check02"">
                                                        <label class=""form-check-label"" for=""messages-notification-check02""></label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
    
                                        <div class=""text-reset notification-item d-block dropdown-item"">
                                            <div class=""d-flex"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbaf827373489e92f68d8404eae97fa930b1530229106", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <div class=""flex-1"">
                                                    <a href=""#!"" class=""stretched-link"">
                                                        <h6 class=""mt-0 mb-1 fs-13 fw-semibold"">Kenneth Brown</h6>
                                                    </a>
                                                    <div class=""fs-13 text-muted"">
                                                        <p class=""mb-1"">Mentionned you in his comment on ???? invoice #12501.
                                                        </p>
                                                    </div>
                                                    <p class=""mb-0 fs-11 fw-medium text-uppercase text-muted"">
                                                        <span><i class=""mdi mdi-clock-outline""></i> 10 hrs ago</span>
                                                    </p>
                                                </div>
                         ");
            WriteLiteral("                       <div class=\"px-2 fs-15\">\n                                                    <div class=\"form-check notification-check\">\n                                                        <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 17667, "\"", 17675, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""messages-notification-check03"">
                                                        <label class=""form-check-label"" for=""messages-notification-check03""></label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
    
                                        <div class=""text-reset notification-item d-block dropdown-item"">
                                            <div class=""d-flex"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbaf827373489e92f68d8404eae97fa930b1530232389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <div class=""flex-1"">
                                                    <a href=""#!"" class=""stretched-link"">
                                                        <h6 class=""mt-0 mb-1 fs-13 fw-semibold"">Maureen Gibson</h6>
                                                    </a>
                                                    <div class=""fs-13 text-muted"">
                                                        <p class=""mb-1"">We talked about a project on linkedin.</p>
                                                    </div>
                                                    <p class=""mb-0 fs-11 fw-medium text-uppercase text-muted"">
                                                        <span><i class=""mdi mdi-clock-outline""></i> 3 days ago</span>
                                                    </p>
                                                </div>
                                                <div class=""px-2 fs-15"">
                     ");
            WriteLiteral("                               <div class=\"form-check notification-check\">\n                                                        <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 19575, "\"", 19583, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""messages-notification-check04"">
                                                        <label class=""form-check-label"" for=""messages-notification-check04""></label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
    
                                        <div class=""my-3 text-center"">
                                            <button type=""button"" class=""btn btn-soft-success waves-effect waves-light"">View
                                                All Messages <i class=""ri-arrow-right-line align-middle""></i></button>
                                        </div>
                                    </div>
                                </div>
                                <div class=""tab-pane fade p-4"" id=""alerts-tab"" role=""tabpanel"" aria-labelledby=""alerts-tab"">
                                    <div class=""w-25 w-sm-50 pt-3 mx");
            WriteLiteral("-auto\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbaf827373489e92f68d8404eae97fa930b1530236115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <div class=""text-center pb-5 mt-2"">
                                        <h6 class=""fs-18 fw-semibold lh-base"">Hey! You have no any notifications </h6>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotificationViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
