package org.sa46.team09.cab.services;

import java.util.ArrayList;

import javax.annotation.Resource;
import org.sa46.team09.cab.models.User;
import org.sa46.team09.cab.repositories.UserRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 11
 */

@Service
public class UserServiceImpl implements UserService{
	@Resource
	private UserRepository userRepository;
	
	@Override
	@Transactional
	public User createUser(User user) {
		return userRepository.saveAndFlush(user);
	}
	
	@Override
	@Transactional
	public User findUser(Integer memId) {
		return userRepository.findOne(memId);

	}
	
	@Override
	@Transactional
	public ArrayList<User> findAllUsers() {
		ArrayList<User> ul = (ArrayList<User>) userRepository.findAll();
		return ul;
	}
	
	@Override
	@Transactional
	public User changeUser(User user) {
		return userRepository.saveAndFlush(user);
	}
	
	@Override
	@Transactional
	public void removeUser(User user) {
		userRepository.delete(user);
	}
	
	@Override
	@Transactional
	public ArrayList<User> findAllUserNotDeleted() {
		ArrayList<User> ul = (ArrayList<User>) userRepository.findAllUserNotDeleted();
		return ul;
	}
	
	/*@Transactional
	public User authenticate(String email, String password) {
		User u = userRepository.findUserByEmailPassword(email, password);
		return u;
	}*/
	
	//For Login by NNH June 13 2018
	/*@Override
	@Transactional
	public boolean FindUserExist(String email) {
		ArrayList<User> clist = userRepository.FindUserExist(email);
		if (clist.isEmpty()) {return false;}
		else { return true;}
	}
	
	public boolean IsChecked(String email,String password) {
		String pwd = userRepository.FindUserPwd(email);
		if (password.equals(pwd)) {return true;}
		else {return false;}
	}
	
	@Override
	public User findUserSession(String email) {
		User c = new User();
		ArrayList<User> clist = userRepository.FindUserExist(email);
		c = clist.get(0);
		return c;
	}*/

}
