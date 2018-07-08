package org.sa46.team09.cab.models;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

/**
 * @author HMT SA46T9
 * 2018 06 11
 */

@Entity
@Table(name="slots")
public class Slots {
	@Id
	@Column(name = "slotid")	
	private int slotId;	
	
	@Column(name = "slottimings")
	private String slotTimings;

	public Slots() {
		super();
	}
	
	public Slots(int slotId) {
		this.slotId = slotId;
	}

	public Slots(int slotId, String slotTimings) {
		super();
		this.slotId = slotId;
		this.slotTimings = slotTimings;
		//this.booking = booking;
	}

	public int getSlotId() {
		return slotId;
	}

	public void setSlotId(int slotId) {
		this.slotId = slotId;
	}

	public String getSlotTimings() {
		return slotTimings;
	}

	public void setSlotTimings(String slotTimings) {
		this.slotTimings = slotTimings;
	}
	
}
