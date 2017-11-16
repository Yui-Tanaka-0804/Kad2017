//******************************************
//プログラム名：Kad6_2.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/11/01
//******************************************

import java.util.Scanner;

public class Kad6_2{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		double[] num = new double[3];
		
		System.out.println("--- 入力 ---");
		for(int i = 0; 3 > i; i++){
			System.out.print("配列 num[" + i + "] = ");
			num[i] = sc.nextDouble();
		}
		
		System.out.println("--- 拡張for文による表示 ---");
		int i = 0;
		for(double array : num){
			System.out.println("配列 num[" + i + "] = " + array);
			i++;
		}
	
	}
	
}