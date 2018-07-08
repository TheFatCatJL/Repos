package org.sa46.team09.cab.controller;

import java.util.ArrayList;
import java.util.List;

import javax.servlet.http.HttpServletRequest;
import org.sa46.team09.cab.models.Booking;
import org.sa46.team09.cab.models.Bookingdetail;
import org.sa46.team09.cab.models.Facility;
import org.sa46.team09.cab.models.Facilitytimeslot;
import org.sa46.team09.cab.models.Slots;
import org.sa46.team09.cab.models.User;
import org.sa46.team09.cab.services.ActivityService;
import org.sa46.team09.cab.services.BookingService;
import org.sa46.team09.cab.services.BookingdetailService;
import org.sa46.team09.cab.services.FacilityService;
import org.sa46.team09.cab.services.FacilitytimeslotService;
import org.sa46.team09.cab.services.SlotsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

/**
 * @author HMT and NNH(A0180529B) SA46T9 2018 06 13
 */
@ComponentScan(basePackages = "org.sa46.team09.cab.services")
@Controller
@RequestMapping(value = "/")
public class BookingController {

	@Autowired
	private BookingService bookServ;
	@Autowired
	private SlotsService sServ;
	@Autowired
	private FacilitytimeslotService fslotServ;
	@Autowired
	private BookingdetailService bDetailServ;
	@Autowired
	private ActivityService aService;
	@Autowired
	private FacilityService fService;
	@Autowired
	private UserSession us;

	// Search for facility booking
	@RequestMapping(value = "/booking-search", method = RequestMethod.GET)
	public ModelAndView newBookingSearchPage() {
		ModelAndView mav = new ModelAndView("booking-search", "facility", new Facility());

		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		
		List<Facility> facilityList = fService.getFacilityGroup();
		mav.addObject(facilityList);

		return mav;
	}
	


	//booking create 
	@RequestMapping(value = "/bookingcreate", method = RequestMethod.POST)
	public ModelAndView newBookingPage(@ModelAttribute Booking booking, BindingResult result,
			final RedirectAttributes redirectAttributes, @RequestParam("facilityId") int facId,
			@RequestParam("bookingdate") String bDate) {
		
		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		
		ModelAndView mav = new ModelAndView("new-book", "booking", new Booking());
		int cfId = facId;

		mav.addObject("booking", booking);
		mav.addObject("cfId", cfId);
		mav.addObject("bookingdate", bDate);
			
		/* chandrika */Facility facility = fService.findFacility(facId);
		ArrayList<Slots> slot = new ArrayList<>();
		slot = sServ.findAllSlots();
		ArrayList<Integer> bookedSlots = fslotServ.getSlotsByBookings(facId, bDate, bDate);

		for (int i : bookedSlots) {
			slot.removeIf((Slots s) -> s.getSlotId() == i);
		}

		mav.addObject("facility", facility);
		mav.addObject("bDate", bDate);
		mav.addObject("booking", booking);
		mav.addObject("slot", slot);/* chandrika */
		User user = us.getUser();
		mav.addObject("user", user);
		return mav;
	}

	@RequestMapping(value = "/bookingcreate/add", method = RequestMethod.POST)
	public ModelAndView createNewBooking(@ModelAttribute Booking booking, BindingResult result,
			final RedirectAttributes redirectAttributes, @RequestParam("facilityId") int facId, @RequestParam(value = "maintenance", required = false) String maintenance) {

		if (result.hasErrors())
			return new ModelAndView("new-book");

		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		
		// Activity activity = aService.findActivity();
		ModelAndView mav = new ModelAndView();
		String message = "New booking " + booking.getBookingId() + " was successfully created.";
		booking.setBookingstatus(true);
		
		if(maintenance != null) // setMaintenancestatus for admin
		  {
			booking.setMaintenancestatus(true);
		  }
		  else
		  {
			booking.setMaintenancestatus(false);
		  }
		
	
		Booking b = bookServ.createBooking(booking);

		Booking bi = bookServ.findFirstByOrderByBookingIdDesc(booking);
		ArrayList<Integer> fai = fService.getActivityByFacilityId(facId); // extract activity id based on chose facility
		Facilitytimeslot fav = new Facilitytimeslot(); // add to Fac-TimeSlot
		fav.setSlotId(booking.getSlotId());

		fav.setBookDate(booking.getDateofBooking());
		for (Integer integer : fai) {

			fav.setActivityId(integer);
		}
		
		fav.setFacilityId(facId);
		fav.setIsDeleted(false);
		Facilitytimeslot f = fslotServ.createFacilitytimeslot(fav);
		Facilitytimeslot fi = fslotServ.findFirstByOrderByFacilityTimeSlotIdDesc(fav);

		Bookingdetail bd = new Bookingdetail(); // add to booking-detail
		bd.setBookingId(bi.getBookingId());
		bd.setFacilityTimeSlotId(fi.getFacilityTimeSlotId());
		bDetailServ.createBookingdetail(bd);
		// mav.setViewName("booking-search");
		mav.setViewName("successful-book");
		redirectAttributes.addFlashAttribute("message", message);
		return mav;
	}
	
	// search booking history 
	@RequestMapping(value = "/searchbooking", method = RequestMethod.GET)
	public ModelAndView searchbooking() {
		
		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}		
		
		ModelAndView mav = new ModelAndView("searchbooking");
		return mav;
	}

	@RequestMapping(params = "Search", value = "/searchresults", method = RequestMethod.POST)
	public ModelAndView searchresults(HttpServletRequest request) {
		
		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		ModelAndView mav = new ModelAndView("searchresults");
		String fromdate = request.getParameter("fromdate");
		String todate = request.getParameter("todate");
		int uid = us.getUser().getMemberId();
		if (us.getUsertype().contains("admin")) {
			ArrayList<Booking> booking = bookServ.findAllBookings();
			mav.addObject("bookings", booking);
		}
		
		if (us.getUsertype().contains("member")) {
			ArrayList<Booking> bookings = bookServ.findBookings(uid, fromdate, todate);
			System.out.println(bookings.size());
			mav.addObject("bookings", bookings);
			
		}
		
		
		return mav;
	}

	
	//Cancel Booking
			@RequestMapping(value = "/searchresults/{bookingId}", method = RequestMethod.GET)
			public ModelAndView Cancellation(@PathVariable("bookingId") int bookingId, final RedirectAttributes redirectAttributes) {

				try 
				{
				if (us.getUser().getMemberType().contentEquals(""))
					return new ModelAndView("redirect:/login");
				} catch (NullPointerException e) {
					return new ModelAndView("redirect:/login");
				}
				
				ModelAndView mav = new ModelAndView("successful-cancel");
				Booking booking = bookServ.findbooking(bookingId);
				booking.setBookingstatus(false);
				bookServ.changeBooking(booking);
				System.out.println(booking.toString());
				//fService.removeFacility(facility);
				return mav;
			}

}
