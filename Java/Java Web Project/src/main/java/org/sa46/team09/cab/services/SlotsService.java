package org.sa46.team09.cab.services;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Slots;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 13
 */

public interface SlotsService {
	
	ArrayList<Slots> findAllSlots();
	Slots findSlots(Integer flNo);

}
