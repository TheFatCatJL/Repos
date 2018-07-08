package dao;

import java.sql.SQLException;
import java.util.ArrayList;

import dullclass.User;

public interface userdao {
	public ArrayList<User> findAllUser();
	public User findByMemberID(int memberId);
	public int createUser(User user) throws ClassNotFoundException, SQLException;
	public int updateUser(User user);
	public int removeUser(User user);
	
}
