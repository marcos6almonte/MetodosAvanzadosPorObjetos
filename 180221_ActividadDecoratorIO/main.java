package DecoratorIO;
import java.io.*;

public class main {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub

		int c;
		try {
			InputStream in = new LowerInputStream(new BufferedInputStream(new FileInputStream("ok.txt")));
			while ((c= in.read())>=0){
				System.out.print((char)c);
			}
			in.close();
		}catch(IOException e){
			e.printStackTrace();
		}
	}

}
