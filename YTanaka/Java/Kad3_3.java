//******************************************
//�v���O�������FKad3_3.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/04
//******************************************

public class Kad3_3{
	public static void main(String[] args){
		short numA = 50;
		short numB = 30;
		int priceA = 5000;
		int priceB = 3000;
		int sumA = numA * priceA;
		int sumB = numB * priceB;
		int sum = sumA + sumB;
		double tax = sum * 0.1;
		double total = sum + tax;
		
		System.out.println("���i A 5000 * 50 = " + sumA);
		System.out.println("���i B 3000 * 30 = " + sumB);
		System.out.println("--------------------------");
		System.out.println("���v               " + sum);
		System.out.println("�����(10%)        " + (int)tax);
		System.out.println("�ō���             " + (int)total);
	}
}