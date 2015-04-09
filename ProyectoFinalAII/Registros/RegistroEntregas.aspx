<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroEntregas.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroEntregas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 248px;
        }
        .auto-style2 {
            width: 247px;
        }
        .auto-style3 {
    }
    .auto-style4 {
        width: 259px;
    }
    .auto-style5 {
        width: 126px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRO ENTREGAS&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="IdLabel" runat="server" Text="IdEntrega"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="IdEntregaTextBox" runat="server" BackColor="White" Width="56px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Fechalabel" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="FechaTextBox" runat="server" BackColor="White" Width="123px" TextMode="Date"></asp:TextBox>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="IdRecepcionLabel" runat="server" Text="IdRecepcion"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="IdRecepcionDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            &nbsp;</td>
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
                <asp:Label ID="ObservacionesLabel" runat="server" Text="Observaciones"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="ObservacionesTextBox" runat="server" BackColor="White" Width="363px" MaxLength="50"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Montolabel" runat="server" Text="Monto"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="MontoTextBox" runat="server" BackColor="White" Width="63px"></asp:TextBox>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Descuentolabel" runat="server" Text="Descuento"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="DescuentoTextBox" runat="server" BackColor="White" Width="61px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;<asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" Width="77px" />
&nbsp;<asp:Button ID="GuardarButton" runat="server" ForeColor="Black" OnClick="SaveButton_Click" Text="Guardar" Width="88px" />
                &nbsp;
                <asp:Button ID="EliminarButton" runat="server" ForeColor="Black" OnClick="DeleteButton_Click" Text="Eliminar" Width="97px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
