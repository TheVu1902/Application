package daohoanhtung;

import java.util.*;

class Tnode {
	int data;
	Tnode left,right;
	public Tnode(int data){
		this.data=data;
		this.left=this.right=null;
	}
	public Tnode(int data,Tnode left,Tnode right) {
		this.data=data;
		this.left=left;
		this.right=right;
	}
}
public class atung {
	Tnode root;
	Tnode insertBST(int x,Tnode T) {
		if(T==null) T = new Tnode(x);
		else if(x==T.data) System.out.print("Da co " +x+ " trong cay");
		else if(x<T.data) T.left=insertBST(x,T.left);
		else T.right=insertBST(x,T.right);
		return T;
	}
	
	public static void main(String[] args) {
		

	}

}
