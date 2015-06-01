<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarContato.aspx.cs" Inherits="AgendaContato.AdicionarContato" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nome:
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        Telefone:
        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
        <br />
        Data de nascimento:
        <asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>
        <br />
        Skype:
        <asp:TextBox ID="txtSkype" runat="server"></asp:TextBox>
        <br />
        Email:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" 
            onclick="btnCadastrar_Click" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Excluir" 
            Width="84px" />
    </div>
    </form>
</body>
</html>
