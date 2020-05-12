<%@ Page Title="Reservar hora" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservarHora.aspx.cs" Inherits="Front.ReservarHora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="cajaDetalleServicio">
        <div class="estiloReserva">
            <h1>Reserva de hora</h1>
            <h2>Nombre de servicio</h2>

            <div class="row">
                <div class="col-md-6">
                    <div class="box box-body">
                        <div class="box-body columnaReserva1">

                            <div class="form-group">
                                <label for="txtNumeroReserva">NUMERO RESERVA</label>
                            </div>
                            <div class="form-group">
                                <input type="text" id="txtNumeroReserva" value="" placeholder="AUTOMATICO" class="form-control" autocomplete="off" />
                            </div>
                            <div class="form-group">
                                <label for="txtPatente">INGRESE PATENTE</label>
                            </div>
                            <div class="form-group">
                                <input type="text" id="txtPatente" value="" placeholder="ej: DFGH-11" class="form-control" autocomplete="off" />
                            </div>
                            <div class="form-group">
                                <label for="txtMarca">INGRESE MARCA</label>
                            </div>
                            <div class="form-group">
                                <input type="text" id="txtMarca" value="" placeholder="Chevrolet" class="form-control" autocomplete="off" />
                            </div>
                        </div>
                    </div>
                </div>

            <div class="col-md-6">
                <div class="box box-body">
                    <div class="box-body columnaReserva2">

                        <div class="form-group">
                            <label for="txtModelo">INGRESE MODELO</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtModelo" value="" placeholder="Sail" class="form-control" disabled="disabled" />
                        </div>
                        <div class="form-group">
                            <label for="txtAnio">INGRESE AÑO</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtAnio" value="" placeholder="2010" class="form-control" autocomplete="off" />
                        </div>
                        <div class="form-group">
                            <label for="txtDescripcion">INGRESE DESCRIPCIÓN</label>
                        </div>
                        <div class="form-group">
                            <input type="text" id="txtDescripcion" value="" placeholder="Mantención total" class="form-control" autocomplete="off" />
                        </div>
                        <div class="form-group">
                            <label for="txtSemana">INGRESE SEMANA</label>
                        </div>
                        <div class="form-group">
                            <input type="number" id="txtSemana" value="" class="form-control" autocomplete="off" />
                        </div>
                    </div>
                    <label id="labelTotal">TOTAL: $111.000</label>
                    <asp:Button ID="btnConfirmarReserva" runat="server" Text="Reservar" CssClass="btn btn-primary btnConfirmarReserva" OnClick="btnConfirmarReserva_Click"/>
                </div>
            </div>
                
        </div>
    </div>
        <table class="table table-striped table-hover" id="disponibilidad">
            <tr>
                <th>Horario</th>
                <th>Lunes</th>
                <th>Martes</th>
                <th>Miercoles</th>
                <th>Jueves</th>
                <th>Viernes</th>
            </tr>
            <tr>
                <th>08:00</th>
                <th>Disponible</th>
                <th>Disponible</th>
                <th>Agotado</th>
                <th>Disponible</th>
                <th>Agotado</th>
            </tr>
            <tr>
                <th>09:00</th>
                <th>Disponible</th>
                <th>Disponible</th>
                <th>Agotado</th>
                <th>Disponible</th>
                <th>Agotado</th>
            </tr>
            <tr>
                <th>10:00</th>
                <th>Disponible</th>
                <th>Disponible</th>
                <th>Agotado</th>
                <th>Disponible</th>
                <th>Agotado</th>
            </tr>
            <tr>
                <th>11:00</th>
                <th>Disponible</th>
                <th>Disponible</th>
                <th>Agotado</th>
                <th>Disponible</th>
                <th>Agotado</th>
            </tr>
        </table>
</div>
</asp:Content>
