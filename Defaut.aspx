<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defaut.aspx.cs" Inherits="ProjetoPresentes.Defaut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 9px;
        }
        .auto-style2 {
            margin-left: 451px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" BackColor="White" BorderColor="White" Font-Italic="True" ForeColor="#0000CC" Text="Label"></asp:Label>
        </p>
        <p>
            Id:&nbsp;&nbsp; <asp:TextBox ID="IdText" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Nome:<asp:TextBox ID="NomeTxt" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Descrição:&nbsp;&nbsp; <asp:TextBox ID="DescricaoTxt" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Tipo:&nbsp;
            <asp:TextBox ID="TipoTxt" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Marca:&nbsp;
            <asp:TextBox ID="MarcaTxt" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Finalidade:&nbsp;
            <asp:TextBox ID="FinalidadeTxt" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Cor:
            <asp:TextBox ID="CorTxt" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Tamanho:
            <asp:TextBox ID="TamanhoTxt" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Preço:
            <asp:TextBox ID="PrecoTxt" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            Nome Fornecedor:
            <asp:TextBox ID="NomeFornecedor" runat="server" CssClass="auto-style1" Width="368px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnSalvar" runat="server" CssClass="auto-style2" OnClick="BtnSalvar_Click" Text="Salvar" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
