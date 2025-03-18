<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Login_web_app._Default" %>


<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:300px; margin:0 auto; padding-top:100px;">
            <h2>Login</h2>
            <div>
                <asp:Label ID="lblUsername" type="text" runat="server" Text="Username:"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="enter username" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CausesValidation="True" ValidateRequestMode="Enabled"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="enter password" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div style="margin-top:10px;">
                
                
                <asp:Button ID="Button1" type="submit" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    <button type="reset">Reset</button>

            </div>
        </div>
    </form>
</body>
</html>
