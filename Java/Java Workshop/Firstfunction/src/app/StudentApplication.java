package app;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.List;

import model.Student;
import model.StudentNameComparator;

public class StudentApplication {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Student s1 = new Student("Chaka",new Date("29/03/2013"),"S1234567A","Boiboi",90);
		Student s2 = new Student("PonPon",new Date("01/01/2014"),"S2234567A","Ponsie",80);
		Student s3 = new Student("Cooper",new Date("03/03/2014"),"S3234567A","CooCoo",85);
		Student s4 = new Student("Cooper",new Date("03/03/2014"),"S3234567A","CooCoo",87);
		Student s5 = new Student("BooBoo",new Date("03/03/2014"),"S3234567A","BooBoo",88);
		
		List<Student> list = new ArrayList<Student>();
		Collections.addAll(list, s1,s2,s3,s4,s5);
				
		if(s3.equals(s4))
		{
			System.out.println("Same");
		}
		else
		{
			System.out.println("Not same");
		}
		
		for (Student student : list)
		{
			System.out.println(student.toString());
		}
		
		Collections.sort(list);
		System.out.println("Compare NRIC");		
		for (Student student : list)
		{
			System.out.println(student.toString());
		}
		
		Collections.sort(list,new StudentNameComparator());		
		System.out.println("Compare Name");		
		for (Student student : list)
		{
			System.out.println(student.toString());
		}
		
		System.out.println("Compare Marks");	
		list.sort((Student o1, Student o2)->{
			String firstmark = "Student 1: " + o1.getMark();
			String Secondmark = "Student 2: " + o2.getMark();
			System.out.println(firstmark);
			System.out.println(Secondmark);			
			return o1.getMark()-o2.getMark();
			
		});
		list.forEach((student)->System.out.println(student.toString()));
		
	
	}

}
