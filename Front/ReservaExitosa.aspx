<%@ Page Title="Reserva Exitosa!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservaExitosa.aspx.cs" Inherits="Front.ReservaExitosa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">Su reserva fue exitosa</h1>
    </section>
    <div class="cajaDetalleServicio">
        <div class="estiloReserva">
            <h2>Nombre del servicio</h2>
            <h3>Detalle del servicio</h3>
            <div id="sampleText" style="position:absolute;left:-20px;">
                <p>Oratío dolorem sed id. Inañi ñomiñatí assueverit mea in, in enim hárum clita per.</p>
                <p>Vidít princípes incorrupte méi in. Pér tibique voluptatum iñterpretaris et</p>
                <p>Cu mél civibús copiosae fórensibus, ex vocent vocibus demócritum sed</p>
            </div>
            <div id="detallesReserva">
                <label>Nombre: Nombre Apellido</label><br />
                <label>Rut: 11.111.111-1</label><br />
                <label>N° boleta: 11111</label><br />
                <label>Total: $111.000</label><br />
                <label>Fecha: 01-01-2021</label><br />  

                <button class="btn btn-default">Volver</button>
            </div>
            
        </div>
    </div>
</asp:Content>
