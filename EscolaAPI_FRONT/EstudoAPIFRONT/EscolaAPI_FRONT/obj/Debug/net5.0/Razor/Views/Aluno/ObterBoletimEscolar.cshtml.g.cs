#pragma checksum "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad5aeb16b2d1e9448382923a40bef9bdbeda092b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_ObterBoletimEscolar), @"mvc.1.0.view", @"/Views/Aluno/ObterBoletimEscolar.cshtml")]
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
#line 1 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\_ViewImports.cshtml"
using EscolaAPI_FRONT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\_ViewImports.cshtml"
using EscolaAPI_FRONT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad5aeb16b2d1e9448382923a40bef9bdbeda092b", @"/Views/Aluno/ObterBoletimEscolar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c20a7d4cb0507cd3a49698fece3ea198727e73", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_ObterBoletimEscolar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EscolaAPI_FRONT.DTO.BoletimEscolarDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
  
    ViewData["Title"] = "BoletimEscolar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Boletim Escolar do ");
#nullable restore
#line 7 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
                  Write(ViewBag.NomeAluno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 174, "\"", 220, 2);
            WriteAttributeValue("", 181, "../CriarBoletimEscolar/", 181, 23, true);
#nullable restore
#line 10 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
WriteAttributeValue("", 204, ViewBag.IdAluno, 204, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Criar Novo Boletim Escolar</a>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Nome do Aluno
            </th>
            <th>
                Professor
            </th>
            <th>
                Disciplina
            </th>
            <th>
               Nota
            </th>
            <th>
                Descrição
            </th>
            <th>
                Data
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 37 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeAluno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeProfessor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeDisciplina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.DisplayFor(modelItem => item.NotaBoletimEscolar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescricaoBoletim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataNota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\lucia\OneDrive\Área de Trabalho\EscolaAPI\EstudoAPI\EscolaAPI_FRONT\EstudoAPIFRONT\EscolaAPI_FRONT\Views\Aluno\ObterBoletimEscolar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EscolaAPI_FRONT.DTO.BoletimEscolarDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
