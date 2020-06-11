<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="Biblioteca.Vistas.Libros" MasterPageFile="~/Vistas/Site.Master" %>

<asp:Content ContentPlaceHolderID="Main" runat="server">
	<div class="container">
		<div class="row my-2">
			<div class="col">
				<div class="card">
					<div class="card-header text-center h1 text-white  bg-dark">Libros</div>
					<div class="card-body  bg-dark">
						<form runat="server" id="addLibros" method="post" class="text-white">
							
							<!----LibCodigo libNombre libNumPag libAutor libEditorial libArea libId-->

							<div>
								<asp:Label runat="server" ID="msgAddLibro" Visible="false" CssClass="text-center d-block"></asp:Label>
								<asp:ValidationSummary runat="server" ID="librosSummary" DisplayMode="BulletList" CssClass="alert alert-danger" />
							</div>

							<div class="form-group">
								<label for="addCodigo" class="form-label">Código</label>
								<asp:TextBox runat="server" ID="addCodigo" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator ControlToValidate="addCodigo" runat="server" Display="None" ErrorMessage="El Código es necesario"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="addNombre" class="col-form-label">Nombre</label>
								<asp:TextBox runat="server" ID="addNombre" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="addNombre" Display="None" ErrorMessage="El Nombre es requerido"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="addNumPag" class="form-label">Número de Páginas</label>
								<asp:TextBox runat="server" ID="addNumPag" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="addNumPag" Display="None" ErrorMessage="El Número de páginas es requerido"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="addAutor" class="form-label">Autor</label>
								<asp:TextBox runat="server" ID="addAutor" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="addAutor" Display="None" ErrorMessage="El Autor es requerido"></asp:RequiredFieldValidator>
							</div>

							<div class="form-gorup">
								<label for="addEditorial" class="form-label">Editorial</label>
								<asp:TextBox runat="server" ID="addEditorial" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="addEditorial" Display="None" ErrorMessage="La Editorial es requeridad"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="addArea" class="form-group">Area</label>
								<asp:DropDownList ID="addArea" runat="server" CssClass="form-control"></asp:DropDownList>
								<%--<asp:RequiredFieldValidator runat="server" ControlToValidate="addArea" Display="None" ErrorMessage="El Area es requerida"></asp:RequiredFieldValidator>--%>
							</div>

						</form>
					</div>
				</div>
			</div>
		</div>
	</div>


</asp:Content>
