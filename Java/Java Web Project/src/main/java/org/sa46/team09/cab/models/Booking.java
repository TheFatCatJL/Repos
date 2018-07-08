package org.sa46.team09.cab.models;

import java.util.ArrayList;
import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

import org.springframework.format.annotation.DateTimeFormat;

/**
 * @author HMT SA46T9
 * 2018 06 11
 */

@Entity
@Table(name="booking")
public class Booking {
	@Id
	@Column(name = "bookingid")
	private int bookingId;
	
	@Column(name = "memberid")
	private int memberId;
	@Temporal(TemporalType.DATE)
	@Column(name = "dateofbooking")
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date dateofBooking;
	@Column(name = "slotid")
	private int slotId;

	@Column(name ="bookingstatus")
	private boolean bookingstatus;
	
	@Column(name="maintenancestatus")
	private boolean maintenancestatus;
	
	public boolean isBookingstatus() {
		return bookingstatus;
	}

	public void setBookingstatus(boolean bookingstatus) {
		this.bookingstatus = bookingstatus;
	}

	public boolean isMaintenancestatus() {
		return maintenancestatus;
	}

	public void setMaintenancestatus(boolean maintenancestatus) {
		this.maintenancestatus = maintenancestatus;
	}

	public Booking() {
		
	}

	public Booking(int bookingId, int memberId, Date dateofBooking, ArrayList<Slots> events) {
		super();
		this.bookingId = bookingId;
		this.memberId = memberId;
		this.dateofBooking = dateofBooking;
		//this.slots.addAll(slots);
	}

	public int getBookingId() {
		return bookingId;
	}

	public void setBookingId(int bookingId) {
		this.bookingId = bookingId;
	}

	public int getMemberId() {
		return memberId;
	}

	public void setMemberId(int memberId) {
		this.memberId = memberId;
	}

	public Date getDateofBooking() {
		return dateofBooking;
	}

	public void setDateofBooking(Date dateofBooking) {
		this.dateofBooking = dateofBooking;
	}

	public int getSlotId() {
		return slotId;
	}

	public void setSlotId(int slotId) {
		this.slotId = slotId;
	}
	
}
