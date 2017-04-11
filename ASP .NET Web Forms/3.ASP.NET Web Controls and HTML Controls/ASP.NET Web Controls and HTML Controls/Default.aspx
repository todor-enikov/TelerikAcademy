<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_Web_Controls_and_HTML_Controls._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>ASP.NET Web Controls and HTML Controls Homework:</h2>
        <ul>
            <li><strong>1. Random</strong>
                Using the HTML server controls create a Web application for generating random numbers. It should have two input fields defining a range (e.g. [10..20]) and a button to generate a random number in the specified range.
                Re-implement the same using Web server controls.
            </li>
            <li><strong>2. Escaping</strong> Define a Web form with text box and button. On button click show the entered in the first textbox text in other textbox control and label control. Enter some potentially dangerous text. Fix issues related to HTML escaping – the application should accept HTML tags and display them correctly.</li>
            <li><strong>3. Students and Courses</strong> Make a simple Web form for registration of students and courses. The form should accept first name, last name, faculty number, university (drop-down list), specialty (drop-down list) and a list of courses (multi-select list) and display them on submit. Use the appropriate Web server controls. After submission you should display summary of the entered information as formatted HTML. Use dynamically generated tags.</li>
            <li><strong>4. Tic-tac-toe</strong> Implement the "Tic-tac-toe" game using Web server controls. The user should play against the computer which follows some fixed strategy.</li>
            <li><strong>5. Web Calculator</strong> Make a simple Web Calculator. The calculator should support the operations like addition, subtraction, multiplication, division and square root. Validation is essential!</li>
        </ul>
    </div>
</asp:Content>
