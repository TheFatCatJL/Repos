package org.sa46.team09.cab.repositories;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Booking;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

/**
 * @author HMT and NNH(A0180529B) SA46T9
 * 2018 06 13
 */

public interface BookingRepository extends JpaRepository<Booking, Integer>{
	
	Booking findFirstByOrderByBookingIdDesc();
	
	
	@Query(value = "SELECT * from booking where memberid =:uid and dateofbooking between :fromdate and :todate", nativeQuery = true)
	ArrayList<Booking> findBookings(@Param("uid") int memberid, @Param("fromdate")String fromdate,@Param("todate")String todate);

	@Query(value ="Update booking set bookingstatus = false where bookingid =?1", nativeQuery = true)
	void cancelbooking( @Param("bookingId") int id);

	@Query(value = "SELECT * from booking where memberid =:uid and dateofbooking between :fromdate and :todate", nativeQuery = true)
	Booking findBooin(@Param("uid") int memberid, @Param("fromdate")String fromdate,@Param("todate")String todate);
}
