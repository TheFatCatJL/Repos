package org.sa46.team09.cab.controller;

import java.util.List;

import javax.validation.Valid;
import org.sa46.team09.cab.models.Facility;
import org.sa46.team09.cab.services.ActivityService;
import org.sa46.team09.cab.services.FacilityService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

/**
 * @author NNH(A0180529B) and Janelle SA46T9 2018 06 12
 */

@RequestMapping(value = "/")
@Controller
public class FacilityController {

	@Autowired
	private FacilityService fService;

	@Autowired
	private ActivityService aService;
	@Autowired
	private UserSession us;

	/**
	 * FACILITY CRUD OPERATIONS
	 * 
	 * @return
	 */

	@RequestMapping(value = "/fcreate", method = RequestMethod.GET)
	public ModelAndView newUserPage() {
		try 
		{
		if (!us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		ModelAndView mav = new ModelAndView("facility-new", "facility", new Facility());
		mav.addObject("activity", aService.findAllActivity());
		return mav;
		
	}

	@RequestMapping(value = "/fcreate", method = RequestMethod.POST)
	public ModelAndView createNewFacility(@ModelAttribute @Valid Facility facility, BindingResult result,
			final RedirectAttributes redirectAttributes) {

		if (result.hasErrors())
			return new ModelAndView("facility-new");

		try 
		{
		if (!us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		ModelAndView mav = new ModelAndView();
		String message = "New facility " + facility.getFacilityId() + " was successfully created.";
		facility.setIsDeleted(false);
		fService.createFacility(facility);
		mav.setViewName("redirect:/flist");

		redirectAttributes.addFlashAttribute("message", message);
		return mav;
	}

	@RequestMapping(value = "/flist", method = RequestMethod.GET)
	public ModelAndView facilityListPage() {
		
		try 
		{
		if (!us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		ModelAndView mav = new ModelAndView("facility-list");
		// List<Facility> facilityList = fService.findAllFacility();
		List<Facility> facilityList = fService.findAllFacilityNotDeleted();
		mav.addObject("facilityList", facilityList);
		return mav;
	}

	@RequestMapping(value = "/fedit/{facilityId}", method = RequestMethod.GET)
	public ModelAndView editFacilityPage(@PathVariable Integer facilityId) {
		
		try 
		{
		if (!us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		ModelAndView mav = new ModelAndView("facility-edit");
		Facility facility = fService.findFacility(facilityId);
		mav.addObject("activity", aService.findAllActivity());
		// mav.addObject("activity", aService.findActivity(facility.getActivityId()));
		mav.addObject("facility", facility);
		return mav;
	}

	@RequestMapping(value = "/fedit/{facilityId}", method = RequestMethod.POST)
	public ModelAndView editFacility(@ModelAttribute @Valid Facility facility, BindingResult result, final RedirectAttributes redirectAttributes) {

		if (result.hasErrors())
			return new ModelAndView("facility-edit");

		try 
		{
		if (!us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		ModelAndView mav = new ModelAndView("redirect:/flist");
		String message = "Facility was successfully updated.";
		facility.setIsDeleted(false);
		fService.changeFacility(facility);

		redirectAttributes.addFlashAttribute("message", message);
		return mav;
	}

	@RequestMapping(value = "/fdelete/{facilityId}", method = RequestMethod.GET)
	public ModelAndView deleteFacility(@PathVariable Integer facilityId, final RedirectAttributes redirectAttributes) {

		try 
		{
		if (!us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		ModelAndView mav = new ModelAndView("redirect:/flist");
		Facility facility = fService.findFacility(facilityId);
		facility.setIsDeleted(true);
		fService.changeFacility(facility);
		// fService.removeFacility(facility);
		String message = "The facility " + facility.getFacilityId() + " was successfully deleted.";

		redirectAttributes.addFlashAttribute("message", message);
		return mav;
	}

}
