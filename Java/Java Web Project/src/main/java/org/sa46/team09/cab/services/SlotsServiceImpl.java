package org.sa46.team09.cab.services;

import java.util.ArrayList;

import javax.annotation.Resource;

import org.sa46.team09.cab.models.Slots;
import org.sa46.team09.cab.repositories.SlotsRepository;
import org.springframework.stereotype.Service;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 13
 */

@Service
public class SlotsServiceImpl implements SlotsService{
	
	@Resource
	private SlotsRepository slotsRepository;
	@Override
	public ArrayList<Slots> findAllSlots() {
		// TODO Auto-generated method stub
		ArrayList<Slots> sl= (ArrayList<Slots>) slotsRepository.findAll();
		return sl;
	}
	@Override
	public Slots findSlots(Integer flNo) {
		// TODO Auto-generated method stub
		return slotsRepository.findOne(flNo);
	}
	
	
	
}
