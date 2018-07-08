<%@ taglib uri="http://www.opensymphony.com/sitemesh/decorator"
	prefix="dec"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="spring" uri="http://www.springframework.org/tags"%>
<html>
<head>
<%@include file="Header.jsp"%>
<c:url value="/css/styles.min.css" var="ss" />
<link rel="STYLESHEET" type="text/css" href="${ss}" />
<dec:head />
</head>
<body>
	<%-- <table style="width: 100%">
		<tr>
			<td style="width: 180; border: 1" valign="top">
				<div>
					
					<%@ include file="Menu.jsp"%>
				</div>
			</td>
			<td> --%>
	<div class="container">
		<h3>
			<spring:message code="${bodyTitle}" />
		</h3>
		<dec:body />
	</div>
	<!-- 	</td>
		</tr>
	</table> -->

	<!-- ======== Footer ======== -->
	<div style="height:30px;"></div>
	<div class="footer-clean">
		<footer>
			<div class="container">
				<div class="row justify-content-center">
					<div class="col-sm-4 col-md-3 item">
						<h3>Services</h3>
						<ul>
							<li><a href="#">Facility Booking</a></li>
							<li><a href="#">Meeting Room</a></li>
							<li><a href="#">Sports</a></li>
						</ul>
					</div>
					<div class="col-sm-4 col-md-3 item">
						<h3>About</h3>
						<ul>
							<li><a href="#">Company</a></li>
							<li><a href="#">Team</a></li>
							<li><a href="#">Legacy</a></li>
						</ul>
					</div>
					<div class="col-sm-4 col-md-3 item">
						<h3>Careers</h3>
						<ul>
							<li><a href="#">Job openings</a></li>
							<li><a href="#">Employee success</a></li>
							<li><a href="#">Benefits</a></li>
						</ul>
					</div>
					<div class="col-lg-3 item social">
						<a href="#"><i class="icon ion-social-facebook"></i></a><a
							href="#"><i class="icon ion-social-twitter"></i></a><a href="#"><i
							class="icon ion-social-snapchat"></i></a><a href="#"><i
							class="icon ion-social-instagram"></i></a>
						<p class="copyright">Team 09 ~ SA46 © 2018</p>
					</div>
				</div>
			</div>
		</footer>
	</div>
	<script>
	$(document).ready( function () {
	    $('#myTable').DataTable();
	} );
	</script>
	 
</body>
</html>
