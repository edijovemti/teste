<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AtualizarContato.aspx.cs" Inherits="AgendaContato.AtualizarContato" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
        <br />
        Código:<asp:TextBox ID="txtidcontato" runat="server"></asp:TextBox>
        <br />
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
        <asp:Button ID="btnAtualizar" runat="server" onclick="btnAtualizar_Click" 
            Text="Atualizar" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BuscarContato" runat="server" onclick="Button1_Click" 
            Text="Buscar" />
    </div>
    
    </div>
    </form>
</body>
</html>
