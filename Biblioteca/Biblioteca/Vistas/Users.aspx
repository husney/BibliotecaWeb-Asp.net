<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="Biblioteca.Users"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
	<div class="container">
		<div class="row">
			<div class="col-9 mx-auto">
				<div class="card">
					<div class="card-header bg-dark text-white text-center h1">Usuarios</div>
					<div class="card-body bg-dark ">
						<form id="formAddUser" runat="server" method="post" class="formUser text-white"><!--INICIO FORMULARIO ADD USERS-->

									<div class="d-flex justify-content-end my-1">
										<asp:Button runat="server" ID="userAgregar" CssClass="btn btn-success mr-1" Text="Agregar" />
										<asp:Button runat="server" ID="userListar" CssClass="btn btn-success" Text="Listar" />
									</div>

															<!--usuDocumento usuNombre usuDireccion usuTelefono usuCorreo usuEstado usuId--->
								<div class="form-group ">
											<label for="addUserDocumento" class="form-label">Documento (Cedula)</label>
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
									<asp:RequiredFieldValidator runat="server"
								</div>

								<div class="form-group">
											<label for="addUserCorreo" class="col-form-label">Correo:</label>
											<asp:TextBox runat="server" ID="addUserCorreo" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator runat="server" ControlToValidate="addUserCorreo" ErrorMessage="El Correo es requerido" Display="None"></asp:RequiredFieldValidator>
											<asp:RegularExpressionValidator runat="server" ControlToValidate="addUserCorreo" ValidationExpression="^[w-]+@[w-]+\.(com|net|org|edu)$" Display="None" ErrorMessage="El Correo no es valido"></asp:RegularExpressionValidator>
								</div>

								<div class="form-group">
											<asp:Label runat="server" ID="mensajeAddUser" Text="" CssClass="text-center d-block"></asp:Label>
											<asp:ValidationSummary runat="server" ID="validadorAddUser" DisplayMode="BulletList"  CssClass="alert alert-danger"/>
								</div>

								<asp:Button runat="server" ID="btnAddUser" CssClass="btn btn-success"  OnClick="agregarUser"/>

					</form><!--FIN FORMULARIO ADD USERS-->
				</div>	
			</div>
		</div>
	</div>

</asp:Content>
