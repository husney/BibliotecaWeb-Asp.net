<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/Vistas/PrestamosLista.aspx.cs" Inherits="Biblioteca.Vistas.PrestamosLista" MasterPageFile="~/Vistas/Site.Master" %>

<asp:Content ContentPlaceHolderID="Main" runat="server">


		<div class="row my-3">
			<div class="col mx-5">
				<div class="card ">
					<div class="card-header h1 text-center text-white bg-dark">Prestamos</div>
					<div class="card-body bg-dark">

						<div class="d-flex justify-content-end">
							<a href="Prestamos.aspx" class="btn btn-success mb-2">Agregar</a>
						</div>
						
						<table class="table table-dark table-bordered table-hover table-responsive-lg w-100 table-active">

							<thead>
								<tr>
									

									<th>Código</th>
									<th>Usuario</th>
									<th>Libro</th>
									<th>Fecha Inicio</th>
									<th>Fecha Fin</th>
									<th>Dias de Sancion</th>
									<th>Cantidad</th>
									<th>Acciónes</th>
								</tr>
							</thead>

							<tbody>
							 
								<%  foreach (Entities.DetallePrestamos det in datos) {  %>
								
								
										<tr>
											<td> <% = det.Codigo %> </td>
											<td> <% = det.Usuario %> </td>
											<td> <% = det.Libro %> </td>
											<td> <% = det.FechaInicio %> </td>
											<td> <% = det.FechaFin %> </td>
											<td> <% = det.DiasSancion %> </td>
											<td> <% = det.Cantidad %> </td>
											<td>
												<a href="PrestamosActualizar.aspx?codigo=<% = det.Codigo %>" class="btn btn-info">Actualizar</a>
												<a href="javascript:void(0)" onclick="eliminar('PrestamosEliminar.aspx?codigo=<% = det.Codigo %>')" class="btn btn-danger">Eliminar</a>
											</td>
										</tr>
								


								<%  }  %>

							</tbody>

						</table>

					</div>
				</div>
			</div>
		</div>


	<script src="../js/funciones.js"></script>
	
	
</asp:Content>

