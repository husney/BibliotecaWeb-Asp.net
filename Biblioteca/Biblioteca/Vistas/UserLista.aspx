<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLista.aspx.cs" Inherits="Biblioteca.Vistas.UserLista" MasterPageFile="~/Vistas/Site.Master"%>

<asp:Content ContentPlaceHolderID="Main" runat="server">

	<div class="container">
		<div class="row my-3">
			<div class="col-12  mx-auto">
				<div class="card">
					<div class="card-header bg-dark text-white text-center h1">Usuarios</div>
						<div class="card-body bg-dark" >
							<form runat="server" method="post" id="formListaUsers" >

							<div class="mb-4 d-flex justify-content-end">
									<a href="Users.aspx" class="btn btn-success">Agregar</a>
								</div>

							<table class="table table-dark table-bordered table-hover table-responsive-lg table-active w-100 ">
								
								<thead>
									<tr>
										<!-- usuDocumento, usuNombre, usuDireccion, usuTelefono, usuCorreo, usuEstado, usuId  -->
										<th>Documento</th>
										<th>Nombre</th>
										<th>Dirección</th>
										<th>Telefono</th>
										<th>Correo</th>
										<th>Estado</th>
										<th>Id</th>
										<th>Acciones</th>

									</tr>
								</thead>
								<tbody>
									<% foreach(Entities.Usuario us in usuarios) {
											%>
											
											<tr>
												<td> <% = us.Documento %> </td>
												<td> <% = us.Nombre %> </td>
												<td> <% = us.Direccion %> </td>
												<td> <% = us.Telefono %> </td>
												<td> <% = us.Correo %> </td>
												<td> <% = us.Estado %> </td>
												<td> <% = us.Id %> </td>
												<td class="d-flex justify-content-center flex-wrap">
													<a href="UserActualizar.aspx?documento=<% = us.Documento %>" class="btn btn-info mb-1 mr-1">Actualizar</a>
													<a href="javascript:void(0)" onclick="eliminar('UserEliminar.aspx?documento=<% = us.Documento %>')" class="btn btn-danger mb-1">Eliminar</a>
												</td>
											</tr>
									<%
										}%>
								</tbody>
							</table>

						</form>
					</div>
				</div>
			</div>
		</div>
	</div>


	<script src="../js/funciones.js"></script>

</asp:Content>

