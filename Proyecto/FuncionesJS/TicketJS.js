﻿function SeleccionaProducto(TicketID) {
    $("#TicketID").val(TicketID)
}

function ActualizarTiqueteJS(Usuario_Empleado_Asig, Usuario_Cliente, Estado_Ticket, Presupuesto, Detalles, TicketID, pid1, pid2, pid3, pid4, pid5, pid6, pid7, pid8) {
    $.ajax({
        type: 'POST',
        url: '/Usuario/ActualizarTiqueteJS',
        data: {
            Usuario_Empleado_Asig: Usuario_Empleado_Asig,
            Usuario_Cliente: Usuario_Cliente,
            Estado_Ticket: Estado_Ticket,
            Presupuesto: Presupuesto,
            Detalles: Detalles,
            TicketID: TicketID,
            pid1: pid1,
            pid2: pid2,
            pid3: pid3,
            pid4: pid4,
            pid5: pid5,
            pid6: pid6,
            pid7: pid7,
            pid8: pid8,
        },
        dataType: 'json',
        success: function (data) {
        },
        error: function (data) {
        }
    });

}