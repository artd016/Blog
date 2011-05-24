<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
<fieldset>
<legend>Komentarze</legend>
<br />
<%:ViewData["komunikat"]%>
<%int id_posta=0; %>
<% foreach (var item in Model)
       { %>
       <fieldset>
       <table>
       <tr>
       <td>
       <h5><%:item.tresc%></h5>
       <%id_posta = item.id_posta; %>
       </td>
       <td>
       <%: Html.ActionLink("Usuń komentarz", "Delete", new { id=item.id }) %>
       </td>
       </tr>
       </table>
       Data dodania: <%:String.Format("{0:yyyy-MM-dd}", item.data_dodania)%>
       Autor: <%:item.autor%>
        Status: <%if (item.status == 0)
          { %>
        Opublikowany
        <%}
          else
          { %>
            Ukryty
        <%} %>
        
        </fieldset>
       <% } %>

<%--<% if (Model.HasPreviousPage)
       { %>
    <%: Html.RouteLink("<<<",
                   "Pageing",
new { page=(Model.PageIndex-1) }) %>
    <% } %>
    <% if (Model.HasNextPage)
       { %>
    <%: Html.RouteLink(">>>", "Pageing",
new { page = (Model.PageIndex + 1) })%>
    <% } %>--%>
    <% using (Html.BeginForm("DodajKom/"+id_posta,"Administracja"))
       {%>    
                <input type="submit" value="Dodaj komentarz" />
                <%} %>
</fieldset>

