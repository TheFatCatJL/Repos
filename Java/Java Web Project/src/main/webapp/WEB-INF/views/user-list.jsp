<%--- Author: NNH(A0180529B) SA46T9 - Date: June 11 2018--%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/functions" prefix="fn"%>

<div class="content">
	<div class="row">
		<div class="col-12">
			<div class="main-content">
				<div class="widget widget-table">
					<div class="widget-header">
						<h3>
							<i class="fa fa-table"></i> MemberList
						</h3>
					</div>
					<!-- SHOW HIDE COLUMNS DATA TABLE -->
					<div class="widget-content">
						<table id="myTable" class="display">
							<thead>
								<tr>
									<th>Member Type</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Email</th>
									<th>Mobile No.</th>
									<th></th>
									<th></th>
									<%-- <c:if test="${sessionScope.currentuser.type=='Admin'}">
								<th></th>
								<th></th>
							</c:if> --%>
								</tr>
							</thead>
							<tbody>
								<c:forEach var="prod" items="${userList}">
									<tr>
										<td>${prod.memberType}</td>
										<td>${prod.firstName}</td>
										<td>${prod.lastName}</td>
										<td>${prod.email}</td>
										<td>${prod.mobile}</td>
										<td align="center"><i class="fa fa-edit"></i><a
											class="btn btn-block btn-custom-secondary"
											href="${pageContext.request.contextPath}/edit/${prod.memberId}">Edit</a></td>
										<td align="center"><i class="fa fa-trash"></i><a
											class="btn btn-block btn-custom-primary"
											href="${pageContext.request.contextPath}/delete/${prod.memberId}">Delete</a></td>

										<%-- <c:if test="${sessionScope.currentuser.type=='Admin'}">
									<td align="center"><a class="btn btn-block btn-custom-secondary"
										href="${pageContext.request.contextPath}/admin/customer/edit/${prod.id}.html">Edit</a></td>
									<td align="center"><a class="btn btn-block btn-custom-primary"
										href="${pageContext.request.contextPath}/admin/customer/delete/${prod.id}.html">Delete</a></td>
								</c:if> --%>
									</tr>
								</c:forEach>
							</tbody>
						</table>
						<table id="datatable-column-interactive"
							class="table table-sorting table-striped table-hover datatable">
							
						</table>
					</div>
					<!-- END SHOW HIDE COLUMNS DATA TABLE -->
					<%-- <a class="btn btn-block label-with-btn" href = "${pageContext.request.contextPath}/create"><button type="button" class="btn btn-default"><i class="fa fa-plus-square"></i>Add a New Member</button></a> --%>
				</div>
			</div>
		</div>
	</div>
</div>
