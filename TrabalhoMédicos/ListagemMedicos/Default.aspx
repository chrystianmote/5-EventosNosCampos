<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ListagemMedicos.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CSU - Cadastro de Saúde Unificado</title>
    <style type="text/css">
    body
    {
        font-family: Calibri;
        color: #0F6688;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <center> <div id="divBusca" runat="server" style="padding-top:150px">
       <img src="imagens/stethoscope-icon.png" /><h2>
       CSU - Cadastro de Saúde Unificado
       </h2>
       <br />
        <asp:TextBox runat="server" ID="txtBusca" Width="400px" BackColor="#0F6688" 
           Font-Bold="True" ForeColor="White" /><asp:Button Text="Buscar Médico" 
            ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
           BackColor="#0F6688" Font-Bold="True" ForeColor="White" />
        
    </div>

       <br />
       <br />
    <div id="divResultado" runat="server">
        <h3>
        Resultados da busca por <span id="spnBusca" runat="server"></span>
        </h3>
        <asp:GridView ID="gvMedicos" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" Width="500px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <EmptyDataTemplate>
                Nenhum dado encontrado.
            </EmptyDataTemplate>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#0f6688" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:Button Text="Voltar" 
            ID="Button1" runat="server" PostBackUrl="~/Default.aspx"
           BackColor="#0F6688" Font-Bold="True" ForeColor="White" />
    </div></center>
    </form>
</body>
</html>
