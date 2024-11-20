public class MultithreadThing extends Thread
{
    // private int threadnumber;
    // public MultithreadThing(int threadnumber)
    // {
    //     this.threadnumber = threadnumber;
    // }

    @Override
    public void run()
    {
        for(int i = 1; i <= 5 ; i++)
        {
            System.out.println( i /*+ " from thread " + threadnumber */);
            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) 
            {
                 
            }
        }
    }
}