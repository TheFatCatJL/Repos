package org.sa46.team09.cab.repositories;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Activity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 12
 */

public interface ActivityRepository extends JpaRepository<Activity, Integer>{
	@Query("SELECT DISTINCT a.activityId FROM Activity a")
	ArrayList<Activity> findAllActivityIDs();
	
}
