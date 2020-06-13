<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserActualizar.aspx.cs" Inherits="Biblioteca.Vistas.UserActualizar" MasterPageFile="~/Vistas/Site.Master" %>


<asp:Content ContentPlaceHolderID="Main" runat="server">

	<div class="container">
		<div class="row my-3">
			<div class="col-12 col-lg-11 mx-auto">
				<div class="card">
					<div class="card-header bg-dark text-white text-center h1">Usuario</div>
					<div class="card-body bg-dark">
						<form runat="server" method="post" class="text-white" id="actualizar">
							
									<div class="d-flex justify-content-end my-1 ">
										
										<a href="UserLista.aspx" class="btn btn-success my-1 mx-1">Lista</a>
										
									</div>
									
								<div class="form-group d-flex justify-content-center">
									<asp:Label runat="server" ID="mensajeAddUser" Text="" CssClass="text-center d-block" Visible="false" ></asp:Label>
									<asp:ValidationSummary runat="server" ID="validadorAddUser" DisplayMode="BulletList"  CssClass="alert alert-danger"/>
								</div>
									
														
								<div class="form-group ">
											<label for="editDocumento" class="form-label" runat="server">Documento (Cedula)</label>
											<asp:TextBox runat="server" ID="editDocumento" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator ControlToValidate="editDocumento" Display="None" ErrorMessage="El Documento es requerido" runat="server"></asp:RequiredFieldValidator>
								</div>

								<div class="form-group">
											<label for="editNombre" class="form-label">Nombres:</label>
											<asp:TextBox ID="editNombre" runat="server" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator runat="server" ControlToValidate="editNombre" Display="None" ErrorMessage="El Nombre es requerido"></asp:RequiredFieldValidator>
								</div>

								<div class="form-group">
											<label for="editDireccion" class="col-form-label">Dirección:</label>
											<asp:TextBox runat="server" ID="editDireccion" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator runat="server" ControlToValidate="editDireccion" ErrorMessage="La Dirección es requerida" Display="None"></asp:RequiredFieldValidator>
								</div>

								<div class="form-group">
									<label for="editTelefono" class="form-label">Telefono:</label>
									<asp:TextBox runat="server" ID="editTelefono" CssClass="form-control"></asp:TextBox>
									<asp:RequiredFieldValidator runat="server" ControlToValidate="editTelefono" ErrorMessage="El Telefono es requerido" Display="None"></asp:RequiredFieldValidator>
								</div>

								<div class="form-group">
											<label for="editCorreo" class="col-form-label">Correo:</label>
											<asp:TextBox runat="server" ID="editCorreo" CssClass="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator runat="server" ControlToValidate="editCorreo" ErrorMessage="El Correo es requerido" Display="None"></asp:RequiredFieldValidator>
											<asp:RegularExpressionValidator runat="server" ControlToValidate="editCorreo" ValidationExpression="^[\w-]+@[\w-]+\.(com|net|edu|org)$" Display="None" ErrorMessage="El Correo no es valido"></asp:RegularExpressionValidator>
								</div>

								<div class="form-group">
									<label for="editEstados" class="col-form-label">Estados:</label>
									<asp:DropDownList runat="server" ID="editEstados" CssClass="form-control">
										<asp:ListItem Value="Libre">Libre</asp:ListItem>
										<asp:ListItem Value="pazysalvo">Paz y salvo</asp:ListItem>
										<asp:ListItem Value="deudor">Deudor</asp:ListItem>
										<asp:ListItem Value="sancionado">Sancionado</asp:ListItem>
									</asp:DropDownList>
									<asp:RequiredFieldValidator runat="server" ControlToValidate="editEstados" ErrorMessage="El estado es requerido" Display="None" InitialValue="Libre" ></asp:RequiredFieldValidator>

								</div>

								<div class="form-group">
											
											
								</div>

								<div class="card-footer d-flex justify-content-center text-white">
									<asp:Button runat="server" ID="btnAddUser" Text="Actualizar" OnClick="Actualizar" CssClass="btn btn-success btn-block"  />
								</div>
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>

	<script src="../js/funciones.js"></script>
	<script>
		window.onload = function () {
			editar('<% = Documento %>', '<% = Nombre %>', '<% = Direccion%>' , '<% = Telefono%>', '<% = Correo%>', '<% = Estado %>')
		}

	</script>
</asp:Content>