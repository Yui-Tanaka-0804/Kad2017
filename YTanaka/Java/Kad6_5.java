//******************************************
//プログラム名：Kad6_5.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/11/01
//******************************************

import java.util.Scanner;

public class Kad6_5{
	
	public static void main(String[] args){
		
		for(int i = 0; 100 >= i; i += 10){
			
			System.out.print("score:" + i + " ");
			
			if(90 <= i) {
				System.out.println("優");
			} else if(70 <= i) {
				System.out.println("良");
			} else if(50 <= i) {
				System.out.println("可");
			} else {
				System.out.println("不可");
			}
		}
	}
	
}