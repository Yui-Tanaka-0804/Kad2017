//******************************************
//�v���O�������FKad5_1.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_1{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("���Ȃ��̖��O����͂��Ă��������B�F");
		String name = sc.next();
		System.out.println(name + "���񂱂�ɂ��́B");
		System.out.print("\n");
		
		System.out.print("�΂���͂��Ă��������B�F");
		int age = sc.nextInt();
		System.out.println(age + "�΂Ƃ���ƁA10�N���" + (age + 10) + "�΂ł��ˁB");
	}
	
}