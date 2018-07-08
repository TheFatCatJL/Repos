<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%--- Author: HMT and NNH(A0180529B) SA46T9 - Date: June 11 2018--%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<html>

<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Successful Book</title>
<head>
	<div class="info-block" align="center">
		<h2>Successful Book</h2>
		<p>Your Booking is Successfully !!!</p>
		<input type="button" value="Back" class="btn btn-info" onclick="javascript:window.location.href ='${pageContext.request.contextPath}/booking-search';">
	</div>			
</head>
</html>
