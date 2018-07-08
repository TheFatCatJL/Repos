<%--- Author: Jason and NNH(A0180529B) SA46T9 - Date: June 11 2018--%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ page import="org.sa46.team09.cab.models.User" %>
<html>
<spring:url value="/css/simple.css" var="style"/>
<link rel="STYLESHEET" type="text/css"
	href="${style}" />
<form:form method="POST" modelAttribute="user"
	action="${pageContext.request.contextPath}/changepass" class="form-horizontal" role="form">
	<fieldset>
			<h3>
				<i class="fa fa-unlock-alt"></i> Change Password!
			</h3>
			
			<div class="form-group">
				<label for="password" class="col-sm-3 control-label">Old Password</label>
				<div class="col-sm-4">
				
				<form:input path="password" class="form-control" />
			
				</div>
			</div>
			<div class="form-group">
				<label for="password" class="col-sm-3 control-label">New Password</label>
				<div class="col-sm-4">				
				
				<% User user = (User) request.getAttribute("user"); %>
				<% String email1=user.getEmail(); %>
				<% user.setEmail(""); %>
				<form:input path="email" class="form-control" type="password" required="required"  />
						
				</div>
			</div>
				<% user.setEmail(email1); %>
				
			<div class="form-group">
				<div class="col-sm-4">
					<div class="display: inline-block">
						<form:button class="btn btn-custom-primary btn-lg btn-block btn-auth" type="submit"><i class="fa fa-floppy-o"></i> Save Change</form:button>
						<form:button class="btn btn-custom-primary btn-lg btn-block btn-auth" type="reset"><i class="fa fa-spinner"></i> Clear</form:button>
					</div>								
				</div>
			</div>			
			</fieldset>	
</form:form>
</html>