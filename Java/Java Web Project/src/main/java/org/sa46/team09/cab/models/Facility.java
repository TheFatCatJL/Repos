package org.sa46.team09.cab.models;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 11
 */

@Entity
@Table(name="facility")
public class Facility {
	@Id
	@Column(name = "facilityid")
	private int facilityId;	
	@Column(name = "facilityname")
	private String facilityName;
	@Column(name = "activityid")
	private int activityId;
	@Column(name = "isdeleted")
	private Boolean isDeleted;
	
	public Facility() {
		super();
	}

	public Facility(int facilityId, String facilityName, int activityId ,Boolean isDeleted) {
		super();
		this.facilityId = facilityId;
		this.facilityName = facilityName;
		this.activityId = activityId;
		this.isDeleted = isDeleted;
	}

	public int getFacilityId() {
		return facilityId;
	}

	public void setFacilityId(int facilityId) {
		this.facilityId = facilityId;
	}

	public String getFacilityName() {
		return facilityName;
	}

	public void setFacilityName(String facilityName) {
		this.facilityName = facilityName;
	}

	public int getActivityId() {
		return activityId;
	}

	public void setActivityId(int activityId) {
		this.activityId = activityId;
	}

	public Boolean getIsDeleted() {
		return isDeleted;
	}

	public void setIsDeleted(Boolean isDeleted) {
		this.isDeleted = isDeleted;
	}
		
}
