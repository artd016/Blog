<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Blog.Models.Post>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Witaj
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Witaj w panelu administracyjnym blogu</h2>

    <p>Panel administracyjny udostępnia następujące operacje</p>
    
                <%: Html.ActionLink("Wyświetl posty", "WyswietlPosty") %> 
                
            

</asp:Content>

