class Thread2 extends Object implements Runnable {
    int count;

    public Thread2(int count) {
        this.count = count;
    }

    @Override
    public void run() {
        for (int i=0; i<count; i++) {
            System.out.printf("Thread2: %d\n", i);
            try {
                Thread.sleep(400);
            } catch (Exception e) {
            }
        }
    }

    public static void main(String[] args) {
        Thread t = new Thread(new Thread2(12));
        t.start();
        for (int i=0; i<10; i++) {
            System.out.printf("main: %d\n", i);
            try {
                Thread.sleep(500);
            } catch (Exception e) {
            }
        }
    }

}