//******************************************
//プログラム名：Kad5_4.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_4{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		int sum = 0;
		
		System.out.print("商品コード：");
		int code = sc.nextInt();
		
		switch(code){
			case 0 : sum = 90000;	break;
			case 1 : sum = 80000;	break;
			case 2 : sum = 150000;	break;
			default: System.out.println("商品コードは０～２を入力してください。");
					 System.exit(1);
		}
		
		System.out.print("入荷数：");
		int val = sc.nextInt();
		
		//条件分岐(あとで配列でもつくりたい)
		if(0 <= val && 500 >= val){
				if(50 >= val){
					sum *= 1.4;
				} else if(100 >= val){
					sum *= 1.3;
				} else if(200 >= val){
					sum *= 1.2;
				} else {
					sum *= 1.1;
				}
				System.out.println("販売価格は " + sum + " 円です。");
		} else {
			System.out.println("入荷できない");
		}
	}
	
}