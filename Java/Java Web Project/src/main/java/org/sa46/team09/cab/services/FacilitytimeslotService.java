package org.sa46.team09.cab.services;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Booking;
import org.sa46.team09.cab.models.Facilitytimeslot;
import org.sa46.team09.cab.models.Slots;
import org.springframework.data.repository.query.Param;

/**
 * @author HMT and NNH(A0180529B) SA46T9
 * 2018 06 13
 */

public interface FacilitytimeslotService {
	
	Facilitytimeslot createFacilitytimeslot(Facilitytimeslot facilitytimeslot);
	
	//ArrayList<Facilitytimeslot> findAllFacilitytimeslot();
	
	ArrayList<Facilitytimeslot> findAllFacilitytimeslot();
	
	Facilitytimeslot findFirstByOrderByFacilityTimeSlotIdDesc(Facilitytimeslot facilitytimeslot);

	ArrayList<Facilitytimeslot> getSlotsByFacilityId(@Param("fId") int fId);
	
	
	ArrayList<Integer> getSlotsByBookings(Integer fId, String fromdate, String todate);
/*chandrika*/
	
	
	
}
