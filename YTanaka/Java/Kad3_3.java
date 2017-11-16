//******************************************
//プログラム名：Kad3_3.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/04
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
		
		System.out.println("商品 A 5000 * 50 = " + sumA);
		System.out.println("商品 B 3000 * 30 = " + sumB);
		System.out.println("--------------------------");
		System.out.println("合計               " + sum);
		System.out.println("消費税(10%)        " + (int)tax);
		System.out.println("税込み             " + (int)total);
	}
}