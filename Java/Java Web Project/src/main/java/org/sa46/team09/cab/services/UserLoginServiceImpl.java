package org.sa46.team09.cab.services;

/**
 * @author Jason and NNH(A0180529B) SA46T9
 * 2018 06 13
 */
import javax.annotation.Resource;

import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import org.sa46.team09.cab.models.User;
import org.sa46.team09.cab.repositories.UserLoginRepository;
import org.sa46.team09.cab.services.UserLoginService;

	@Service
	public class UserLoginServiceImpl implements UserLoginService 
	{
		
		@Resource
		private UserLoginRepository userlgRepository;
		
		@Transactional
		public User authenticate(String email, String password) {
			User u = userlgRepository.findUserByEmailPassword(email, password);
			return u;
		}

	}

