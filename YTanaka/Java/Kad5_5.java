//******************************************
//プログラム名：Kad5_5.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/31
//******************************************

import java.util.Scanner;

public class Kad5_5{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		int a, b, c;
		
		System.out.println("３つの整数を入力して下さい。");
		System.out.print("１つ目の整数を入力：");
		a = sc.nextInt();
		System.out.print("２つ目の整数を入力：");
		b = sc.nextInt();
		System.out.print("３つ目の整数を入力：");
		c = sc.nextInt();
        
        if (a == b && b == c){
            System.out.println("全部同じ値です。");
        } else if(a == b || b == c || a == c) {
            System.out.println("２つの値が同じです。");
        } else {
            System.out.println("３つの値は異なります。");
		}
		
	}
	
}