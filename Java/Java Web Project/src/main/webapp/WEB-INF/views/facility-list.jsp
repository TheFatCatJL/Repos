<%--- Author: NNH(A0180529B) and Janelle SA46T9 - Date: June 11 2018--%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/functions" prefix="fn"%>

<div class="content">	
	<div class="main-content">
		<div class="widget widget-table">			
			<div class="widget-header">
				<h3>
					<i class="fa fa-table"></i> FacilityList
				</h3>
				
			</div>
			<!-- SHOW HIDE COLUMNS DATA TABLE -->
			<div class="widget-content">
				<table id="myTable" 
					class="display table table-sorting table-striped table-hover datatable">
					<thead>
						<tr>				
							
							<th>Facility Name</th>					
							<th>Activity</th>
							<th></th>
							<th></th>
							<%-- <c:if test="${sessionScope.currentuser.type=='Admin'}">
								<th></th>
								<th></th>
							</c:if> --%>
						</tr>
					</thead>
					<tbody>
						<c:forEach var="fac" items="${facilityList}">
							<tr>								
								<td>${fac.facilityName}</td>
								<td>${fac.activityId}</td>
								<td align="center"><i class="fa fa-edit"></i><a class="btn btn-block btn-custom-secondary"
									href="${pageContext.request.contextPath}/fedit/${fac.facilityId}">Edit</a></td>
								<td align="center"><i class="fa fa-trash"></i><a class="btn btn-block btn-custom-primary"
									href="${pageContext.request.contextPath}/fdelete/${fac.facilityId}">Delete</a></td>
																					
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
				
				
			</div>
			<!-- END SHOW HIDE COLUMNS DATA TABLE -->
			<a class="btn btn-info" href ="${pageContext.request.contextPath}/fcreate">Cancel</a>
		</div>
	</div>
</div>
