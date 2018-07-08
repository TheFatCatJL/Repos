package org.sa46.team09.cab.repositories;

import java.util.ArrayList;

import org.sa46.team09.cab.models.Slots;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 13
 */

public interface SlotsRepository extends JpaRepository<Slots, Integer>{
	
 
}
