<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

    <%: Model.tytul %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h1><%: Model.tytul %></h1>

<fieldset id="a_tresc_posta">

    <div class="display-field"><%: Model.tresc %></div>
    </fieldset>
    <fieldset id="a_tagi_data">
    <div class="display-label">Tagi:<% foreach (var item in ViewData["tagi"] as IEnumerable)
                                       { %><%: Html.ActionLink(item as string, "PostyOznaczoneTagiem", new { id = item })%>,<%} %> </div>
    <div class="display-label">Data dodania: <%: String.Format("{0:yyyy-MM-dd hh:mm}", Model.data_dodania) %></div>

    <%if (Model.data_modyfikacji != null)
      { %><div class="display-label">Data modyfikacji: <%: String.Format("{0:yyyy-MM-dd HH:mm:ss}", Model.data_modyfikacji)%></div><%} %>
    <div class="display-label">Status: <%if (Model.status == 0)
          { %>Opublikowany<%}
          else
          { %>Ukryty<%} %></div>
 
    
</fieldset>
<p>

    <%: Html.ActionLink("Edytuj", "Edit", new { id=Model.id }) %> |
    <%: Html.ActionLink("Wróć do listy postów", "WyswietlPosty") %>
</p>
<div id="divContactList">
<% Html.RenderAction("WysKomentarze", "Administracja", new { id = Model.id }); %>
</div>

</asp:Content>