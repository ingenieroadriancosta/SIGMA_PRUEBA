#pragma checksum "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\SIGMA\SIGMA_PRUEBA\Views\Shared\_profesorform.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1750cb548ef693bdcf8b3d07146efcf248684f6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__profesorform), @"mvc.1.0.view", @"/Views/Shared/_profesorform.cshtml")]
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
#line 1 "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\SIGMA\SIGMA_PRUEBA\Views\_ViewImports.cshtml"
using SIGMA_PRUEBA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\SIGMA\SIGMA_PRUEBA\Views\_ViewImports.cshtml"
using SIGMA_PRUEBA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1750cb548ef693bdcf8b3d07146efcf248684f6d", @"/Views/Shared/_profesorform.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb1c87723f1e88ca2c1ed5ba6a4d173d8bf7778", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__profesorform : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" border border-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("validator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ingprof"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1750cb548ef693bdcf8b3d07146efcf248684f6d5151", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <div style=""display: block;"">
            <label for=""exaest""><b>INGRESO DE PROFESORES:</b></label>
        </div>
        <label for=""static"">Código del módulo:</label>
        <select class=""form-control col-md-4"" id=""idcodmod"" name=""idcodmod"">
");
#nullable restore
#line 9 "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\SIGMA\SIGMA_PRUEBA\Views\Shared\_profesorform.cshtml"
             foreach (var item in @Model.Lmod)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1750cb548ef693bdcf8b3d07146efcf248684f6d6009", async() => {
#nullable restore
#line 11 "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\SIGMA\SIGMA_PRUEBA\Views\Shared\_profesorform.cshtml"
                   Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 12 "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\SIGMA\SIGMA_PRUEBA\Views\Shared\_profesorform.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </select>
    </div>
    
    <br>
    <table class=""table table-bordered form-group"">
        <thead>
            <tr>
            <th>Cédula</th>
            <th>Nombre</th>
            <th>ApellidoP</th>
            <th>ApellidoM</th>
            </tr>
        </thead>
    <tbody>
    <tr>
        <td>
        <input required type=""text"" class=""form-control"" name=""idcard"" id=""idcard"" placeholder=""Cedula"" 
            oninput=""this.value = this.value.replace(/[^0-9.]/g, '').replace(/(\..*)\./g, '$1');""
            maxlength=""18""
                value=""90901283"">

        </td>
        <td>
            <input required type=""text"" class=""form-control"" name=""name"" id=""name"" placeholder=""Nombre"" 
                onkeydown=""return /[a-z]/i.test(event.key)""
                    value=""Lena"">

        </td>
        <td>
            <input required type=""text"" class=""form-control"" name=""lnamep"" id=""lnamep"" placeholder=""Apelllido Pat"" 
                onkeydown=""return /[a-z]/i.t");
                WriteLiteral(@"est(event.key)""
                    value=""Forsen"">
        </td>
        <td>
            <input required type=""text"" class=""form-control"" name=""lnamem"" id=""lnamem"" placeholder=""Apelllido Mat"" 
                onkeydown=""return /[a-z]/i.test(event.key)""
                    value=""DSP"">
        </td>
    </tbody>
    </table>
    <br>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Dirección</th>
                <th>Teléfono</th>
                <th>Fecha de nacimiento</th>
            </tr>
        </thead>
    <tbody>
        <td>
            <input required type=""text"" class=""form-control"" name=""direcc"" id=""direcc"" placeholder=""Dirección"" 
                    value=""Cra19 No 41-21"">
        </td>
        <td>
            <input required type=""text"" class=""form-control"" name=""phone"" id=""phone"" placeholder=""Telefono"" 
                oninput=""this.value = this.value.replace(/[^0-9.]/g, '').replace(/(\..*)\./g, '$1');""
                ma");
                WriteLiteral(@"xlength=""18""
                    value=""5771054"">

        </td>
        <td>
            <input type=""date"" id=""dborn"" name=""dborn""
            value=""1940-01-01""
            min=""1940-01-01"" max=""2020-12-31"">
        </td>
    </tbody>
    </table> 
    <br>
    <button type=""submit"" class=""btn btn-primary mb-2"">Ingresar profesor</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
