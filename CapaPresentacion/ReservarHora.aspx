﻿<%@ Page Title="Reservar hora" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservarHora.aspx.cs" Inherits="CapaPresentacion.ReservarHora" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="upPanel" runat="server">
        <ContentTemplate>
            <section class="content">
                <asp:Panel runat="server" ID="panelMensajes">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </asp:Panel>

                <section class="page-header">
                    <h3 style="text-align: center">Reserva de horas</h3>
                </section>
                <div class="container">
                    <div class="row">
                        <div class="offset-md-1 col-md-4 offset-md-1 text-center">
                            <asp:Label runat="server">
                                <strong>Ingrese Rut</strong>
                            </asp:Label>
                            <asp:TextBox ID="txtRut" required oninvalid="this.setCustomValidity('Ingrese su rut')"
                                         oninput="this.setCustomValidity('')"
                                         runat="server" CssClass="form-control" MaxLength="9"/>

                        </div>
                        <div class="offset-md-1 col-md-4 offset-md-1 text-center">
                            <asp:Label runat="server">
                                <strong>Numero de reserva</strong>
                            </asp:Label>
                            <asp:TextBox ID="txtReserva" placeholder="Llene N° reserva si desea cancelar reserva" runat="server" CssClass="form-control"/>
                        </div>
                    </div>
                </div>
                <br>
                <div class="container">
                    <div class="row caja">
                        <div class="col-md-6 text-center">
                            <div class="form-group">
                                <asp:Label runat="server">
                                    <strong>Ingrese fecha</strong>
                                </asp:Label>
                                <asp:TextBox TextMode="Date" required runat="server" Text="2020-06-29" CssClass="form-control" ID="dpFechaReserva"
                                             oninvalid="this.setCustomValidity('Ingrese una fecha')"
                                             oninput="this.setCustomValidity('')"/>
                            </div>

                            <div class="form-group">
                                <asp:Label runat="server">
                                    <strong>Ingrese patente</strong>
                                </asp:Label>
                                <asp:TextBox runat="server" MaxLength="6" required ID="txtPatente" CssClass="form-control"
                                             oninvalid="this.setCustomValidity('Ingrese la patente')"
                                             oninput="this.setCustomValidity('')"/>
                            </div>

                            <div class="form-group">
                                <asp:Label runat="server">
                                    <strong>Ingrese marca</strong>
                                </asp:Label>
                                <asp:Textbox runat="server" required ID="txtMarca" CssClass="form-control"
                                             oninvalid="this.setCustomValidity('Ingrese la marca')"
                                             oninput="this.setCustomValidity('')"/>
                            </div>

                            <div class="form-group">
                                <asp:Label runat="server">
                                    <strong>Ingrese modelo</strong>
                                </asp:Label>
                                <asp:Textbox runat="server" required ID="txtModelo" CssClass="form-control"
                                             oninvalid="this.setCustomValidity('Ingrese el modelo')"
                                             oninput="this.setCustomValidity('')"/>
                            </div>
                        </div>
                        <div class="col-md-6 text-center">
                            <div class="form-group">
                                <asp:Label runat="server">
                                    <strong>Ingrese el año</strong>
                                </asp:Label>
                                <asp:TextBox runat="server" MaxLength="4" required ID="txtAnno" CssClass="form-control"
                                             oninvalid="this.setCustomValidity('Ingrese el año del auto')"
                                             oninput="this.setCustomValidity('')"/>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server">
                                    <strong>Ingrese descipción</strong>
                                </asp:Label>
                                <asp:TextBox runat="server" required ID="txtDescripcion" CssClass="form-control"
                                             oninvalid="this.setCustomValidity('Ingrese una descripción')"
                                             oninput="this.setCustomValidity('')"/>
                            </div>


                            <div class="form-group">
                                <label>
                                    <strong>Seleccione servicio</strong>
                                </label>
                                <asp:DropDownList ID="ddlServicio" OnSelectedIndexChanged="SeleccionServicio" required AutoPostBack="True" CssClass="form-control" runat="server"
                                                  oninvalid="this.setCustomValidity('Luego un servicio')"
                                                  oninput="this.setCustomValidity('')"
                                                  MaintainScrollPositionOnPostback="true"/>

                                <%-- <asp:TextBox runat="server" ID="txtServicio" CssClass="form-control"> </asp:TextBox>--%>
                            </div>
                            <div class="form-group">
                                <label>
                                    <strong>Seleccione empleado</strong>
                                </label>
                                <asp:DropDownList ID="ddlEmpleado" required OnSelectedIndexChanged="SeleccionEmpleado" AutoPostBack="True" CssClass="form-control" runat="server"
                                                  oninvalid="this.setCustomValidity('Primero seleccione un empleado')"
                                                  oninput="this.setCustomValidity('')"
                                                  MaintainScrollPositionOnPostback="true"/>
                            </div>

                            <div class="form-group">
                                <label>
                                    <strong>Seleccione horario</strong>
                                </label>
                                <asp:DropDownList ID="ddlBloque" required CssClass="form-control" runat="server"
                                                  oninvalid="this.setCustomValidity('Y un bloque horario que le acomode')"
                                                  oninput="this.setCustomValidity('')"
                                                  MaintainScrollPositionOnPostback="true"/>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="container">
                    <div class="row">
                        <div class="col-md-12">

                            <asp:GridView
                                CssClass="table table-secondary table-striped"
                                ID="gridReservas"
                                runat="server"
                                AutoGenerateColumns="False">

                                <Columns>
                                    <asp:BoundField HeaderText="Numero reserva" DataField="n_reserva"/>
                                    <asp:BoundField DataFormatString="{0:D}" HeaderText="Fecha" DataField="fecha"/>
                                    <asp:BoundField HeaderText="Hora inicio" DataField="hora_inicio"/>
                                    <asp:BoundField HeaderText="Hora final" DataField="hora_final"/>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>

                <br/>
                <div class="row">
                    <div class="col-md-12">
                        <textarea runat="server" ID="detallesReserva" class="form-control"></textarea>
                    </div>
                    </div>
                <div class="container">
                    <div class="row">

                        <div class="col-md-4 text-center">
                            <asp:LinkButton ID="btnListarReserva" CausesValidation="False" runat="server" Text="Ver Reservas" CssClass="btn btn-secondary" OnClick="btnListarReserva_Click"/>
                        </div>

                        <div class="col-md-4 text-center">
                            <asp:Button ID="btnAgendarReserva" runat="server" Text="Agendar Reserva" CssClass="btn btn-primary" OnClick="btnAgendarReserva_Click"/>
                        </div>
                        <div class="col-md-4 text-center">
                            <asp:LinkButton ID="btnCancelarReserva" data-toggle="modal" data-target="#myModal" CausesValidation="False" runat="server" Text="Cancelar Reserva" CssClass="btn btn-secondary" OnClick="btnCancelar_Click"/>
                        </div>
                        <!--OnClientClick para llamar a funcion js -->
                    </div>

                </div>
            </section>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">

</asp:Content>