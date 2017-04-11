<%@ Page Language="C#" Title="Validation control" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidationControl.aspx.cs" Inherits="ValidationControls.ValidationControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well">
        <div>
            <asp:Label ID="LabelUsername" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="Username" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server"
                ErrorMessage="Username is required!" ControlToValidate="Username"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="LabelPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="Password" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server"
                ErrorMessage="Password is required!" ControlToValidate="Password"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="LabelRepeatPassword" runat="server" Text="Repeat password: "></asp:Label>
            <asp:TextBox ID="RepeatPassword" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorRepeatPassword" runat="server"
                ErrorMessage="RepeatPassword is required!" ControlToValidate="RepeatPassword"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <asp:CompareValidator ID="CompareValidatorForPassword" runat="server"
            ErrorMessage="The passwords must be identical!"
            ControlToCompare="Password" ControlToValidate="RepeatPassword"
            Display="Dynamic" Text="The passwords must be identical!"></asp:CompareValidator>
        <div>
            <asp:Label ID="LabelFirstName" runat="server" Text="Firstname: "></asp:Label>
            <asp:TextBox ID="FirstName" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server"
                ErrorMessage="FirstName is required!" ControlToValidate="FirstName"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="LabelLastName" runat="server" Text="Lastname: "></asp:Label>
            <asp:TextBox ID="LastName" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server"
                ErrorMessage="LastName is required!" ControlToValidate="LastName"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="LabelAge" runat="server" Text="Age: "></asp:Label>
            <asp:TextBox ID="Age" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge" runat="server"
                ErrorMessage="Age is required!" ControlToValidate="Age"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidatorAge" runat="server"
                ErrorMessage="Age must be between 18 and 81 years!"
                ControlToValidate="Age" MinimumValue="18" MaximumValue="81"></asp:RangeValidator>
        </div>
        <div>
            <asp:Label ID="Label7Email" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="Email" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"
                ErrorMessage="Email is required!" ControlToValidate="Email"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ErrorMessage="The email is invalid!" ControlToValidate="Email"
                ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:Label ID="LabelAddress" runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="Address" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server"
                ErrorMessage="Address is required!" ControlToValidate="Address"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="LabelPhone" runat="server" Text="Phone number: "></asp:Label>
            <asp:TextBox ID="Phone" runat="server" ValidationGroup="AllFields"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server"
                ErrorMessage="Phone is required!" ControlToValidate="Phone"
                Text="Required field" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server"
                ErrorMessage="The phone is invalid!" ControlToValidate="Phone"
                ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$"></asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:RadioButton ID="Accept" runat="server" Text="I Accept!" />
            <asp:RadioButtonList ID="GenderList" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <asp:Button ID="Register" runat="server" Text="Register!" OnClick="Register_Click" />
        <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="DarkRed" />
    </div>
    <asp:Label ID="Result" runat="server" Text=""></asp:Label>
    <asp:CheckBoxList ID="CheckBoxListCars" runat="server" Visible="false" RepeatDirection="Horizontal">
        <asp:ListItem Text="BMW"></asp:ListItem>
        <asp:ListItem Text="Toyota"></asp:ListItem>
        <asp:ListItem Text="LADA"></asp:ListItem>
        <asp:ListItem Text="Pejak"></asp:ListItem>
        <asp:ListItem Text="Myrtvak"></asp:ListItem>
    </asp:CheckBoxList>
    <asp:CheckBoxList ID="CheckBoxListCoffees" runat="server" Visible="false" RepeatDirection="Horizontal">
        <asp:ListItem Text="Lavazza"></asp:ListItem>
        <asp:ListItem Text="New Brasil"></asp:ListItem>
        <asp:ListItem Text="Esspresso"></asp:ListItem>
        <asp:ListItem Text="Dylgo"></asp:ListItem>
        <asp:ListItem Text="Kyso"></asp:ListItem>
    </asp:CheckBoxList>
</asp:Content>
