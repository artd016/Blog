<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Blog.Models.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    EdytujPost
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edytuj Post</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Post</legend>

        <%: Html.HiddenFor(model => model.id) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.tytul) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.tytul) %>
            <%: Html.ValidationMessageFor(model => model.tytul) %>
        </div>
        <br />
        <div class="editor-label">
            <%: Html.LabelFor(model => model.tresc) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.tresc) %>
            <%: Html.ValidationMessageFor(model => model.tresc) %>
        </div>
        <br />
        <div class="editor-field">
            <%: Html.DropDownList("status", ViewData["list"] as SelectList)%>
        </div>
        <br />
        <p>
            <input type="submit" value="Zapisz" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Wróć do listy postów", "Index") %>
</div>

</asp:Content>

