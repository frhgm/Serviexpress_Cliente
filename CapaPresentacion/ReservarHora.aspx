<%@ Page Title="Reservar hora" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservarHora.aspx.cs" Inherits="CapaPresentacion.ReservarHora" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="upPanel" runat="server">
        <ContentTemplate>
            <section class="content">
                <section class="content-header" style="padding-top: 5%;">
                    <h3 style="text-align: center">HORARIOS DE ATENCIÓN</h3>
                </section>
                <div class="row">
                    <div class="offset-md-4 col-md-4 offset-md-4 text-center">
                        <asp:Label runat="server">INGRESE RUT</asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="offset-md-4 col-md-4 offset-md-4">
                        <asp:TextBox ID="txtRut" runat="server" CssClass="form-control" MaxLength="9"/>
                    </div>
                </div>
                <br>
                <div class="row caja">
                    <div class="col-md-6 text-center">
                        <div class="form-group">
                            <asp:Label runat="server">INGRESE FECHA</asp:Label>
                            <asp:Calendar runat="server" ID="dpFechaReserva"></asp:Calendar>
                        </div>

                        <div class="form-group">
                            <asp:Label runat="server">INGRESE PATENTE</asp:Label>
                            <asp:TextBox runat="server" ID="txtPatente" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:Label runat="server">INGRESE MARCA</asp:Label>
                            <asp:Textbox runat="server" ID="txtMarca" CssClass="form-control"></asp:Textbox>
                        </div>

                        <div class="form-group">
                            <asp:Label runat="server">INGRESE MODELO</asp:Label>
                            <asp:Textbox runat="server" ID="txtModelo" CssClass="form-control"></asp:Textbox>
                        </div>
                    </div>
                    <div class="col-md-6 text-center">
                        <div class="form-group">
                            <asp:Label runat="server">INGRESE AÑO</asp:Label>
                            <asp:TextBox runat="server" ID="txtAnno" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server">INGRESE DESCRIPCIÓN</asp:Label>
                            <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>SELECCIONE SERVICIO</label>
                            <asp:DropDownList ID="ddlServicio" CssClass="form-control" runat="server" AppendDataBoundItems="True"> </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>SELECCIONE EMPLEADO</label>
                            <asp:DropDownList ID="ddlEmpleado" CssClass="form-control" runat="server" AppendDataBoundItems="True"> </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>SELECCIONE BLOQUE HORARIO</label>
                            <asp:DropDownList ID="ddlBloque" CssClass="form-control" runat="server" AppendDataBoundItems="True"> </asp:DropDownList>
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
                                        <asp:Label ID="lblHoraInicio" runat="server" Text='<%#Eval("hora_inicio") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        <asp:Label ID="lblBloqueHeader" runat="server" Text="Hora Termino"></asp:Label>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hfHoraFinal" runat="server" Value='<%#Eval("hora_final") %>'/>
                                        <asp:Label ID="lblHoraFinal" runat="server" Text='<%#Eval("hora_final") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <br/>
                <div class="row">
                    <div class="col-md-6 text-center">
                        <asp:Button ID="btnListarReserva" runat="server" Text="Ver Reservas" CssClass="btn btn-primary" OnClick="btnListarReserva_Click"/>
                    </div>
                    <div class="col-md-6 text-center">
                        <asp:Button ID="btnAgendarReserva" runat="server" Text="Agendar Reserva" CssClass="btn btn-primary" OnClick="btnAgendarReserva_Click"/>
                    </div>
                    <!--OnClientClick para llamar a funcion js -->
                </div>

            </section>
            <%--<input id="idPaciente" type="hidden"  />--%>
            <asp:HiddenField ID="idPaciente" runat="server" Visible="false"/>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="js/reserva.js"></script>
</asp:Content>