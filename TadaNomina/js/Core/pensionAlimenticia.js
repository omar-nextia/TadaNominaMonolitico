﻿$(function () {
    $(".anchorDetail").click(function () {
        debugger;
        var $buttonClicked = $(this);
        var id = $buttonClicked.attr('data-id');
        var options = { "backdrop": "static", keyboard: true };

        $.ajax({
            type: "GET",
            url: 'PensionAlimenticia/Details',
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
            url: 'PensionAlimenticia/Delete',
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

function CambiaStatus(IdPension) {
    $.ajax({
        type: 'POST',
        url: 'PensionAlimenticia/CambiaStatusCredito',
        data: { IdPension: IdPension },
        datatype: 'json',
        success: function (data) {
            if (data == "OK") {
                mensajeAlerta("Atencion!", "Se suspendio correctamente el saldo.", "mint", "bounce", "fadeOut", 2000);
                setTimeout(redirigir, 2500);
            }
            else {
                mensajeAlerta("Atencion!", data, "danger", "bounce", "fadeOut", 2100);
            }
        }
    });
}