<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Blog.Models.Komentarze>" %>

<script src="<%: Url.Content("~/Scripts/jquery-1.4.4.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Komentarze</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.tresc) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.tresc) %>
            <%: Html.ValidationMessageFor(model => model.tresc) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.autor) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.autor) %>
            <%: Html.ValidationMessageFor(model => model.autor) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.data_dodania) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.data_dodania) %>
            <%: Html.ValidationMessageFor(model => model.data_dodania) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.status) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.status) %>
            <%: Html.ValidationMessageFor(model => model.status) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

