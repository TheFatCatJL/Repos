package org.sa46.team09.cab.controller;

import java.text.DateFormat;
import java.util.Date;
import java.util.Locale;
import org.sa46.team09.cab.models.User;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 11
 */
/**
 * Handles requests for the application home page.
 */

//@RequestMapping(value="/")
@Controller
public class HomeController {
	
	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);
	
	/**
	 * Simply selects the home view to render by returning its name.
	 */
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home(Locale locale, Model model) {
		logger.info("Welcome home! The client locale is {}.", locale);		
		Date date = new Date();
		DateFormat dateFormat = DateFormat.getDateTimeInstance(DateFormat.LONG, DateFormat.LONG, locale);
		
		String formattedDate = dateFormat.format(date);
		model.addAttribute("serverTime", formattedDate );
		
		return "redirect:/login";//By NNH June 13 2018
	}
	
	@RequestMapping(value = "/contact", method = RequestMethod.GET)
	public String logic(Model model) {
		model.addAttribute("user", new User());
		return "contact";
	}
}
