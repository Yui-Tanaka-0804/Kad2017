//******************************************
//�v���O�������FKad4_4.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/18
//******************************************

public class Kad4_4{
	
	public static void main(String[] args){
		int[] num = {24, 68, 50, 97, 82, 36, 76, 49, 2, 15};
		int max = num[0], min = num[0];
		
		System.out.print("�z����e�F");
		
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
		
		System.out.println("�ő�l�F" + max);
		System.out.println("�ŏ��l�F" + min);
	}
	
}