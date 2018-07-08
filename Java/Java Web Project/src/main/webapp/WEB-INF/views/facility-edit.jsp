<%--- Author: NNH(A0180529B) and Janelle SA46T9 - Date: June 11 2018--%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>

<div class="tab-content profile-page">
	<!-- PROFILE TAB CONTENT -->
	<div class="tab-pane profile active" id="profile-tab">
		<form:form method="POST" modelAttribute="facility"
	action="${pageContext.request.contextPath}/fedit/${facility.facilityId}" class="form-horizontal" role="form">
			<fieldset>
				<h3>
					<i class="fa fa-square"></i>Update Facility
				</h3>
				<div class="form-group">
					<label for="facilityName" class="col-sm-3 control-label">Facility ID</label>
					<div class="col-sm-4">
						<form:input path="facilityId" type="text" id="facilityId"
							name="facilityId" class="form-control" readonly="true"></form:input>
					</div>
				</div>
				<div class="form-group">
					<label for="facilityName" class="col-sm-3 control-label">Facility Name</label>
					<div class="col-sm-4">
						<form:input path="facilityName" type="text" id="facilityName"
							name="facilityName" class="form-control"></form:input>
					</div>
				</div>
				<div class="form-group">
					<label for="activityid" class="col-sm-3 control-label">Activity</label>
					<div class="col-sm-4">
						<form:select path="activityId" class="form-control" data-toggle="dropdown">
				       		<form:options value="activityName" label="--- Select ---" />				       		
				       		<c:forEach items="${activity}" var="act">
						       <option value="${act.activityId}">
						       <c:out value="${act.activityName}" />
						       </option>
						    </c:forEach>
						</form:select>						
					</div>						
				</div>
				<%-- <div class="form-group">
					<label for="activityId" class="col-sm-3 control-label">Activity</label>
					<div class="col-sm-4">
						<form:input path="activityId" id="activityId"
							name="activityId" class="form-control"></form:input>
					</div>
				</div> --%>
		</fieldset>
		<div class="col-sm-4">
			<form:button type="submit" class="btn btn-info">
				<i class="fa fa-floppy-o"></i> Save Changes</form:button>
	
		<input type="button" value="Cancel" class="btn btn-info" onclick="javascript:window.location.href ='${pageContext.request.contextPath}/flist';">
		</div>
	</form:form>
</div>
</div>

