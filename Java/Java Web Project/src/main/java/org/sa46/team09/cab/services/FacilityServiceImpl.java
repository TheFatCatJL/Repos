package org.sa46.team09.cab.services;

import java.util.ArrayList;

import javax.annotation.Resource;

import org.sa46.team09.cab.models.Facility;
import org.sa46.team09.cab.repositories.FacilityRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

/**
 * @author NNH(A0180529B) and Janelle SA46T9
 * 2018 06 12
 */
@Service
public class FacilityServiceImpl implements FacilityService{
	@Resource
	private FacilityRepository facilityRepository;
	
	@Override
	@Transactional
	public Facility createFacility(Facility facility) {
		return facilityRepository.saveAndFlush(facility);
	}
	
	@Override
	@Transactional
	public ArrayList<Facility> findAllFacility() {
		ArrayList<Facility> ul = (ArrayList<Facility>) facilityRepository.findAll();
		return ul;
	}
	
	@Override
	@Transactional
	public Facility findFacility(Integer facId) {
		return facilityRepository.findOne(facId);

	}
	
	@Override
	@Transactional
	public Facility changeFacility(Facility fact) {
		return facilityRepository.saveAndFlush(fact);
	}
	
	@Override
	@Transactional
	public void removeFacility(Facility facility) {
		facilityRepository.delete(facility);
	}
	
	@Override
	@Transactional
	public ArrayList<Facility> findAllFacilityNotDeleted() {
		ArrayList<Facility> ul = (ArrayList<Facility>) facilityRepository.findAllFacilityNotDeleted();
		return ul;
	}
	
	@Override
	public ArrayList<Integer> getActivityByFacilityId(Integer faId) {
		// TODO Auto-generated method stub
		return (ArrayList<Integer>) facilityRepository.getActivityByFacilityId(faId);
	}

	@Override
	public ArrayList<Facility> getFacilityGroup() {
		// TODO Auto-generated method stub
		ArrayList<Facility> fl = (ArrayList<Facility>) facilityRepository.getFacilityGroup();
		return fl;
	}
	
	
}
