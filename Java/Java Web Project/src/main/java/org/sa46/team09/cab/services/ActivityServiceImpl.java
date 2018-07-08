package org.sa46.team09.cab.services;

import java.util.ArrayList;

import javax.annotation.Resource;

import org.sa46.team09.cab.models.Activity;
import org.sa46.team09.cab.repositories.ActivityRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 12
 */

@Service
public class ActivityServiceImpl implements ActivityService{
	@Resource
	private ActivityRepository activityRepository;

	@Override
	@Transactional
	public ArrayList<Activity> findAllActivity() {
		ArrayList<Activity> ul = (ArrayList<Activity>) activityRepository.findAll();
		return ul;
	}
	
	@Override
	@Transactional
	public Activity findActivity(Integer activityId) {
		return activityRepository.findOne(activityId);

	}
}
