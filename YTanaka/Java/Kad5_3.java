//******************************************
//プログラム名：Kad5_3.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/25
//******************************************

import java.util.Scanner;

public class Kad5_3{
	
	public static void main(String[] args){
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("降水確率：");
		int per = sc.nextInt();
		
		if(0 <= per && 100 >= per) {
			if(20 >= per) {
				System.out.println("傘はいりませんね。");
			} else if(50 > per) {
				System.out.println("微妙ですね～折り畳み傘を持って行きましょう。");
			} else {
				System.out.println("傘を持って出かけましょう。");
			}
		} else {
			System.out.println("0～100までの数値を入力して下さい。");
		}
	}
	
}