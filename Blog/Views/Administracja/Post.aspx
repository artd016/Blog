﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Wyświetl posty
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
        <h2>Wyświetl posty z dnia <%:ViewData["data"]%></h2>
        <h1><%:ViewData["komunikat"] %></h1>
    <p>
        <%: Html.ActionLink("Dodaj post", "DodajPost") %>
    </p>
    <% foreach (var item in Model)
       { %>
    <fieldset>
        <h1>
            <%int y=item.data_dodania.Year; %>
        <%string m=Convert.ToString(item.data_dodania.Month); %>
        <%string d = Convert.ToString(item.data_dodania.Day); %>
        <%if (m.Length == 1) m="0"+m; %>
        <%if (d.Length == 1) d="0"+d; %>
            <%: Html.ActionLink(item.tytul as string, "Post" + "/" + y + "/" + m + "/" + d, new { id = item.tytul.Replace(' ', '_') })%></h1>
        <p>
            <%if ((item.tresc as string).Length > 99)
              { %>
            <%: (item.tresc as string).Remove(98)%>
            ...<br />
            <%:Html.ActionLink("Więcej", "Post" + "/" + y + "/" + m + "/" + d, new { id = item.tytul.Replace(' ', '_') })%>
            <%}
              else
              {%>
            <%: item.tresc%>
            <% }%></p>
        <%: String.Format("{0:yyyy-MM-dd}", item.data_dodania) %>
        <%if (item.data_modyfikacji != null)
          { %>
        <%: String.Format("{0:yyyy-MM-dd}}", item.data_modyfikacji)%>
        <%} %>
        <%if (item.status == 0)
          { %>
        <p>
            Opublikowany</p>
        <%}
          else
          { %>
        <p>
            Ukryty</p>
        <%} %>
        <%: Html.ActionLink("Edytuj post", "EdytujPost", new { id = item.id })%>
        <%: Html.ActionLink("Usuń post", "Delete", new { id=item.id }) %>
    </fieldset>
    <% } %>
    
    <% if (Model.HasPreviousPage)
       { %>
    <%: Html.ActionLink("<<<","Post" + ViewData["akcja"],
new { page=(Model.PageIndex-1) }) %>
    <% } %>
    <% if (Model.HasNextPage)
       { %>
    <%: Html.ActionLink(">>>", "Post"+ViewData["akcja"],
new { page = (Model.PageIndex + 1) })%>
    <% } %>
</asp:Content>
