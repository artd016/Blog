<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Blog.Models.PostTag>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Dodaj post
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Dodaj post</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            

            <div class="editor-label">
                <%: Html.LabelFor(model => model.post.tytul)%>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.post.tytul)%>
                <%: Html.ValidationMessageFor(model => model.post.tytul)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.post.tresc)%>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.post.tresc) %>
                <%: Html.ValidationMessageFor(model => model.post.tresc)%>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.tag.keywords)%>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.tag.keywords)%>
                <%: Html.ValidationMessageFor(model => model.tag.keywords)%>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.tag.description)%>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.tag.description)%>
                <%: Html.ValidationMessageFor(model => model.tag.description)%>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.post.status)%>
            </div>
            <div class="editor-field">
    
               
            </div>
            
            <p>
                <input type="submit" value="Dodaj post" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Wróć", "Index") %>
    </div>

</asp:Content>

