package DecoratorIO;
import java.io.*;

public class LowerInputStream extends FilterInputStream{
	
	public LowerInputStream(InputStream in)
	{
		super(in);
	}
	
	public int read() throws IOException{
		int entrada= in.read();
		if(entrada==-1){
			return -1;
		}
		else{
			char caracter= (char)entrada;
			return caracter= Character.toLowerCase(caracter);
		}
		
	}

}
