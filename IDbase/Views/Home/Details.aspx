<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<IDbase.Models.IDtable>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Номер <%: Model.IDnumber %>  </div> 
        <div class="display-field"><%: Model.IDnumber %></div>
        
        <div class="display-label">FirstName</div>
        <div class="display-field"><%: Model.FirstName %></div>
        
        <div class="display-label">LastName</div>
        <div class="display-field"><%: Model.LastName %></div>
        
        <div class="display-label">DateOfBirth</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.DateOfBirth) %></div>
        
        <div class="display-label">Since</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.Since) %></div>
        
        <div class="display-label">Expire</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.Expire) %></div>
        
        <div class="display-label">PlaceOfBirth</div>
        <div class="display-field"><%: Model.PlaceOfBirth %></div>
        
        <div class="display-label">Sex</div>
        <div class="display-field"><%: Model.Sex %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.IDnumber }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

