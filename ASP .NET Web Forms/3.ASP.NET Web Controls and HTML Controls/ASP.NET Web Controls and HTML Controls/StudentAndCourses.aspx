<%@ Page Title="Students and courses" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentAndCourses.aspx.cs" Inherits="ASP.NET_Web_Controls_and_HTML_Controls.StudentAndCourses" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div>
            <p>
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="FacultyNumberLabel" runat="server" Text="Faculty number"></asp:Label>
                <asp:TextBox ID="FacultyNumberTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="UniversityLabel" runat="server" Text="University"></asp:Label>
                <asp:DropDownList ID="universityDropDownList" runat="server">
                    <asp:ListItem Selected="True" Value="Telerik Academy"> Telerik Academy </asp:ListItem>
                    <asp:ListItem Value="TU-Sofia"> TU-Sofia </asp:ListItem>
                    <asp:ListItem Value="UNWE"> UNWE </asp:ListItem>
                    <asp:ListItem Value="Sofia university"> Sofia university </asp:ListItem>
                    <asp:ListItem Value="NBU"> NBU </asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="SpecialtyLabel" runat="server" Text="Specialty"></asp:Label>
                <asp:DropDownList ID="SpecialtyDropDownList" runat="server">
                    <asp:ListItem Selected="True" Value="Programming"> Programming </asp:ListItem>
                    <asp:ListItem Value="FrontEnd"> Front End </asp:ListItem>
                    <asp:ListItem Value="QA"> Quality assurance </asp:ListItem>
                    <asp:ListItem Value="CS"> Computer science </asp:ListItem>
                    <asp:ListItem Value="Medicine"> Medicine </asp:ListItem>
                    <asp:ListItem Value="Law"> Law </asp:ListItem>
                    <asp:ListItem Value="History"> History </asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="ListOfCoursesLabel" runat="server" Text="List of courses"></asp:Label>
                <asp:CheckBoxList ID="ListOfCoursesListBox" runat="server">
                    <asp:ListItem Value="ASP">ASP</asp:ListItem>
                    <asp:ListItem Value="More ASP">More ASP</asp:ListItem>
                    <asp:ListItem Value="A Lot OF ASP">A Lot OF ASP</asp:ListItem>
                </asp:CheckBoxList>
            </p>
            <asp:Button ID="Register" runat="server" Text="Register!" OnClick="Register_Click" />
        </div>
        <div id="AllStudents" runat="server">
            <p>
                <asp:Label ID="Label1" runat="server" Text="First name: "></asp:Label>
                <asp:Label ID="FirstNameAfterRegister" runat="server" Text="No info yet!"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Last name: "></asp:Label>
                <asp:Label ID="LastNameAfterRegister" runat="server" Text="No info yet!"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text="Faculty number: "></asp:Label>
                <asp:Label ID="FacultyAfterRegister" runat="server" Text="No info yet!"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label7" runat="server" Text="University "></asp:Label>
                <asp:Label ID="UniversityAfterRegister" runat="server" Text="No info yet!"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label9" runat="server" Text="Specialty: "></asp:Label>
                <asp:Label ID="SpecialtyAfterRegister" runat="server" Text="No info yet!"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label11" runat="server" Text="Courses: "></asp:Label>
                <asp:Label ID="CoursesAfterRegister" runat="server" Text="No info yet!"></asp:Label>
            </p>
        </div>
    </div>
</asp:Content>
