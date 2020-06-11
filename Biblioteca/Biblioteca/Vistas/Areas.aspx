<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Areas.aspx.cs" Inherits="Biblioteca.Vistas.Areas" MasterPageFile="~/Vistas/Site.Master"  %>



<asp:Content ContentPlaceHolderID="Main" runat="server">
	<div class="container">
		<div class="row my-3">
			<div class="col col-lg-8 mx-auto">
				<div class="card bg-dark">
					<div class="card-header h1 text-white text-center">Areas</div>
					<div class="card-body">
						<form runat="server" id="addArea" class="text-white">

							<div class="d-flex justify-content-end">
								<a href="AreasLista.aspx" class="btn btn-success">Lista</a>
							</div>

							<div class="form-group">
								<asp:Label runat="server" ID="msgAddLibro" Visible="false"></asp:Label>
								<asp:ValidationSummary runat="server" ID="sumaryErrors" DisplayMode="BulletList" CssClass="alert alert-danger" />
							</div>

							<div class="form-group">
								<label for="addAreasCodigo" class="col-form-label">Código:</label>
								<asp:TextBox runat="server" ID="addAreasCodigo" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="addAreasCodigo" Display="None" ErrorMessage="El Código es requerido"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="addAreasNombre" class="form-label">Nombre:</label>
								<asp:TextBox runat="server" ID="addAreasNombre" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="addAreasNombre" Display="None" ErrorMessage="El Nombre es requerido"></asp:RequiredFieldValidator>
							</div>

							<div class="card-footer">
								<asp:Button runat="server" ID="btnAddArea" CssClass="btn btn-success btn-block" Text="Agregar" OnClick="registrar"/>
							</div>

						</form>
					</div>
				</div>
			</div>
		</div>
	</div>

</asp:Content>

