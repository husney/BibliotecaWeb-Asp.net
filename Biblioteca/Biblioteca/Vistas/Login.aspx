<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Biblioteca.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<link rel="stylesheet" href="../css/bootstrap.min.css"/>
	<link rel="stylesheet" href="../css/styles.css" />
    <title>Iniciar Sesion</title>
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
                        <a href="Register.aspx" class="btn btn-primary">Registrar</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

      <div class="container h-100 d-flex justify-content-center ">
    <form  method="post" class="form d-flex flex-wrap align-content-end text-center" runat="server">
       <div class="cont ">

        <div class="form-group ">
            <label for="user" class="form-label h1 text-white">Usuario</label>
         
			<asp:TextBox ID="user" class="form-control" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-info" runat="server" ErrorMessage="Ingrese el Usuario" ControlToValidate="user"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label for="pass" class="form-label h1 text-white">Contraseña</label>
          
			<asp:TextBox ID="pass" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="text-info" ErrorMessage="Ingrese la Contraseña" ControlToValidate="pass"></asp:RequiredFieldValidator>
       </div>

        
		   <asp:Button ID="ingresar" class="btn btn-primary d-block w-100" runat="server" Text="Ingresar" OnClick="Button1_Click1" />
		 <asp:Label ID="msg" runat="server"  Text=""></asp:Label>
       </div>
		
		
    </form>
</div>
	 <script src="../js/jquery-3.5.1.slim.min.js"></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</body>
</html>
