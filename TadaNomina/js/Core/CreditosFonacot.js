﻿$("#btnBuscar").click(function () {
    var clave = $("#ClaveEmp").val();
    $("#Empleado").val('');
    $("#rfc").val('');
    $.ajax({
        type: 'GET',
        url: 'BuscaEmpleado',
        dataType: 'json',
        data: { clave },
        success: function (data) {
            if (data != 'El Empleado con la clave que ingreso no existe!') {
                $("#IdEmpleado").val(data.IdEmpleado);
                $("#NombreEmpleado").val(data.Nombre);
                $("#RFC").val(data.Rfc);
            }
            else {
                mensajeAlerta("Atencion!", data, "danger", "fadeInDown", "fadeOutDown", 2500);
            }
        }
    });

});

$(function () {
    $(".anchorDetail").click(function () {
        debugger;
        var $buttonClicked = $(this);
        var id = $buttonClicked.attr('data-id');
        var options = { "backdrop": "static", keyboard: true };

        $.ajax({
            type: "GET",
            url: 'Fonacot/Details',
            contentType: "application/json; charset=utf-8",
            data: { id },
            datatype: "json",
            success: function (data) {
                debugger;
                $('#myModalContent').html(data);
                $('#myModal').modal(options);
                $('#myModal').modal('show');

            },
            error: function () {
                alert("Dynamic content load failed.");
            }
        });
    });

    $("#closbtn").click(function () {
        $('#myModal').modal('hide');
    });
});

$(function () {
    $(".anchorDelete").click(function () {
        debugger;
        var $buttonClicked = $(this);
        var id = $buttonClicked.attr('data-id');
        var options = { "backdrop": "static", keyboard: true };
        $.ajax({
            type: "GET",
            url: 'Fonacot/Delete',
            contentType: "application/json; charset=utf-8",
            data: { id },
            datatype: "json",
            success: function (data) {
                debugger;
                $('#myModalContent').html(data);
                $('#myModal').modal(options);
                $('#myModal').modal('show');

            },
            error: function () {
                alert("Dynamic content load failed.");
            }
        });
    });

    $("#closbtn").click(function () {
        $('#myModal').modal('hide');
    });
});

function CambiaStatus(IdCredito) {
    $.ajax({
        type: 'POST',
        url: 'Fonacot/CambiaStatusCredito',
        data: { IdCredito: IdCredito },
        datatype: 'json',
        success: function (data) {
            if (data == "OK") {
                mensajeAlerta("Atencion!", "Movimiento realizado correctamente.", "mint", "bounce", "fadeOut", 2000);
            }
            else {
                mensajeAlerta("Atencion!", data, "danger", "bounce", "fadeOut", 2100);
            }
        }
    });
}

function ModalDesactivarCreditos(tipoMovimiento) {
    $("#modDesactivaCreditos").modal('show');
    $("#TipoMovimiento").val(tipoMovimiento);

    if (tipoMovimiento == 1) {
        $("#TituloModal").text('Activar créditos');
        $("#EtiquetaModal").text('¿Estás seguro que quieres activar todos los créditos?');
    } else {
        $("#TituloModal").text('Desactivar créditos');
        $("#EtiquetaModal").text('¿Estás seguro que quieres desactivar todos los créditos?');
    }
}

function MovimientoCreditos() {
    const tipoMov = $("#TipoMovimiento").val();
    $.ajax({
        type: 'POST',
        url: 'Fonacot/Desactivacreditos',
        data: {tipoMov : tipoMov},
        datatype: 'json',
        success: function (data) {
            if (data == "OK") {
                mensajeAlerta("Atencion!", "Movimiento realizado correctamente.", "mint", "bounce", "fadeOut", 2000);
                setTimeout(function () {
                    window.location.reload();
                }, 2500);
            }
            else {
                mensajeAlerta("Atencion!", data, "danger", "bounce", "fadeOut", 2100);
                setTimeout(function () {
                    window.location.reload();
                }, 2500);
            }
        }
    });
}

function CierraModal() {
    $("#modDesactivaCreditos").modal('hide');
    $("#TipoMovimiento").val(null);
    $("#TituloModal").text('');
    $("#EtiquetaModal").text('');
}