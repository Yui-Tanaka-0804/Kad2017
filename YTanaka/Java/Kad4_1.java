//******************************************
//�v���O�������FKad4_1.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/18
//******************************************

public class Kad4_1{
	
	public static void main(String[] args){
		int[] num = {10, 20, 30};
		
		System.out.println("---�\���i�����j---");
		for(int i = 0; i < num.length; i++){
			System.out.println("�z�� num[" + i + "]=" + num[i]);
		}
		
		System.out.println("---�\���i�t���j---");
		for(int i = num.length - 1; i >= 0; i--){
			System.out.println("�z�� num[" + i + "]=" + num[i]);
		}
		
		System.out.println("---�g�� for ���i�����j---");
		int i = 0;
		for(int array : num){
			System.out.println("�z�� num[" + i + "]=" + array);
			i++;
		}
	}
	
}