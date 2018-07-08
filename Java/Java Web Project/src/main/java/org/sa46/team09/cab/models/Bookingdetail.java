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
@Table(name="bookingdetail")
public class Bookingdetail {
	@Id
	@Column(name = "bookingdetailid")
	private int bookingDetailId;
	
	@Column(name = "bookingid")
	private int bookingId;
	
	@Column(name = "facilitytimeslotid")
	private int facilityTimeSlotId;
	
	public Bookingdetail() {
		super();
	}

	public Bookingdetail(int bookingDetailId, int bookingId, int facilityTimeSlotId) {
		super();
		this.bookingDetailId = bookingDetailId;
		this.bookingId = bookingId;
		this.facilityTimeSlotId = facilityTimeSlotId;
	}

	public int getBookingDetailId() {
		return bookingDetailId;
	}

	public void setBookingDetailId(int bookingDetailId) {
		this.bookingDetailId = bookingDetailId;
	}

	public int getBookingId() {
		return bookingId;
	}

	public void setBookingId(int bookingId) {
		this.bookingId = bookingId;
	}

	public int getFacilityTimeSlotId() {
		return facilityTimeSlotId;
	}

	public void setFacilityTimeSlotId(int facilityTimeSlotId) {
		this.facilityTimeSlotId = facilityTimeSlotId;
	}
	
}
