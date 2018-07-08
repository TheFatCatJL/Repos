class Thread1 extends Thread {
    int count;

    public Thread1(int count) {
        this.count = count;
    }

    @Override
    public void run() {
        for (int i=0; i<count; i++) {
            System.out.printf("Thread1: %d\n", i);
            try {
                Thread.sleep(100);
            } catch (Exception e) {
            }
        }
    }

    public static void main(String[] args) {
        Thread1 t = new Thread1(12);
        t.start();
        for (int i=0; i<10; i++) {
            System.out.printf("main: %d\n", i);
            try {
                Thread.sleep(200);
            } catch (Exception e) {
            }
        }
    }

}
