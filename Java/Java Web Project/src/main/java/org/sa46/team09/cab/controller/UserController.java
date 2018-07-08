package org.sa46.team09.cab.controller;

import java.util.ArrayList;
import java.util.List;

import javax.validation.Valid;
import org.sa46.team09.cab.models.User;
import org.sa46.team09.cab.services.UserService;
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
 * @author NNH(A0180529B) SA46T9
 * 2018 06 11
 */

@RequestMapping(value="/")
@Controller
public class UserController {
	
	@Autowired
	private UserService uService;
	
	@Autowired
	private UserSession us;
	
	/**
	 * USER CRUD OPERATIONS
	 * 
	 * @return
	 */

	@RequestMapping(value = "/create", method = RequestMethod.GET)
	public ModelAndView newUserPage() {
		ModelAndView mav = new ModelAndView("user-new", "user", new User());
		return mav;
	}
	
	@RequestMapping(value = "/create", method = RequestMethod.POST)
	public ModelAndView createNewUser(@ModelAttribute @Valid User user, BindingResult result,
			final RedirectAttributes redirectAttributes) {

		if (result.hasErrors())
			return new ModelAndView("user-new");

		ModelAndView mav = new ModelAndView();
		String message = "New user " + user.getMemberId() + " was successfully created.";
		user.setIsDeleted(false);
		uService.createUser(user);
		mav.setViewName("redirect:/login");

		redirectAttributes.addFlashAttribute("message", message);
		return mav;
	}
	
	@RequestMapping(value = "/list", method = RequestMethod.GET)
	public ModelAndView userListPage() {
		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		ModelAndView mav = new ModelAndView("user-list");
		
		if(!us.getUser().getMemberType().contentEquals("admin"))
			{
			User user = uService.findUser(us.getUser().getMemberId());
			List<User> userList = new ArrayList<User>();
			userList.add(user);
			mav.addObject("userList", userList);
			return mav;
			}
				
		//List<User> userList = uService.findAllUsers();
		List<User> userList = uService.findAllUserNotDeleted();
		mav.addObject("userList", userList);
		return mav;
	}

	@RequestMapping(value = "/edit/{memberId}", method = RequestMethod.GET)
	public ModelAndView editUserPage(@PathVariable Integer memberId) {
		
		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		if(us.getUser().getMemberId()!=memberId && !us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		
		
		ModelAndView mav = new ModelAndView("user-edit");
		User user = uService.findUser(memberId);
		mav.addObject("user", user);
		return mav;
	}
	
	@RequestMapping(value = "/edit/{memberId}", method = RequestMethod.POST)
	public ModelAndView editUser(@ModelAttribute @Valid User user, BindingResult result,
			@PathVariable Integer memberId, final RedirectAttributes redirectAttributes){

		if (result.hasErrors())
			return new ModelAndView("user-edit");

		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		if(us.getUser().getMemberId()!=memberId && !us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		
		
		ModelAndView mav = new ModelAndView("redirect:/list");
		String message = "User was successfully updated.";
		user.setIsDeleted(false);
		uService.changeUser(user);

		redirectAttributes.addFlashAttribute("message", message);
		return mav;
	}

	@RequestMapping(value = "/delete/{memberId}", method = RequestMethod.GET)
	public ModelAndView deleteUser(@PathVariable Integer memberId, final RedirectAttributes redirectAttributes) {
		
		try 
		{
		if (us.getUser().getMemberType().contentEquals(""))
			return new ModelAndView("redirect:/login");
		} catch (NullPointerException e) {
			return new ModelAndView("redirect:/login");
		}
		
		if(us.getUser().getMemberId()!=memberId && !us.getUser().getMemberType().contentEquals("admin"))
			return new ModelAndView("redirect:/login");
		
		
		ModelAndView mav = new ModelAndView("redirect:/list");
		User user = uService.findUser(memberId);
		user.setIsDeleted(true);
		uService.changeUser(user);
		//uService.removeUser(user);
		String message = "The user " + user.getMemberId() + " was successfully deleted.";

		redirectAttributes.addFlashAttribute("message", message);
		return mav;
	}
	

}
