<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroSuplidor.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroSuplidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <asp:Label ID="RLabel" runat="server" Text="REGISTRO SUPLIDOR"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="IdSuplidorLabel" runat="server" Text="IdSuplidor" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="IdSuplidorTextBox" runat="server" Width="39px" Visible="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="NombresLabel" runat="server" Text="Nombres"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="NombresTextBox" runat="server" MaxLength="20"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" Width="96px" />
            </td>
            <td>
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
