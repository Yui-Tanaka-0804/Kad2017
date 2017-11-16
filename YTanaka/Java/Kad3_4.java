//******************************************
//プログラム名：Kad3_4.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/04
//******************************************

public class Kad3_4{
	public static void main(String[] args){
		final double PI = 3.1416;
		double radius = 7.2;
		String str1 = "半径：";
		String str2 = "円周の長さは ";
		String str3 = "面積は ";
		String str4 = " です。";
		
		double circle = radius * 2 * PI;
		double area = radius * radius * PI;
		
		System.out.println(str1 + radius);
		System.out.println(str2 + circle + str4);
		System.out.println(str3 + area + str4);
		
	}
}