//******************************************
//プログラム名：Kad5_4.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_4{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		int[] tanka = {90000, 80000, 150000};
		double[] warimasi = {1.4, 1.3, 1.2, 1.1};
		
		System.out.print("商品コード：");
		int code = sc.nextInt();
		
		if(0 <= code && tanka.length >= per) {
			
		} else {
			System.out.println("商品コードは0～" + tanka.length + "を入力してください。");
			return;
		}
		
		System.out.print("入荷数：");
		int val = sc.nextInt();
	}
	
}