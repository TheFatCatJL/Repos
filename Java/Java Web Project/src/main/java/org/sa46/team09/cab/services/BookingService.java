package org.sa46.team09.cab.services;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Booking;
import org.sa46.team09.cab.models.User;

/**
 * @author HMT and NNH(A0180529B) SA46T9
 * 2018 06 13
 */

public interface BookingService {
	
	Booking createBooking(Booking booking);
	
	ArrayList<Booking> findAllBookings();
	
	ArrayList<Booking> findAllBookingsById(Integer bookingId);
	
	Booking findFirstByOrderByBookingIdDesc(Booking booking);
	
	Booking changeBooking(Booking booking);//Update
	
	void removeBooking(Booking booking);//Delete
	
	Booking findBooking(Integer bookingId);//Find by ID
	
	ArrayList<Booking> findBookings(Integer uid, String fromdate, String todate);
	
	Booking findBookin(Integer uid, String fromdate, String todate);

	Booking findbooking(int bookingId);

	


}
