<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarUsuario.aspx.cs" Inherits="MedidoresDB.IngresarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Usuario</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutUsuario">RUT</label>
                        <asp:TextBox runat="server" MaxLength="11" ID="rutUsuario" CssClass="form-control mt-2 mb-2"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="nombreUsuario">Nombre</label>
                        <asp:TextBox runat="server" MaxLength="100" ID="nombreUsuario" CssClass="form-control mt-2 mb-2"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="emailUsuario">Correo Electrónico</label>
                        <asp:TextBox runat="server" MaxLength="100" ID="emailUsuario" CssClass="form-control mt-2 mb-2"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="passwordUsuario">Contraseña</label>
                        <asp:TextBox runat="server" MaxLength="12" TextMode="Password" ID="passwordUsuario" CssClass="form-control mt-2 mb-2"></asp:TextBox>
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
