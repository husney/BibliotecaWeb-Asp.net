<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Biblioteca.aspx.cs" Inherits="Biblioteca.Biblioteca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<link rel="stylesheet" href="css/bootstrap.min.css"/>
	<link rel="stylesheet" href="css/styles.css" />
    <title>Control Biblioteca</title>
   
</head>
<body>

	<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container">
            <a href="#" class="navbar-brand">Biblioteca</a>

            <button type="button" class="navbar-toggler" data-toggle="collapse"
            data-target="#navbar" aria-controls="navbar" aria-expanded="false">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbar">
                <ul class="navbar-nav ml-auto">
                    
					<li class="nav-item">
                        <a href="Home.aspx" class="btn btn-primary">Salir</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

		<div class="container">
        <div class="row d-flex justify-content-center">
            <div class="col-auto">
                <div class="card card-fuid">
                    <div class="card-img">
                        <img src="img/slideBiblioteca.jpg"  class="img-fluid" alt="">
                    </div>
                </div>
            </div>
        </div>
    </div>

    <form id="form1" runat="server">
        <div>


			<div class="container">
						<div class="row mt-3 d-flex flex-row justify-content-center  ">
							<div class="col-12 col-lg-8 ">
								<div class="indiceMenus d-flex flex-sm-row justify-content-sm-between flex-wrap justify-content-start ">
									
										<asp:Button ID="btnAreas"  CssClass="btn btn-info mt-1 mr-1" runat="server" Text="Areas" />
										<asp:Button ID="btnLibros"  CssClass="btn btn-info mt-1 mr-1" runat="server" Text="Libros" />
										<asp:Button ID="btnPrestamos"  CssClass="btn btn-info mt-1 mr-1" runat="server" Text="Préstamos" />
										<asp:Button ID="btnSanciones"  CssClass="btn btn-info mt-1 mr-1" runat="server" Text="Sanciones" />
										<asp:Button ID="btnUsuarios"  CssClass="btn btn-info mt-1 mr-1" runat="server" Text="Usuarios" />
									
								</div>
							</div>
						</div>
					</div>

		
			<div class="container">
				<div class="row mt-3">
					<div class="col">
						<div class="card">
        			<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
						<asp:View ID="View1" runat="server">

					
						</asp:View>
					</asp:MultiView>
							</div>
					</div>
				</div>
			</div>
		

        </div>

	 <script src="js/jquery-3.5.1.slim.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    </form>

	 </body>
</html>
