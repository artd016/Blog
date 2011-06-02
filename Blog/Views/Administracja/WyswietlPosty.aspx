<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Wyświetl posty
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <!--<script type="text/javascript">
     $(function () {
         $("#accordion").accordion({
             autoHeight: false
         });
     });
	</script>  -->
    
    <p id="a_link_dodaj_posta">
        <%: Html.ActionLink("Dodaj post", "DodajPost") %>
    </p>
    <%:ViewData["komunikat"] %>
    <div id="accordion">
    <% foreach (var item in Model)
       { %>
       
    <fieldset id="a_post_na_glownej">
        <h1>
        <!--<script type="text/javascript">

            $(document).ready(
function () {
    $("#more<%:item.id%>").hide();
    $("#link<%:item.id%>").click(
function () {
    $("#more<%:item.id%>").toggle();
});
});
</script>-->
        <%int y=item.data_dodania.Year; %>
        <%string m=Convert.ToString(item.data_dodania.Month); %>
        <%string d = Convert.ToString(item.data_dodania.Day); %>
        <%if (m.Length == 1) m="0"+m; %>
        <%if (d.Length == 1) d="0"+d; %>
            <%: Html.ActionLink(item.tytul as string, "Post" + "/" + y + "/" + m + "/" + d, new { id = item.tytul.Replace(' ', '_')})%>           
            </h1>
            <p><a href="#" id="link<%:item.id%>">kliknij</a></p>

        <p id="more<%:item.id%>">
            <%if ((item.tresc as string).Length > 99)
              { %>
            <%: (item.tresc as string).Remove(98)%>
            ...<br />
            <%:Html.ActionLink("Więcej", "Post" + "/" + y + "/" + m + "/" + d, new { id = item.tytul.Replace(' ', '_') }, new { id = item.id })%>
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
        <%: Html.ActionLink("Edytuj post", "Edit", new { id=item.id }) %> |
        <%: Html.ActionLink("Usuń post", "Delete", new { id=item.id }) %>
    </fieldset>
   
    <% } %>
     </div>
    <% if (Model.HasPreviousPage)
       { %>
    <%: Html.RouteLink("<<<",
                   "Pageing",
new { page=(Model.PageIndex-1) }) %>
    <% } %>
    <% if (Model.HasNextPage)
       { %>
    <%: Html.RouteLink(">>>", "Pageing",
new { page = (Model.PageIndex + 1) })%>
    <% } %>

    <!--<script>
        // increase the default animation speed to exaggerate the effect
        $.fx.speeds._default = 1000;
        $(function () {
            $("#dialog").dialog({
                autoOpen: false,
                show: "blind",
                hide: "explode"
            });

            $("#opener").click(function () {
                $("#dialog").dialog("open");
                return false;
            });
        });
	</script>



<div class="demo">

<div id="dialog" title="Basic dialog">
	<p>This is an animated dialog which is useful for displaying information. The dialog window can be moved, resized and closed with the 'x' icon.</p>
</div>

<button id="opener">Open Dialog</button>

</div><!-- End demo -->



<!--<div class="demo-description">
<p>Dialogs may be animated by specifying an effect for the show and/or hide properties.  You must include the individual effects file for any effects you would like to use.</p>
</div><!-- End demo-description -->
</asp:Content>
