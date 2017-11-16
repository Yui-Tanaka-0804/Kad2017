//******************************************
//プログラム名：Kad4_3.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/18
//******************************************

public class Kad4_3{
	
	public static void main(String[] args){
		int[][] ten = {{50, 90, 76}, {80, 46, 84, 67}, {30, 69, 72, 89, 56}};
		String[] name = {"青木", "木村", "山田"};
		String[] subject = {"国語", "数学", "英語", "社会", "理科"};
		
		System.out.print("    ");
		for(String j : subject){
			System.out.print("  " + j);
		}
		System.out.println("  |平均点");
		
		for(int i = 0; i < name.length; i++){
			int sum = 0;
			
			System.out.print(name[i] + "  ");
			for(int j : ten[i]){
				System.out.printf("%4d  ", j);
				sum += j;
			}
			for(int j = ten[i].length; j < subject.length; j++){
				System.out.print("      ");
			}
			System.out.printf("|%4d\n", sum / ten[i].length);
		}
	}
	
}