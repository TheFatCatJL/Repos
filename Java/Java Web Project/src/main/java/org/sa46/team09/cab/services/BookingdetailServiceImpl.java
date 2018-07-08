package org.sa46.team09.cab.services;

import javax.annotation.Resource;

import org.sa46.team09.cab.models.Bookingdetail;
import org.sa46.team09.cab.repositories.BookingdetailRepository;
import org.springframework.stereotype.Service;

/**
 * @author HMT and NNH(A0180529B) SA46T9
 * 2018 06 13
 */
@Service
public class BookingdetailServiceImpl implements BookingdetailService {
	
	@Resource
	private BookingdetailRepository bookingdetailRepository;
	@Override
	public Bookingdetail createBookingdetail(Bookingdetail bookingdetail) {
		
		// TODO Auto-generated method stub
		return bookingdetailRepository.save(bookingdetail);
	}

}
