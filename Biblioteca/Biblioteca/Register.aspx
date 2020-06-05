<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Biblioteca.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<link rel="stylesheet" href="css/bootstrap.min.css"/>
	<link rel="stylesheet" href="css/styles.css" />
  
	<title>Registro</title>
	</asp:Literal>
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
					
                </ul>
            </div>
        </div>
    </nav>


    <div class="container h-100 d-flex justify-content-center ">
     <form action="" method="POST" class="form d-flex flex-wrap align-content-end text-center" runat="server">
       <div class="cont d-flex flex-wrap align-content-between justify-content-center">
        <div class="form-group ">
            <label for="regUser" class="form-label h1 text-white">Usuario</label>
			<asp:TextBox ID="regUser" runat="server" CssClass="form-control" ></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-info" ErrorMessage="Ingrese el Usuario" ControlToValidate="regUser"></asp:RequiredFieldValidator>
          <%--  <input type="text" class="form-control in" id="user">--%>
        </div>
        <div class="form-group">
            <label for="regPass" class="form-label h1 text-white">Contraseña</label>
			<asp:TextBox ID="regPass" runat="server" CssClass="form-control" TextMode="Password" Wrap="False" ></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="text-info" ErrorMessage="Ingrese la Contraseña" ControlToValidate="regPass"></asp:RequiredFieldValidator>
			<%--<input type="password" class="form-control in" id="pass">--%>
        </div>

        <div class="form-check text-white d-flex justify-content-center flex-wrap ml-2">
            <div class="d-block d-flex flex-row justify-content-between">
				<label for="terminos" class="ch1">Acepto Terminos y Condiciones</label>
				<asp:CheckBox ID="terminos" CssClass="form-check-input ml-3" runat="server" />
            </div>
				<div class="d-block d-flex justify-content-center">
				<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="text-info mb-1" ErrorMessage="Acepte Terminos" ControlToValidate="regPass"></asp:RequiredFieldValidator>
			</div>
			<%--<input type="checkbox" id="terminos" class="form-check-input ch" required>--%>

        </div>

		   <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary btn-block" Text="Registrar" OnClick="Button1_Click" />
		    <asp:Label ID="msg" runat="server" Text="" Visible="True" CssClass="h1 text-success text-center" OnDataBinding="Button1_Click"></asp:Label>
        <%--<button class="btn btn-primary btn-block" type="submit">Ingresar</button>--%>
       </div>
		
    </form>
		
		
		
	<script src="js/jquery-3.5.1.slim.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
