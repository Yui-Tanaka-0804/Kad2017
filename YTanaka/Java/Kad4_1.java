//******************************************
//プログラム名：Kad4_1.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/18
//******************************************

public class Kad4_1{
	
	public static void main(String[] args){
		int[] num = {10, 20, 30};
		
		System.out.println("---表示（正順）---");
		for(int i = 0; i < num.length; i++){
			System.out.println("配列 num[" + i + "]=" + num[i]);
		}
		
		System.out.println("---表示（逆順）---");
		for(int i = num.length - 1; i >= 0; i--){
			System.out.println("配列 num[" + i + "]=" + num[i]);
		}
		
		System.out.println("---拡張 for 文（正順）---");
		int i = 0;
		for(int array : num){
			System.out.println("配列 num[" + i + "]=" + array);
			i++;
		}
	}
	
}