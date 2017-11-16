//******************************************
//プログラム名：Kad7_4.java
//クラス名＋出席番号＋名前：sja1b05 田中結衣
//日付：2017/11/15
//******************************************

import java.util.Scanner;

public class Kad7_4{
	
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Student student[] = {new Student(), new Student()};
		
		for(Student s : student){
			
			System.out.print("学籍番号：");
			s.schoolNumber = sc.nextInt();
			
			System.out.print("年齢：");
			s.age = sc.nextInt();
			
			System.out.print("名前：");
			s.name = sc.next();
			
			System.out.print("\n");
		}
		
		char c = 'A';
		for(Student s : student){
			System.out.println("学生" + c);
			s.show();
			c++;
			System.out.print("\n");
		}
		
//		System.out.println("学生A");
//		student[0].show();
//		
//		System.out.print("\n");
//		
//		System.out.println("学生B");
//		student[1].show();
	}
	
}
