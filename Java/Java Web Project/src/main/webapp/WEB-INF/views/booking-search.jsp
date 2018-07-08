<%--- Author: HMT and NNH(A0180529B) SA46T9 - Date: June 11 2018--%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!-- add menu link enable disable by NNH June 17 2018 -->
<c:if test="${sessionScope.currentuser.memberType=='admin' || sessionScope.currentuser.memberType=='member'}">
<form:form method="POST" modelAttribute="booking"
	action="${pageContext.request.contextPath}/bookingcreate"
	class="form-horizontal" role="form">
	<div class="container">
		<div class="row">
			<div class="col-9" style="margin: auto; padding-top: 29px;">
				<div style="">
					<div class="dropdown" style="margin-right: 10px; width:35%;">

						<select name="facilityId"
							class="form-control float-left"
							
							data-toggle="dropdown" aria-expanded="false"
							style="background-color: rgba(0, 0, 0, 0.1); color: #222222; width:100%">

							<c:forEach items="${facilityList}" var="fac">
								<option value="${fac.facilityId}">
									<c:out value="${fac.facilityName}" /></option>

							</c:forEach>
						</select>


					</div>
					<div class="form-group">
					<input class="form-control"  style="width:30%; display:inline-block; margin-left:5px; margin-right:3px;" id="datepicker" type="date" name="bookingdate"
						required="required"><i sytle="display: inline-block; vertical-align: middle !important; margin: auto; padding-bottom: 7px;" class="fa fa-2x fa-calendar"></i>
					</div>
					
					<div class="btn-group" role="group">
						<input class="btn btn-info" type="submit"
							value="search" />

					</div>
				</div>
			</div>
		</div>
		<div style="height:30px"></div>
		<div class="features-boxed" style="border:1px solid #eeeeee; background-color:#fff;">
        <div class="container">
            <div class="intro">
                <h2 class="text-center">Features </h2>
                <p class="text-center"></p>
            </div>
            <div class="row justify-content-center features">
                <div class="col-sm-6 col-md-5 col-lg-4 item">
                    <div class="box"> 
                    	<img style="width:270px; height:180px;" src="${pageContext.request.contextPath}/image/AVdERWQ.jpg" >
                    	<h3>Basketball</h3>
                    </div>
                </div>
                <div class="col-sm-6 col-md-5 col-lg-4 item">
                    <div class="box"> 
                    	<img style="width:270px; height:180px;" src="${pageContext.request.contextPath}/image/meeting1.jpg" >
                    	<h3>Meeting Room</h3>
                    </div>
                </div>
                <div class="col-sm-6 col-md-5 col-lg-4 item">
                    <div class="box"> 
                    	<img style="width:270px; height:180px;" src="${pageContext.request.contextPath}/image/tennis.jpg" >
                    	<h3>Tennis</h3>
                    </div>
                </div>
            </div>
        </div>
    </div>
	</div>
</form:form>
</c:if>
<script type="text/javascript">
	$(function() {
		var dtToday = new Date();

		var month = dtToday.getMonth() + 1;
		var day = dtToday.getDate();
		var year = dtToday.getFullYear();
		var next7day = day + 7;
		if (month < 10)
			month = '0' + month.toString();
		if (day < 10)
			day = '0' + day.toString();

		var minDate = year + '-' + month + '-' + day;
		var maxDate = year + '-' + month + '-' + next7day;
		$('#datepicker').attr('min', minDate);
		$('#datepicker').attr('max', maxDate);

	});
</script>
