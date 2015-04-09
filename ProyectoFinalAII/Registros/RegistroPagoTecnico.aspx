<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroPagoTecnico.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroPagoTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        width: 444px;
    }
        .auto-style2 {
            width: 246px;
        }
        .auto-style3 {
    }
    .auto-style4 {
        width: 191px;
    }
    .auto-style5 {
        width: 127px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="2">&nbsp;REGISTRO PAGO TECNICO&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="IdLabel" runat="server" Text="IdPagoTecnico"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="IdPagoTecnicoTextBox" runat="server" BackColor="White" Width="56px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Fechalabel" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="FechaTextBox" runat="server" BackColor="White" Width="152px" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="IdTecnicoLabel" runat="server" Text="IdTecnico"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="IdTecnicoDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="IdUsuarioLabel" runat="server" Text="IdUsuario"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="IdUsuarioDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="FechaCortelabel" runat="server" Text="FechaCorte"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="FechaCorteTextBox" runat="server" BackColor="White" Width="162px" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Montolabel" runat="server" Text="Monto"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="MontoTextBox" runat="server" BackColor="White" Width="162px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" Width="86px" />
&nbsp;&nbsp;
                <asp:Button ID="GuardarButton" runat="server" ForeColor="Black" OnClick="SaveButton_Click" Text="Guardar" Width="88px" style="height: 26px" />
                &nbsp;
                <asp:Button ID="EliminarButton" runat="server" ForeColor="Black" OnClick="DeleteButton_Click" Text="Eliminar" Width="97px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
