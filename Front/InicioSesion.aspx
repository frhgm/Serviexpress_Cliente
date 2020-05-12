<%@ Page Title="Inicio de sesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="Front.InicioSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">INICIAR SESION</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-offset-4 col-md-4 col-md-offset-4">
                <div class="box box-body">
                    <div class="box-body" id="columnaLogin">
                        <form>
                            <div class="form-group">
                                <label for="txtUsuario">USUARIO</label>
                                <input type="text" id="txtUsuario" value="" class="form-control"/>
                            </div>
                            <div class="form-group">
                                <label for="txtPassword">CONTRASEÑA</label>
                                <input type="password" id="txtPassword" value="" class="form-control" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
        <div align="center">
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary btn-lg" OnClick="btnLogin_Click"/>
        </div>
    </section>
</asp:Content>
