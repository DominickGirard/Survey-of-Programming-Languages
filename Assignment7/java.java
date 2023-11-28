import java.io.*;

public class FileReadDemo {
    public static void main(String[] args) {
        Runnable readTask = () -> {
            try {
                File file = new File("example.txt"); // Replace with your file path
                BufferedReader br = new BufferedReader(new FileReader(file));
                String line;
                while ((line = br.readLine()) != null) {
                    System.out.println(Thread.currentThread().getName() + " reads: " + line);
                }
                br.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        };

        Thread thread1 = new Thread(readTask);
        Thread thread2 = new Thread(readTask);

        thread1.start();
        thread2.start();
    }
}
