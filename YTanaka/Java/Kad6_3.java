//******************************************
//�v���O�������FKad6_3.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/11/01
//******************************************

import java.util.Scanner;

public class Kad6_3{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("�\�����镶����F");
		String name = sc.next();
		
		for(int i = name.length() - 1; 0 <= i; i--){
			System.out.print( name.charAt(i) );
		}
		System.out.print("\n");
	
	}
	
}