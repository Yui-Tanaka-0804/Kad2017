//******************************************
//�v���O�������FKad6_2.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/11/01
//******************************************

import java.util.Scanner;

public class Kad6_2{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		double[] num = new double[3];
		
		System.out.println("--- ���� ---");
		for(int i = 0; 3 > i; i++){
			System.out.print("�z�� num[" + i + "] = ");
			num[i] = sc.nextDouble();
		}
		
		System.out.println("--- �g��for���ɂ��\�� ---");
		int i = 0;
		for(double array : num){
			System.out.println("�z�� num[" + i + "] = " + array);
			i++;
		}
	
	}
	
}