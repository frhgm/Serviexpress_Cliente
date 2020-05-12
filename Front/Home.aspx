<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Front._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div style="height:200px; width:1030px; border-style:solid;border-width:2px;">
            <h1 align="center">ICONO GALERIA</h1>
        </div>
    </div>

    <div class="row">
        <div class="col-md-3">
            <a href="detalleServicios.aspx">Cambio de aceite</a>
            <p>
                Agende con nosotros este servicio en una variedad de horarios
            </p>
            <p>
                <a class="btn btn-default" href="~ReservaHora.aspx">Agendar &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <a href="detalleServicios.aspx">Reemplazo Filtros</a>
            <p>
                Agende con nosotros este servicio en una variedad de horarios
            </p>
            <p>
                <a class="btn btn-default" href="~ReservaHora.aspx">Agendar &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <a href="detalleServicios.aspx">Servicio total</a>
            <p>
                Agende con nosotros este servicio en una variedad de horarios
            </p>
            <p>
                <a class="btn btn-default" href="~ReservaHora.aspx">Agendar &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <a href="detalleServicios.aspx">Neumaticos de nieve</a>
            <p>
                Agende con nosotros este servicio en una variedad de horarios
            </p>
            <p>
                <a class="btn btn-default" href="~ReservaHora.aspx">Agendar &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
