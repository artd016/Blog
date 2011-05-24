﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Blog.Models.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Dodaj post
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Dodaj post</h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    
    <% Html.EnableClientValidation(); %>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    
    <fieldset>
        <legend>Post</legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.tytul) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.tytul) %>
            <%: Html.ValidationMessageFor(model => model.tytul) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.tresc) %>
        </div>
        <div class="text-box.multi-line">
            <%: Html.TextAreaFor(model => model.tresc) %>
            <%: Html.ValidationMessageFor(model => model.tresc) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.status) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("status", ViewData["list"] as SelectList)%>
        </div>
        <p>
            <input type="submit" value="Dodaj post" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
</asp:Content>
