$("[data-mask]").inputmask();

$("#btnBuscar").on("click", function (e) {
  e.preventDefault();

  var dni = $("#txtDNI").val();

  searchPacienteDni(dni);
});

function searchPacienteDni(dni) {
  var data = JSON.stringify({ dni: dni });
  $.ajax({
    type: "POST",
    url: "GestionarReservaCitas.aspx/BuscarPacienteDNI",
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

function limpiarDatosPaciente() {
  $("#idPaciente").val("0");
  $("#txtNombres").val("");
  $("#txtApellidos").val("");
  $("#txtTelefono").val("");
  $("#txtEdad").val("");
  $("#txtSexo").val("");
}
/*
function ocultarMostrar() {
  var x = document.getElementById("registroCliente");
  if (x.style.display === "none") {
    x.style.display = "block";
  } else {
    x.style.display = "none";
  }
}
*/
function imprimirFecha() {
  var x = document.getElementById("dpFechaNacimiento").value;
  document.getElementById("labelNacimiento").innerHTML = x;
}
