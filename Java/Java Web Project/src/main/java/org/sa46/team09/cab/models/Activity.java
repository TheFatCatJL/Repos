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
@Table(name="activity")
public class Activity {
	@Id
	@Column(name = "activityid")
	private int activityId;
	@Column(name = "activityname")
	private String activityName;
	
	public Activity() {
		super();
	}
	public Activity(String activityName) {
		super();
		this.activityName = activityName;
	}
	public int getActivityId() {
		return activityId;
	}
	public void setActivityId(int activityId) {
		this.activityId = activityId;
	}
	public String getActivityName() {
		return activityName;
	}
	public void setActivityName(String activityName) {
		this.activityName = activityName;
	}
	
}
