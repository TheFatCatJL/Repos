package org.sa46.team09.cab.services;

import java.util.ArrayList;
import org.sa46.team09.cab.models.Activity;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 12
 */

public interface ActivityService {
		
	ArrayList<Activity> findAllActivity();//All Activity
	
	Activity findActivity(Integer activityId);//Find by ID

}
