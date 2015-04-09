<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="ConsultaTrabajoRecepciones.aspx.cs" Inherits="ProyectoFinalAII.Consultas.ConsultaTrabajoRecepciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td>&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="BuscarDropDownList" runat="server" Width="114px">
            <asp:ListItem>IdTrabajoRecepciones</asp:ListItem>
            <asp:ListItem>IdTecnico</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="BuscarText" runat="server" Width="225px"></asp:TextBox>
                &nbsp;
                <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click1" Text="Buscar" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="ConsultaGridView" runat="server">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="IdTrabajoRecepciones" DataNavigateUrlFormatString="/Registros/RegistroTrabajoRecepciones.aspx?IdTrabajoRecepciones={0}" Text="Editar" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
