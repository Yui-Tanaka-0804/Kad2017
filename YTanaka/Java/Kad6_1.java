//******************************************
//プログラム名：Kad6_1.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/11/01
//******************************************

import java.util.Scanner;

public class Kad6_1{
	
	public static void main(String[] args){
		
		int sum = 0;
		
		System.out.println("1 2 3 4 5 ･･････ 100");
		
		for(int i = 0; 100 >= i; i++){
			sum += i;
		}
		
		System.out.println("1～100の和：" + sum);
	}
	
}