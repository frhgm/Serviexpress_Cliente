<%@ Page Title="Inicio de sesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="CapaPresentacion.InicioSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h2 style="text-align: center">INICIAR SESION</h2>
    </section>
    <section class="content">
        <asp:Label runat="server" ID="mensajeLogin" BackColor="#fefefe"></asp:Label>
        <div class="row">
            <div class="offset-md-4 col-md-4 offset-md-4 caja" id="columnaLogin">
                <asp:Login ID="LoginUser" runat="server" EnableViewState="false" OnAuthenticate="LoginUser_Authenticate" Width="100%">
                    <LayoutTemplate>
                        <form action="#">
                            <div class="form-group">
                                <label for="Username">USUARIO</label>
                                <asp:TextBox ID="UserName" runat="server" CssClass="form-control" placeholder="Ingrese usuario..."></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="Password">CONTRASEÑA</label>
                                <asp:TextBox ID="Password" runat="server" CssClass="form-control" placeholder="Ingrese clave..." TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="text-center">
                                <asp:Button ID="btnIngresar" CommandName="Login" runat="server" Text="Inicar Sesión" CssClass="btn btn-primary btn-lg"/>
                            </div>
                        </form>
                    </LayoutTemplate>
                </asp:Login>
            </div>
        </div>
    </section>
</asp:Content>