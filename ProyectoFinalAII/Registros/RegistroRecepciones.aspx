<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroRecepciones.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroRecepciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRO RECEPCIONES&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="IdLabel" runat="server" Text="IdRecepcion" Visible="False"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="IdRecepcionTextBox" runat="server" BackColor="White" Width="56px" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Fechalabel" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="FechaTextBox" runat="server" BackColor="White" Width="152px" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="IdClienteLabel" runat="server" Text="IdCliente"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="IdClienteDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="IdEquipoLabel" runat="server" Text="IdEquipo"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="IdEquipoDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="IdDiagnosticoLabel" runat="server" Text="IdDiagnostico"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="IdDiagnosticoDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="IdEstadoLabel" runat="server" Text="IdEquipo"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="IdEstadoDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="IdUsuarioLabel" runat="server" Text="IdUsuario"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="IdUsuarioDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="SerialLabel" runat="server" Text="Serial"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="SerialTextBox" runat="server" BackColor="White" Width="139px" MaxLength="20"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="ObservacionesLabel" runat="server" Text="Observaciones"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="ObservacionesTextBox" runat="server" BackColor="White" Width="363px" MaxLength="50"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" Width="76px" />
                &nbsp;
                <asp:Button ID="GuardarButton" runat="server" ForeColor="Black" OnClick="SaveButton_Click" Text="Guardar" Width="88px" />
                &nbsp;
                <asp:Button ID="EliminarButton" runat="server" ForeColor="Black" OnClick="DeleteButton_Click" Text="Eliminar" Width="97px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
