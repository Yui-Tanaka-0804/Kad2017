//******************************************
//�v���O�������FKad7_4.java
//�N���X���{�o�Ȕԍ��{���O�Fsja1b05 �c������
//���t�F2017/11/15
//******************************************

import java.util.Scanner;

public class Kad7_4{
	
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Student student[] = {new Student(), new Student()};
		
		for(Student s : student){
			
			System.out.print("�w�Дԍ��F");
			s.schoolNumber = sc.nextInt();
			
			System.out.print("�N��F");
			s.age = sc.nextInt();
			
			System.out.print("���O�F");
			s.name = sc.next();
			
			System.out.print("\n");
		}
		
		char c = 'A';
		for(Student s : student){
			System.out.println("�w��" + c);
			s.show();
			c++;
			System.out.print("\n");
		}
		
//		System.out.println("�w��A");
//		student[0].show();
//		
//		System.out.print("\n");
//		
//		System.out.println("�w��B");
//		student[1].show();
	}
	
}
