//******************************************
//�v���O�������FKad3_5.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/04
//******************************************

public class Kad3_5{
	//java.lang.Math
	
	public static void main(String[] args){
		double radius = 7.2;
		String str1 = "���a�F";
		String str2 = "�~���̒����� ";
		String str3 = "�ʐς� ";
		String str4 = " �ł��B";
		
		double circle = radius * 2 * Math.PI;
		double area = Math.pow(radius, 2) * Math.PI;
		
		System.out.println(str1 + radius);
		System.out.println(str2 + (int)circle + str4);
		System.out.println(str3 + (int)area + str4);
		
	}
}