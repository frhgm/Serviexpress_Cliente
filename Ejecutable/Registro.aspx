<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="CapaPresentacion.Registro" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--REFORMAT CTRL+E,C-->

    <section class="content">
        <asp:Panel runat="server" ID="panelMensajes">
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        </asp:Panel>

        <section class="content-header">
            <h2 style="text-align: center">Registro de clientes</h2>
        </section>

        <div class="row" id="registroCliente">
            <!--FILA 1-->
            <div class="col-md-6 caja">
                <!--COLUMNA 1-->
                <div class="form-group">
                    <label for="txtRut">INGRESE RUT</label>
                    <asp:TextBox ID="txtRut" required runat="server" CssClass="form-control" MaxLength="9"
                                 oninvalid="this.setCustomValidity('Ingrese su rut')"
                                 oninput="this.setCustomValidity('')"/>
                </div>
                <div class="form-group">
                    <label for="txtNombre">INGRESE NOMBRE</label>
                    <asp:TextBox ID="txtNombre" required runat="server" Text="" CssClass="form-control"
                                 oninvalid="this.setCustomValidity('Ingrese su nombre')"
                                 oninput="this.setCustomValidity('')"/>
                </div>
                <div class="form-group">
                    <label for="txtApellido">INGRESE APELLIDO</label>
                    <asp:TextBox ID="txtApellido" required runat="server" Text="" CssClass="form-control"
                                 oninvalid="this.setCustomValidity('Ingrese su apellido')"
                                 oninput="this.setCustomValidity('')"/>
                </div>
            </div>

            <div class="col-md-6 caja">
                <div class="form-group">
                    <label for="txtCelular">TELEFONO CELULAR</label>
                    <asp:TextBox ID="txtCelular" required runat="server" Text="" MaxLength="9" CssClass="form-control"
                                 oninvalid="this.setCustomValidity('Ingrese su celular')"
                                 oninput="this.setCustomValidity('')"/>
                </div>
                <div class="form-group">
                    <label for="txtFijo">TELEFONO FIJO</label>
                    <asp:TextBox ID="txtFijo" runat="server" placeholder="Opcional" Text="" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtDireccion">DIRECCIÓN</label>
                    <asp:TextBox ID="txtDireccion" required runat="server" Text="" CssClass="form-control"
                                 oninvalid="this.setCustomValidity('Ingrese su direccion')"
                                 oninput="this.setCustomValidity('')"/>
                </div>
                <div class="form-group">
                    <asp:Label for="dpFechaNacimiento" ID="labelNacimiento" runat="server">FECHA NACIMIENTO</asp:Label>
                    <asp:TextBox TextMode="Date" required runat="server" Text="1980-01-31" CssClass="form-control" ID="dpFechaNacimiento"
                                 oninvalid="this.setCustomValidity('Seleccione su fecha de nacimiento')"
                                 oninput="this.setCustomValidity('')"/>
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
</asp:Content>
    <asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
        
    </asp:Content>

