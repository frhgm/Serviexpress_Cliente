<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Front.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section class="content-header">
        <h1 style="text-align: center">CREAR CUENTA NUEVA</h1>
    </section>
    <!--REFORMAT CTRL+E,C-->

    <section class="content">

        <div class="row">
            <!--FILA 1-->
            <div class="col-md-12 caja">
                <!--COLUMNA 1-->
                <div class="form-group">
                    <label for="txtUsuario">INGRESE USUARIO</label>
                    <asp:TextBox ID="txtUsuario" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtCorreo">INGRESE CORREO</label>
                    <asp:TextBox ID="txtCorreo" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtPassword">INGRESE password</label>
                    <asp:TextBox ID="txtPassword" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtFecha">FECHA CREACION</label>
                    <asp:TextBox ID="txtFecha" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtActivo">ACTIVO</label>
                    <asp:TextBox ID="txtActivo" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtRol">RoL</label>
                    <asp:TextBox ID="txtRol" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>


            </div>


        </div>
        <br/>
        <div class="text-center">
            <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Registrar" OnClick="btnRegistrar_Click"/>
        </div>

        <div class="row">
            <div class="col-md-12">
                <h3 class="box-title">Lista de Usuarios</h3>
            </div>
            <div class="table-responsive">
                <table id="tbl_usuarios" class="table table-bordered table-hover text-center">
                    <thead>
                    <tr>
                        <th>ID</th>
                        <th>CORREO</th>
                        <th>FECHA CREACIÓN</th>
                        <th>CONTRASEÑA</th>
                        <th>ACTIVO</th>
                        <th>ROL</th>
                        <th>Acciones</th>
                    </tr>
                    </thead>
                    <tbody id="tbl_body_table">
                    <!-- DATA POR MEDIO DE AJAX-->
                    </tbody>
                </table>
            </div>
        </div>
    </section>

    <script src="js/CRUDUsuario.js" type="text/javascript">
        
        </script>
</asp:Content>