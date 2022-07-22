<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="MedidoresDB.IngresarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
            <div class="card-body">
                <div class="form-group">
                    <label for="codigoMedidor">Código Medidor</label>
                    <asp:TextBox MaxLength="4" ID="codigoMedidor" CssClass="form-control mt-2 mb-2" runat="server"></asp:TextBox>
                    <label for="tipoMedidorDropdown">Tipo de Medidor</label>
                    <asp:DropDownList runat="server" ID="tipoMedidorDropdown" CssClass="form-control mt-2 mb-2">
                        <asp:ListItem Value="Inteligente" Text="Inteligente"></asp:ListItem>
                        <asp:ListItem Value="Estado Solido" Text="Estado Sólido"></asp:ListItem>
                        <asp:ListItem Value="Vatios-Hora" Text="Vatios-Hora"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <asp:Button runat="server" ID="agregarButton" OnClick="agregarButton_Click" Text="Agregar" CssClass="btn btn-primary mt-2 mb-2" />
                </div>
                <div class="mensaje">
                    <asp:Label ID="mensajesLabel" runat="server" CssClass=""></asp:Label>
                </div>
            </div>
            </div>
        </div>
    </div>
</asp:Content>
