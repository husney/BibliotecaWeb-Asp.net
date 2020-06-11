<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="Biblioteca.Users"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
	<div class="container">
		<div class="row my-3">
			<div class="col-12 col-lg-9 mx-auto">
				<div class="card">
					<div class="card-header bg-dark text-white text-center h1">Usuarios</div>
					<div class="card-body bg-dark ">
						<form id="formAddUser" runat="server" method="post" class="formUser text-white"><!--INICIO FORMULARIO ADD USERS-->

									<div class="d-flex justify-content-end my-1 ">
										<!--<asp:Button runat="server" ID="userAgregar" CssClass="btn btn-success mr-1" Text="Agregar" />-->
										<%--<asp:Button runat="server" ID="userListar" CssClass="btn btn-success" Text="Listar" />--%>
										<a href="UserLista.aspx" class="btn btn-success my-1 mx-1">Lista</a>
										
									</div>
									
								<div class="form-group d-flex justify-content-center">
									<asp:Label runat="server" ID="mensajeAddUser" Text="" CssClass="text-center d-block" Visible="false" ></asp:Label>
								</div>
									
														
								<div class="form-group ">
											<label for="addUserDocumento" class="form-label" runat="server">Documento (Cedula)</label>
											<asp:TextBox runat="server" ID="addUserDocumento" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator ControlToValidate="addUserDocumento" Display="None" ErrorMessage="El Documento es requerido" runat="server"></asp:RequiredFieldValidator>
								</div>

								<div class="form-group">
											<label for="addUserNombre" class="form-label">Nombres:</label>
											<asp:TextBox ID="addUserNombre" runat="server" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator runat="server" ControlToValidate="addUserNombre" Display="None" ErrorMessage="El Nombre es requerido"></asp:RequiredFieldValidator>
								</div>

								<div class="form-group">
											<label for="addUserDireccion" class="col-form-label">Dirección:</label>
											<asp:TextBox runat="server" ID="addUserDireccion" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator runat="server" ControlToValidate="addUserDireccion" ErrorMessage="La Dirección es requerida" Display="None"></asp:RequiredFieldValidator>
								</div>

								<div class="form-group">
									<label for="addUserTelefono" class="form-label">Telefono:</label>
									<asp:TextBox runat="server" ID="addUserTelefono" CssClass="form-control"></asp:TextBox>
									<asp:RequiredFieldValidator runat="server" ControlToValidate="addUserTelefono" ErrorMessage="El Telefono es requerido" Display="None"></asp:RequiredFieldValidator>
								</div>

								<div class="form-group">
											<label for="addUserCorreo" class="col-form-label">Correo:</label>
											<asp:TextBox runat="server" ID="addUserCorreo" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator runat="server" ControlToValidate="addUserCorreo" ErrorMessage="El Correo es requerido" Display="None"></asp:RequiredFieldValidator>
											<asp:RegularExpressionValidator runat="server" ControlToValidate="addUserCorreo" ValidationExpression="^[\w-]+@[\w-]+\.(com|net|edu|org)$" Display="None" ErrorMessage="El Correo no es valido"></asp:RegularExpressionValidator>
								</div>

								<div class="form-group">
											
											<asp:ValidationSummary runat="server" ID="validadorAddUser" DisplayMode="BulletList"  CssClass="alert alert-danger"/>
								</div>

								<div class="card-footer d-flex justify-content-center text-white">
									<asp:Button runat="server" ID="btnAddUser" Text="Registrar" CssClass="btn btn-success btn-block"  OnClick="agregarUser"/>
								</div>

					</form><!--FIN FORMULARIO ADD USERS-->
				</div>	
			</div>
		</div>
	</div>

</asp:Content>
