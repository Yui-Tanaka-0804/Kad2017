//******************************************
//�v���O�������FKad5_3.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_3{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("�~���m���F");
		int per = sc.nextInt();
		
		if(0 <= per && 100 >= per) {
			if(20 >= per) {
				System.out.println("�P�͂���܂���ˁB");
			} else if(50 > per) {
				System.out.println("�����ł��ˁ`�܂��ݎP�������čs���܂��傤�B");
			} else {
				System.out.println("�P�������ďo�����܂��傤�B");
			}
		} else {
			System.out.println("0�`100�܂ł̐��l����͂��ĉ������B");
		}
	}
	
}