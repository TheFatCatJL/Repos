package org.sa46.team09.cab.services;

import java.util.ArrayList;

import org.sa46.team09.cab.models.User;
/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 11
 */

public interface UserService {

	User createUser(User user);//Insert
	
	User findUser(Integer memId);//Find by ID
	
	ArrayList<User> findAllUsers();//All List
	
	User changeUser(User user);//Update
	
	void removeUser(User user);//Delete
	
	ArrayList<User> findAllUserNotDeleted();//All User without deleted datas
	
	//Login
	/*boolean FindUserExist(@Param("email") String email);
	
	public boolean IsChecked(String email,String password);
	
	User findUserSession(String email);*/

}
