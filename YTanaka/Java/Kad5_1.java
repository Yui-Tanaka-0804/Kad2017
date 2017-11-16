//******************************************
//プログラム名：Kad5_1.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_1{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("あなたの名前を入力してください。：");
		String name = sc.next();
		System.out.println(name + "さんこんにちは。");
		System.out.print("\n");
		
		System.out.print("歳を入力してください。：");
		int age = sc.nextInt();
		System.out.println(age + "歳とすると、10年後は" + (age + 10) + "歳ですね。");
	}
	
}