<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="CapaPresentacion.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section class="content-header">
        <h2 style="text-align: center">CREAR CUENTA NUEVA</h2>
    </section>
    <!--REFORMAT CTRL+E,C-->

    <section class="content">

        <div class="row" id="registroCliente">
            <!--FILA 1-->
            <div class="col-md-6 caja">
                <!--COLUMNA 1-->
                <div class="form-group">
                    <label for="txtRut">INGRESE RUT</label>
                    <asp:TextBox ID="txtRut" runat="server" CssClass="form-control" MaxLength="9"/>
                </div>
                <div class="form-group">
                    <label for="txtNombre">INGRESE NOMBRE</label>
                    <asp:TextBox ID="txtNombre" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtApellido">INGRESE APELLIDO</label>
                    <asp:TextBox ID="txtApellido" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-6 caja">
                <div class="form-group">
                    <label for="txtCelular">TELEFONO CELULAR</label>
                    <asp:TextBox ID="txtCelular" runat="server" Text="" MaxLength="9" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtFijo">TELEFONO FIJO</label>
                    <asp:TextBox ID="txtFijo" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtDireccion">DIRECCIÓN</label>
                    <asp:TextBox ID="txtDireccion" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label for="dpFechaNacimiento" ID="labelNacimiento" runat="server">FECHA NACIMIENTO</asp:Label>
                    <asp:TextBox TextMode="Date" runat="server" Text="1986-07-31" CssClass="form-control" ID="dpFechaNacimiento"></asp:TextBox>
                </div>

            </div>
        </div>
        <div class="row">
            <div class="offset-md-4 col-md-4 offset-md-4">
                <br>
                <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary btn-block" Text="Registrar" OnClick="btnRegistrar_Click"/>
            </div>
        </div>
        <br/>


    </section>

    <script src="js/CRUDUsuario.js" type="text/javascript">
        
        </script>
</asp:Content>