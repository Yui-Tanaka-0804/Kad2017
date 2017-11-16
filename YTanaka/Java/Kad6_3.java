//******************************************
//プログラム名：Kad6_3.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/11/01
//******************************************

import java.util.Scanner;

public class Kad6_3{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("表示する文字列：");
		String name = sc.next();
		
		for(int i = name.length() - 1; 0 <= i; i--){
			System.out.print( name.charAt(i) );
		}
		System.out.print("\n");
	
	}
	
}