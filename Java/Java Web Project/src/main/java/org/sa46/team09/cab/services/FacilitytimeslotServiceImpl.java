package org.sa46.team09.cab.services;

import java.util.ArrayList;

import javax.annotation.Resource;

import org.sa46.team09.cab.models.Facilitytimeslot;
import org.sa46.team09.cab.models.Slots;
import org.sa46.team09.cab.repositories.FacilitytimeslotRepository;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Service;

/**
 * @author HMT and NNH(A0180529B) SA46T9
 * 2018 06 13
 */

@Service
@Component
public class FacilitytimeslotServiceImpl implements FacilitytimeslotService {
	
	@Resource
	private FacilitytimeslotRepository facilityimeslotRepository;
	@Override
	public Facilitytimeslot createFacilitytimeslot(Facilitytimeslot facilitytimeslot) {
		// TODO Auto-generated method stub
		return facilityimeslotRepository.save(facilitytimeslot);
	}

	/*@Override
	public ArrayList<Facilitytimeslot> findAllFacilitytimeslot() {
		// TODO Auto-generated method stub
		return null;
	}*/
	
	@Override
	public ArrayList<Facilitytimeslot> findAllFacilitytimeslot() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Facilitytimeslot findFirstByOrderByFacilityTimeSlotIdDesc(Facilitytimeslot facilitytimeslot) {
		// TODO Auto-generated method stub
		return facilityimeslotRepository.findFirstByOrderByFacilityTimeSlotIdDesc();
	}

	@Override
	public ArrayList<Facilitytimeslot> getSlotsByFacilityId(int fId) {
		// TODO Auto-generated method stub
		return facilityimeslotRepository.getSlotsByFacilityId(fId);
	}

	@Override
	public ArrayList<Integer> getSlotsByBookings(Integer fId, String fromdate, String todate) {
		// TODO Auto-generated method stub
		return facilityimeslotRepository.getSlotsByBookings(fId, fromdate, todate);
	}
/*chandrika*/
	



	
	

}
