<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Blog.Models.Tagi>" %>

<asp:Content ID="Content3" ContentPlaceHolderID="TitleContent" runat="server">
    Dodaj post
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

<h2>Dodaj post</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

   <!-- <script>        $(document).ready(function () {
            alert($('input#status').length + ' test' + $('input#status').text());
            if ($('input#status').text() == 0) {
                alert('0');
                $('input#status').text('Wyświetl');
            }
            else {
                alert('1');
                $('input#status').text('Ukryj');
            }
        });</script>-->
    <fieldset>
        <legend>Post</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model=>model.Post.tytul) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBox("Tytul",null, new { disabled = "disabled" })%>           
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model=>model.Post.tresc)%>
        </div>
        <div class="text-box.multi-line">
            <%: Html.TextArea("Tresc", null, new { disabled = "disabled" })%>

        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model=>model.Post.status)%>
        </div>
        <div class="editor-field">    
            <%: Html.TextBox("status",null, new { disabled = "disabled" })%> 

        </div>
        </fieldset>
        <% Html.EnableClientValidation(); %>
<% using (Html.BeginForm("Tagi","Administracja")) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Tagi</legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.keywords) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.keywords) %>
            <%: Html.ValidationMessageFor(model => model.keywords) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.description) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.description) %>
            <%: Html.ValidationMessageFor(model => model.description) %>
        </div>
        <%:Html.HiddenFor(model=>model.id_posta,Model.id_posta) %>
        <p>
            <input type="submit" value="Dodaj tagi"/>
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>

