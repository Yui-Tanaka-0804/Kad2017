//******************************************
//�v���O�������FKad4_2.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/18
//******************************************

public class Kad4_2{
	
	public static void main(String[] args){
		int[] num = {24, 68, 50, 97, 82, 36, 76, 49, 2, 15};
		int max = num[0], min = num[0];
		//Integer.MAX_VALUE �� int�^�̍ő�l
		
		System.out.print("�z����e�F" + num[0]);
		
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
		
		System.out.println("�ő�l�F" + max);
		System.out.println("�ŏ��l�F" + min);
	}
	
}