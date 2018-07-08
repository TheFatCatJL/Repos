package dullclass;

public class User {
private int memberid;
private String firstname;
private String lastname;
private String mobile;
public User() {
	super();
	// TODO Auto-generated constructor stub
}
public User(String firstname, String lastname, String mobile) {
	super();
	this.firstname = firstname;
	this.lastname = lastname;
	this.mobile = mobile;
}
public int getMemberid() {
	return memberid;
}
public void setMemberid(int memberid) {
	this.memberid = memberid;
}
public String getFirstname() {
	return firstname;
}
public void setFirstname(String firstname) {
	this.firstname = firstname;
}
public String getLastname() {
	return lastname;
}
public void setLastname(String lastname) {
	this.lastname = lastname;
}
public String getMobile() {
	return mobile;
}
public void setMobile(String mobile) {
	this.mobile = mobile;
}
@Override
public String toString() {
	return "User [memberid=" + memberid + ", firstname=" + firstname + ", lastname=" + lastname + ", mobile=" + mobile
			+ "]";
}

}
