//******************************************
//�v���O�������FKad7_3.java
//�N���X���{�o�Ȕԍ��{���O�Fsja1b05 �c������
//���t�F2017/11/15
//******************************************

import java.util.Scanner;

public class Kad7_3{
	
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Car car[] = {new Car(), new Car()};
		
		for(Car c : car){
			System.out.print("�Ԃ̃i���o�[����́F");
			c.num = sc.nextInt();
			System.out.print("�Ԃ̃K�\�����ʂ���́F");
			c.gas = sc.nextDouble();
			
			System.out.print("\n");
		}
		
		char i = 'A';
		for(Car c : car){
			System.out.println("��" + i);
			c.show();
			i++;
		}
		
//		System.out.println("��A");
//		car[0].show();
//		System.out.println("��B");
//		car[1].show();
	}
	
}
