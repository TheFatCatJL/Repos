<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"%>
<%@ taglib prefix="s" uri="http://www.springframework.org/tags"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Booking details</title>
</head>
<body>
	<%-- <form:form method="POST" action="${pageContext.request.contextPath}/searchresults/.html" > --%>

	<table id="myTable" class="display">
		<thead>
			<tr>

				<th>Booking ID</th>
				<th>Member ID</th>
				<th>date of booking</th>
				<th>Slot id</th>
				<th>Booking status</th>
				<c:choose>
					<c:when
						test="${sessionScope.currentuser.getMemberType() == 'admin' }">
						<th>Maintenance status</th>
					</c:when>
				</c:choose>
				<th>Action</th>
			</tr>
		</thead>
		<tbody>
			<c:forEach var="booking" items="${bookings}">

				<tr>
					<td>${booking.bookingId}</td>
					<td>${booking.memberId}</td>
					<td>${booking.dateofBooking}</td>
					<td>${booking.slotId}</td>

					<td><c:choose>
							<c:when test="${booking.bookingstatus == true }">Booked</c:when>
							<c:otherwise>Cancelled</c:otherwise>
						</c:choose></td>
					<c:choose>
						<c:when
							test="${sessionScope.currentuser.getMemberType() == 'admin' }">
							<td><c:if test="${booking.maintenancestatus == true }">Under Maintenance </c:if>

							</td>
						</c:when>
					</c:choose>
					<td><c:choose>
							<c:when test="${booking.bookingstatus == true }">
								<a class="btn btn-info"
									href="<c:url value ='searchresults/${booking.bookingId}'/>">Cancel</a>
							</c:when>

						</c:choose></td>



				</tr>
			</c:forEach>
		</tbody>
	</table>
	<%-- </form:form>  --%>

</body>
</html>