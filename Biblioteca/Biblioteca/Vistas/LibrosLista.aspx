<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/Vistas/LibrosLista.aspx.cs" Inherits="Biblioteca.Vistas.LibrosLista" MasterPageFile="~/Vistas/Site.Master" %>

<asp:Content ContentPlaceHolderID="Main" runat="server">

<div class="container">
		<div class="row my-3">
			<div class="col">
				<div class="card ">
					<div class="card-header h1 text-center text-white bg-dark">Libros</div>
					<div class="card-body bg-dark">

						<div class="d-flex justify-content-end">
							<a href="Libros.aspx" class="btn btn-success mb-2">Agregar</a>
						</div>
						
						<table class="table table-dark table-bordered table-hover table-responsive-lg w-100 table-active">

							<thead>
								<tr>
									
									<th>Código</th>
									<th>Nombre</th>
									<th>Páginas</th>
									<th>Autor</th>
									<th>Editorial</th>
									<th>Area</th>
									<th>Id</th>
									<th>Acciónes</th>
								</tr>
							</thead>

							<tbody>
								
							<% foreach (Entities.Libro lib in datos)
								{ %>
								
								<tr>
									<td> <% = lib.Codigo %> </td>
									<td> <% = lib.Nombre %> </td>
									<td> <% = lib.NumeroPaginas %> </td>
									<td> <% = lib.Autor %> </td>
									<td> <% = lib.Editorial %> </td>
									<td> <% = lib.Area%> </td>
									<td> <% = lib.Id %> </td>
									<td>
										<a href="LibrosActualizar.aspx?codigo=<% = lib.Codigo %>" class="btn btn-info">Actualizar</a>
										<a href="javascript:void(0)" onclick="eliminar('LibrosEliminar.aspx?codigo=<% = lib.Codigo %>')" class="btn btn-danger">Eliminar</a>
									</td>
								</tr>

							<%

								}%>

							</tbody>

						</table>

					</div>
				</div>
			</div>
		</div>
	</div>

	<script src="../js/funciones.js"></script>
	
</asp:Content>
