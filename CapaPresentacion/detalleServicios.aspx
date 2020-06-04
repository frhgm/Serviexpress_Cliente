<%@ Page Title="Detalle servicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="detalleServicios.aspx.cs" Inherits="CapaPresentacion.detalleServicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1 style="text-align: center;">Mi cuenta</h1>
    </section>
    <div class="cajaDetalleServicio">
        <h2>Mis servicios agendados</h2>
        <div class="row">
            <br />
            <br />
            <div class="col-md-12">
                <p id="tipoServicio">Cambio de aceite</p>
                <div class="divDetalleServicio">
                    <h4>IMAGEN SERVICIO</h4>
                </div>
                <div id="sampleText">
                    <p>Oratío dolorem sed id. Inañi ñomiñatí assueverit mea in, in enim hárum clita per.</p>
                    <p>Vidít princípes incorrupte méi in. Pér tibique voluptatum iñterpretaris et</p>
                    <p>Cu mél civibús copiosae fórensibus, ex vocent vocibus demócritum sed</p>
                </div>
                <asp:Button ID="btnReservar" runat="server" Text="Reservar hora" CssClass="btn btn-primary btn-lg btn-Reservar" OnClick="btnReservar_Click" />
            </div>
            
        </div>
    </div>
</asp:Content>
