$(function(){
    $('.galeria .contenedor-imagen').on('click', function(){
        $('#modal').modal;
        var ruta = ($(this).find('img')).attr('src');
        $('#imagen-modal').attr('src', ruta);
    });

    $('#modal').on('click', function(){
        $('#modal').modal('hide');
    });
})