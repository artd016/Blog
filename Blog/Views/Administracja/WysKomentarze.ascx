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
                <td>
                    <a href="/Administracja/UsunKom/<%:item.id%>" onclick="Sys.Mvc.AsyncHyperlink.handleClick(this, new Sys.UI.DomEvent(event), { insertionMode: Sys.Mvc.InsertionMode.replace, confirm: &#39;Czy na pewno chcesz usunąć komentarz?&#39;, httpMethod: &#39;POST&#39;, updateTargetId: &#39;divContactList&#39; });">
                        Usuń komentarz</a>
                    <br />
                    <!--<%:Ajax.ActionLink("Usuń komentarz","UsunKom", new { id = item.id }, new AjaxOptions { Confirm = "Czy na pewno chcesz usunąć komentarz?", HttpMethod = "POST", UpdateTargetId = "divContactList" })%>-->
                </td>
            </tr>
        </table>
        Data dodania:
        <%:String.Format("{0:yyyy-MM-dd hh:mm:ss}", item.data_dodania)%> | 
        Autor:
        <%:item.autor%> | 
        Status:
        <%if (item.status == 0)
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
</fieldset>
<div id="button">
    <input type="submit" value="Dodaj komentarz"/></div>
<div id="popupContact">
    <a id="popupContactClose">x</a>
    <% Html.RenderAction("DodajKom"); %>
</div>
<div id="backgroundPopup">
</div>
