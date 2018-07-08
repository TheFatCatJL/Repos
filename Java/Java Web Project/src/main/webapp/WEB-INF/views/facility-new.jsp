<%--- Author: NNH(A0180529B) and Janelle SA46T9 - Date: June 12 2018--%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>

<div class="tab-content profile-page">
	<!-- PROFILE TAB CONTENT -->
	<div class="tab-pane profile active" id="profile-tab">
		<!-- add menu link enable disable by NNH June 17 2018 -->
		<c:if test="${sessionScope.currentuser.memberType=='admin'}">
			<div class="form-group" style="float:right;">
				<div class="col-sm-4">
					<a class="btn btn-info"
						href="${pageContext.request.contextPath}/flist">View All
						Facility</a>
				</div>
			</div>
			<form:form method="POST" modelAttribute="facility"
				action="${pageContext.request.contextPath}/fcreate"
				class="form-horizontal" role="form">
				<fieldset>
					<h3>
						<i class="fa fa-square"></i>Facility Information
					</h3>
					<div class="form-group">
						<label for="facilityname" class="col-sm-3 control-label">Facility
							Name</label>
						<div class="col-sm-4">
							<form:input path="facilityName" class="form-control"
								required="required" />
						</div>
					</div>

					<div class="form-group">
						<label for="activityid" class="col-sm-3 control-label">Activity</label>
						<div class="col-sm-3">
							<form:select path="activityId" class="form-control"
								data-toggle="dropdown">
								<%-- <form:options value="activityName" label="--- Select ---" /> --%>
								<c:forEach items="${activity}" var="act">
									<option value="${act.activityId}">
										<c:out value="${act.activityName}" /></option>
								</c:forEach>
							</form:select>
						</div>
					</div>

				</fieldset>


				<div class="form-group">
					<div class="col-sm-4">
						<input type="submit" value="Create" class="btn btn-info" /> <input
							type="button" value="Cancel" class="btn btn-info "
							onclick="javascript:window.location.href ='${pageContext.request.contextPath}/flist';">
					</div>
				</div>

				<%-- <div>
				<a class="btn btn-block label-with-btn" href = "${pageContext.request.contextPath}/list"><button type="button" class="btn btn-default"><i class="fa fa-plus-square"></i>Member List</button></a>
			</div> --%>

			</form:form>
		</c:if>
	</div>
</div>

