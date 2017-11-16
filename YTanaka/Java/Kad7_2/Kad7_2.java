//******************************************
//プログラム名：Kad7_2.java
//クラス名＋出席番号＋名前：sja1b05 田中結衣
//日付：2017/11/15
//******************************************

import java.util.Scanner;

public class Kad7_2{
	
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Car car = new Car();
		
		
		System.out.print("車のナンバーを入力：");
		car.num = sc.nextInt();
		System.out.print("車のガソリン量を入力：");
		car.gas = sc.nextDouble();
		
		System.out.print("\n");
		
		System.out.println("ナンバー：" + car.num);
		System.out.println("ガソリン：" + car.gas);
	}
	
}
