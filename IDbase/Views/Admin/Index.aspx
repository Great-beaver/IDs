<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<IDbase.Models.IDtable>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <%: Html.ActionLink("Log Off", "LogOff", "Account") %>
    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Номер
            </th>
            <th>
                Имя
            </th>
            <th>
                Фамилия
            </th>
            <th>
                Дата рождения
            </th>
            <th>
                Дата выдачи
            </th>
            <th>
                Действителен до
            </th>
            <th>
                Место рождения
            </th>
            <th>
                Пол
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.IDnumber }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.IDnumber })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.IDnumber })%>
            </td>
            <td>
                <%: item.IDnumber %>
            </td>
            <td>
                <%: item.FirstName %>
            </td>
            <td>
                <%: item.LastName %>
            </td>
              <td>
                     <%: String.Format("{0:MM/dd/yyyy}", item.DateOfBirth)%>  
            </td>
            <td>
                <%: String.Format("{0:MM/dd/yyyy}", item.Since)%>
            </td>
            <td>
                <%: String.Format("{0:MM/dd/yyyy}", item.Expire)%>
            </td>
            <td>
                <%: item.PlaceOfBirth %>
            </td>
            <td>
                <% if (item.Sex == true)
                    {  %>
                 <%: "Мужской"%>
                 <%}
                    else   %>
                 <%: "Женский"%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

