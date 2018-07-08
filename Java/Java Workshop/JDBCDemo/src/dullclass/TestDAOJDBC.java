package dullclass;

import java.sql.SQLException;

import dao.userdao;
import dao.jdbc.UserDAOImpl;

public class TestDAOJDBC {

	public static void main(String[] args) throws ClassNotFoundException, SQLException {
		// TODO Auto-generated method stub
		userdao udao = new UserDAOImpl();
		User user1 = new User("Black","Cat","912234");
		udao.createUser(user1);
		
	}

}
