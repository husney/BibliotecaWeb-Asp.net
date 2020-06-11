function eliminar(url) {
    if (window.confirm('¿Desea eliminar este usuario?')) {
        window.location = url;
    }
}

//usuDocumento, usuNombre, usuDireccion, usuTelefono, usuCorreo, usuEstado, usuId
function editar(documento, nombre, direccion, telefono, correo, estado) {
    document.getElementById('Main_editDocumento').value = documento;
    document.getElementById('Main_editNombre').value = nombre;
    document.getElementById('Main_editDireccion').value = direccion;
    document.getElementById('Main_editTelefono').value = telefono;
    document.getElementById('Main_editCorreo').value = correo;
    document.getElementById('Main_editEstados').value = estado;
   
}
