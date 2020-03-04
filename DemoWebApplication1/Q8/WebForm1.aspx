<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <table class="auto-style1">  
                <tr>  
                    <td>Detail_Name :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="Enter name"></asp:RequiredFieldValidator>
&nbsp;&nbsp;  
                    </td>  
                            
               </tr>  
                <tr>  
                    <td class="auto-style1">Detail_Password</td>  
                     <td class="auto-style1"> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="None" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
                    </td>  
                </tr>  
                <tr>  
                    <td>Detail_Confirm Password</td>  
                    <td>  
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>  
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Display="None" ErrorMessage="Enter same password as above"></asp:CompareValidator>
                    </td>  
                </tr>  
                <tr>  
                    <td>Detail_City</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList1" runat="server">  
                            <asp:ListItem Text="Select City" Value="select" Selected="True"></asp:ListItem>  
                            <asp:ListItem Text="Bangalore" Value="Bangalore"></asp:ListItem>  
                            <asp:ListItem Text="Mysore" Value="Mysore"></asp:ListItem>  
                            <asp:ListItem Text="Hubli" Value="hubli"></asp:ListItem>  
                        </asp:DropDownList>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Detail_Gender</td>  
                    <td>  
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">  
                            <asp:ListItem>Male</asp:ListItem>  
                            <asp:ListItem>Female</asp:ListItem>  
                        </asp:RadioButtonList>  
                    </td>  
               </tr>  
                 
                    
                 
                <tr>  
                    <td>  
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />  
                    </td>  
                </tr>  
            </table>  
              <br />
              <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
              <br />
        </div>  
    </form>  
</body>  
</html>   