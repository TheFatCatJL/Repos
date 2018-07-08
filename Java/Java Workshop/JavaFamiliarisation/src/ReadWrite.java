import java.io.*;

class ReadWrite {

    public static void main(String[] args) {
        try {
//            InputStream is = new FileInputStream("src/abc.txt");
//            DataInputStream b = new DataInputStream(is);

            //append = true if new file every time not desired
            OutputStream os = new FileOutputStream("src/abc.txt",true);
//            PrintStream p = new PrintStream(os);
//            String s;
//            while ((s = b.readLine()) != null)
//                System.out.println(s);
//            p.close();
            //b.close();
        } catch (IOException e) {
            System.err.println(e.toString());
        }
    }
}