//******************************************
//�v���O�������FKad4_3.java
//�N���X���{�o�Ȕԍ��{���O�Ffja1a03 �c������
//���t�F2017/10/18
//******************************************

public class Kad4_3{
	
	public static void main(String[] args){
		int[][] ten = {{50, 90, 76}, {80, 46, 84, 67}, {30, 69, 72, 89, 56}};
		String[] name = {"��", "�ؑ�", "�R�c"};
		String[] subject = {"����", "���w", "�p��", "�Љ�", "����"};
		
		System.out.print("    ");
		for(String j : subject){
			System.out.print("  " + j);
		}
		System.out.println("  |���ϓ_");
		
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