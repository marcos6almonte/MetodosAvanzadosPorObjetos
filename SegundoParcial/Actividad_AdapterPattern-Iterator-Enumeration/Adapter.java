import java.util.*;

public class Adapter implements Iterator<Object> {
	Enumeration<?> enumeration;

	public Adapter(Enumeration<?> _enumeration){
		enumeration = _enumeration;
	}

	public boolean hasNext(){
		return enumeration.hasMoreElements();
	}

	public Object next(){
		return enumeration.nextElement();
	}

	public void remove(){
		System.out.println("Error verifica porfavor.");
	}

	

}
