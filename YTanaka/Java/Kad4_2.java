//******************************************
//プログラム名：Kad4_2.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/18
//******************************************

public class Kad4_2{
	
	public static void main(String[] args){
		int[] num = {24, 68, 50, 97, 82, 36, 76, 49, 2, 15};
		int max = num[0], min = num[0];
		//Integer.MAX_VALUE → int型の最大値
		
		System.out.print("配列内容：" + num[0]);
		
		for(int i = 1; i < num.length; i++){
			System.out.print(", " + num[i]);
			if(max < num[i]){
				max = num[i];
			}
			if(min > num[i]){
				min = num[i];
			}
		}
		System.out.print("\n");
		
		System.out.println("最大値：" + max);
		System.out.println("最小値：" + min);
	}
	
}