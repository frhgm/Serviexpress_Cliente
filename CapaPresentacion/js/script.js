$("[data-mask]").inputmask();

$("#btnBuscar").on("click", function (e) {
  e.preventDefault();

  var rut = $("#txtRut").val();

  searchPacienteDni(rut);
});

function searchPacienteDni(rut) {
  var data = JSON.stringify({ rut: rut });
  $.ajax({
    type: "POST",
    url: "ReservarHora.aspx/",
    data: data,
    contentType: "application/json; charset=utf-8",
    error: function (xhr, ajaxOptions, thrownError) {
      console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
    },
    success: function (data) {
      if (data.d == null) {
        alert("No exite el cliente con dni" + dni);
        limpiarDatosPaciente();
      } else {
        llenarDatosPaciente(data.d);
      }
    },
  });
}

function llenarDatosPaciente(obj) {
  $("#idPaciente").val(obj.IdPaciente);
  $("#txtNombres").val(obj.Nombres);
  $("#txtApellidos").val(obj.ApPaterno + " " + obj.ApMaterno);
  $("#txtTelefono").val(obj.Telefono);
  $("#txtEdad").val(obj.Edad);
  $("#txtSexo").val(obj.Sexo == "M" ? "Masculino" : "Femenino");
}
*/

function limpiarDatosPaciente() {
  $("#idPaciente").val("0");
  $("#txtNombres").val("");
  $("#txtApellidos").val("");
  $("#txtTelefono").val("");
  $("#txtEdad").val("");
  $("#txtSexo").val("");
}

function fijarFecha() {
  var x = document.getElementById("dpFechaReserva").value;
  document.getElementById("labelNacimiento").innerHTML = x;
}
