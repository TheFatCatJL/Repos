package org.sa46.team09.cab.repositories;


import org.sa46.team09.cab.models.User;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

/**
 * @author Jason SA46T9
 * 2018 06 13
 */

public interface UserLoginRepository extends JpaRepository<User, String>{
	
	@Query("SELECT u FROM User u WHERE u.email=:em AND u.password=:password")
	User findUserByEmailPassword(@Param("em") String email, @Param("password") String password);
		
}