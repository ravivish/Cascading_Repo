<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cascading DropDown.aspx.cs" Inherits="Test16_1_19.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>First Name:</td>
                <td>
                    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Country:</td>
                <td>
                    <asp:DropDownList ID="ddlcountry" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Department</td>
                <td>
                    <asp:DropDownList ID="ddldepart" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
                </td>
            </tr>

            <tr>
                <td style="text-decoration: underline">
                    <asp:GridView ID="grd" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Fname">
                                <ItemTemplate>
                                    <%#Eval("fname") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Lname ">
                                <ItemTemplate>
                                    <%#Eval("lname") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Country">
                                <ItemTemplate>
                                    <%#Eval("cname") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Department">
                                <ItemTemplate>
                                    <%#Eval("dname") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>

        </table>
    
    </div>
    </form>
</body>
</html>
