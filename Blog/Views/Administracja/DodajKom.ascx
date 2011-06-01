<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Blog.Models.Komentarze>" %>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% Html.EnableClientValidation(); %>

<% using (Html.BeginForm()){ %>

    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Dodaj komentarz</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.tresc) %>
        </div>
        <div class="editor-field">
            <%: Html.TextAreaFor(model => model.tresc) %>
            <p><%: Html.ValidationMessageFor(model => model.tresc) %></p>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.autor) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.autor) %>
            <p><%: Html.ValidationMessageFor(model => model.autor) %></p>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.status) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("status", ViewData["list"] as SelectList)%>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>



