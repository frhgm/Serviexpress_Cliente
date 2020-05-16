<%@ Page Title="Inicio de sesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="Front.InicioSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">INICIAR SESION</h1>
    </section>
    <section class="content">
        <asp:Label runat="server" ID="mensajeLogin" BackColor="#fefefe"></asp:Label>
        <div class="row">
            <div class="col-md-offset-4 col-md-4 col-md-offset-4">
                <div class="box box-body">
                    <div class="box-body" id="columnaLogin">
                            <div class="form-box" id="login-box">
                                <asp:Login ID="LoginUser" runat="server" EnableViewState="false" OnAuthenticate="LoginUser_Authenticate" Width="100%">
                                    <LayoutTemplate>
                                        <div class="header">Login</div>
                                        <div class="body bg-gray">
                                            <div class="form-group">
                                                <asp:TextBox ID="UserName" runat="server" CssClass="form-control" placeholder="Ingrese usuario..."></asp:TextBox>
                                            </div>
                                            <div class="form-group">
                                                <asp:TextBox ID="Password" runat="server" CssClass="form-control" placeholder="Ingrese clave..." TextMode="Password"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="footer">
                                            <asp:Button ID="btnIngresar" CommandName="Login" runat="server" Text="Inicar Sesión" CssClass="btn bg-olive btn-block" />
                                        </div>
                                    </LayoutTemplate>
                                </asp:Login>
                            </div>
                    </div>
                </div>
            </div>
        </div>
        
    </section>
</asp:Content>
