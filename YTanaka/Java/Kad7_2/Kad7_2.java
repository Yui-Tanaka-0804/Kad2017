//******************************************
//�v���O�������FKad7_2.java
//�N���X���{�o�Ȕԍ��{���O�Fsja1b05 �c������
//���t�F2017/11/15
//******************************************

import java.util.Scanner;

public class Kad7_2{
	
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Car car = new Car();
		
		
		System.out.print("�Ԃ̃i���o�[����́F");
		car.num = sc.nextInt();
		System.out.print("�Ԃ̃K�\�����ʂ���́F");
		car.gas = sc.nextDouble();
		
		System.out.print("\n");
		
		System.out.println("�i���o�[�F" + car.num);
		System.out.println("�K�\�����F" + car.gas);
	}
	
}
