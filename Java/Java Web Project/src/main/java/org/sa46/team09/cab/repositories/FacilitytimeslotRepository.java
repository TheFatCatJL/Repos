package org.sa46.team09.cab.repositories;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Booking;
import org.sa46.team09.cab.models.Facilitytimeslot;
import org.sa46.team09.cab.models.Slots;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

/**
 * @author HMT and NNH(A0180529B) SA46T9
 * 2018 06 13
 */

public interface FacilitytimeslotRepository extends JpaRepository<Facilitytimeslot, Integer>{
	
	Facilitytimeslot findFirstByOrderByFacilityTimeSlotIdDesc();
	
	 
	
	@Query("SELECT s FROM Facilitytimeslot s WHERE s.facilityId=(:fId)")
	ArrayList<Facilitytimeslot> getSlotsByFacilityId(@Param("fId") int fId);
	
	//@Query(value = "SELECT  slotId from Facilitytimeslot where facilityId =:fid and bookDate= :bDate and isDeleted=false", nativeQuery = true)
	//ArrayList<Integer> getSlotsByBookings(@Param("aId")  int facilityId,@Param("bdate")String bdate);
	
	@Query(value = "SELECT slotId from Facilitytimeslot where facilityId =:fid and bookDate between :fromdate and :todate", nativeQuery = true)
	ArrayList<Integer> getSlotsByBookings(@Param("fid") int facilityId, @Param("fromdate")String fromdate,@Param("todate")String todate);

/*chandrika*/

	
	
	

}
