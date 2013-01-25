<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IDbase.Models.IDtable>" %>


            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IDnumber) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IDnumber) %>
                <%: Html.ValidationMessageFor(model => model.IDnumber) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FirstName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FirstName) %>
                <%: Html.ValidationMessageFor(model => model.FirstName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.LastName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LastName) %>
                <%: Html.ValidationMessageFor(model => model.LastName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.DateOfBirth) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.DateOfBirth, String.Format("{0:MM/dd/yyyy}", Model.DateOfBirth))%>
                <%: Html.ValidationMessageFor(model => model.DateOfBirth) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Since) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Since, String.Format("{0:MM/dd/yyyy}", Model.Since))%>
                <%: Html.ValidationMessageFor(model => model.Since) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Expire) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Expire, String.Format("{0:MM/dd/yyyy}", Model.Expire))%>
                <%: Html.ValidationMessageFor(model => model.Expire) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.PlaceOfBirth) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.PlaceOfBirth) %>
                <%: Html.ValidationMessageFor(model => model.PlaceOfBirth) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Sex) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Sex) %>
                <%: Html.ValidationMessageFor(model => model.Sex) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>

