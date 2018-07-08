package org.sa46.team09.cab.models;

import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import org.springframework.format.annotation.DateTimeFormat;

/**
 * @author HMT SA46T9
 * 2018 06 11
 */

@Entity
@Table(name="facilitytimeslot")
public class Facilitytimeslot {
	@Id
	@Column(name = "facilitytimeslotid")
	private int facilityTimeSlotId;
	
	@Column(name = "facilityid")
	private int facilityId;
	
	@Column(name = "slotid")
	private int slotId;
	
	@Column(name = "activityid")
	private int activityId;
	
	@Column(name = "isdeleted")
	 private Boolean isDeleted;
	
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date bookDate;
	
	public Boolean getIsDeleted() {
		return isDeleted;
	}

	public void setIsDeleted(Boolean isDeleted) {
		this.isDeleted = isDeleted;
	}

	public Date getBookDate() {
		return bookDate;
	}

	public void setBookDate(Date bookDate) {
		this.bookDate = bookDate;
	}

	public Facilitytimeslot() {
		super();
	}

	public Facilitytimeslot(int facilityTimeSlotId, int facilityId, int slotId, int activityId) {
		super();
		this.facilityTimeSlotId = facilityTimeSlotId;
		this.facilityId = facilityId;
		this.slotId = slotId;
		this.activityId = activityId;
	}

	public int getFacilityTimeSlotId() {
		return facilityTimeSlotId;
	}

	public void setFacilityTimeSlotId(int facilityTimeSlotId) {
		this.facilityTimeSlotId = facilityTimeSlotId;
	}

	public int getFacilityId() {
		return facilityId;
	}

	public void setFacilityId(int facilityId) {
		this.facilityId = facilityId;
	}

	public int getSlotId() {
		return slotId;
	}

	public void setSlotId(int slotId) {
		this.slotId = slotId;
	}

	public int getActivityId() {
		return activityId;
	}

	public void setActivityId(int activityId) {
		this.activityId = activityId;
	}
	
}
