<%@ Page Title="Reservar hora" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservarHora.aspx.cs" Inherits="CapaPresentacion.ReservarHora" %>


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
                <div class="row">
                    <div class="offset-md-1 col-md-4 offset-md-1 text-center">
                        <asp:Label runat="server">INGRESE RUT</asp:Label>
                        <asp:TextBox ID="txtRut" required oninvalid="this.setCustomValidity('Ingrese su rut')"
                                     oninput="this.setCustomValidity('')"
                                     runat="server" CssClass="form-control" MaxLength="9"/>

                    </div>
                    <div class="offset-md-1 col-md-4 offset-md-1 text-center">
                        <asp:Label runat="server">NUMERO DE RESERVA</asp:Label>
                        <asp:TextBox ID="txtReserva" placeholder="Llene N° reserva si desea cancelar reserva" runat="server" CssClass="form-control"/>
                    </div>
                </div>
                <br>
                <div class="row caja">
                    <div class="col-md-6 text-center">
                        <div class="form-group">
                            <asp:Label runat="server">INGRESE FECHA</asp:Label>
                            <asp:TextBox TextMode="Date" required runat="server" Text="2020-06-29" CssClass="form-control" ID="dpFechaReserva"
                                         oninvalid="this.setCustomValidity('Ingrese una fecha')"
                                         oninput="this.setCustomValidity('')"/>
                        </div>

                        <div class="form-group">
                            <asp:Label runat="server">INGRESE PATENTE</asp:Label>
                            <asp:TextBox runat="server" required ID="txtPatente" CssClass="form-control"
                                         oninvalid="this.setCustomValidity('Ingrese la patente')"
                                         oninput="this.setCustomValidity('')"/>
                        </div>

                        <div class="form-group">
                            <asp:Label runat="server">INGRESE MARCA</asp:Label>
                            <asp:Textbox runat="server" required ID="txtMarca" CssClass="form-control"
                                         oninvalid="this.setCustomValidity('Ingrese la marca')"
                                         oninput="this.setCustomValidity('')"/>
                        </div>

                        <div class="form-group">
                            <asp:Label runat="server">INGRESE MODELO</asp:Label>
                            <asp:Textbox runat="server" required ID="txtModelo" CssClass="form-control"
                                         oninvalid="this.setCustomValidity('Ingrese el modelo')"
                                         oninput="this.setCustomValidity('')"/>
                        </div>
                    </div>
                    <div class="col-md-6 text-center">
                        <div class="form-group">
                            <asp:Label runat="server">INGRESE AÑO</asp:Label>
                            <asp:TextBox runat="server" required ID="txtAnno" CssClass="form-control"
                                         oninvalid="this.setCustomValidity('Ingrese el año del auto')"
                                         oninput="this.setCustomValidity('')"/>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server">INGRESE DESCRIPCIÓN</asp:Label>
                            <asp:TextBox runat="server" required ID="txtDescripcion" CssClass="form-control"
                                         oninvalid="this.setCustomValidity('Ingrese una descripción')"
                                         oninput="this.setCustomValidity('')"/>
                        </div>

                        <div class="form-group">
                            <label>SELECCIONE EMPLEADO</label>
                            <asp:DropDownList ID="ddlEmpleado" required OnSelectedIndexChanged="SeleccionEmpleado" AutoPostBack="True" CssClass="form-control" runat="server"
                                              oninvalid="this.setCustomValidity('Primero seleccione un empleado')"
                                              oninput="this.setCustomValidity('')"
                                              MaintainScrollPositionOnPostback="true" />
                        </div>
                        <div class="form-group">
                            <label>SELECCIONE SERVICIO</label>
                            <asp:DropDownList ID="ddlServicio" required OnSelectedIndexChanged="SeleccionServicio" AutoPostBack="True" CssClass="form-control" runat="server"
                                              oninvalid="this.setCustomValidity('Luego un servicio')"
                                              oninput="this.setCustomValidity('')"
                                              MaintainScrollPositionOnPostback="true" />

                            <%-- <asp:TextBox runat="server" ID="txtServicio" CssClass="form-control"> </asp:TextBox>--%>
                        </div>
                        <div class="form-group">
                            <label>SELECCIONE BLOQUE HORARIO</label>
                            <asp:DropDownList ID="ddlBloque" required CssClass="form-control" runat="server"
                                              oninvalid="this.setCustomValidity('Y un bloque horario que le acomode')"
                                              oninput="this.setCustomValidity('')"
                                              MaintainScrollPositionOnPostback="true" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <!-- Crear nuestro GridView -->
                        <asp:GridView ID="grdHorariosAtencion" runat="server" CssClass="table table-secondary table-striped" AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        <asp:Label ID="lblNumeroHeader" runat="server" Text="N° Reserva"></asp:Label>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblNumero" runat="server" Text='<%#Eval("Numero_Reserva") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        <asp:Label ID="lblFechaHeader" runat="server" Text="Fecha de Atención"></asp:Label>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblFecha" runat="server" Text='<%#Eval("Fecha") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        <asp:Label ID="lblBloqueHeader" runat="server" Text="Hora inicio"></asp:Label>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hfHoraInicio" runat="server" Value='<%#Eval("hora_inicio") %>'/>
                                        <asp:Label ID="lblHoraInicio" runat="server" Text='<%#Eval("BloqueHora.Hora_Inicio") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        <asp:Label ID="lblBloqueHeader" runat="server" Text="Hora Termino"></asp:Label>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hfHoraFinal" runat="server" Value='<%#Eval("hora_final") %>'/>
                                        <asp:Label ID="lblHoraFinal" runat="server" Text='<%#Eval("BloqueHora.Hora_Final") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <br/>
                <div id="dialogo" role="alert">
                    <h4>Reserva exitosa</h4>
                    <hr>
                    <p runat="server" id="detallesReserva"></p>
                </div>
                <div class="row">
                    <div class="col-md-4 text-center">
                        <asp:LinkButton ID="btnListarReserva" OnClientClick="limpiarDatosCliente()" CausesValidation="False" runat="server" Text="Ver Reservas" CssClass="btn btn-primary" OnClick="btnListarReserva_Click"/>
                    </div>
                    <div class="col-md-4 text-center">
                        <asp:Button ID="btnAgendarReserva"  runat="server" Text="Agendar Reserva" CssClass="btn btn-primary" OnClick="btnAgendarReserva_Click"/>
                    </div>
                    <div class="col-md-4 text-center">
                        <asp:LinkButton ID="btnCancelarReserva" CausesValidation="False" runat="server" Text="Cancelar Reserva" CssClass="btn btn-primary" OnClick="btnCancelar_Click"/>
                    </div>
                    <!--OnClientClick para llamar a funcion js -->
                </div>

            </section>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    
    <script src="js/script.js"></script>
</asp:Content>