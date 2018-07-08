package dao.jdbc;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import dao.userdao;
import dullclass.User;

public class UserDAOImpl implements userdao {

	@Override
	public ArrayList<User> findAllUser() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public User findByMemberID(int memberId) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public int createUser(User user) throws ClassNotFoundException, SQLException {
		Class.forName("com.mysql.jdbc.Driver");
		String url = "jdbc:mysql://localhost:3306/sa46team09cab";
		String usern ="root";
		String password = "password";
		Connection connection = DriverManager.getConnection(url, usern, password);
		Statement statement = connection.createStatement();
		String execstate = "INSERT INTO sa46team09cab.user (firstname, lastname, mobile) VALUES (\""+ user.getFirstname() + "\",\"" + user.getLastname() + "\",\"" + user.getMobile() + "\");";
		System.out.println(execstate);
		int status = statement.executeUpdate(execstate);
		statement.close();
		connection.close();
		return status;
	}

	@Override
	public int updateUser(User user) {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public int removeUser(User user) {
		// TODO Auto-generated method stub
		return 0;
	}

}
