import java.util.*;

public class Cliente {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Vector<Integer> vector = new Vector<Integer> ();
		for(int i = 0; i < 5; i++)
		{
			vector.add(i);
		}

		Enumeration<Integer> enumeration = vector.elements();
		
		Adapter adapter = new Adapter(enumeration);
		
		System.out.println("hasNext: " + adapter.hasNext());
		System.out.println("Next [0]: " + adapter.next());
		System.out.print("remove:");
		adapter.remove();

	}

}
