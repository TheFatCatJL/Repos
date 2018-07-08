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
	action="${pageContext.request.contextPath}/create" class="form-horizontal" role="form">
			<fieldset>
				<h3>
					<i class="fa fa-square"></i>Member Information
				</h3>
<%-- 				<div class="form-group">
					<label for="name" class="col-sm-3 control-label">Member Id</label>
					<div class="col-sm-4">
					<form:input path="memberId" class="form-control" readonly="true"/>						
					</div>
				</div> --%>				
				<div class="form-group">
					<label for="firstname" class="col-sm-3 control-label">First Name</label>
					<div class="col-sm-4">
					<form:input path="firstName" class="form-control" required="required"/>						
					</div>
				</div>
				<div class="form-group">
					<label for="lastname" class="col-sm-3 control-label">Last Name</label>
					<div class="col-sm-4">
					<form:input path="lastName" class="form-control" required="required"/>						
					</div>
				</div>
				<div class="form-group">
					<label for="email" class="col-sm-3 control-label">Email</label>
					<div class="col-sm-4">
					<form:input path="email" class="form-control" required="required"/>						
					</div>
				</div>
				<div class="form-group">
					<label for="password" class="col-sm-3 control-label">Password</label>
					<div class="col-sm-4">
					<form:input path="password" class="form-control" type="password" required="required"/>						
					</div>
				</div>
				<div class="form-group">
				<label for="memberType" class="col-sm-3 control-label">Member Type</label>
					<div class="col-sm-2">
						<form:select path="memberType"
							style="background-color:#dae0e5;" class="form-control" data-toggle="dropdown">
							<form:option value="member" label="Member" />
						</form:select>
					</div>						
				</div>
				<%-- <div class="form-group">
					<label for="memberType" class="col-sm-3 control-label">Member Type</label>
					<div class="col-sm-4">
					<form:input path="memberType" class="form-control" required="required"/>						
					</div>
				</div> --%>
				<div class="form-group">
					<label for="mobile" class="col-sm-3 control-label">Moblie No.</label>
					<div class="col-sm-4">
					<form:input path="mobile" class="form-control" required="required"/>						
					</div>
				</div>
						
			</fieldset>
			
			
				<div class="form-group">
				<div class="col-sm-4">
					<input type="submit" value="Create" class="btn btn-info" />
					<!-- add menu link enable disable by NNH June 17 2018 -->
					<c:if test="${sessionScope.currentuser.memberType=='admin'}">
						<input type="button" value="Cancel" class="btn btn-info" onclick="javascript:window.location.href ='${pageContext.request.contextPath}/list';">
					</c:if>
				</div>
				</div>
			
			<%-- <div>
				<a class="btn btn-block label-with-btn" href = "${pageContext.request.contextPath}/list"><button type="button" class="btn btn-default"><i class="fa fa-plus-square"></i>Member List</button></a>
			</div> --%>
		
</form:form>
	</div>
</div>

