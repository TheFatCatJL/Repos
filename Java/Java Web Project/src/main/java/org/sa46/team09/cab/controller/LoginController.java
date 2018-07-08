package org.sa46.team09.cab.controller;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;
import org.sa46.team09.cab.controller.UserSession;
import org.sa46.team09.cab.models.User;
import org.sa46.team09.cab.services.UserService;
import org.sa46.team09.cab.services.UserLoginService;

/**
 * @author Jason and NNH(A0180529B) SA46T9
 * 2018 06 13
 */
@Controller
public class LoginController {
	
	@Autowired
	private UserSession us;
	@Autowired
	private UserLoginService ulgService;
	@Autowired
	private UserService uService;

	@RequestMapping(value = "/login", method = RequestMethod.GET)
	public String logic(Model model) {
		model.addAttribute("user", new User());
		return "login";
	}
	
	/*for logout by NNH June 17 2018*/
	@RequestMapping(value = "/logout")
	public String logout(HttpSession session) {
		session.invalidate();
		return "redirect:/login";

	}
	
	@RequestMapping(value = "/changepw", method = RequestMethod.GET)
	public String changepwpage(Model model) {
		model.addAttribute("user", us.getUser());
		return "changepw";
	}


	@RequestMapping(value = "/changepass", method = RequestMethod.POST)
	public ModelAndView changepass(@ModelAttribute User user, HttpSession session, BindingResult result) {
		
		ModelAndView mav = new ModelAndView("redirect:/changepw");
		
		try {
			if (result.hasErrors())
			return mav;
		
			User user1 = us.getUser();			
			
			if (user.getEmail() !=null && user.getPassword() != null) 
			{
				if(!user1.getPassword().contentEquals(user.getPassword()))
					return mav;
				else
				{
					user1.setPassword(user.getEmail());
					us.setUser(user1);
					uService.changeUser(user1);
					return new ModelAndView("redirect:/login");					
				}
			}
		
		}
		catch(Exception e)
		{			
			return mav;
		}
		return mav;		
	}

	
	@RequestMapping(value = "/logincontrol", method = RequestMethod.POST)
	public ModelAndView logincontrol(@ModelAttribute User user, HttpSession session, BindingResult result) {
		ModelAndView mav = new ModelAndView("redirect:/login");
		try {
		if (result.hasErrors())
			return mav;
		if (user.getEmail() != null) {
			User u = ulgService.authenticate(user.getEmail(), user.getPassword());
			us.setUser(u);
			us.setSessionId(session.getId());
			us.setUsertype(u.getMemberType());
			
		if(u.getMemberType().contains("admin"))
			{
				session.setAttribute("currentuser", u);//add current user session by NNH 
				mav = new ModelAndView("redirect:/list");
			}
		if(u.getMemberType().contains("member"))
			{
				session.setAttribute("currentuser", u);//add current user session by NNH 
				mav = new ModelAndView("redirect:/booking-search");
					
			}
		} 
		}
		catch(Exception e)
		{			
			return mav;
		}
		session.setAttribute("USSESSION", us);
		return mav;		
	}
	

}
