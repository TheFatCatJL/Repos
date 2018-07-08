package org.sa46.team09.cab.repositories;

import java.util.ArrayList;

import org.sa46.team09.cab.models.User;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

/**
 * @author NNH(A0180529B) SA46T9
 * 2018 06 11
 */

public interface UserRepository extends JpaRepository<User, Integer>{
		
	@Query("SELECT DISTINCT u.memberId FROM User u")
	ArrayList<User> findAllUserIDs();
	
	//Customize by NNH(A0180529B) June 12 2018
	@Query("select u from User u where u.isDeleted != true")
	ArrayList<User> findAllUserNotDeleted();
	
	//Login
	/*@Query("select u from User u where u.email = :email")
	ArrayList<User> FindUserExist(@Param("email") String email);
	
	@Query("select u.password from User u where u.email = :email")
	String FindUserPwd(@Param("email") String email);*/
}
