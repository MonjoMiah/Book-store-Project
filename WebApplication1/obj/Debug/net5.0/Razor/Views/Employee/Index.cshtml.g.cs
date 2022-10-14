#pragma checksum "G:\My all Project\asp.net core project\WebApplication1\WebApplication1\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a51dfba88e32bb64a5df5fdc25f4b189e852da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "G:\My all Project\asp.net core project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\My all Project\asp.net core project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a51dfba88e32bb64a5df5fdc25f4b189e852da", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.12.1/css/jquery.dataTables.css"">
<style>
    #tblemployee_length {
        margin-top: 15px;
    }
</style>
<div class=""row"">
    <div class=""col-lg-12"">
        <a href=""#"" onclick=""createnew();return false;"" class=""btn btn-primary"">Add New</a>
        ");
#nullable restore
#line 10 "G:\My all Project\asp.net core project\WebApplication1\WebApplication1\Views\Employee\Index.cshtml"
   Write(Html.Partial("~/Views/Shared/master/_employee.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "G:\My all Project\asp.net core project\WebApplication1\WebApplication1\Views\Employee\Index.cshtml"
   Write(Html.Partial("~/Views/Shared/master/_upload.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <br />

    <div class=""col-lg-12"">
        <table id=""tblemployee"" class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Code</th>
                    <th>Name</th>
                    <th>Phone</th>
                    <th>Email</th>
                    <th>Designation</th>
                    <th>Image</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</div>
<br /><br />
<script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.6.1.min.js""></script>
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.js""></script>
<script type=""text/javascript"">
    var js = jQuery.noConflict(true);
    js(document).ready(function () {
        loadEmployee();
        loaddesignation();
    })
    function funtionEdit(element) {
        createnew();
        var code = $(");
            WriteLiteral(@"element).closest('tr').find(""#hdncode"").val();
        $.ajax({
            type: 'post',
            url: '/Employee/GetByCode',
            data: { code: code },
            async: false,
            success(data) {
                if (data != null) {
                    $.each(data, function (key, value) {
                        $('#textcode').val(data.code);
                        $('#textname').val(data.name);
                        $('#textphone').val(data.email);
                        $('#textemail').val(data.phone);
                        $('#ddldesignation').val(data.dcode);
                    });
                }
            },
            error() {

            }
        })
    }

    function functionDelete(element) {
        if (confirm(""Do You want Delete This?"")) {
            var code = $(element).closest('tr').find(""#hdncode"").val();
            $.ajax({
                type: 'post',
                url: 'Employee/Remove',
                data: { code: cod");
            WriteLiteral(@"e },
                async: false,
                success(data) {
                    loadEmployee();
                },
                error() {

                }
            });
        }
    }
    function loadEmployee() {
        var empdata = [];
        $.ajax({
            type: 'post',
            url: '/Employee/GetAll',
            data: {},
            async: false,
            success(data) {
                if (data != null) {
                    $.each(data, function (key, value) {
                        var editbutton = ""<a href='#' onclick='funtionEdit(this)' class='btn btn-primary'>Edit</a>""
                        var Deletebutton = ""<a href='#' onclick='functionDelete(this)' class='btn btn-danger'>Delete</a>""
                        var hidden = ""<input type=hidden id='hdncode' value='"" + value.code + ""'>""
                        var action = hidden + editbutton + ' | ' + Deletebutton;
                        var imgPath = '/Uploads/Employee/' + value.code + '.j");
            WriteLiteral(@"peg';
                        var images = ""<img class='img-responsive img-thumbnail' style='height:50px;width:50px;' onclick='openpopup(this); return False' src='"" + imgPath + ""'/>""
                        empdata.push([value.code, value.name, value.email, value.phone, value.dcode, images, action])
                    });
                }
            },
            error() {

            }
        })
        js(""#tblemployee"").dataTable({
            destroy: true,
            data: empdata
        })
    }
    function createnew() {
        ClearAll();
        $(""#btnmodal"").trigger('click');
    }
    function ClearAll() {
        $('#textcode').val('');
        $('#textname').val('');
        $('#textphone').val('');
        $('#textemail').val('');
        $('#ddldesignation').val('');
    }
    function loaddesignation() {
        $(""#ddldesignation option"").remove();
        $(""#ddldesignation"").append(""<option value =''>--Select--</option>"");
        $.ajax({
           ");
            WriteLiteral(@" type: 'post',
            url: 'Employee/GetAlldesig',
            data: {},
            success(data) {
                if (data != null) {
                    $.each(data, function (key, value) {
                        $(""#ddldesignation"").append(""<option value ='"" + value.dcode + ""'>"" + value.dname + ""</option >"");
                    });
                }
            },
            error() {

            }
        })
    }
    function save() {
        var isProcced = true;
        var code = $('#textcode').val();
        var name = $('#textname').val();
        var phone = $('#textphone').val();
        var email = $('#textemail').val();
        var dcode = $('#ddldesignation').val();
        if (dcode == '') {
            isProcced = false;
            $('#ddldesignation').css('borderColor', 'red');
        }
        else {
            $('#textname').css('borderColor', '#ccc');
        }
        if (isProcced) {
            var empdata = new Object();
            empdata");
            WriteLiteral(@".code = code;
            empdata.name = name;
            empdata.email = email;
            empdata.phone = phone;
            empdata.dcode = dcode;
            $.ajax({
                type: 'post',
                url: '/Employee/save',
                data: empdata,
                success(data) {
                    if (data == 'pass') {
                        $('.close').trigger('click');
                        loadEmployee();
                        alert('Save Successfully');
                    }
                    else {
                        alert('Failed');
                    }
                },
                error() {

                }
            });
        }
    }
    var currentImage;
    function openpopup(element) {
        $('#imgupload').val('');
        currentImage = $(element);
        $('#popupimage').attr('src',currentImage.attr('src'));
        var employeecode = currentImage.closest('tr').find(""#hdncode"").val();
        $('#currentemcode')");
            WriteLiteral(@".val(employeecode);
        $('#btnpopup').trigger('click');
    }
    function funtionupload() {
        var uploadfile = $('#imgupload').get(0);
        var files = uploadfile.files;
        var filedata = new FormData();
        var empcode = $('#currentemcode').val();
        for (var i = 0; i < files.length; i++) {
            filedata.append(empcode, files[i]);
        }
        $.ajax({
            url: 'Employee/uploadImage',
            type: 'POST',
            data: filedata,
            processData: false,
            contentType: false,
            success: function (result) {
                if (result == 'pass') {
                    alert('Employe Image Uploaded');
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        $(currentImage).attr('src', e.target.result);
                        $('#popupimage').attr('src', e.target.result);
                    }
                    reader.readAsDataURL(upl");
            WriteLiteral(@"oadfile.files[0]);
                }
            },
            error: function () {

            }
        })
    }
    function RemoveImage() {
        var empcode = $('#currentemcode').val();
        $.ajax({
            type: 'post',
            url: '/Employee/RemoveImage',
            data: { code: empcode },
            async: false,
            success(data) {
                $(currentImage).attr('src', '');
            },
            error() {

            }
        })
    }
</script>

");
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