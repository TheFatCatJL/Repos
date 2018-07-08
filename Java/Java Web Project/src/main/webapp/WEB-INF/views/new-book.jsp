<%--- Author: HMT and NNH(A0180529B) SA46T9 - Date: June 11 2018--%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<div class="container">
	<div class="row">
		<div class="col-12" style="margin: auto; padding-top: 29px;">
			<div class="tab-content profile-page">
				<!-- PROFILE TAB CONTENT -->
				<div class="tab-pane profile active" id="profile-tab">
					<form:form method="POST" modelAttribute="booking"
						action="${pageContext.request.contextPath}/bookingcreate/add"
						class="form-horizontal" role="form">
						<fieldset>
							<h3>
								<i class="fa fa-square"></i>Facility Booking
							</h3>

							<div class="form-group">
								<label for="name" class="col-sm-3 control-label">Member
									Name</label>
								<div class="col-sm-4">
									<input type="hidden" style="display: none;" name="memberId"
										value="${user.memberId}" /> <input name="memberId"
										class="form-control"
										value="${user.firstName} ${user.lastName}" readonly="false" />
								</div>
							</div>


							<div class="form-group">
								<label for="name" class="col-sm-3 control-label">Facility
									Name</label>
								<div class="col-sm-4">
									<input type="hidden" style="display: none;" name="facilityId"
										value="${facility.facilityId}" /> <input name="facilityId"
										class="form-control" value="${facility.facilityName}"
										readonly="false" />
								</div>
							</div>
							<div class="form-group">
								<!-- <label for="name" class="col-sm-3 control-label">Activity</label> -->
								<div class="col-sm-4">
									<input type="hidden" style="display: none;" name="activityId"
										value="${activity.activityId}" />
									<%-- <input name="activityId"
							class="form-control" value="${activity.activityName}"
							readonly="false" /> --%>
								</div>
							</div>
							<div class="form-group">
								<label for="name" class="col-sm-3 control-label">Booking
									Date</label>
								<div class="col-sm-4">
									<form:hidden path="dateofBooking" value="${bDate }" />
									<input name=dateofBooking class="form-control"
										value="${bDate }" readonly="false" />
								</div>
							</div>


							<div class="form-group">
								<label for="name" class="col-sm-3 control-label">Please
									choose available time slot</label>
								<div class="col-sm-2">
									<form:select path="slotId" class="form-control"
										data-toggle="dropdown">
										<c:forEach items="${slot}" var="slots">
											<form:option value="${slots.slotId}">
												<c:out value="${slots.slotTimings}" />
											</form:option>
										</c:forEach>
									</form:select>
								</div>
							</div>
							<div class="form-group">
								<div class="col-sm-4">
									<c:choose>
										<c:when
											test="${sessionScope.currentuser.getMemberType() == 'admin' }">
											<input type="checkbox" name="maintenance" value="maintenance"> Maintenance
										</c:when>
									</c:choose>

								</div>
							</div>
							<div class="form-group">
								<div class="col-sm-4">

									<input type="submit" value="Book" class="btn btn-info"
										type="button"
										style="padding: 8px; margin-right: 0px; margin-left: 5px; width: 100px;" />
									<input value="Cancel" class="btn btn-info float-right"
										onclick="javascript:window.location.href ='${pageContext.request.contextPath}/booking-search';"
										type="button"
										style="padding: 8px; margin-right: 0px; margin-left: 5px; width: 100px;" />
								</div>
							</div>
						</fieldset>
						<hr />
					</form:form>
				</div>
			</div>
		</div>
	</div>
</div>

<script
	src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<script
	src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0/js/bootstrap.bundle.min.js"></script>
<script src="assets/js/script.min.js"></script>
