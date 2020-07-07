<%@ Page Title="Mi cuenta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="miCuenta.aspx.cs" Inherits="CapaPresentacion.miCuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1 style="text-align: center;">Mi cuenta</h1>
    </section>
    <div id="miCuenta">
        <h2>Mis servicios agendados</h2>
        <div class="row">
            <br/>
            <br/>
            <div class="col-md-4">
                <div class="misServicios">
                    <a href="ReservarHora.aspx">Cambio de aceite</a>
                    <h4>IMAGEN SERVICIO</h4>
                    <p>Hora:12:15PM</p>
                    <p>Fecha:15-05-2021</p>
                </div>
            </div>


            <div class="col-md-4">
                <div class="misServicios">
                    <a href="ReservarHora.aspx">Reemplazo filtro de aceite</a>
                    <h4>IMAGEN SERVICIO</h4>
                    <p>Hora:12:15PM</p>
                    <p>Fecha:15-05-2021</p>
                </div>
            </div>
            <div class="col-md-4">
                <div class="misServicios">
                    <a href="ReservarHora.aspx">Mantención total</a>
                    <h4>IMAGEN SERVICIO</h4>
                    <p>Hora:12:15PM</p>
                    <p>Fecha:15-05-2021</p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>