//******************************************
//プログラム名：Kad5_2.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_2{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("4桁の西暦を入力してください。：");
		int year = sc.nextInt();
		
		if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
			System.out.println(year + "年は閏年です。");
		} else {
			System.out.println(year + "年は閏年ではありません。");
		}
	}
	
}