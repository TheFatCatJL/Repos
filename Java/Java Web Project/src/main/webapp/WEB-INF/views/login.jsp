<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%--- Author: Jason and NNH(A0180529B) SA46T9 - Date: June 11 2018--%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>


<html>
<spring:url value="/css/simple.css" var="style" />
<link rel="STYLESHEET" type="text/css" href="${style}" />
<%-- <form:form modelAttribute="user" method="POST" action="${pageContext.request.contextPath}/logincontrol" > --%>

<div class="register-photo" style="background-color: #eeeeee;">
	<div class="form-container">
		<div class="image-holder"
			style="background-image:url(${pageContext.request.contextPath}/image/AVdERWQ.jpg);"></div>
		<form:form method="POST" modelAttribute="user"
			action="${pageContext.request.contextPath}/logincontrol"
			class="form-horizontal" role="form">
			<fieldset>
				<h3>
					<i class="fa fa-at"></i> Log In!
				</h3>

				<div class="form-group">
					<label for="email" class="col-sm control-label">Email</label>
					<div class="col-sm">
						<form:input path="email" class="form-control" required="required" />
					</div>
				</div>
				<div class="form-group">
					<label for="password" class="col-sm control-label">Password</label>
					<div class="col-sm">
						<form:input path="password" class="form-control" type="password"
							required="required" />
					</div>
				</div>

				<div class="form-group">
					<!-- <label for="password" class="col-sm-3 control-label">Password</label> -->
					<div class="col-sm">
						<div class="display: inline-block">
							<form:button class="btn btn-secondary btn-lg btn-auth"
								type="submit">
								<i class="fa fa-arrow-circle-o-right"></i> Login</form:button>
							<form:button class="btn btn-secondary btn-lg btn-auth"
								type="reset">
								<i class="fa fa-spinner"></i> Clear</form:button>
						</div>
						<%-- <div class="display: inline-block">
						<form:button class="btn btn-custom-primary btn-lg btn-block btn-auth" type="reset"><i class="fa fa-spinner"></i> Clear</form:button>
					</div>	 --%>

					</div>
				</div>

			</fieldset>

		</form:form>
	</div>
</div>


</html>