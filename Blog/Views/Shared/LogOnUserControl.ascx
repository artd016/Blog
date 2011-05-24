<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome <b><%: Page.User.Identity.Name %></b>!
        [ <%: Html.ActionLink("Log Off", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Log On", "LogOn", "Account") %> ]
<%
    }
%>
<br />
<% using (Html.BeginForm(new { action = "Szukaj" }))
       { %>
    <input type="text" id="name-list" name="zapytanie"/>
    <input type="submit" value="Szukaj" />
    <% } %>

    <script type="text/javascript" language="javascript">

        $(function () {

            $("#name-list").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "/Home/FindItems", type: "POST", dataType: "json",
                        data: { searchText: request.term, maxResults: 10},
                        success: function (data) {
                            response($.map(data, function (item) {
                                return { label: item, value: item }
                            }))
                        }
                    })
                }
            });
        });
    </script>
