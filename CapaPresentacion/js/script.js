$("[data-mask]").inputmask();

$("#btnListarReserva").on("click", function (e) {
  e.preventDefault();

  var rut = $("#txtRut").val();

  searchClienteRut(rut);
});

$( function() {
  $( "#dialogo" ).dialog();
} );

function searchClienteRut(rut) {
  var data = JSON.stringify({ rut: rut });
  $.ajax({
    type: "POST",
    url: "ReservarHora.aspx/BuscarClienteReserva",
    data: data,
    contentType: "application/json; charset=utf-8",
    error: function (xhr, ajaxOptions, thrownError) {
      console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
    },
    success: function (data) {
      if (data.d == null) {
        alert("No exite el cliente con rut" + rut);
      } else {
        llenarDatosCliente(data.d);
      }
    },
  });
}

function llenarDatosCliente(obj) {
  $("#txtMarca").val(obj.Numero_Reserva);
  $("#txtFijo").val(obj.Fecha);
  $("#txtNombre").val(obj.Hora_Inicio);
  $("#txtPatente").val(obj.Hora_Final);
}

function limpiarDatosCliente() {
  $("#txtMarca").val("0");
  $("#txtFijo").val("");
  $("#txtNombre").val("");
  $("#txtPatente").val("");
}
function vaciarCampos() {
  let rut,
    fecha,
    patente,
    marca,
    modelo,
    anno,
    descripcion,
    empleado,
    servicio,
    bloque;

  rut = document.getElementById("txtRut").value;
  fecha = document.getElementById("dpFechaReserva").value;
  patente = document.getElementById("txtPatente").value;
  marca = document.getElementById("txtMarca").value;
  modelo = document.getElementById("txtModelo").value;
  anno = document.getElementById("txtAnno").value;
  descripcion = document.getElementById("txtDescripcion").value;

  rut.oninput = this.setCustomValidity("");
}
function validarCampos() {
  let rut,
    fecha,
    patente,
    marca,
    modelo,
    anno,
    descripcion,
    empleado,
    servicio,
    bloque;

  rut = document.getElementById("txtRut").value;
  fecha = document.getElementById("dpFechaReserva").value;
  patente = document.getElementById("txtPatente").value;
  marca = document.getElementById("txtMarca").value;
  modelo = document.getElementById("txtModelo").value;
  anno = document.getElementById("txtAnno").value;
  descripcion = document.getElementById("txtDescripcion").value;
  /*
  var value = document.getElementById("<%=ddlMaster1.ClientID%>");  
   var getvalue = value.options[value.selectedIndex].value;  
   var gettext = value.options[value.selectedIndex].text;  
   */

  if (rut == 0) {
    rut.oninvalid = this.setCustomValidity("Ingrese su rut");
  }
}
