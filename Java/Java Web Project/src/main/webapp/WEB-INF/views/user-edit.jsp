<%--- Author: NNH(A0180529B) SA46T9 - Date: June 11 2018--%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>

<div class="tab-content profile-page">
	<!-- PROFILE TAB CONTENT -->
	<div class="tab-pane profile active" id="profile-tab">
		<form:form method="POST" modelAttribute="user"
			action="${pageContext.request.contextPath}/edit/${user.memberId}"
			class="form-horizontal" role="form">
			<fieldset>
				<h3>
					<i class="fa fa-square"></i>Update My Profile
				</h3>
				<div class="form-group">
					<label for="firstName" class="col-sm-3 control-label">First
						Name</label>
					<div class="col-sm-4">
						<form:input path="firstName" type="text" id="firstName"
							name="firstName" class="form-control"></form:input>
					</div>
				</div>
				<div class="form-group">
					<label for="lastName" class="col-sm-3 control-label">Last
						Name</label>
					<div class="col-sm-4">
						<form:input path="lastName" type="text" id="lastName"
							name="lastName" class="form-control"></form:input>
					</div>
				</div>
				<div class="form-group">
					<label for="memberType" class="col-sm-3 control-label">Member
						Type</label>
					<div class="col-sm-4">
						<form:input path="memberType" type="text" id="memberType"
							name="memberType" class="form-control"></form:input>
					</div>
				</div>
				<div class="form-group">
					<label for="email" class="col-sm-3 control-label">Email</label>
					<div class="col-sm-4">
						<form:input path="email" type="text" id="email" name="email"
							class="form-control"></form:input>
					</div>
				</div>
				<div class="form-group">
					<label for="password" class="col-sm-3 control-label">Password</label>
					<div class="col-sm-4">
						<form:input path="password" class="form-control" type="password"
							readonly="true" />
					</div>
				</div>
				<div class="form-group">
					<label for="mobile" class="col-sm-3 control-label">Mobile
						No.</label>
					<div class="col-sm-4">
						<form:input path="mobile" type="text" id="mobile" name="mobile"
							class="form-control"></form:input>
					</div>
				</div>
			</fieldset>
			<i class="fa fa-unlock-alt"></i>
			<a href="${pageContext.request.contextPath}/changepw"
				style="color: red;">Change Password</a>
			<br />
			<form:button type="submit" class="btn btn-custom-primary">
				<i class="fa fa-floppy-o"></i> Save Changes</form:button>
			<c:choose>
				<c:when
					test="${sessionScope.currentuser.getMemberType() == 'admin' }">
					<input type="button" value="Cancel" class="btn btn-custom-primary"
						onclick="javascript:window.location.href ='${pageContext.request.contextPath}/list';">
				</c:when>
			</c:choose>
		</form:form>
	</div>
</div>

