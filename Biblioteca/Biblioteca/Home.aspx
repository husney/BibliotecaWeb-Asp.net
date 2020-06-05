<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Biblioteca.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	 <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<link rel="stylesheet" href="css/bootstrap.min.css"/>
	<link rel="stylesheet" href="css/styles.css" />
	
    <title>Biblioteca</title>
</head>
<body>
    
	  <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container">
            <a href="Home.aspx" class="navbar-brand">Biblioteca</a>

            <button type="button" class="navbar-toggler" data-toggle="collapse"
            data-target="#navbar" aria-controls="navbar" aria-expanded="false">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbar">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a href="Login.aspx" class="btn btn-primary mt-1 mr-1">Iniciar Sesion</a>
                    </li>
					<li class="nav-item">
                        <a href="Register.aspx" class="btn btn-primary mt-1">Registrar</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <div class="container">
        <div class="row">
            <div class="col-12">
                <div id="slide" class="carousel slide" data-ride="carousel">
                    <ol class="carousel-indicators">
                      <li data-target="#slide" data-slide-to="0" class="active"></li>
                      <li data-target="#slide" data-slide-to="1"></li>
                      <li data-target="#slide" data-slide-to="2"></li>
                      
                    </ol>
                    <div class="carousel-inner">
                      
                      <div class="carousel-item active">
                        <img src="img/sd2.jpg" class="d-block w-100 img" alt=""/>
                      </div>
                      <div class="carousel-item">
                        <img src="img/sd3.jpg" class="d-block w-100 img" alt=""/>
                     </div>
                      <div class="carousel-item">
                        <img src="img/sd4.jpg" class="d-block w-100 img" alt=""/>
                        </div>
                      </div>
                    <a class="carousel-control-prev" href="#slide" role="button" data-slide="prev">
                      <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                      <span class="sr-only">Anterior</span>
                    </a>
                    <a class="carousel-control-next" href="#slide" role="button" data-slide="next">
                      <span class="carousel-control-next-icon" aria-hidden="true"></span>
                      <span class="sr-only">Siguiente</span>
                    </a>
                  </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">
                <main class="descripcion my-4  h-100 rounded  text-white">
                    <h3 class="text-center">Biblioteca</h3>
                    <p class="lead ml-3 my-4">El Sistema de Bibliotecas proporciona recursos y servicios de información pertinentes con altos niveles de calidad. Se apoya en el talento humano, la tecnología, la infraestructura y el mejoramiento continuo de sus procesos y servicios para facilitar el desarrollo de las actividades de enseñanza, aprendizaje, investigación y creación, con el fin de satisfacer las necesidades de información de sus usuarios.</p>
                    <h3 class="text-center">Misión</h3>
                    <p class="lead ml-3 my-4"> Proporcionar recursos y servicios de información innovadores, pertinentes y de calidad, que sirvan como soporte para el desarrollo de los procesos académicos, de investigación y creación de conocimiento</p>
                    <h3 class="text-center">Visión</h3>
                    <p class="lead ml-3 my-4">Visión

                        Ser un Sistema de Bibliotecas incluyente y solidario, líder en América Latina por la innovación y calidad de sus servicios, la pertinencia y relevancia de sus colecciones, que integra herramientas tecnológicas para facilitar el acceso a la información y promueve la generación de usuarios autónomos, la investigación/creación y la cooperación con el entorno y demás instituciones del país y del mundo.</p>
                </main>
            </div>
        </div>
    </div>

	  <script src="js/jquery-3.5.1.slim.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
