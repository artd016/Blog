<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Blog.Models.Post>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Blog</h1>



    <% foreach (var item in Model) { %>
    
    <%if(item.status==1){ %>
    <fieldset>

            <h1>
                <%:  Html.ActionLink(item.tytul, "Delete", new { id = item.id })%>
            </h1>
            <p>
                <%: item.tresc %>
            </p>
            <button><%: Html.ActionLink("Więcej...", "Delete", new { id=item.id })%>
            </button>
            <h5>
                <%: String.Format("{0:g}", item.data_dodania) %>
                <%: String.Format("{0:g}", item.data_modyfikacji) %>
            </h5>

        </fieldset>
    <% } %>
    <% } %>



</asp:Content>

