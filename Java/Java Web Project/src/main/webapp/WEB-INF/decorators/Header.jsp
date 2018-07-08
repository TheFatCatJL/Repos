<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">


<%--- Author: HMT  Date: June 17 2018--%>


<html>
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>CAB</title>

<link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0/css/bootstrap.min.css">
<link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
<link rel="stylesheet"
	href="https://fonts.googleapis.com/css?family=Bitter:400,700">
<link rel="stylesheet"
	href="${pageContext.request.contextPath}/css/stylesfacility.min.css">
<link rel="stylesheet"
	href="${pageContext.request.contextPath}/css/Features-Boxed.css">
<link rel="stylesheet"
	href="${pageContext.request.contextPath}/css/Footer-Clean.css">
<link rel="stylesheet"
	href="${pageContext.request.contextPath}/css/Header-Dark.css">
<link rel="stylesheet"
	href="${pageContext.request.contextPath}/css/Navigation-Clean.css">
<link rel="stylesheet"
	href="${pageContext.request.contextPath}/css/Registration-Form-with-Photo.css">
<link rel="stylesheet"
	href="${pageContext.request.contextPath}/css/styles.css">
<link rel="stylesheet"
	href="//cdn.datatables.net/1.10.18/css/jquery.dataTables.min.css">	
	<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0/js/bootstrap.bundle.min.js"></script>
    <script src="//cdn.datatables.net/1.10.18/js/jquery.dataTables.min.js"></script>
</head>
<body>
<body>
	<div>
		<nav class="navbar navbar-light navbar-expand-md navigation-clean"
			style="background-color:#444444;">
		<div class="container">
			<a class="navbar-brand" href="${pageContext.request.contextPath}/"
				style="color: rgb(249, 249, 249);">CAB</a>
			<button class="navbar-toggler" data-toggle="collapse"
				data-target="#navcol-1">
				<span class="sr-only">Toggle navigation</span><span
					class="navbar-toggler-icon"></span>
			</button>
			<div class="collapse navbar-collapse" id="navcol-1">
				<ul class="nav navbar-nav ml-auto">

					<c:choose>
						<c:when
							test="${sessionScope.currentuser.getMemberType() == 'admin' }">

							<li class="nav-item" role="presentation"><a class="nav-link"
								href="${pageContext.request.contextPath}/list"
								style="color: #ffffff;"><i class="fa fa-plus-square"></i>
									Member List</a></li>
						</c:when>
					</c:choose>
					<c:choose>
						<c:when
							test="${sessionScope.currentuser.getMemberType() == 'admin' }">

							<li class="nav-item" role="presentation"><a class="nav-link"
								href="${pageContext.request.contextPath}/fcreate"
								style="color: #ffffff;"><i class="fa fa-plus-square"></i>
									Add New Facility</a></li>
						</c:when>
					</c:choose>



					<c:choose>
						<c:when test="${sessionScope.currentuser.getMemberType() != null}">
							<li class="nav-item" role="presentation"><a class="nav-link"
								href="${pageContext.request.contextPath}/booking-search"
								style="color: #ffffff;"><i class="fa fa-bookmark"></i>
									Booking</a></li>
							<li class="nav-item" role="presentation"><a class="nav-link"
								href="${pageContext.request.contextPath}/searchbooking"
								style="color: #ffffff;"><i class="fa fa-bookmark"></i>
									Booking History</a></li>

						</c:when>
					</c:choose>

					<c:choose>
						<c:when test="${sessionScope.currentuser.getMemberType() == null}">
							<li class="nav-item" role="presentation"><a class="nav-link"
								href="${pageContext.request.contextPath}/login"
								style="color: #ebeff1;">Log in</a></li>
							<li class="nav-item" role="presentation"><a class="nav-link"
								href="${pageContext.request.contextPath}/create"
								style="color: #ffffff;">Sign up</a></li>
						</c:when>
					</c:choose>


					<c:choose>
						<c:when test="${sessionScope.currentuser.getMemberType() != null}">
							<li class="nav-item" role="presentation"><a class="nav-link"
								href="${pageContext.request.contextPath}/edit/${sessionScope.currentuser.getMemberId()}"
								style="color: #ebeff1;">Manage Profile</a></li>
						</c:when>
					</c:choose>
					<c:choose>
						<c:when test="${sessionScope.currentuser.getMemberType() != null}">
							<li class="nav-item" role="presentation"><a class="nav-link"
								href="${pageContext.request.contextPath}/logout"
								style="color: #ebeff1;">Log Out</a></li>

						</c:when>
					</c:choose>
					<li class="nav-item" role="presentation"><a class="nav-link"
						href="${pageContext.request.contextPath}/contact"
						style="color: #ffffff;">Contact us</a></li>
				</ul>

			</div>
		</div>
		</nav>
	</div>
</body>
</html>