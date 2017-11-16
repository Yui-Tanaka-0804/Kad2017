//******************************************
//プログラム名：Kad2_3.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/09/27
//******************************************

public class Kad2_3{
	public static void main(String[] args){
		System.out.println("商品 A 2500 * 15 = " + (2500 * 15));
		System.out.println("商品 B 49800 * 1 = " + (49800 * 1));
		System.out.println("--------------------------");
		System.out.println("合計               " + (2500 * 15 + 49800 * 1));
		System.out.println("消費税(8%)          " + ((2500 * 15 + 49800 * 1) * 0.08));
		System.out.println("税込み             " + ((2500 * 15 + 49800 * 1) * 1.08));
	}
}