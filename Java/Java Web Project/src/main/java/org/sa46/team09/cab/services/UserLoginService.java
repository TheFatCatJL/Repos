package org.sa46.team09.cab.services;

import org.sa46.team09.cab.models.User;
/**
 * @author Jason and NNH(A0180529B) SA46T9
 * 2018 06 13
 */

public interface UserLoginService {

	User authenticate(String email, String password);

}
