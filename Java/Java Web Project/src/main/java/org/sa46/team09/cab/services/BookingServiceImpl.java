package org.sa46.team09.cab.services;

import java.util.ArrayList;

import javax.annotation.Resource;

import org.sa46.team09.cab.models.Booking;
import org.sa46.team09.cab.models.User;
import org.sa46.team09.cab.repositories.BookingRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

/**
 * @author HMT and NNH(A0180529B) SA46T9
 * 2018 06 13
 */

@Service
public class BookingServiceImpl implements BookingService{
	
@Resource
	
	private BookingRepository bookingRepository;

	@Override
	public Booking createBooking(Booking booking) {
		// TODO Auto-generated method stub
		return bookingRepository.save(booking);
	}

	/*@Override
	public ArrayList<Booking> findAllBookings() {
		// TODO Auto-generated method stub
		return null;
	}*/
	
	@Override
	public Booking findFirstByOrderByBookingIdDesc(Booking booking) {
		// TODO Auto-generated method stub
		
		return bookingRepository.findFirstByOrderByBookingIdDesc();
	}

	@Override
	@Transactional
	public ArrayList<Booking> findAllBookings() {
		ArrayList<Booking> bl = (ArrayList<Booking>) bookingRepository.findAll();
		return bl;
	}

	@Override
	@Transactional
	public Booking changeBooking(Booking booking) {
		return bookingRepository.saveAndFlush(booking);
	}

	@Override
	@Transactional
	public void removeBooking(Booking booking) {
		bookingRepository.delete(booking);
		
	}

	@Override
	public Booking findBooking(Integer bookingId) {
		return bookingRepository.findOne(bookingId);
	}

	@Override
	public ArrayList<Booking> findAllBookingsById(Integer bookingId) {
		ArrayList<Booking> bl = (ArrayList<Booking>) bookingRepository.findAll();
		ArrayList<Booking> bl2 = new ArrayList<Booking>();
		int i = 0;
		for(Booking book : bl) 
		{
			i = book.getBookingId();
			if(i == bookingId)
				bl2.add(book);
		}		
		return bl2;
	}
	
	@Override
	@Transactional
	public ArrayList<Booking> findBookings(Integer uid, String fromdate, String todate) {
	
		ArrayList<Booking> booking = bookingRepository.findBookings(uid, fromdate, todate);
		return booking;
	}

	@Override
	@Transactional
	public Booking findbooking(int bookingId) {
		// TODO Auto-generated method stub
		return bookingRepository.findOne(bookingId);
	}

	@Override
	public Booking findBookin(Integer uid, String fromdate, String todate) {
		// TODO Auto-generated method stub
		return bookingRepository.findBooin(uid, fromdate, todate);
	}
	
	

}
