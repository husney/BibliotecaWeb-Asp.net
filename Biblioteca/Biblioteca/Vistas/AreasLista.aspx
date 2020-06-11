<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AreasLista.aspx.cs" Inherits="Biblioteca.Vistas.AreasLista" MasterPageFile="~/Vistas/Site.Master" %>


<asp:Content ContentPlaceHolderID="Main" runat="server">

	<div class="container">
		<div class="row my-3">
			<div class="col">
				<div class="card ">
					<div class="card-header h1 text-center text-white bg-dark">Areas</div>
					<div class="card-body bg-dark">

						<div class="d-flex justify-content-end">
							<a href="Areas.aspx" class="btn btn-success mb-2">Agregar</a>
						</div>
						
						<table class="table table-dark table-bordered table-hover table-responsive-lg w-100 table-active">

							<thead>
								<tr>
									<th>Código</th>
									<th>Nombre</th>
									<th>Creación</th>
									<th>ID</th>
									<th>Acciones</th>
								</tr>
							</thead>

							<tbody>
								
								<% foreach (Entities.Area list in lista)
									{ %>

									<tr>
										<td> <% = list.Codigo %> </td>
										<td> <% = list.Nombre %> </td>
										<td> <% = list.Tiempo %> </td>
										<td> <% = list.Id %> </td>
										<td>
											<a href="AreasActualizar.aspx?codigo=<% = list.Codigo %>" class="btn btn-info">Actualizar</a>
											<a href="javascript:void(0)" onclick="eliminar('AreasEliminar.aspx?codigo=<% = list.Codigo %>')" class="btn btn-danger">Eliminar</a>
										</td>
									</tr>

								<% } %>

							</tbody>

						</table>

					</div>
				</div>
			</div>
		</div>
	</div>


	<script src="../js/funciones.js"></script>
</asp:Content>