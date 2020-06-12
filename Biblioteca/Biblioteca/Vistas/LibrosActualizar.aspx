<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LibrosActualizar.aspx.cs" Inherits="Biblioteca.Vistas.LibrosActualizar" MasterPageFile="~/Vistas/Site.Master" %>

<asp:Content ContentPlaceHolderID="Main" runat="server">
	<div class="container">
		<div class="row my-2">
			<div class="col col-lg-10 mx-auto">
				<div class="card">
					<div class="card-header text-center h1 text-white  bg-dark">Libros</div>
					<div class="card-body  bg-dark">

						<div class="d-flex justify-content-end">
							<a href="LibrosLista.aspx" class="btn btn-success my-1">Lista</a>
						</div>

						<form runat="server" id="addLibros" method="post" class="text-white">
			


							<div class="d-flex justify-content-center">
								<asp:Label runat="server" ID="msgAddLibro" Visible="false" CssClass="text-center d-block"></asp:Label>
								<asp:ValidationSummary runat="server" ID="librosSummary" DisplayMode="BulletList" CssClass="alert alert-danger" />
							</div>
							

							<div class="form-group">
								<label for="actCodigo" class="form-label">Código</label>
								<asp:TextBox runat="server" ID="actCodigo" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator ControlToValidate="actCodigo" runat="server" Display="None" ErrorMessage="El Código es necesario"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="actNombre" class="col-form-label">Nombre</label>
								<asp:TextBox runat="server" ID="actNombre" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="actNombre" Display="None" ErrorMessage="El Nombre es requerido"></asp:RequiredFieldValidator>
							</div>
							
							<div class="form-group">
								<label for="actNumPag" class="form-label">Número de Páginas</label>
								<asp:TextBox runat="server" ID="actNumPag" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="actNumPag" Display="None" ErrorMessage="El Número de páginas es requerido"></asp:RequiredFieldValidator>
								<asp:RegularExpressionValidator runat="server" ControlToValidate="actNumPag" ValidationExpression="[0-9]{1,15}" ErrorMessage="Las páginas deben estar en formato de numero" Display="None"></asp:RegularExpressionValidator>
							</div>
						
							<div class="form-group">
								<label for="actAutor" class="form-label">Autor</label>
								<asp:TextBox runat="server" ID="actAutor" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="actAutor" Display="None" ErrorMessage="El Autor es requerido"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="actEditorial" class="form-label">Editorial</label>
								<asp:TextBox runat="server" ID="actEditorial" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="actEditorial" Display="None" ErrorMessage="La Editorial es requerida"></asp:RequiredFieldValidator>
								
							</div>

							<div class="form-group py-0">
								<label for="actArea" class="form-group p-0">Area</label>
								<asp:DropDownList ID="actArea" runat="server" CssClass="form-control"></asp:DropDownList>
							</div>

							<div class="card-footer">
									<asp:Button runat="server" ID="btnAddLibro" Text="Actualizar" OnClick="Actualizar" CssClass="btn btn-success btn-block" />
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
			editarLibro('<% = Codigo%>', '<% = Nombre%>', '<% = Paginas%>', '<% = Autor%>', '<% = Editorial %>')
		}
	</script>
</asp:Content>


