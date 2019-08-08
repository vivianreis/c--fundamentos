<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormsAula1.WebForm1" %>

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
                    <td>Nome
                    </td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Sobrenome
                    </td>
                    <td>
                        <asp:TextBox ID="txtSobrenome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">

                        <asp:Label ID="lblNomeCompleto" runat="server" Text=""></asp:Label>

                    </td>
                </tr>


            </table>
        </div>
    </form>
</body>
</html>
