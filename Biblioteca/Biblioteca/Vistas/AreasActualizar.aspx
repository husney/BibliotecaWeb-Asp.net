<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AreasActualizar.aspx.cs" Inherits="Biblioteca.Vistas.AreasActualizar" MasterPageFile="~/Vistas/Site.Master" %>

<asp:Content ContentPlaceHolderID="Main" runat="server">
	<div class="container">
		<div class="row my-3">
			<div class="col col-8 mx-auto">
				<div class="card">
					<div class="card-header text-center h1 text-white bg-dark">Actualizar Area</div>
					<div class="card-body bg-dark">
						<form runat="server" id="ActualizarArea" class="text-white">

							<div>
								<asp:Label runat="server" ID="msgActualizar" CssClass="text-center d-block" Visible="false" ></asp:Label>
								<asp:ValidationSummary runat="server" DisplayMode="BulletList" CssClass="alert alert-danger" ID="sumaryErrors" />
							</div>

							<div class="form-group">
								<label for="actualizarCod" class="col-form-label">Código</label>
								<asp:TextBox runat="server" ID="actualizarCod" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="actualizarCod" Display="None" ErrorMessage="El Código es requerido"></asp:RequiredFieldValidator>
							</div>

							<div class="form-group">
								<label for="acutalizarNomb" class="col-form-label">Nombre</label>
								<asp:TextBox runat="server" ID="actualizarNomb" CssClass="form-control"></asp:TextBox>
								<asp:RequiredFieldValidator runat="server" ControlToValidate="actualizarNomb" Display="None" ErrorMessage="El Nombre es requerido"></asp:RequiredFieldValidator>
							</div>

							<div class="card-footer">
								<asp:Button runat="server" CssClass="btn btn-success btn-block" OnClick="Actualizar" id="btnActualizar" Text="Actualizar"/>
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
			editarArea('<% = this.Codigo %>', '<% = this.Nombre%>')
		}
	</script>
</asp:Content>

