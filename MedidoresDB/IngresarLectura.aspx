<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedidoresDB.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="codigoMedidorDropdown">Código Medidor</label>
                        <asp:DropDownList runat="server" ID="codigoMedidorDropdown" CssClass="form-control mt-2 mb-2"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="valorConsumo">Consumo Energético (kWh)</label>
                        <asp:TextBox runat="server" MaxLength="3" ID="valorConsumo" CssClass="form-control mt-2 mb-2"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarButton" OnClick="agregarButton_Click" Text="Agregar" CssClass="btn btn-primary mt-2 mb-2"/>
                    </div>
                    <div class="mensaje">
                        <asp:Label ID="mensajesLabel" runat="server" CssClass=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
