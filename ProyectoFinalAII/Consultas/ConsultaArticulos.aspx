<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="ConsultaArticulos.aspx.cs" Inherits="ProyectoFinalAII.Consultas.ConsultaArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                &nbsp;<asp:DropDownList ID="BuscarDropDownList" runat="server" Width="131px">
                    <asp:ListItem>IdArticulo</asp:ListItem>
                    <asp:ListItem>Descripcion</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="BuscarText" runat="server" Width="225px"></asp:TextBox>
                &nbsp;
                <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click1" Text="Buscar" Height="30px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="ConsultaGridView" runat="server" CellPadding="4" Width="622px" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="IdArticulo" DataNavigateUrlFormatString="/Registros/RegistroArticulos.aspx?IdArticulo={0}" Text="Editar" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
