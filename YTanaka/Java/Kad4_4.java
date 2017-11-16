//******************************************
//プログラム名：Kad4_4.java
//クラス名＋出席番号＋名前：fja1a03 田中結衣
//日付：2017/10/18
//******************************************

public class Kad4_4{
	
	public static void main(String[] args){
		int[] num = {24, 68, 50, 97, 82, 36, 76, 49, 2, 15};
		int max = num[0], min = num[0];
		
		System.out.print("配列内容：");
		
		for(int array : num){
			System.out.print(array + ", ");
			if(max < array){
				max = array;
			}
			if(min > array){
				min = array;
			}
		}
		System.out.print("\b\b \n");
		
		System.out.println("最大値：" + max);
		System.out.println("最小値：" + min);
	}
	
}