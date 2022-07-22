<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarUsuario.aspx.cs" Inherits="MedidoresDB.MostrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Mostrar y Eliminar Usuarios</h3>
                </div>
                <div class="card-body">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="form-group">
                                <asp:GridView runat="server" CssClass="table table-hover table-bordered" AutoGenerateColumns="false" ID="grillaUsuarios" OnRowCommand="grillaUsuarios_RowCommand">
                                    <Columns>
                                        <asp:BoundField DataField="Rut" HeaderText="Rut" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Nombre Usuario" />
                                        <asp:BoundField DataField="Email" HeaderText="Correo Electrónico" />
                                        <asp:BoundField DataField="Contrasena" HeaderText="Contraseña (Sin encriptar para comprobar el funcionamiento del campo)" />
                                        <asp:TemplateField HeaderText="Acciones">
                                            <ItemTemplate>
                                                <asp:Button CssClass="btn btn-danger" runat="server" CommandName="eliminar" Text="Eliminar" CommandArgument='<%# Eval("Id")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <div class="mensaje">
                                <asp:Label ID="mensajesLabel" runat="server" CssClass=""></asp:Label>
                            </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
</asp:Content>
