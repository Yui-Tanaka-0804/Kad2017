//******************************************
//�v���O�������FKad5_4.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_4{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		int sum = 0;
		
		System.out.print("���i�R�[�h�F");
		int code = sc.nextInt();
		
		switch(code){
			case 0 : sum = 90000;	break;
			case 1 : sum = 80000;	break;
			case 2 : sum = 150000;	break;
			default: System.out.println("���i�R�[�h�͂O�`�Q����͂��Ă��������B");
					 System.exit(1);
		}
		
		System.out.print("���א��F");
		int val = sc.nextInt();
		
		//��������(���ƂŔz��ł����肽��)
		if(0 <= val && 500 >= val){
				if(50 >= val){
					sum *= 1.4;
				} else if(100 >= val){
					sum *= 1.3;
				} else if(200 >= val){
					sum *= 1.2;
				} else {
					sum *= 1.1;
				}
				System.out.println("�̔����i�� " + sum + " �~�ł��B");
		} else {
			System.out.println("���ׂł��Ȃ�");
		}
	}
	
}