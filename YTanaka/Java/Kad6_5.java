//******************************************
//�v���O�������FKad6_5.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/11/01
//******************************************

import java.util.Scanner;

public class Kad6_5{
	
	public static void main(String[] args){
		
		for(int i = 0; 100 >= i; i += 10){
			
			System.out.print("score:" + i + " ");
			
			if(90 <= i) {
				System.out.println("�D");
			} else if(70 <= i) {
				System.out.println("��");
			} else if(50 <= i) {
				System.out.println("��");
			} else {
				System.out.println("�s��");
			}
		}
	}
	
}