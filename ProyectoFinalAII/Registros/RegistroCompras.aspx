<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroCompras.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
        }
        .auto-style4 {
            width: 248px;
        }
        .auto-style5 {
            height: 28px;
        }
        .auto-style6 {
            height: 28px;
            width: 248px;
        }
    .auto-style7 {
        }
        .auto-style8 {
            width: 112px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="IdLabel" runat="server" Text="IdCompra"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="IdCompraTextBox" runat="server" Height="16px" Width="34px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:Label ID="IdArticuloLabel" runat="server" Text="IdArticulo"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:DropDownList ID="ArticuloDropDownList" runat="server" Width="179px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="FechaLabel" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="FechaTextBox" runat="server" Height="16px" TextMode="Date" Width="146px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:Label ID="CantidadLabel" runat="server" Text="Cantidad"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="CantidadTextBox" runat="server" Height="16px" Width="50px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="AgregarButton" runat="server" OnClick="AgregarButton_Click" Text="Agregar" Width="87px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="IdUsuarioLabel" runat="server" Text="IdUsuario"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="UsuarioDropDownList" runat="server" Width="96px">
                </asp:DropDownList>
            </td>
            <td class="auto-style8">
                <asp:Label ID="CostoLabel" runat="server" Text="Costo"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="CostoTextBox" runat="server" Height="16px" Width="46px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CostoTextBox" ErrorMessage="*" ForeColor="Red">Ingrese el costo.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="IdSuplidorLabel" runat="server" Text="IdSuplidor"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="SuplidorDropDownList" runat="server" Width="96px">
                </asp:DropDownList>
            </td>
            <td class="auto-style8">
                <asp:Label ID="MontoLabel" runat="server" Text="Monto"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="MontoTextBox" runat="server" Height="16px" Width="70px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="4">
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Height="137px" Width="614px" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField HeaderText="IdArticulo" DataField="IdArticulo" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" />
                        <asp:BoundField HeaderText="Costo" DataField="Costo" />
                        <asp:BoundField DataField="Total" HeaderText="Total" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
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
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Button ID="GenerarButton" runat="server" Text="Generar Compra" Width="126px" OnClick="GenerarButton_Click" />
            &nbsp;&nbsp;
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" Width="101px" OnClick="GuardarButton_Click" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" Width="114px" OnClick="EliminarButton_Click" />
            </td>
            <td class="auto-style6">
                <asp:Label ID="TotalLabel" runat="server" Text="Total"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:TextBox ID="TotalTextBox" runat="server" Height="16px" Width="49px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="4">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
        </tr>
    </table>
</asp:Content>
