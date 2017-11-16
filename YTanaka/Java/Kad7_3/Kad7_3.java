//******************************************
//プログラム名：Kad7_3.java
//クラス名＋出席番号＋名前：sja1b05 田中結衣
//日付：2017/11/15
//******************************************

import java.util.Scanner;

public class Kad7_3{
	
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Car car[] = {new Car(), new Car()};
		
		for(Car c : car){
			System.out.print("車のナンバーを入力：");
			c.num = sc.nextInt();
			System.out.print("車のガソリン量を入力：");
			c.gas = sc.nextDouble();
			
			System.out.print("\n");
		}
		
		char i = 'A';
		for(Car c : car){
			System.out.println("車" + i);
			c.show();
			i++;
		}
		
//		System.out.println("車A");
//		car[0].show();
//		System.out.println("車B");
//		car[1].show();
	}
	
}
