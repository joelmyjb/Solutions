<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroDiagnosticos.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroDiagnosticos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
    }
        .auto-style2 {
            width: 172px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <asp:Label ID="RLabel" runat="server" Text="REGISTRO DIAGNOSTICOS"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="IdDiagnosticoLabel" runat="server" Text="IdDiagnostico"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="IdDiagnosticoTextBox" runat="server" Width="39px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="DescripcionLabel" runat="server" Text="Descripcion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="DescripcionTextBox" runat="server" MaxLength="30"></asp:TextBox>
            &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" Height="49px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" Width="93px" />
            </td>
            <td>
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
