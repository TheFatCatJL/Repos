<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"%>
<%@ taglib prefix="s" uri="http://www.springframework.org/tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">

<link rel="stylesheet"
	href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
<link rel="stylesheet" href="/resources/demos/style.css">
<script src="https://code.jquery.com/jquery-1.12.4.js"></script>
<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
<script>
	$(function() {
		$("#fromdatepicker").datepicker(

		{
			dateFormat : "yy/mm/dd"
		});
		/*  onSelect: function(dateText, inst){
			
			$("#todatepicker").datepicker("option","minDate", $("#fromdatepicker").datepicker("getDate"));
		} */

	});
	$(function() {

		$("#todatepicker").datepicker({
			dateFormat : "yy/mm/dd"
		});
	})
</script>
<title>Search Booking</title>
</head>
<body>
	<div class="container">
		<div class="row">
			<div class="col-9" style="margin: auto; padding-top: 29px;">
			<!-- add menu link enable disable by NNH June 17 2018 -->
			<c:if test="${sessionScope.currentuser.memberType=='admin' || sessionScope.currentuser.memberType=='member'}">
				<form:form method="POST"
					action="${pageContext.request.contextPath}/searchresults.html">
					<h3>Search for your past bookings:</h3>
					<div class="form-group">
						Date from: <input name="fromdate" type="text" id="fromdatepicker" required="required"><i class="fa fa-2x fa-calendar"></i>						
					</div>
					<br>
					<div class="form-group">
						Date to: &nbsp;&nbsp;&nbsp;&nbsp;<input name="todate" type="text" id="todatepicker" required="required"><i class="fa fa-2x fa-calendar"></i>
					</div>
					<br>
					<div class="col-3">
					<input style="width: 100px;"
						class="btn btn-info" type="submit"
						name="Search">
					</div>
				</form:form>
				</c:if>
			</div>
		</div>
	</div>
</body>