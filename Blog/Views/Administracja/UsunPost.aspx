<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Blog.Models.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    UsunPost
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>UsunPost</h2>

<h3>Czy na pewno chcesz usun¹æ ten post?</h3>
<fieldset>
    <legend>Post</legend>

    <div class="display-label">Data dodania</div>
    <div class="display-field"><%: String.Format("{0:g}", Model.data_dodania) %></div>

    <div class="display-label">Tytu³ posta</div>
    <div class="display-field"><%: Model.tytul %></div>

    <div class="display-label">Treœæ posta</div>
    <div class="display-field"><%: Model.tresc %></div>

    <div class="display-label">Data modyfikacji</div>
    <div class="display-field"><%: String.Format("{0:g}", Model.data_modyfikacji) %></div>

    <div class="display-label">Status</div>
    <div class="display-field"><%: Model.status %></div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Wróæ do listy postów", "Index") %>
    </p>
<% } %>

</asp:Content>

