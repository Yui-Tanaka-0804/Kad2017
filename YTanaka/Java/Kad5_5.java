//******************************************
//�v���O�������FKad5_5.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/31
//******************************************

import java.util.Scanner;

public class Kad5_5{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		int a, b, c;
		
		System.out.println("�R�̐�������͂��ĉ������B");
		System.out.print("�P�ڂ̐�������́F");
		a = sc.nextInt();
		System.out.print("�Q�ڂ̐�������́F");
		b = sc.nextInt();
		System.out.print("�R�ڂ̐�������́F");
		c = sc.nextInt();
        
        if (a == b && b == c){
            System.out.println("�S�������l�ł��B");
        } else if(a == b || b == c || a == c) {
            System.out.println("�Q�̒l�������ł��B");
        } else {
            System.out.println("�R�̒l�͈قȂ�܂��B");
		}
		
	}
	
}