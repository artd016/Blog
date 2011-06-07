<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
<script src="<%: Url.Content("~/Scripts/popup.js") %>" type="text/javascript"></script>
<fieldset id="komenty">
    <legend>Komentarze</legend>
    <br />
    <%:ViewData["komunikat"]%>

    <% foreach (var item in Model)
       { %>
    <fieldset id="komentarz">
        <table id="tabela_komentarza">
            <tr>
                <td>

                        <%:item.tresc%>
                    
                </td>
                
            </tr>
        </table>
        Data dodania:
        <%:String.Format("{0:yyyy-MM-dd hh:mm:ss}", item.data_dodania)%> | 
        Autor:
        <%:item.autor%> | 
        <% Html.RenderAction("DodajKom"); %>
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
</fieldset>
<div id="button">
    <input type="submit" value="Dodaj komentarz"/></div>
<div id="popupContact">
    <a id="popupContactClose">x</a>
    
</div>
<div id="backgroundPopup">
</div>
