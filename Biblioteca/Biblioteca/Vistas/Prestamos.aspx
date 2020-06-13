<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prestamos.aspx.cs" Inherits="Biblioteca.Vistas.Prestamos" MasterPageFile="~/Vistas/Site.Master" %>

<asp:Content ContentPlaceHolderID="Main" runat="server">
	<div class="container">
		<div class="row my-2">
			<div class="col col-lg-10 mx-auto">
				<div class="card">
					<div class="card-header text-center h1 text-white  bg-dark">Prestamos</div>
					<div class="card-body  bg-dark">

						<div class="d-flex justify-content-end">
							<a href="#" class="btn btn-success my-1">Lista</a>
						</div>

						<form runat="server" id="addLibros" method="post" class="text-white">
			
							<div class="d-fles justify-content-center">
								<asp:Label Text="" runat="server" ID="msgPrestamo" CssClass="d-block text-center" Visible="false"></asp:Label>
								<asp:ValidationSummary runat="server" ID="sumaryPrestamos" DisplayMode="BulletList" CssClass="alert alert-danger" />
							</div>

							<div class="form-group">
								<label for="usuario" class="form-label">Documento del usuario (CEDULA)</label>
								<asp:TextBox runat="server" ID="usuario" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="usuario" ErrorMessage="El Documento es requerido" Display="None"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="libro" class="col-form-label">Libro (CÓDIGO)</label>
								<asp:TextBox runat="server" ID="libro" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="libro" ErrorMessage="El Llibro es requerido" Display="None">
								</asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="fechaInicio" class="form-label">Fecha de Inicio</label>
								<asp:Textbox runat="server" ID="fechaInicio" CssClass="form-control"></asp:Textbox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="fechaInicio" ErrorMessage="La Fecha de Inicio es requerida" Display="None"></asp:RequiredFieldValidator>
								<asp:RegularExpressionValidator runat="server" ControlToValidate="fechaInicio" ValidationExpression="\d{4}-\d{2}-\d{2}" ErrorMessage="La Fecha de Inicio tiene que estar en formato Año Mes Dia (2000-12-20)" Display="None"></asp:RegularExpressionValidator>
							</div>
								

							<div class="form-group">
								<label for="fechaFin" class="form-label">Fecha Fin</label>
								<asp:TextBox runat="server" ID="fechaFin" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="fechaFin" ErrorMessage="La Fecha de Fin es requerida" Display="None"></asp:RequiredFieldValidator>
								<asp:RegularExpressionValidator runat="server" ControlToValidate="fechaFin" ValidationExpression="\d{4}-\d{2}-\d{2}" Display="None" ErrorMessage="La Fecha de Fin tiene que estar en formato Año Mes Dia (2000-12-20)"></asp:RegularExpressionValidator>
							</div>

							<div class="form-group">
								<label for="diasSancion" class="form-label">Días de sanción</label>
								<asp:TextBox runat="server" ID="diasSancion" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="diasSancion" Display="None" ErrorMessage="Los Días de sanción son requeridos"></asp:RequiredFieldValidator>
								<asp:RegularExpressionValidator runat="server" ControlToValidate="diasSancion" Display="None" ValidationExpression="\d{1,3}" ErrorMessage="Los dias de sancón solo pueden ser numeros de maximo 3 caracteres"></asp:RegularExpressionValidator>
							</div>

							<div class="form-group">
								<label for="cantidad" class="col-form-label">Cantidad</label>
								<asp:TextBox runat="server" ID="cantidad" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="cantidad" Display="None" ErrorMessage="La Cantidad es requerida"></asp:RequiredFieldValidator>
								<asp:RegularExpressionValidator runat="server" ControlToValidate="cantidad" ValidationExpression="\d{1,9}" Display="None" ErrorMessage="La Cantidad solo pueden ser numeros desde 1 en adelante"></asp:RegularExpressionValidator>
							</div>

							<div class="card-footer">
								<asp:Button runat="server" ID="btnAgregar" OnClick="Agregar" CssClass="btn btn-success btn-block" Text="Agregar" />
							</div>

						</form>
					</div>
				</div>
			</div>
		</div>
	</div>

</asp:Content>

