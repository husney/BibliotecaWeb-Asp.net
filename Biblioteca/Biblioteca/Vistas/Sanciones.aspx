<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sanciones.aspx.cs" Inherits="Biblioteca.Vistas.Sanciones" MasterPageFile="~/Vistas/Site.Master" %>

<asp:Content ContentPlaceHolderID="Main" runat="server">

		<div class="row my-2">
			<div class="col col-lg-10 mx-auto">
				<div class="card">
					<div class="card-header text-center h1 text-white  bg-dark">Sanciones</div>
					<div class="card-body  bg-dark">

						<div class="card text-center">
							<div class="card-body">Para hacer un cambio en una sanción es necesario actualizar al usuario, este modulo es solamente informativo de las sanciones, muchas gracias.</div>
						</div>

						<table class="table table-dark table-bordered table-hover table-responsive-lg w-100 table-active mt-3">

							<thead>
								<tr>
									<th>Cedula</th>
									<th>Nombre</th>
									<th>Dirección</th>
									<th>Telefono</th>
									<th>Correo</th>
									<th>Estado</th>
									<th>Id</th>
									<th>Código <br/> Prestamo</th>
									<th>Libro</th>
									<th>Días <br/> Sanción</th>
									<th>Cantidad</th>
								</tr>

							</thead>

							<tbody>

								<% foreach (Entities.Sancionados san in datos) { %>
									
										<tr>
											<td> <% = san.Usuario %> </td>
											<td> <% = san.Nombre %> </td>
											<td> <% = san.Direccion %> </td>
											<td> <% = san.Telefono %> </td>
											<td> <% = san.Correo %> </td>
											<td> <% = san.Estado %> </td>
											<td> <% = san.Id %> </td>
											<td> <% = san.CodigoPrestamo %> </td>
											<td> <% = san.Libro %> </td>
											<td> <% = san.DiasSancion %> </td>
											<td> <% = san.Cantidad %> </td>
										</tr>
								
								
								<% } %>

							</tbody>

						</table>

					</div>
				</div>
			</div>
		</div>

</asp:Content>