//////////function PostRequest(url,data) {
    return $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: url,
        data: JSON.stringify(data),
        dataType: "json",
    }).fail(function (objetoError) {
            mostrarError(objetoError.Mensaje);
    });
}


