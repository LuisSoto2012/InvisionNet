var tabla = $("#TablaProductos").DataTable();;
function cargarTabla() {
    $.get("/api/ProductosEnCapas/listar")
        .then(function (listaDeProductos) {
            listaDeProductos.forEach(function (producto) {
                AgregarProductoParaTabla(producto);
            });
            tabla.draw();
        });
}

function AgregarProductoParaTabla(producto) {
    tabla.row.add(
        [
            producto.Id,
            producto.Nombre,
            producto.Precio,
            producto.NombreCategoria
        ]
    )
}

$('#Guardar').click(RegistrarProducto);

function RegistrarProducto() {
    var producto = {
        Nombre: $("#Nombre").val(),
        CategoriaId: $("#CategoriaId").val(),
        Precio: $("#Precio").val()
    };

    PostRequest("/api/ProductosEnCapas/crear", producto)
        .then(function (productoRegistrado) {
        AgregarProductoParaTabla(productoRegistrado);
        tabla.draw();
        LimpiarFormulario();
    });
}

function LimpiarFormulario() {
    $('#Nombre').val('');
    $('#CategoriaId').val('');
    $('#Precio').val('');
}

cargarTabla();

tabla.on('click', 'tbody tr', function () {
    console.log('API row values : ', tabla.row(this).data());
});