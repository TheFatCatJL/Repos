package org.sa46.team09.cab.repositories;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Facility;
import org.springframework.data.jpa.repository.JpaRepository;
/**
 * @author NNH SA46T9
 * 2018 06 12
 */
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

/**
 * @author NNH(A0180529B) and HMT SA46T9
 * 2018 06 12
 */
public interface FacilityRepository extends JpaRepository<Facility, Integer>{

	//Customize by NNH(A0180529B) June 12 2018
	@Query("select f from Facility f where f.isDeleted != true")
	ArrayList<Facility> findAllFacilityNotDeleted();
	
	//Customize by HMT June 12 2018
	@Query("SELECT f.activityId FROM Facility f WHERE f.facilityId=(:fId)")
	ArrayList<Integer> getActivityByFacilityId(@Param("fId") int fId);
	//Customize by HMT June 12 2018
	@Query("SELECT f FROM Facility f Order By f.activityId")
		ArrayList<Facility> getFacilityGroup();
	
}
