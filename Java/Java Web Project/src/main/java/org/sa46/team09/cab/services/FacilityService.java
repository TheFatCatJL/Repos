package org.sa46.team09.cab.services;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Facility;

/**
 * @author NNH(A0180529B) and Janelle SA46T9
 * 2018 06 12
 */
public interface FacilityService {

	Facility createFacility(Facility facility);//Insert
	
	ArrayList<Facility> findAllFacility();//All Facility
	
	Facility findFacility(Integer facId);//Find by ID
	
	Facility changeFacility(Facility factivity);//Update
	
	void removeFacility(Facility facility);//Delete
	
	ArrayList<Facility> findAllFacilityNotDeleted();//All Facility without deleted datas
	
	ArrayList<Integer> getActivityByFacilityId(Integer faId); //get activity by fac ID
	
	ArrayList<Facility> getFacilityGroup();//  group by facility name 
}
