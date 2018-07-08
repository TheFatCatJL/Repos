package org.sa46.team09.cab.controller;


import org.springframework.context.annotation.Scope;
import org.springframework.context.annotation.ScopedProxyMode;
import org.springframework.stereotype.Component;

import org.sa46.team09.cab.models.User;
/**
 * @author Jason SA46T9
 * 2018 06 13
 */
@Component
@Scope(value="session", proxyMode=ScopedProxyMode.TARGET_CLASS)
public class UserSession {
	
	private String sessionId = null;
	private User user = null;
	private String Usertype = null;
	
	public UserSession() {

	}

	public UserSession(String sessionId, User user, String usertype) {
		this.sessionId = sessionId;
		this.user = user;
		this.setUsertype(usertype);
	}

	public String getSessionId() {
		return sessionId;
	}

	public void setSessionId(String sessionId) {
		this.sessionId = sessionId;
	}

	public User getUser() {
		return user;
	}

	public void setUser(User user) {
		this.user = user;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((sessionId == null) ? 0 : sessionId.hashCode());
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		UserSession other = (UserSession) obj;
		if (sessionId == null) {
			if (other.sessionId != null)
				return false;
		} else if (!sessionId.equals(other.sessionId))
			return false;
		return true;
	}

	public String getUsertype() {
		return Usertype;
	}

	public void setUsertype(String usertype) {
		Usertype = usertype;
	}
	
	


}
