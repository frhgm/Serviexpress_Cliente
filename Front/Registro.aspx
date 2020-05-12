<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Front.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section class="content-header">
        <h1 style="text-align: center">CREAR CUENTA NUEVA</h1>
    </section>


    <section class="content">

        <div class="row"><!--FILA 1-->
            <div class="col-md-6"><!--COLUMNA 1-->
                <div class="box box-body">
                    <div class="box-body" id="columna1">
                        <div class="form-group">
                            <label for="txtNombre">INGRESE NOMBRE</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtNombre" value="" placeholder="ej: Pedro" class="form-control" autocomplete="off"/>
                        </div>
                        <div class="form-group">
                            <label for="txtApellido">INGRESE APELLIDO</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtApellido" value="" placeholder="ej: Perez" class="form-control" autocomplete="off" />
                        </div>
                        <div class="form-group">
                            <label for="txtRut">INGRESE RUT</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtRut" value="" placeholder="sin puntos ni guión" class="form-control" autocomplete="off" />
                        </div>
                        <div class="form-group">
                            <label for="txtApellido">NOMBRE DE USUARIO</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtUsuario" value="" placeholder="AUTOMATICO" class="form-control" disabled="disabled" />
                        </div>
                        <div class="form-group">
                            <label for="txtCorreo">CORREO ELECTRONICO</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtCorreo" value="" placeholder="ej: pedro@correo.com" class="form-control" autocomplete="off" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-6"> <!--COLUMNA 2-->
                <div class="box box-body">
                    <div class="box-body" id="columna2">
                        <!--INPUT 1-->
                        <div class="form-group">
                            <label for="txtNombre">INGRESE DIRECCIÓN</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtDireccion" value="" placeholder="Ingrese dirección" class="form-control" autocomplete="off" />
                        </div>
                        <!--INPUT 2-->
                        <div class="form-group">
                            <label for="txtFechaNacimiento">FECHA DE NACIMIENTO</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtFechaNacimiento" value="" placeholder="Ingrese fecha de nacimiento" class="form-control" autocomplete="off" />
                        </div>

                        <div class="form-group">
                            <label for="txtTelefono">INGRESE TELEFONO</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtTelefono" value="" placeholder="227598648" class="form-control" autocomplete="off" />
                        </div>

                        <div class="form-group">
                            <label for="txtTelefono2">INGRESE TELEFONO 2</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtTelefono2" value="" placeholder="224869674" class="form-control" autocomplete="off" />
                        </div>


                    </div>
                </div>
            </div>
          </div>
        <br />
        <div align="center">
                <button type="button" class="btn btn-primary">Registrar</button>
                <button type="button" class="btn btn-default">No Registrar</button>
        </div>
</section>
        
    
</asp:Content>
