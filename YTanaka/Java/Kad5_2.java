//******************************************
//�v���O�������FKad5_2.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_2{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("4���̐������͂��Ă��������B�F");
		int year = sc.nextInt();
		
		if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
			System.out.println(year + "�N�͉[�N�ł��B");
		} else {
			System.out.println(year + "�N�͉[�N�ł͂���܂���B");
		}
	}
	
}